using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionSample
{
    public class ParkhidCrypto : ICrypto
    {
        private string input;
        public ParkhidCrypto(string input)
        {
            this.input = input;
        }

        public string Decrypt()
        {
            int n = this.input.Length;
            char t = input[n - 1];
            char f = input[0];
            string result = t.ToString();
            for (int i = 1; i < n - 1; i++)
            {
                result += input[i];
            }
            result += f.ToString();
            return result;

        }

        public string Encrypt()
        {
            int n = this.input.Length;
            char t = input[n - 1];
            char f = input[0];
            string result = t.ToString();
            for(int i = 1; i < n-1; i++)
            {
                result += input[i];
            }
            result += f.ToString();
            return result;
        }
    }
}
