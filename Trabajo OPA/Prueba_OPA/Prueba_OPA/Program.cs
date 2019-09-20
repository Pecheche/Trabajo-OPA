using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_OPA
{
    class Program
    {
        public static void Main (string[] args)
        {
            int c;
            int i;
            int n;
            int suma;
            suma = 0;
            n = 0;
            c = 1;
            i = 0;
            while (i < 3)
            {
                Console.WriteLine("Ingrese el número a verificar");
                n = Convert.ToInt32(Console.ReadLine());
                if (n < Math.Pow(2, 58) && n > 0)
                {
                    while (c < n)
                    {
                        if (n % c == 0)
                        {
                            Console.Write((Convert.ToString(c) + ","));
                            suma = suma + c;
                        }
                        c = c + 1;
                    }
                    i = 4;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine("Número invalido");
                }
            }
            if (i == 1000000000)
            {
                Console.WriteLine("Error");
            }
            else
            {
                if (suma == n)
                {
                    Console.WriteLine("El número " + n + " Perfecto");
                }
                else
                {
                    if (suma < n)
                    {
                        Console.WriteLine("El número " + n + " Deficiente");
                    }
                    else
                    {
                        Console.WriteLine("El número " + n + " Abundante");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
