using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SecurityProtectionBasis4
{
    public static class DbManager
    {
        private static readonly string startupPath = Path.Combine(
                    Directory.GetParent(Directory.GetCurrentDirectory())
                    .Parent.Parent.Parent.FullName, "UserDB.txt");
        public static void WriteUser(string login, string password)
        {
            File.WriteAllLines(startupPath,new List<string> {login,EncDec.Encrypt(password)});
        }

        public static bool FindUser(string login, string password)
        {
            string[] users = File.ReadAllLines(startupPath);
            for(int i = 0; i<users.Length; i += 2)
            {
                if(users[i] == login && EncDec.Decrypt(users[i+1]) == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
