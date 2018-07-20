using System;
using System.Collections.Generic;
using System.Text;

namespace Encryption.Interfaces
{
    public interface IEncryptorFlow
    {
        string EncryptValue(string word);
    }
}
