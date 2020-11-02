using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DONANIM
{
    class Program
    {
        static void Main(string[] args)
        {
            PcOyun pcssd = new PcOyun("Ssd" , "Ryzen 5 1600" , "Ddr4" , "GDdr5" , 10);
            pcssd.Details();
            pcssd.TransferTime();
            pcssd.Use();
             
            Console.WriteLine(" ");

            PcOfis pchdd = new PcOfis("Hdd", "İntel Core i3 3220", "Ddr3", "GDdr4", 40);
            pchdd.Details();
            pchdd.TransferTime();
            pchdd.Use();

            Console.ReadLine();
        }
    }
}
