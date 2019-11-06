using ServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammaticDiscoverableService
{
    public class CalculatorService : ICalculator
    {
        int ICalculator.Add(int a, int b) => Add(a, b);

        protected int Add(int a, int b) => a + b;
    }
}
