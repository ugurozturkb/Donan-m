using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DONANIM
{
    public class PcOfis : Pc
    {
        public PcOfis(string v, string v1, string v2, string v3, string v4, string v5, int v6, int v7, int v8)
        {
            Opening = v;
            MemoryType = v1;
            Processor = v2;
            RamType = v3;
            DisplayCard = v4;
            DisplayCardType = v5;
            OpenTime = v6;
            RamCapacity = v7;
            PointProcessor = v8;
        }

        public override void TransferTime()
        {
            Console.WriteLine("Hızlı Aktarım ");
        }

        public override void Performance()
        {
            Console.WriteLine("Oyunlarda Güçsüz, Ofis İşlerinde Yeterli");
        }

    }
}
