using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_25.StaticGeneric
{
    public class Panda
    {
        public static string CountryName {get; set; }
        public Panda()
        {

        }
        public override string ToString()
        {
            if (CountryName == "Iran")
            {
                return "IR-Panda";
            }
            return "EXTERNAL-Panda";
        }
    }
}
