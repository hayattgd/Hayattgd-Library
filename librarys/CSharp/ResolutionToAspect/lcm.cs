using System;

namespace HL.Aspect
{
    public class lcm
    {
        void Start()
        {
            var lcm = Lcm(28, 34);
        }

        public static int Lcm(int a, int b)
        {
            return a * b / Gcd(a, b);
        }

        public static int Gcd(int a, int b)
        {
            if (a < b)
                return Gcd(b, a);
            while (b != 0)
            {
                var remainder = a % b;
                a = b;
                b = remainder;
            }
            return a;
        }
    }
}