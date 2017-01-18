using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yuri_Zinovev__Homework_3.Class
{
    class Complex
    {
        public double Im { get; set; }
        public double Re { get; set; }

        public Complex() { }
        public Complex(double im, double re)
        {
            Im = im;
            Re = re;
        }

        public override string ToString()
        {
            return String.Format($"{Re}+{Im}i");
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex result = new Complex();
            result.Im = c1.Im + c2.Im;
            result.Re = c1.Re + c2.Re;
            return result;
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            Complex result = new Complex();
            result.Im = c1.Im - c2.Im;
            result.Re = c1.Re - c2.Re;
            return result;
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            Complex result = new Complex();
            result.Im = c1.Im * c2.Im + c1.Re * c2.Im;
            result.Re = c1.Re * c2.Im - c1.Im * c2.Re;
            return result;
        }
    }
}
