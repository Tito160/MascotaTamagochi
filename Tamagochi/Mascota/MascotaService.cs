using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    public class MascotaService : IMascota
    {
        public void Alimentar(Mascota mascota)
        {
            mascota.Comer();
        }

        public void JugarConMascota(Mascota mascota)
        {
            mascota.Jugar();
        }

        public void MostrarEstadoMascota(Mascota mascota)
        {
            mascota.MostrarEstado();
        }
    }
}