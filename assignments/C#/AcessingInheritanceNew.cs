using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AccessingInheritance {
    class MultTwo {
        public void MultValue(ref int a) {
            a *= 2;
        }
    }
    class MultThree : MultTwo {
        public int MultValue(ref int a) { 
           a *= 3;
            return a;
        }
    }
    class MultFive:MultThree {
        public void MultValue(ref int a) {
            a *= 5;
        }
    }
    class MultCalculate : MultFive{
        static void Main(string[] args)
        {
            var i = 1;
            int div, p = 0, q = 0, r = 0, inl = 1;
            MultTwo classA = new MultTwo();
            MultThree classB = new MultThree();
            MultFive classC = new MultFive();
            Console.WriteLine("Enter New Value");
            var newValue = int.Parse(Console.ReadLine());
            var temp = newValue;
            while (true)
            {
                if (temp % 2 == 0)
                {
                    temp = temp / 2;
                    classA.MultValue(ref inl);
                    r++;
                                
                }
                else if (temp % 3 == 0)
                {
                    temp = temp / 3;
                    classB.MultValue(ref inl);
                    p++;
                }
                else if (temp % 5 == 0)
                {
                    temp = temp / 5;
                    classC.MultValue(ref inl);
                    q++;

                }
                else
                {
                    Console.WriteLine("Wrong input");
                    break;
                }
                if (inl == newValue) {
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




































