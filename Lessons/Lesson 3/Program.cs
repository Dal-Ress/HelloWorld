using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    class ComplexNumber
    {
        public ComplexNumber(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        private double x, y;
        public double GetX() { return this.x; }
        public double GetY() { return this.y; }


        public ComplexNumber Plus(ComplexNumber z)
        {
            ComplexNumber temp = new ComplexNumber()
            {
                x = this.x + z.x,
                y = this.y + z.y
            };
            return temp;
        }
        public ComplexNumber Minus(ComplexNumber c)
        {
            ComplexNumber temp2 = new ComplexNumber()
            {
                x = this.x - c.x,
                y = this.y - c.y
            };
            return temp2;   
        }

        public ComplexNumber Mult(ComplexNumber v)
        {
            ComplexNumber temp3 = new ComplexNumber()
            {
                x = this.x * v.x - this.y * v.y,
                y = this.y * v.x + this.x * v.x
            };
            return temp3;
        }


        public string ToString()
        {
            return $"{x} + {y}i";
        }

    }


    class Program
    {

        static void Main(string[] args)
        {
            ComplexNumber a = new ComplexNumber(1,7);
            ComplexNumber b = new ComplexNumber(3,5);

            ComplexNumber res = a.Plus(b);

            ComplexNumber res2 = a.Minus(b);

            ComplexNumber res3 = a.Mult(b);

            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            Console.WriteLine(res.ToString());
            Console.WriteLine(res2.ToString());
            Console.WriteLine(res3.ToString());

        }
    }
}

