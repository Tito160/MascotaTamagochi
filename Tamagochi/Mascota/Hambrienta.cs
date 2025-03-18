using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TamagochiBD
{
    public class Hambrienta : EstadoMascota
    {
        public override void Comer(Mascota mascota)
        {
            mascota.cambiarEstado(new EstadoContenta());
            Console.WriteLine("La mascota comio y ahora esta contenta");
        }

        public override void Jugar(Mascota mascota)
        {
            Console.WriteLine("La mascota tiene hambre y no quiere jugar");
        }

        public override void MostrarEstado()
        {
            Console.WriteLine("La mascota esta hambrienta");
        }
    }
}