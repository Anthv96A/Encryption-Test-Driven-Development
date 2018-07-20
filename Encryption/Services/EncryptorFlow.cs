using Encryption.Interfaces;


namespace Encryption.Services
{
    public class EncryptorFlow : IEncryptorFlow
    {
        private readonly IAlphabetEncryptor alphabetEncryptor;

        public EncryptorFlow(IAlphabetEncryptor alphabetEncryptor)
        {
            this.alphabetEncryptor = alphabetEncryptor;
        }

        public string EncryptValue(string word)
        {
            string encryptedWord = "";

            for(var i = 0; i < word.Length; i++)
            {
                encryptedWord += alphabetEncryptor.EncryptMessage(word[i], i);
            }

            return encryptedWord;
        }
    }
}
