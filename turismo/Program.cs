using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turismo
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantViajes, edad, nroPasaje=0, edadMenor, cantMenores=0, pasajeMenor;
            double recTotalP=0, recXPaseo=0, ticket, totalTicket=0, desc;
            Console.Title = "TURISMO CITY";
            Console.WindowHeight = 8;
            Console.WindowWidth = 45;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine("Ingrese la cantidad de viajes a realizar: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            cantViajes = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();

            for(int i=1; i < cantViajes; i++)
            {
                Console.WriteLine("Inicia el viaje numero: "+ i);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ingrese edad: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                edad = Convert.ToInt32(Console.ReadLine());
                pasajeMenor = nroPasaje + 1;
                edadMenor = edad;

                Console.ResetColor();

                while (edad > 0)
                {
                    nroPasaje++;
                    ticket = 3;
                    desc = 0;

                    if (edad < 12)
                    {
                        desc = (ticket * 50) / 100;
                        cantMenores++;
                    }
                    totalTicket = ticket - desc;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.WriteLine("Valor del ticket: {0:c}", ticket);
                    Console.WriteLine("descuento: {0:c}", desc);
                    Console.WriteLine("total ticket: {0:c}", totalTicket);
                    

                    recXPaseo = recXPaseo + totalTicket;

                    if (edad < edadMenor)
                    {
                        edadMenor = edad;
                        pasajeMenor = nroPasaje;
                    }

                    Console.WriteLine("Ingrese otra edad o 0 para terminar: ");
                    edad = Convert.ToInt32(Console.ReadLine());
                }

                recTotalP = recTotalP + recXPaseo;

                if (nroPasaje > 0)
                {
                    Console.WriteLine("Numero de pasaje menor de edad: " + nroPasaje + " edad: " + edadMenor);
                }
                else
                {
                    Console.WriteLine("no hubo menores");
                }

                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Recaudacion por viaje: {0:c}", recXPaseo);
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("recaudacion total: {0:C}" , recTotalP);
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("cantidad de menores: " + cantMenores);
                Console.WriteLine("--------------------------------------------");
                Console.ReadKey();

            }
        }
    }
}
