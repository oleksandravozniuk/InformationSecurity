using SecurityProtectionBasis.DataAccess;
using SecurityProtectionBasis.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecurityProtectionBasis.Services
{
    public class AdminService:IAdmin
    {
        private readonly IFileManager fileManager;

        public AdminService(IFileManager fileManager)
        {
            this.fileManager = fileManager;

        }

        public void RegisterUser(User user)
        {

                fileManager.WriteUserToFile(user);
            
        }

        public bool UsernameExists(string username)
        {
            List<User> allUsers = new List<User>();
            allUsers = fileManager.GetAllUsers();
            foreach (var user in allUsers)
            {
                if (user.UserName == username)
                    return true;
            }
            return false;
        }
    }
}
