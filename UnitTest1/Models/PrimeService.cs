using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest1.Models
{
    public class PrimeService
    {
        public bool IsPrime(int number)
        {

            if (number <= 1 || number % 2 == 0) return false;
            if (number == 2) return true;
            var boundary = (int)Math.Floor(Math.Sqrt(number));
            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
