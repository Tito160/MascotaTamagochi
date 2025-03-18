using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    public class Aburrida : EstadoMascota
    {
        private DateTime TiempoInicioAburrida = DateTime.Now;

        public override void Comer(Mascota mascota)
        {
            if ((DateTime.Now - TiempoInicioAburrida).TotalMinutes > 80)
            {
                mascota.cambiarEstado(new EstadoContenta());
                Console.WriteLine("La mascota comio y dejo de estar aburrida");
            }
            else
            {
                Console.WriteLine("La mascota comio pero sigue aburrida");
            }
        }

        public override void Jugar(Mascota mascota)
        {
            mascota.cambiarEstado(new EstadoContenta());
            Console.WriteLine("La mascota jugo y ahora esta contenta");
        }

        public override void MostrarEstado()
        {
            Console.WriteLine("La mascota esta aburrida");
        }
    }
}