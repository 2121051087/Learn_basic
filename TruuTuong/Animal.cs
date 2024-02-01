using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_basic.TruuTuong
{
    abstract class Animal
    {
        public abstract void SoChan();
        public abstract void Noi();

        public abstract void Loai();
        public abstract void MauLong();

        public void showInFo()
        {
            this.Loai();
            this.MauLong();
            this.Noi();
            this.SoChan();
        }
    }
}
