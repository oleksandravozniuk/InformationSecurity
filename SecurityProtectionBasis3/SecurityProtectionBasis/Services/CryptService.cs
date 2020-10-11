using SecurityProtectionBasis.DataAccess;
using SecurityProtectionBasis.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecurityProtectionBasis.Services
{
    public class CryptService : ICryptService
    {
        private readonly string adminPhrase = "admin admin";
        private readonly IFileManager fileManager;

        public CryptService(IFileManager fileManager)
        {
            this.fileManager = fileManager;
        }

        public void Encrypt()
        {
            string key = HashAdminPhrase();
            string data = fileManager.GetDecryptedStringAllInfo();
            Encoding unicode = Encoding.Unicode;

            fileManager.WriteToEncrypted(Convert.ToBase64String(Encrypt(unicode.GetBytes(key), unicode.GetBytes(data))));
        }

        public void Decrypt()
        {
            string key = HashAdminPhrase();
            string data = fileManager.GetEncryptedStringAllInfo();
            Encoding unicode = Encoding.Unicode;

            fileManager.WriteToDecrypted(unicode.GetString(Decrypt(unicode.GetBytes(key), Convert.FromBase64String(data))));
        }

        private static byte[] Encrypt(byte[] key, byte[] data)
        {
            return EncryptOutput(key, data).ToArray();
        }

        private static byte[] Decrypt(byte[] key, byte[] data)
        {
            return EncryptOutput(key, data).ToArray();
        }

        private static byte[] EncryptInitalize(byte[] key)
        {
            byte[] s = Enumerable.Range(0, 256)
              .Select(i => (byte)i)
              .ToArray();

            for (int i = 0, j = 0; i < 256; i++)
            {
                j = (j + key[i % key.Length] + s[i]) & 255;

                Swap(s, i, j);
            }

            return s;
        }

        private static IEnumerable<byte> EncryptOutput(byte[] key, IEnumerable<byte> data)
        {
            byte[] s = EncryptInitalize(key);

            int i = 0;
            int j = 0;

            return data.Select((b) =>
            {
                i = (i + 1) & 255;
                j = (j + s[i]) & 255;

                Swap(s, i, j);

                return (byte)(b ^ s[(s[i] + s[j]) & 255]);
            });
        }

        private static void Swap(byte[] s, int i, int j)
        {
            byte c = s[i];

            s[i] = s[j];
            s[j] = c;
        }

        public string HashAdminPhrase()
        {
            Chilkat.Crypt2 crypt = new Chilkat.Crypt2();
            // Hash using MD5
            crypt.HashAlgorithm = "md5";
            return crypt.HashStringENC(adminPhrase);
        }

    }
}
