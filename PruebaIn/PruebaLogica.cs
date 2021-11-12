using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;

namespace PruebaIn
{
    class PruebaLogica
    {
        public static string trans(string mns)
        {
            string men = mns;
            string resultado = "";
            string palabraActual = "";
            int n = 0;
            Dictionary<int, string> frase = new Dictionary<int, string>();

            foreach (char letra in men)
            {
                if (letra != ' ')
                    palabraActual += letra;
                else
                {
                    if (palabraActual.Length > 5)
                    {
                        palabraActual = palabraActual.ToArray().Reverse().ToString();
                        frase.Add(n, palabraActual);
                        n += 1;
                        palabraActual = "";
                    }
                    else
                    {
                        frase[n] = palabraActual;
                        n += 1;
                        palabraActual = "";
                    }
                }
            }
            frase[n] = palabraActual;
            for (int i = n; i >= 0; i--)
            {
                resultado = frase[i] + resultado;
            }
            
            return resultado;
        }
        public static string Tranform(string mens)
        {
            string men = mens;
            string resultado = "";
            string palabraActual = "";
            int n = 0;
            Dictionary<int, string> frase = new Dictionary<int, string>();

            foreach (char letra in men)
            {
                if (letra != ' ' || letra != '-' || letra != '_')
                    palabraActual += letra;
                else
                {
                    if (palabraActual.Length > 5)
                    {
                        palabraActual = palabraActual.ToArray().Reverse().ToString();
                        frase.Add(n, palabraActual);
                        n += 1;
                        palabraActual = "";
                    }
                    else
                    {
                        frase[n] = palabraActual;
                        n += 1;
                        palabraActual = "";
                    }
                }
            }
            frase[n] = palabraActual;
            for (int i = n; i >= 0; i--)
            {
                resultado = frase[i].ToUpperInvariant() + resultado;
            }

            return resultado;
        }


        public static int Multiplos(int num)
        {
            int numero = num;
            int num1 = 3;
            int num2 = 5;
            int mul, mul2;
            int sum = 0;
            int cont=0;
            bool ban = false;
            
            while (ban == false)
            {
                mul = num1 * cont;
                mul2 = num2 * cont;
                if (mul < numero)
                {
                    cont = cont+1;
                    sum = sum + mul;
                    if (mul2 < numero)
                    {
                        sum = sum + mul2;
                    }
                }
                else
                {
                    ban = true;
                }
            }
            return sum;
        }
    }
}