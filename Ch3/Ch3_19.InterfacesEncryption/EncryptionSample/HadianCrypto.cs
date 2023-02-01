using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionSample
{
    public class HadianCrypto : ICrypto
    {
        private string input;

        public HadianCrypto(string input)
        {
            this.input = input;
        }

     

        public string Encrypt()
        {
            int n = this.input.Length;
            string result = "";
            for (int i = 0; i < n; i++)
            {
                int c = (int)this.input[i] +1;
             
                result += ((char)c).ToString(); 
            }

            return result;
        }

        public string Decrypt()
        {
            int n = this.input.Length;
            string result = "";
            for (int i = 0; i < n; i++)
            {
                int c = (int)this.input[i] - 1;

                result += ((char)c).ToString();
            }

            return result;
        }
    }
}
