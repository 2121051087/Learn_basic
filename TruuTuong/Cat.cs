using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_basic.TruuTuong
{
     class Cat : Animal
    {
        public Cat()
        {
            Console.WriteLine(@"Mèo");
            
        }
        public override void SoChan()
        {
            Console.WriteLine("So chan : 4 ");
          
        }
        public override void Noi()
        {
            Console.WriteLine("Tieng keu : Mew Mew");
        }
        public override void Loai()
        {
            Console.WriteLine("Loai : Meo nha");
        }

        public override void MauLong()
        {
            Console.WriteLine("Mau Long  : Xam ");
        }
    }
}
