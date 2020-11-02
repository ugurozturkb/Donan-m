using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DONANIM
{
    public class PcOyun : Pc
    {
        public PcOyun(string v, string v1, string v2, string v3, int v4)
        {
            MemoryType = v;
            Processor = v1;
            RamType = v2;
            DisplayCard = v3;
            OpenTime = v4;
        }

        public override void TransferTime()
        {
            Console.WriteLine("Yavaş aktarım ");
        }

        public override void Performance()
        {
            Console.WriteLine("Oyunlarda Güçlü, Ofis İşlerinde Yetersiz");
        }
    }
}
