using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_basic
{
    public class operator_logic_compare
    {
        bool c = (3 == 0); // sử dụng toán tử "==" để so sáng 2 giá trị : kết quả là false
        bool d = (3 >= 4);//false
        bool e = (3 <= 4);//true 
        bool f = (3 > 4);//false
        bool g = (3 < 4);// true
        bool h = (3 != 4);//true

        bool i = (3 == 0 && 4 == 4); //false
        bool j = (3 == 0 || 4 == 4); // true 
        bool k = !(3 == 0); // true 
       
    }
}
  