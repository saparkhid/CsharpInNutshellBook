using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_20.ExplicitInterfaceImplementation
{
    public class Cake : ISerializable
    {
        public string CakeName;
        public double Price;
        public CakeType CakeFlavor;
        public Cake()
        {

        }
        public Cake(string name)
        {
            this.CakeName = name;
        }

        /*
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", this.CakeName);
            info.AddValue("Price", this.Price);
            info.AddValue("Flavor", this.CakeFlavor);
        }*/

       
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", this.CakeName);
            info.AddValue("Price", this.Price);
            info.AddValue("Flavor", this.CakeFlavor);
        }
    }
}
