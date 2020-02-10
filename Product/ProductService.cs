using System;

namespace Product.Services
{
    public class ProductService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }
            throw new NotImplementedException("Please create a test first.");

        }
        public int Sum(int a, int b) {
            int c;
            c = a+b;
            if (c == 3) {
                return a+b;
            }
            throw new NotImplementedException("Sum is not implemented");
        }

    }
    
}
