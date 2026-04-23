using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemaaaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaReferencia = new DateTime(2026, 4, 22);
            Console.Write("Ingrese su fecha de nacimiento: ");
            Console.Write("Dia: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Mes: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Año: ");
            int anio = int.Parse(Console.ReadLine());
            DateTime fechaNaciminento = new DateTime(anio, mes, dia);
            int edad = fechaNaciminento.Year - fechaReferencia.Year;
            if (fechaReferencia < fechaNaciminento.AddYears(edad))
            {
                edad--;
            }
            Console.WriteLine($"\nAl {fechaReferencia:dd/MM/yyyy}, su edad es: {edad} años.");
        }
    }
}
