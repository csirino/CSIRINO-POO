using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_Instituto_Arqueologico
{
    public class Tumba : Descubrimiento
    {
        
        // cantidad de individuos encontrados
        private int varcantindividuos;

        public int varCantIndividuos
        {
            get { return varcantindividuos; }
            set { varcantindividuos = value; }
        }
        //es una autoridad? faraon, rey, etc.
        private string varautoridad;

        public string varAutoridad
        {
            get { return varautoridad; }
            set { varautoridad = value; }
        }

    }
}