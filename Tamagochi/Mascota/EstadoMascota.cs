using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TamagochiBD
{
    public abstract class EstadoMascota
    {
        public abstract void Comer(Mascota mascota);
        public abstract void Jugar(Mascota mascota);
        public abstract void MostrarEstado();
    }
}