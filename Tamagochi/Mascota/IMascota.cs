using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    public interface IMascota
    {
        void Alimentar(Mascota mascota);
        void JugarConMascota(Mascota mascota);
        void MostrarEstadoMascota(Mascota mascota);
    } 
}