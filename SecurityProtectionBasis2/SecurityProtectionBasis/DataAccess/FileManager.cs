using SecurityProtectionBasis.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SecurityProtectionBasis.DataAccess
{
    class FileManager: IFileManager
    {
        private readonly string startupPath = Path.Combine(
                    Directory.GetParent(Directory.GetCurrentDirectory())
                    .Parent.Parent.FullName, "UserDB.txt");
        


        public void InitializeFile()
        {
            if(!File.Exists(startupPath))
            {
                User admin = new User()
                {
                    UserName = "ADMIN",
                    Password = String.Empty,
                    Blocked = false,
                    PasswordLimitationIsSet = false
                };
                File.WriteAllText(startupPath,admin.ToString());
            }
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

        public void DeleteDB()
        {
            if (File.Exists(startupPath))
            {
                File.WriteAllText(startupPath, string.Empty);
            }
        }

        
    }
}
