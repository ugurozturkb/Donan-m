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
            PcOyun pcOyun = new PcOyun("","Ssd" , "Ryzen 5 1600" , "Ddr4" , "Rx580" , "GDdr5" , 10, 8, 80);
            pcOyun.Details();
            pcOyun.TransferTime();
            pcOyun.Performance();
             
            Console.WriteLine("");

            PcOfis pcOfis = new PcOfis("", "Ssd", "Ryzen 5 1600", "Ddr4", "Rx580", "GDdr5", 10, 8, 60);
            pcOfis.Details();
            pcOfis.TransferTime();
            pcOfis.Performance();


            Console.ReadLine();
        }
    }
}
