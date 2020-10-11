using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace SecurityProtectionBasis2
{
    class Info
    {
        public string UserName { get; set; }
        public string ComputerName { get; set; }
        public string WindowsPath { get; set; }
        public string WindowsSystemFilesPath { get; set; }
        public string KeyboardType { get; set; }
        public string KeyboardSubtype { get; set; }
        public string MonitorWidth { get; set; }
        public string Memory { get; set; }
        public string InstalledProgramDriveMemory { get; set; }

        public override string ToString()
        {
            return "User name: " + UserName + "\nComputer name: " + ComputerName + "\nPath to Windows OS: " + WindowsPath +
                "\nPath to Windows system files: " + WindowsSystemFilesPath + "\nKeyboard type: " + KeyboardType +
                "\nKeyboard subtype: " + KeyboardSubtype + "\nMonitor width: " + MonitorWidth + "\nMemory: " +
                Memory + "\nDrive memory of installed program: " + InstalledProgramDriveMemory;
        }
        public byte[] GetHash()
        {
            using HashAlgorithm algorithm = SHA256.Create();
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(base.ToString()));
        }

        public string GetHashString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash())
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }
    }
}
