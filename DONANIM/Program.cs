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
            PcSsd pcssd = new PcSsd("Ssd" , "Ryzen 5 1600" , "Ddr4" , "GDdr5" , 10);
            pcssd.Details();
            pcssd.TransferTime();
            pcssd.Use();
             
            Console.WriteLine(" ");

            PcHdd pchdd = new PcHdd("Hdd", "Ryzen 3 1300x", "Ddr3", "GDdr4", 40);
            pchdd.Details();
            pchdd.TransferTime();
            pchdd.Use();

            Console.ReadLine();
        }
    }
}
