using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Frm_Login frm = new Frm_Login();

            frm.Show();



            Descriptografar();


        }

        static void Descriptografar()
        {
            try
            {
                XmlDocument xml = new XmlDocument();

                xml.Load(@"C:\Users\wesley.valadao\Desktop\Ribbon1.xml");

                string password = xml.ChildNodes[0].ChildNodes[1].InnerText; //Password
                string hostname = xml.ChildNodes[0].ChildNodes[0].InnerText; //HostName
                string login = xml.ChildNodes[0].ChildNodes[2].InnerText; //Login

                string passwordDecrypt = Encryption.Decrypt(password, @"Valadão");

                string loginDecrypt = Encryption.Decrypt(login, @"Valadao");

                string hostnamedecrypt = Encryption.Decrypt(hostname, @"Valadao");
                
            }

            catch (Exception e)
            {
                Console.Write(e.Message);

            }
            
        }

        static void Criptografar()
        {
            try
            {
                XmlDocument xml = new XmlDocument();

                Frm_Login frm_Login = new Frm_Login();
                
                Form form = new Form();
                
                string password = TxtSenha.Text;
                string login = TxtLogin.Text;
                string hostname = TxtHostName.Text;

                string passwordencrypt = Encryption.Encrypt(login, @"Valadao");

                string loginencrypt = Encryption.Encrypt(password, @"Valadao");

                string hostnamencrypt = Encryption.Encrypt(hostname, @"Valadao");

                xml.ChildNodes[0].ChildNodes[0].InnerText = hostnamencrypt;

                xml.ChildNodes[0].ChildNodes[1].InnerText = passwordencrypt;

                xml.ChildNodes[0].ChildNodes[2].InnerText = loginencrypt;

                xml.Save(@"")

            }

            catch
            {

            }
        }
    }
    
}


        


       