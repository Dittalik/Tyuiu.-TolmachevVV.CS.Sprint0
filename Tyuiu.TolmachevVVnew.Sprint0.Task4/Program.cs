using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TolmachevVVnew.Sprint0.Task4.Lib;

namespace Tyuiu.TolmachevVVnew.Sprint0.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(12, 32));
            Console.WriteLine(DataService.Substraction(32, 12));
            Console.WriteLine(DataService.Multiplication(2, 8));
            Console.WriteLine(DataService.Division(12, 6));
            Console.ReadKey();
        }
    }
}
