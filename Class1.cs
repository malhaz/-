using System;

namespace DLL
{
    public  class Class1
    {
        double result;

        public  double Area(double r) 
        {
            return result = Math.PI * Math.Pow(r, 2);
        }

        public  double Area(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return result = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }

        public bool Rornot(double a, double b, double c) 
        {
            if (c * c == a * a + b * b)
                return true;
            else return false;
        }
    }
}
