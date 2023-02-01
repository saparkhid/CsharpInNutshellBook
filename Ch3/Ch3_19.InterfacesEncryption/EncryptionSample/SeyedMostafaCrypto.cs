using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionSample
{
    public class SeyedMostafaCrypto : ICrypto
    {
        private string input;

        public SeyedMostafaCrypto(string input)
        {
            this.input = input;
        }

 

        public string Encrypt()
        {
            int n = this.input.Length;
            return this.input;
        }

        public string Decrypt()
        {
            int n = this.input.Length;
            return this.input;
        }
    }
}
