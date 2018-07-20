using System;
using System.Collections.Generic;
using System.Text;

namespace Encryption.Helpers
{
    public interface IAlphabetInitialiser
    {
        Dictionary<int, char> Alphabet();
    }
}
