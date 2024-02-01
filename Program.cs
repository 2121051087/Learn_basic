using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learn_basic;

namespace Learn_basic
{

    public class Program
    {
       
        static void Main(string[] args)
        {
         
            Product p2 = new Iphone();
            p2.TestProduct();
            Console.WriteLine("====================================");
            Category c1 = new SamSung();
            c1.TestCategory();
            thucHanh th1 = new thucHanh(100);
            th1.ShowPrice();
            th1.OderAction(36);

            Console.WriteLine("====================================");
            Category c2 = new LapTop();
            c2.TestCategory();
            thucHanh th = new thucHanh(100);
            th.ShowPrice();
            th.OderAction(36);
        
        
          

        }
        
    }


}

    
