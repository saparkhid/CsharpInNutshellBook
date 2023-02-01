using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionSample
{
    public class TeimorianCrypto : ICrypto
    {
        private string input;

        public TeimorianCrypto(string input)
        {
            this.input = input;
        }

        public string Encrypt()
        {
            var arr = this.input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public string Decrypt()
        {
            var arr = this.input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
