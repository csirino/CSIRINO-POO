using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_Instituto_Arqueologico
{
     public abstract class Descubrimiento
    {
        public string varPais;
        public string varCiudad;
        public DateTime varFecha;
        public Arqueologo Arqueologo = new Arqueologo();
        //presupuesto
    }
}
