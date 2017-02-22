using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace demo1 {
    class A {
        public void mult(ref int a) {
            a *= 2;
        }
    }
    class B {
        public int mult(ref int b) {
            b *= 3;
            return b;
        }
    }
    class c {
        public void mult(ref int c) {
            c *= 5;
        }
    }
    class D {
        static void Main(string[] args)
        {
            var i = 1;
            int div;
            A classA = new A();
            B classB = new B();
            c classC = new c();
            Console.WriteLine("Enter New Value");
            var newvalue = int.Parse(Console.ReadLine());
            if (newvalue % 2 == 0)
            {
                div = newvalue / 2;
                classA.mult(ref div);
                Console.WriteLine(div);
            }
            else if (newvalue % 3 == 0) {
                div = newvalue / 3;
                classB.mult(ref div);
                Console.WriteLine(div);
            }
            else if (newvalue % 5 == 0) {
                div = newvalue / 5;
                classC.mult(ref div);
                Console.WriteLine(div);
            }
            Console.Read();
        }
    }
}
















