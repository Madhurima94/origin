using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace demo1 {
    class P {
        public void mult(ref int a) {
            a *= 2;
        }
    }
    class Q {
        public int mult(ref int b) {
            b *= 3;
            return b;
        }
    }
    class R {
        public void mult(ref int c) {
            c *= 5;
        }
    }
    class D {
        static void Main(string[] args)
        {
            var i = 1;
            int div, p = 0, q = 0, r = 0, inl = 1;
            P classA = new P();
            Q classB = new Q();
            R classC = new R();
            Console.WriteLine("Enter New Value");
            var newvalue = int.Parse(Console.ReadLine());
            var temp = newvalue;
            while (true)
            {
                if (temp % 2 == 0)
                {
                    temp = temp / 2;
                    classA.mult(ref inl);
                    r++;
                                
                }
                else if (temp % 3 == 0)
                {
                    temp = temp / 3;
                    classB.mult(ref inl);
                    p++;
                }
                else if (temp % 5 == 0)
                {
                    temp = temp / 5;
                    classC.mult(ref inl);
                    q++;

                }
                else
                {
                    Console.WriteLine("Wrong input");
                    break;
                }
                if (inl == newvalue) {
                    Console.WriteLine(r);
                    Console.WriteLine(p);
                    Console.WriteLine(q);
                    break;
                }
            }
            Console.Read();
        }
    }
}




































