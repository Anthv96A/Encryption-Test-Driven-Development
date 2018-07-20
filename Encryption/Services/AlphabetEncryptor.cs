using Encryption.Helpers;
using Encryption.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Encryption.Services
{
    public sealed class AlphabetEncryptor : IAlphabetEncryptor
    {
        private readonly IAlphabetInitialiser alphabetInitialiser;

        public AlphabetEncryptor(IAlphabetInitialiser alphabetInitialiser)
        {
            this.alphabetInitialiser = alphabetInitialiser;
        }
        
        public string EncryptMessage(char letter, int letterPosition)
        {
            Dictionary<int, char> alphabet = alphabetInitialiser.Alphabet();
             
            int currentKey = alphabet.FirstOrDefault(r => r.Value == letter).Key;
            int newPositionKey = currentKey + letterPosition;

            while (newPositionKey > 26)
            {
                newPositionKey -= 26;
            }
            return alphabet.FirstOrDefault(r => r.Key == newPositionKey).Value.ToString();
        }
    }

 }

