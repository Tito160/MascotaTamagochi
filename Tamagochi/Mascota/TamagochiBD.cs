using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TamagochiBD
{
    public abstract class Mascota
    {
        public int Felicidad;
        public EstadoMascota estadoActual;

        public Mascota()
        {
            Felicidad = 5;
            estadoActual = new EstadoAburrida();
        }

        public void cambiarEstado(EstadoMascota nuevoEstado)
        {
            estadoActual = nuevoEstado;
        }

        public abstract void Comer();
        public abstract void Jugar();
        public int NivelFelicidad() => Felicidad;
        public void MostrarEstado() => estadoActual.MostrarEstado();
    }
}
