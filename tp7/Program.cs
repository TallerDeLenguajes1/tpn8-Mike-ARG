using System;

namespace tp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            calc.Numero1 = 351;
            calc.Numero2 = 239;
            float num1 = 200;
            float num2 = 130;
            

            Console.WriteLine(calc.Suma(num1, num2));
        }
    }
}
