using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    public class MascotaConcreta : Mascota
    {
        public override void Comer()
        {
            estadoActual.Comer(this);
        }

        public override void Jugar()
        {
            estadoActual:Jugar(this);
        }
    }
}