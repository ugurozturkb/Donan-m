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
            PcOyun pcOyun = new PcOyun("Ssd" , "Ryzen 5 1600" , "Ddr4" , "Rx580" , "GDdr5" , 10, 8);
            pcOyun.Details();
            pcOyun.TransferTime();
            pcOyun.Performance();
             
            Console.WriteLine("");

            PcOfis pcOfis = new PcOfis("Hdd", "İntel Core i3 3220", "Ddr3", "Gt 730", "GDdr4", 40, 16);
            pcOfis.Details();
            pcOfis.TransferTime();
            pcOfis.Performance();

            Console.ReadLine();
        }
    }
}
