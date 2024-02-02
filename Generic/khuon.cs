using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_basic.Generic
{
     class khuon<T>
    {
        private T data ;
        public khuon (T value)
        {
            data = value;
        }
        public T methodParameter(T Parameter)
        {
            Console.WriteLine(Parameter);
            return data;
        }
        public T Property { get; set; }
    }
}
