using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int res = calculator.Summing(10, 20);

            Console.WriteLine(res);
        }
    }

    public class Calculator
    {
        public int Summing(int x, int y)
        {
            int res = x + y;
            return res;
        }
    }
}
