using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_semana_7
{
    internal class Program
    {
        static void Main(string[] args)
       
        {
            trabajo01();
        }
        static void trabajo01()
        {
            int numero;
            int mayor = 0;
            int contador = 0;

            Console.Write("Ingrese un número (0 para salir): ");
            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                if (numero > mayor)
                {
                    mayor = numero;
                }
                else
                {
                    contador++;
                }

                Console.Write("Ingrese un número (0 para salir): ");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("El número mayor es: " + mayor);
            Console.WriteLine("Cantidad de números menores: " + contador);
        }
        
    }
    
}
    
