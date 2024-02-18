using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Learn_basic.DaHinh;
using Learn_basic.Delegate;
using Learn_basic.Event;
using Learn_basic.Generic;
using Learn_basic.Interface;
using Learn_basic.KeThua;
using Learn_basic.TruuTuong;

namespace Learn_basic
{

    public class Program
    {

        public delegate int TinhToan(int a, int b);
        public static void Main(string[] args){
            Func<int, int, int> tinhTong1 = (int x, int y) =>
            {
                return x + y;
            };
            Action<int> thongbao = (int vl) =>
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(vl);
                
            };

            int kq1 = tinhTong1(5, 6);
            int kq2 = tinhTong1(2, 22);

            thongbao(kq1);
            thongbao(kq2);

            Publisher p = new Publisher();
            TestEvent tEventObj = new TestEvent();
            SubscriberA aEvent = new SubscriberA();
            SubscriberB bEvent = new SubscriberB();

            tEventObj.Sub(p);
            aEvent.Sub(p);
            bEvent.Sub(p);
            p.Send();
            Console.ResetColor();
            
           
        }
    }


}

    
