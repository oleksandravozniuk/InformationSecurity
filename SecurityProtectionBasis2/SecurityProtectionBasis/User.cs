using System;
using System.Collections.Generic;
using System.Text;

namespace SecurityProtectionBasis
{
    public struct User
    {
        public string UserName{get;set;}
        public string Password { get; set; }
        public bool Blocked { get; set; }
        public bool PasswordLimitationIsSet { get; set; }

        public User(string userName, string password, bool blocked, bool passwordLimitationIsSet)
        {
            UserName = userName;
            Password = password;
            Blocked = blocked;
            PasswordLimitationIsSet = passwordLimitationIsSet;
        }

        public override string ToString() => 
            $"{UserName+"\n"}{Password+"\n"}{Blocked+"\n"}{PasswordLimitationIsSet+"\n"}";
    }
}
