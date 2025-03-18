using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TamagochiBD
{
    public class Contenta : EstadoMascota
    {
        private int vecesJugadas = 0;

        public override void Comer(Mascota mascota)
        {
            mascota.cambiarEstado(new EstadoContenta());
            Console.WriteLine("La mascota comio y se siente aun mas feliz");
        }

        public override void Jugar (Mascota mascota)
        {
            vecesJugadas++;
            mascota.cambiarEstado(new EstadoContenta());
            Console.WriteLine("La mascota jugo y su felicidad aumento");

            if (vecesJugadas > 5)
            {
                mascota.cambiarEstado(new EstadoHambrienta());
                Console.WriteLine("La mascota jugo mucho y esta hambrienta");
            }
        }

        public override void MostrarEstado()
        {
            Console.WriteLine("La mascota esta contenta");
        }
    }

}