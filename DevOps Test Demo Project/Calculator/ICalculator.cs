using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOps_Test_Demo_Project.Calculator
{
    public interface ICalculator
    {
        int Add(int x, int y);
        int Subtract(int x, int y);
        int Multiply(int x, int y);
        int Divide(int x, int y);
    }
}
