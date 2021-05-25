using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_Instituto_Arqueologico
{
    public class Monumento : Descubrimiento
    {
        //posee jeroglíficos?
        private Boolean varjeroglificos;

        public Boolean varJeroglificos
        {
            get { return varjeroglificos; }
            set { varjeroglificos = value; }
        }

        //conmemora a una autoridad? cual?
        private string varautoridad;

        public string varAutoridad
        {
            get { return varautoridad; }
            set { varautoridad = value; }
        }
        //listado de dioses a los que hace tributo
     

    }
}