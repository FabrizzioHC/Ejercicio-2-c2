using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_c2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String tipofruta;
            int distanciaKilometros;
            int costocaja;
            Console.WriteLine("ingresa el nombre de la fruta que va a llevar (Naranja, Fresa o Mango): ");
            tipofruta = Console.ReadLine();
            Console.WriteLine("ingresa la distancia en kilometros: ");
            distanciaKilometros = int.Parse(Console.ReadLine());
            switch (tipofruta)
            {
                case "Naranja":
                    if (distanciaKilometros < 30)
                    {
                        costocaja = 2;
                    }
                    else
                    {
                        costocaja = 4;
                    }
                    break;
                case "Fresa":
                    if (distanciaKilometros < 30)
                    {
                        costocaja = 6;
                    }
                    else
                    {
                        costocaja = 9;
                    }
                    break;
                case "Mango":
                    if (distanciaKilometros < 30)
                    {
                        costocaja = 3;
                    }
                    else
                    {
                        costocaja = 5;
                    }
                    break;
                default:
                    Console.WriteLine("la fruta que elijio no esta en nuestra lista.");
                    return;
            }

            Console.WriteLine($"el costo por caja de frutas es: S/{costocaja}");
            Console.ReadKey();
        }
    }
}
