using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_c
{
    internal class Drob
    {
        private int _nominator; private int _denominator;
        public int Nominator
        {
            get { return _nominator; }
            set { _nominator = value; }
        }
        public int Denominator
        {
            get { return _denominator; }
            set { _denominator = value != 0 ? value : throw new FormatException("Denominator kann nicht 0 sein."); }
        }
        public Drob(int nominator, int denominator)
        {
            Nominator = nominator;
            Denominator = denominator;
        }
        public override string ToString() { return $"{Nominator}/{Denominator}"; }
        public static Drob operator +(Drob a, Drob b)
        {
            return (a.Denominator != b.Denominator) ? new Drob(a.Nominator * b.Denominator + b.Nominator * a.Denominator, a.Denominator * b.Denominator)
                : new Drob(a.Nominator + b.Nominator, a.Denominator);
        }
        public static Drob operator -(Drob a, Drob b)
        {
            return (a.Denominator != b.Denominator) ? new Drob(a.Nominator * b.Denominator - b.Nominator * a.Denominator, a.Denominator * b.Denominator) : new Drob(a.Nominator - b.Nominator, a.Denominator);
        }
        public static Drob operator *(Drob a, Drob b)
        {
            return new Drob(a.Nominator * b.Nominator, a.Denominator * b.Denominator);
        }
        public static Drob operator /(Drob a, Drob b)
        {
            return new Drob(a.Nominator * b.Denominator, a.Denominator * b.Nominator);
        }
        public static bool operator >(Drob a, Drob b)
        {
            return a.Nominator * b.Denominator > b.Nominator * a.Denominator;
        }
        public static bool operator <(Drob a, Drob b)
        {
            return a.Nominator * b.Denominator < b.Nominator * a.Denominator;
        }
        public Drob pow(int k)
        {
            Drob answer = new Drob(1, 1);
            for (int i = 0; i < k; i++)
            {
                answer.Nominator *= this.Nominator; answer.Denominator *= this.Denominator;
            }
            return answer;
        }
    }
}
