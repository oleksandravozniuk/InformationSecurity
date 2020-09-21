using System;
using System.Collections.Generic;
using System.Text;

namespace SecurityProtectionBasis.Interfaces
{
    public interface IUser
    {
        public void SetInitialState();
        public bool Login(string username, string password);
        public User GetUserByUsername(string username);
        public void UpdateUser(User user);
        public IEnumerable<string> GetAllUsernames();
        public bool PasswordLimitation(string password);
    }
}
