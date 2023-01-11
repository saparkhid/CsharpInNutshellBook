using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_11.BaseKeyword
{
    public class Mobile
    {
        protected string _modelNumber;
        protected readonly string workingCountry = "IRI";
        private string uuid;

        public Mobile(string modelNumber)
        {
            this.NewUUID();
            this._modelNumber = modelNumber;
        }
        public virtual void PrintMobileInfo()
        {
            Console.WriteLine("-MOB INF-");
            Console.WriteLine(ID);
            Console.WriteLine(ModelNumber);
        }
        private void NewUUID()
        {
            this.uuid = Guid.NewGuid().ToString();
        }
        public string ID
        {
            get
            {
                return this.workingCountry + "-" + this.uuid.Substring(0, 5);
            }
        }
        public string ModelNumber
        {
            get
            {
                return _modelNumber;
            }
            set
            {
                _modelNumber = value;
            }
        }

    }
}
