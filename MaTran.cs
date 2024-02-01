using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_basic
{
    internal class MaTran
    {
        public void Matran1()
        {
            // Khai báo mảng 2 chiều
            int[,] mang = new int[3, 4];


            // Nhập giá trị của các phần tử trong mảng
            for (int i = 0; i < mang.GetLength(0); i++)
            {
                for (int j = 0; j < mang.GetLength(1); j++)
                {
                    Console.WriteLine("Nhap gia tri cua phan tu co vi tri {0}:{1}:", i, j);
                    mang[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //in mảng 
            for (int i = 0; i < mang.GetLength(0); i++)
            {
                for (int j = 0; j < mang.GetLength(1); j++)
                {
                    Console.Write(mang[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
