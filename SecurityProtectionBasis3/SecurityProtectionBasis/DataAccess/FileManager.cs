using SecurityProtectionBasis.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace SecurityProtectionBasis.DataAccess
{
    class FileManager: IFileManager
    {
        private readonly string startupPath = Path.Combine(
                    Directory.GetParent(Directory.GetCurrentDirectory())
                    .Parent.Parent.FullName, "UserDB.txt");

        private readonly string encryptedFilePath = Path.Combine(
                    Directory.GetParent(Directory.GetCurrentDirectory())
                    .Parent.Parent.FullName, "Encrypted.txt");        

        public bool InitializeFile()
        {
            if(!File.Exists(encryptedFilePath))
            {
                User admin = new User()
                {
                    UserName = "ADMIN",
                    Password = String.Empty,
                    Blocked = false,
                    PasswordLimitationIsSet = false
                };
                File.WriteAllText(startupPath,admin.ToString());
                return false;
            }
            return true;
        }
        public void WriteUserToFile(User user)
        {
                File.AppendAllText(startupPath,user.ToString());
        }

        public List<User> GetAllUsers()
        {
            List<User> allUsers = new List<User>();
            StreamReader file = new StreamReader(startupPath);
            string line;
            int counter = 0;

            User user = new User();

            while ((line = file.ReadLine()) != null)
            {
                counter++;
                switch(counter)
                {
                    case 1: user.UserName = line; break;
                    case 2: user.Password = line; break;
                    case 3: user.Blocked = bool.Parse(line); break;
                    case 4: user.PasswordLimitationIsSet = bool.Parse(line); counter = 0; allUsers.Add(user); break;
                }
            }

            file.Close();
            return allUsers;

        }

        public void ClearTemporaryDB()
        {
            if (File.Exists(startupPath))
            {
                File.WriteAllText(startupPath, string.Empty);
            }
        }

        public string GetEncryptedStringAllInfo()
        {
            return File.ReadAllText(encryptedFilePath);
        }

        public string GetDecryptedStringAllInfo()
        {
            return File.ReadAllText(startupPath);
        }

        public void WriteToEncrypted(string data)
        {
            File.WriteAllText(encryptedFilePath,data);
        }

        public void WriteToDecrypted(string data)
        {
            File.WriteAllText(startupPath, data);
        }

        public void DeleteTemporaryDB()
        {
            File.Delete(startupPath);
        }
    }
}
