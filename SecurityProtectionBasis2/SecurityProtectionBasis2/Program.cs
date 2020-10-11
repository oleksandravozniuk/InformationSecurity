using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.Cryptography;

namespace SecurityProtectionBasis2
{
    class Program
    {
        static void Main(string[] args)
        {
            Info info = GetInfo();

            CngKey keySignature = CngKey.Create(CngAlgorithm.ECDsaP256);

           // byte[]  pubKeyBlob = keySignature.Export(CngKeyBlobFormat.GenericPublicBlob);

            byte[] hashedData = info.GetHash();

            byte[] signedData = CreateSignature(hashedData, keySignature);

            WriteInfo(signedData);
            ReadInfo();

            Console.ReadKey();
        }

        public static Info GetInfo()
        {
            Info info = new Info
            {
                UserName = Environment.UserName,
                ComputerName = Environment.MachineName
            };

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2","SELECT * FROM Win32_OperatingSystem");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                info.WindowsSystemFilesPath = queryObj["SystemDirectory"].ToString();
                info.WindowsPath = queryObj["WindowsDirectory"].ToString();
            }

            searcher = new ManagementObjectSearcher("root\\CIMV2","SELECT * FROM Win32_Volume");

            string driveName = Environment.CurrentDirectory.Substring(0, 2) + "\\";
            string driveSpace = DriveInfo.GetDrives().Where(x => x.Name == driveName).FirstOrDefault().TotalSize.ToString();

            info.InstalledProgramDriveMemory = driveSpace;

            searcher = new ManagementObjectSearcher("SELECT TotalVisibleMemorySize,FreePhysicalMemory FROM Win32_OperatingSystem");
            foreach (ManagementObject objram in searcher.Get())
            {
                info.Memory = Convert.ToUInt64(objram["TotalVisibleMemorySize"]).ToString();    //общая память ОЗУ

            }

            searcher = new ManagementObjectSearcher("root\\CIMV2","SELECT * FROM Win32_VideoController");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                if (queryObj["CurrentHorizontalResolution"] != null)
                {
                    info.MonitorWidth = queryObj["CurrentHorizontalResolution"].ToString();
                }
            }

            searcher = new ManagementObjectSearcher("root\\CIMV2","SELECT * FROM Win32_Keyboard");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                info.KeyboardType = queryObj["Name"].ToString();
                info.KeyboardSubtype = queryObj["Description"].ToString();
            }

            Console.WriteLine(info);
            return info;
        }

        public static byte[] CreateSignature(byte[] data, CngKey key)
        {
            byte[] signature;
            var signingAlg = new ECDsaCng(key);
            signature = signingAlg.SignData(data);
            signingAlg.Clear();
            return signature;
        }

        static bool VerifySignature(byte[] data, byte[] signature, byte[] pubKey)
        {
            bool retValue = false;
            using (CngKey key = CngKey.Import(pubKey, CngKeyBlobFormat.GenericPublicBlob))
            {
                var signingAlg = new ECDsaCng(key);
                retValue = signingAlg.VerifyData(data, signature);
                signingAlg.Clear();
            }
            return retValue;
        }

        static void WriteInfo(byte [] data)
        {
            RegistryKey userKey = Registry.CurrentUser;
            RegistryKey key = userKey.CreateSubKey("Vozniuk");
            key.SetValue("Vozniuk", data);
            key.Close();
            //Console.WriteLine("Data was written successfuly!");
        }

        static void ReadInfo()
        {
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey personalKey = currentUserKey.OpenSubKey("Vozniuk", true);

            try
            {
                string signedData = personalKey.GetValue("_Vozniuk").ToString();
                Console.WriteLine(signedData);
            }
            catch
            {
                Console.WriteLine("Current key isn't appropriate. Access is denied");
                Console.ReadKey();
            }

            personalKey.Close();
        }
    }
}
