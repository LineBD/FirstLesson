using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandTestingCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator myCalculator = new Calculator();
            var add = myCalculator.Add(2, 3);
            var subtract = myCalculator.Subtract(4, 2);
            var multiply = myCalculator.Multiply(2, 3);
            var power = myCalculator.Power(2,2);

            Console.WriteLine("Add: {0} + {1} = {2}", 2,3, add);
            Console.WriteLine("Subtract: {0} - {1} = {2}", 4, 2, subtract);
            Console.WriteLine("Multiply: {0} * {1} = {2}", 2, 3, multiply);
            Console.WriteLine("Power: {0} ^ {1} = {2}", 2, 2, power);

            Console.ReadKey();
        }
    }
}
