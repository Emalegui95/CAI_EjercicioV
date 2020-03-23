using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_EjercicioV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número: ");
            string numero = Console.ReadLine();
            Console.Write("El número invertido es: ");
            for (int i = numero.Length-1; i >= 0; i--)
            {
                Console.Write(numero[i]);
            }
            Console.ReadKey(true);
        }
    }
}
