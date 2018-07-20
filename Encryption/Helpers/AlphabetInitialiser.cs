using System;
using System.Collections.Generic;
using System.Text;

namespace Encryption.Helpers
{
    public class AlphabetInitialiser: IAlphabetInitialiser
    {
        public Dictionary<int,char> Alphabet()
        {
            Dictionary<int, char> keyValuePairs = new Dictionary<int, char>();
            int looper = 1;

            for(char c = 'a'; c <= 'z' + 1; c++)
            {
                keyValuePairs.Add(looper, c);
                looper++;
            }
            return keyValuePairs;
        }
    }
}
