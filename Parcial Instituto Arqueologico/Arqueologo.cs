using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_Instituto_Arqueologico
{
    public class Arqueologo
    {
        
        // nombre
        private string varnombre;

        public string varNombre
        {
            get { return varnombre; }
            set { varnombre = value; }
        }
        // apellido
        private string varapellido;

        public string varApellido
        {
            get { return varapellido; }
            set { varapellido = value; }
        }
        // fecha de nacimiento
        private DateTime varfechanacimiento;

        public DateTime varFechaNacimiento
        {
            get { return varfechanacimiento; }
            set { varfechanacimiento = value; }
        }
        // fecha de deceso
        private DateTime varfechadeceso;

        public DateTime varFechaDeceso
        {
            get { return varfechadeceso; }
            set { varfechadeceso = value; }
        }

    }
}