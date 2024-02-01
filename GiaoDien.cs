using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_basic
{
    interface GiaoDien
    {
        public void ShowPrice();
    }
    interface IOrder
    {
        public void OderAction(int numberProduct);
    }

    class thucHanh : GiaoDien, IOrder
    {
         double price = 1000;
        public thucHanh(double price)
        {
            this.price = price;
        }
        public void ShowPrice()
        {
            Console.WriteLine($"gia san pham :{price}");
        }

        public void OderAction(int numberProduct)
        {
            Console.WriteLine($"so luong san pham :{numberProduct}");
        }
    }
}
