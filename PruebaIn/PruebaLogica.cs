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
        public static string Tranform(string mens)
        {
            string men = mens;
            string men1 = "";
            if (string.IsNullOrEmpty(men))
                return men;

            // We want to build string in a loop. 
            // StringBuilder has been specially desinged for this
            StringBuilder sb = new StringBuilder();

            foreach (var c in men)
            {
                if (char.IsSeparator(c))
                    sb.Replace(" ".Replace"");
            }

            return sb.ToString();
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