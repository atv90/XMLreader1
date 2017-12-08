using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLreader1
{
    class Program
    {

        //[‎7.‎12.‎2017 20.34] Bo Furustam:  
        static void Main(string[] args)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                string file1 = @"C:\Users\Anne\source\repos\XMLreader1\XMLtiedosto.xml";
                xmlDoc.Load(file1);
                xmlDoc.Save(Console.Out);
                Console.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine("the file could not be read");
                Console.WriteLine(e.Message);
            }
            
            Console.ReadLine();
        }
    }
}



