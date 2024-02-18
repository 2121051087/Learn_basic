using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_basic.DaHinh
{
    internal class toan
    {
        public float nhan(float d ,float c)
        {
            float result = d * c;
            Console.Write("nhan 2 so thuc co ket qua :"+ result);
            return result ;
        }

        public int nhan(int d , int c)
        {
            int result = d * c;
            Console.Write("nhan 2 so nguyen co ket qua: "+ result);
            return result;
        }  
        public float chia(float d , float c)
        {
            float result = d / c;
            Console.Write("chia 2 so thuc co ket qua: "+ result);
            return result;
        }
       
    }
}
