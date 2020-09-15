using System;
using System.Collections.Generic;
using System.Text;

namespace SecurityProtectionBasis.Interfaces
{
    public interface IFileManager
    {
        public void InitializeFile();
        public void WriteUserToFile(User user);
        public List<User> GetAllUsers();
        public void DeleteDB();
        
    }
}
