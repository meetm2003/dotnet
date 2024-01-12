using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labwork.java_lab2
{
    public class complex
    {
        int r, i;
        public complex()
        {
            r = 0;
            i = 0;
        }
        public complex(int d_r, int d_i)
        {
            r = d_r;
            i = d_i;
        }
        public void display()
        {
            Console.WriteLine(r + "+" + i + "i");
        }
        public complex add_complex(complex d_c_ref)
        {
            complex res_ref = new complex();
            res_ref.r = r + d_c_ref.r;
            res_ref.i = i + d_c_ref.i;
            return res_ref;
        }
    }
    class complex_main
    {
        public static void Main(string[] args)
        {
            complex c_ref1 = new complex(3, 6);
            c_ref1.display();
            complex c_ref2 = new complex(2, 5);
            c_ref2.display();
            complex result;
            result = c_ref1.add_complex(c_ref2);
            result.display();
        }
    }
}
