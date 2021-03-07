using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invertir_valor_de_dos_variables
{
    class Program
    {
        static void Main(string[] args)
        {

            int a;
            int b;
            int c;


            Console.Write("Introduce el valor entero de A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el valor entero de B: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            c = a;
            a = b;
            b = c;

            Console.Write("El valor de A es: " + a);

            Console.WriteLine("");
            
            Console.Write("El Valor de B es:" + b);

            Console.WriteLine("");
            
            Console.Write("El valor de A ahora es: " + c);
            
            Console.WriteLine("");
            
            Console.Write("El valor de B ahora es: " + a);
            

            Console.ReadKey();

        }
    }
}
