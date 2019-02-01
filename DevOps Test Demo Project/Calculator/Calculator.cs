using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOps_Test_Demo_Project.Calculator
{
    public class Calculator : ICalculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Divide(int x, int y)
        {
            try
            {
                return x / y;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex);
                return 0;
            }
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }
    }
}
