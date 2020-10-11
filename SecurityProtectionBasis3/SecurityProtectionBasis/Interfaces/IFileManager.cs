using System;
using System.Collections.Generic;
using System.Text;

namespace SecurityProtectionBasis.Interfaces
{
    public interface IFileManager
    {
        public bool InitializeFile();
        public void WriteUserToFile(User user);
        public List<User> GetAllUsers();
        public void ClearTemporaryDB();
        public string GetEncryptedStringAllInfo();
        public string GetDecryptedStringAllInfo();
        public void WriteToEncrypted(string data);
        public void WriteToDecrypted(string data);
        public void DeleteTemporaryDB();
    }
}
