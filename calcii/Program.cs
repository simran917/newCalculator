using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcii
{
    public class Calc
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public int sub(int a, int b)
        {
            return a - b;
        }
        public int mul(int a, int b)
        {
            return a * b;
        }
        public int div(int a, int b)
        {
            return a / b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calc obj = new Calc();
            obj.add(2, 3);
            Console.WriteLine(obj.add(2, 3));
            Console.ReadKey();
        }
    }
}
