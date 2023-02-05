using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ch3_20.ExplicitInterfaceImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cake cake = new Cake("Chococake1");
            cake.CakeFlavor = CakeType.Chocolate;
            cake.Price = 3650;

            
           
            XmlSerializer serializer = new XmlSerializer(typeof(Cake));
            Stream stream = new FileStream(@"D:\xmlFile.xml", FileMode.Create);
            serializer.Serialize(stream, cake);
            stream.Close();

            Console.ReadKey();

        }
    }
}
