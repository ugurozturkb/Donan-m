using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DONANIM
{

    public abstract class Pc : IPc
    {          
        public string Opening { get; set; }
        
        public string Processor { get; set; }

        public string DisplayCard { get; set; }

        public string DisplayCardType { get; set; }

        public string MemoryType { get; set; }
    
        public string RamType { get; set; }

        public int OpenTime { get; set; }
        
        public int RamCapacity { get; set; }

        public int PointProcessor { get; set; }

        public void Off()
        {
            throw new NotImplementedException();
        }

        public void Open()
        {
             throw new NotImplementedException();
        }

        public virtual void TransferTime()
        {
             Console.Write("SSD Aktarım = ");
        }

        public virtual void Performance()
        {
             Console.WriteLine("SSD Açılış = ");
        }

        public void Details() 
        {
            Console.WriteLine("Bilgisayar Açılıyor... {0}", Opening);
            Console.WriteLine("Hafıza Türü : {0}", MemoryType);
            Console.WriteLine("İşlemci : {0}", Processor);
            Console.WriteLine("Ram Türü : {0}", RamType);
            Console.WriteLine("Ekran Kartı : {0}", DisplayCard);
            Console.WriteLine("Ekran Kartı Türü : {0}", DisplayCardType);
            Console.WriteLine("Açılış Süresi : {0}", OpenTime);
            Console.WriteLine("Ram Kapasitesi : {0}", RamCapacity);
            Console.WriteLine("İşlemsi Puanı : {0}", PointProcessor);
        }
    }
    
}
