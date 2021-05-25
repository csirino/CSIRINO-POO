using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_Instituto_Arqueologico
{
    public class Ciudad : Descubrimiento
    {
        // nombre antiguo de la ciudad
        private string varnombreantiguo;

        public string varNombreAntiguo
        {
            get { return varnombreantiguo; }
            set { varnombreantiguo = value; }
        }

        //periodo en un intervalo de años que tuvo población activa
        private DateTime varperiodoinicial;

        public DateTime varPeriodoInicial
        {
            get { return varperiodoinicial; }
            set { varperiodoinicial = value; }
        }


        private DateTime varperiodofinal;

        public DateTime varPeriodoFinal
        {
            get { return varperiodofinal; }
            set { varperiodofinal = value; }
        }

        //cantidad demográfica de habitantes en ese período
        private int varcanthabitantes;
            
        public int varCantHabitantes
        {
            get { return varcanthabitantes; }
            set { varcanthabitantes = value; }
        }

    }
}