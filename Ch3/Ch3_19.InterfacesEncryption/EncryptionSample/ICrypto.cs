﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionSample
{
    public interface ICrypto
    {
        string Encrypt();
        string Decrypt();
    }
}
