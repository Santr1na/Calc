using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, result, resultSub, resultMult, resultDiv;
            Console.WriteLine("Введите первое число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = Convert.ToInt32(Console.ReadLine());
            result = a + b;
            Console.WriteLine("Сумма = "+result);
            resultSub = a - b;
            Console.WriteLine("Разность = " + resultSub);
            resultMult = a * b;
            Console.WriteLine("Умножение = " + resultMult);
            resultDiv = a / b;
            Console.WriteLine("Деление = " + resultDiv);
            Console.ReadKey();
        }
    }
}
