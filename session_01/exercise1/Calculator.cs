using System;

namespace DNB
{
    namespace MathLib
    {
        class Calculator
        {
            public Calculator()
            {

            }

            public int Add(int a, int b)
            {
                return a + b;
            }

            public int Add(int[] a)
            {
                int b = 0;
                foreach (int num in a)
                {
                    b += num;
                }
                return b;
            }
        }
    }

}

