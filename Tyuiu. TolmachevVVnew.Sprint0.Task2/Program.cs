using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.TolmachevVVnew.Sprint0.Task2.Lib;
namespace Tyuiu.TolmachevVVnew.Sprint0.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Виталий"));
            Console.ReadKey();
        }
    }
}
