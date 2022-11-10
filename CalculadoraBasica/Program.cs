using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("--------------Calcular Suma-------------------");
            Console.Write("\nIntroduzca un numero 1:");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.Write("\nIntroduzca un numero 2:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"El resultado de la suma es:{ CalcularOperaciones.Sumar(n1, n2)}");
            Console.ReadLine();
        }
    }
}
