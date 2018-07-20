using Encryption.Helpers;
using Encryption.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Encryption.Services
{
    public sealed class CaseEncryptor : ICaseEncryptor
    {
        public string Transform(char input)
        {                   
            return input.ToString().ToUpper();
        }
    }
}
