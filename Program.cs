using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            string Estado = "";
            bool RedActiva = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();

            if (RedActiva)
                Estado = "Se estableció conexión con la red local";
            else
                Estado = "No está conectado a la red";
            Console.Write(Estado);

            Console.ReadKey();








            Console.Read();
        }
    }
}
