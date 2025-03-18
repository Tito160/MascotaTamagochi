using System;
using MascotaVirtual.Models;
using MascotaVirtual.Services;

class Program
{
    static void Main()
    {
        IMascotaService mascotaService = new MascotaService();
        Mascota miMascota = new MascotaConcreta();

        while (true)
        {
            Console.WriteLine("\n--- Estado Actual de la Mascota ---");
            mascotaService.MostrarEstadoMascota(miMascota);

            Console.WriteLine("\n¿Qué quieres hacer?");
            Console.WriteLine("1. Alimentar");
            Console.WriteLine("2. Jugar");
            Console.WriteLine("3. Salir");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    mascotaService.Alimentar(miMascota);
                    break;
                case "2":
                    mascotaService.JugarConMascota(miMascota);
                    break;
                case "3":
                    Console.WriteLine("¡Hasta luego!");
                    return;
                default:
                    Console.WriteLine("Opción no válida, intenta de nuevo.");
                    break;
            }
        }
    }
}
