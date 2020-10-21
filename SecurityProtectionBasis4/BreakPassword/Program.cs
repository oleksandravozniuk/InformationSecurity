using SecurityProtectionBasis4;
using System;

namespace BreakPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            string randomPassword = string.Empty;
            for(int i=0;i<10000;i++)
            {
                randomPassword = PasswordGen.PswrdGen.GeneratePassword(true, true, true, true, 10);
                Console.WriteLine(randomPassword);
                if (DbManager.FindUser("login",randomPassword))
                {
                    Console.WriteLine("Success! Coincidence was found!");
                    flag = true;
                    break;
                }
            }
            if(flag == false)
            {
                Console.WriteLine("Coincidence was not found :(");
            }
        }
    }
}
