using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yuri_Zinovev__Homework_3.Class
{
    class Fraction
    {
        public int Num { get; set; }
        int _denum = 1;
        public int Denum
        {
            get
            {
                return _denum;
            }
            set
            {
                if (value != 0)
                {
                    _denum = value;
                }
            }
        }

        public Fraction()
        {
            Num = 0;
            Denum = 1;
        }

        public Fraction(int numerator, int denumerator)
        {
            Num = numerator;
            Denum = denumerator;
        }

        //приведение к знаменателю
        public void Adduction(int commonDenum)
        {
            Num *= commonDenum / Denum;
            Denum = commonDenum;
        }

        public Fraction Clone()
        {
            return new Fraction(Num, Denum);
        }

        //упрощение дроби
        public void TrySimplify()
        {
            int maxTry = Math.Min(Num, Denum);

            for (int i = maxTry; i >= 2; i--)
            {
                if (Num % i == 0 && Denum % i == 0)
                {
                    Num /= i;
                    Denum /= i;

                    TrySimplify();
                }
            }
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            Fraction result = new Fraction();
            result.Num = f1.Num * f2.Num;
            result.Denum = f1.Denum * f2.Denum;
            return result;
        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            Fraction result = new Fraction();
            result.Num = f1.Num * f2.Denum;
            result.Denum = f1.Denum * f2.Num;
            return result;
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            Fraction result = new Fraction();
            Fraction f1copy = f1.Clone();
            Fraction f2copy = f2.Clone();
            int commonDenum = CommonDenumerator(f1.Denum, f2.Denum);

            f1copy.Adduction(commonDenum);
            f2copy.Adduction(commonDenum);

            result.Num = f1copy.Num + f2copy.Num;
            result.Denum = commonDenum;

            return result;
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            Fraction result = new Fraction();
            Fraction f1copy = f1.Clone();
            Fraction f2copy = f2.Clone();
            int commonDenum = CommonDenumerator(f1.Denum, f2.Denum);

            f1copy.Adduction(commonDenum);
            f2copy.Adduction(commonDenum);

            result.Num = f1copy.Num - f2copy.Num;
            result.Denum = commonDenum;

            return result;
        }

        public static Fraction operator *(Fraction f1, int integer)
        {
            f1.Num *= integer;
            return f1;
        }

        //вычисление общего знаменателя
        public static int CommonDenumerator(int d1, int d2)
        {
            int i = 1;
            int max = Math.Max(d1, d2);
            int min = Math.Min(d1, d2);
            while ((d1 * i) % d2 != 0)
            {
                i++;
            }
            return d1 * i;
        }

        public override string ToString()
        {
            return $"{Num}/{Denum}";
        }
    }
}
