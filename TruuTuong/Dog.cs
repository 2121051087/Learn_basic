using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_basic.TruuTuong
{
    internal class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine(@"       Chó");
        }
        public override void SoChan()
        {
            Console.WriteLine("So chan : 4 ");

        }
        public override void Noi()
        {
            Console.WriteLine("Tieng keu :Gau Gau");
        }
        public override void Loai()
        {
            Console.WriteLine("Loai : Cho nha");
        }

        public override void MauLong()
        {
            Console.WriteLine("Mau Long  : White ");
        }
    }
}
    
