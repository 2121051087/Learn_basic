using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Learn_basic.TruuTuong
{
    abstract class Category
    {
        protected string nameProduct;
        protected double countNumberProduct;
        public abstract void CategoryInfo();
        public void TestCategory()
        {
            CategoryInfo();
        }
    }

    class SamSung : Category
    {
        public SamSung()
        {
            nameProduct = " Dien Thoai";
            countNumberProduct = 100;
        }

        public override void CategoryInfo()
        {
            Console.WriteLine($"Loai san pham :{nameProduct}");
            Console.WriteLine($"so luong san pham : {countNumberProduct}");

        }
    }
    class LapTop : Category
    {
        public LapTop()
        {
            nameProduct = " May tinh";
            countNumberProduct = 18;
        }
        public override void CategoryInfo()
        {
            Console.WriteLine($"Loai san pham :{nameProduct}");
            Console.WriteLine($"so luong san pham : {countNumberProduct}");
        }
    }
}
