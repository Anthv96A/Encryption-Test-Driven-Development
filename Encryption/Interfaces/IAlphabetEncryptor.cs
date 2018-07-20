using System;
using System.Collections.Generic;
using System.Text;

namespace Encryption.Interfaces
{
    public interface IAlphabetEncryptor
    {
        string EncryptMessage(char letter, int letterPosition);
    }
}
