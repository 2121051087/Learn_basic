using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_basic.KeThua
{
    internal class Product
    {
        protected double price;

        public virtual void ProductInfo()
        {
            Console.WriteLine($"Gia san pham la :{price}");
        }
        public void TestProduct()
        {
            ProductInfo();
        }

    }

    class Iphone : Product
    {
        public Iphone()
        {
            price = 1000;

        }
        public override void ProductInfo()
        {
            Console.WriteLine($"Gia san pham Iphone");
            base.ProductInfo();
        }
    }
}
