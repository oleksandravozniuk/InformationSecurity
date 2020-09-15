using System;
using System.Collections.Generic;
using System.Text;

namespace SecurityProtectionBasis.Interfaces
{
    public interface IAdmin
    {
        public void RegisterUser(User user);
        public bool UsernameExists(string username);
    }
}
