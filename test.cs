using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_basic
{
    public class test
    {
        public int leg { get; }
       
        public double weight { get; }

        public void showInfo(int leg, double weight )
        {
            Console.WriteLine($"so chan: {leg}");
            Console.WriteLine($"can nang: {weight}");
        }
        public test()
        {
          
        }


    }
    class  haha : test 
    {
        public string food { get; }
        public string color { get; }

        public haha()
        {
            food = " meat";
            color = "red";
            showInfo(2, 49.3f);

        }
        
    }
}
