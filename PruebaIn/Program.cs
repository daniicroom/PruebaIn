using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIn
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int suma = 0;
            string men = "";
            System.Console.Write("Escriba una sentencia: ");
            men = System.Console.ReadLine();
            System.Console.Write("Setencia con cambio de orden: " + PruebaLogica.trans(men));
            Console.ReadKey();
            Console.Clear();
            System.Console.Write("Escriba una sentencia: ");
            men = System.Console.ReadLine();
            System.Console.Write("Dato Transformado: " + PruebaLogica.Tranform(men));
            Console.ReadKey();
            Console.Clear();
            System.Console.Write("Escriba un numero: ");
            num = int.Parse(System.Console.ReadLine());
            suma = PruebaLogica.Multiplos(num);
            System.Console.Write("la suma de los multiplos es: " + suma);
            Console.ReadKey();
        }
    }
}
