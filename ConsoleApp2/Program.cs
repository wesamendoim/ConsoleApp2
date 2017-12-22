using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Encryption.Decrypt(@"C:\Users\wesley.valadao\Desktop\LOGGER.txt", @"12345");

                

                Encryption.Encrypt(@"C:\Users\wesley.valadao\Desktop\LOGGER.xml",@"12345");
                
            }
            
            catch(Exception e)
            {
                Console.Write(e.Message);
            }

        }

    }


}


        


       