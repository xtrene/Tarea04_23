using System;

namespace Tarea04_23
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            string operador = "";
            double resultado = 0;

            Console.Write("Introduce el primer número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce wl segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce operador ( + , - , * , / , ^ (ALT+94) ,% ): ");
            operador = Console.ReadLine();

            switch (operador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
                case "^":
                    resultado =Math.Pow(num1 , num2);
                    break;
                case "%":
                    resultado = num1 % num2;
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("El resultado de {0} {1} {2} es: {3}", num1, operador, num2, resultado);

            Console.ReadKey();
        }
    }
}
