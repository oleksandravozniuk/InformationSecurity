
using SecurityProtectionBasis.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SecurityProtectionBasis.Services
{
    public class UserService:IUser
    {
        private readonly IFileManager fileManager;
        private readonly ICryptService cryptService;

        public UserService(IFileManager fileManager, ICryptService cryptService)
        {
            this.fileManager = fileManager;
            this.cryptService = cryptService;
        }

        public void SetInitialState()
        {
            if(fileManager.InitializeFile())
            {
                cryptService.Decrypt();
            }
        }
        public bool Login(string username, string password)
        {
            IEnumerable<User> allUsers = fileManager.GetAllUsers();
            if (allUsers.Where(x => x.UserName == username && x.Password == password).Count() == 1)
            {
                return true;
            }
            else
                return false;
        }

        public User GetUserByUsername(string username)
        {
            IEnumerable<User> allUsers = fileManager.GetAllUsers();
            return allUsers.Where(x => x.UserName == username).First();
        }

        public void UpdateUser(User user)
        {
            List<User> allUsers = new List<User>();
            allUsers = fileManager.GetAllUsers();
            for(int i=0;i<allUsers.Count();i++)
            {
                if(allUsers[i].UserName==user.UserName)
                {
                    User updatedUser = new User(user.UserName, user.Password, user.Blocked, user.PasswordLimitationIsSet);
                    allUsers[i] = updatedUser;
                }
            }
            fileManager.ClearTemporaryDB();
            for (int i=0;i<allUsers.Count();i++)
            {
                
                fileManager.WriteUserToFile(allUsers[i]);
            }

        }

       public IEnumerable<string> GetAllUsernames()
        {
            return fileManager.GetAllUsers().Select(x => x.UserName).Where(x => x != "ADMIN");
        }

        public bool PasswordLimitation(string password)
        {

            if (Regex.IsMatch(password, @"\p{IsCyrillic}") && Regex.IsMatch(password, "[a-z]", RegexOptions.IgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       public void DeleteTemporaryDB()
        {
            fileManager.DeleteTemporaryDB();
        }
    }
}
