using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probleme1otro_profesor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese hora (0-23): ");
            int hora = int.Parse(Console.ReadLine());

            Console.Write("Ingrese los minutos (0-59): ");
            int minutos = int.Parse(Console.ReadLine());

            Console.Write("Ingrese los segundos (0-59): ");
            int segundo = int.Parse(Console.ReadLine());

            segundo++;

            if(segundo == 60)
            {
                segundo = 0;
                minutos++;
                if(minutos == 60)
                {
                    minutos = 0;
                    hora++;
                    if(hora == 24)
                    {
                        hora = 0;
                    }
                }
            }
            Console.WriteLine("\nEl segundo siguiente es:");
            Console.WriteLine($"{hora:D2}:{minutos:D2}:{segundo:D2}");


            {


            }
        } 
    }
}
