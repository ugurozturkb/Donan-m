﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DONANIM
{
    public class PcOyun : Pc
    {
        public PcOyun(string v, string v1, string v2, string v3, string v4, int v5, int v6)
        {
            MemoryType = v;
            Processor = v1;
            RamType = v2;
            DisplayCard = v3;
            DisplayCardType = v4;
            OpenTime = v5;
            RamCapacity = v6;
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
