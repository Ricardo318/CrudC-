using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1.Clases
{
    internal class Equipo
    {
        public string NombreEquipo { get; set; }
        public int CantidadJugadores { get; set; }
        public string NombreDT { get; set; }
        public string TipoEquipo { get; set; }
        public string CapitanEquipo { get; set; }
        public bool TieneSub21 { get; set; }



        public Equipo()
        {
        }

        public Equipo(string nombreequipo, int cantidadjugadores, string nombreDT, string tipoequipo, string capitanequipo, bool tieneSub21)
        {

            NombreEquipo = nombreequipo;
            CantidadJugadores = cantidadjugadores;
            NombreDT = nombreDT;
            TipoEquipo = tipoequipo;
            CapitanEquipo = capitanequipo;
            TieneSub21 = tieneSub21;
        }
    }
}
