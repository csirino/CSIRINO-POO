using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_Instituto_Arqueologico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Descubrimiento descubrimiento = null;
            
            if (radioButtonCiudad.Checked) {
                descubrimiento = new Ciudad();
                ((Ciudad) descubrimiento).varNombreAntiguo = textBoxCiudad.Text;
                //Ciudad.varPeriodoFinal = ;


            }
             
                if (radioButtonTumba.Checked)
                {
                    descubrimiento = new Tumba();
                    ((Tumba) descubrimiento).varCantIndividuos = 22;
                    //Tumba.varAutoridad = true;

     
            }

            if (radioButtonMonumento.Checked)
            {
                descubrimiento = new Monumento();                


            }

            // asigno valores ciudad / fecha / pais / arqueologo / presupuesto
            descubrimiento.varCiudad = textBoxCiudad.Text;
            descubrimiento.varPais = textBoxPais.Text;
            descubrimiento.varFecha = dateTimePicker1.Value;
            //descubrimiento.Arqueologo 

            // agrego descubrimiento al listado
            listBoxDescubrimientos.Items.Add(descubrimiento);
            //listBoxDescubrimientos.DisplayMember = "";
        }

        private void buttonCrearArqueologo_Click(object sender, EventArgs e)
        {
            // lo creo
            Arqueologo arqueologo = new Arqueologo();

            // le cargo los atributos
            arqueologo.varNombre = textBoxNombre.Text;
            arqueologo.varApellido = textBoxApellido.Text;
            arqueologo.varFechaNacimiento = dateTimePickerNacimiento.Value;
            arqueologo.varFechaDeceso = dateTimePickerDeceso.Value;

            // agrego lista
            listBoxArqueologo.Items.Add(arqueologo);
            listBoxArqueologo.DisplayMember = "varApellido";
            
            // limpio campos
            textBoxNombre.Text="";
            textBoxApellido.Text="";
            //dateTimePickerNacimiento.Value=DateTime();
            //dateTimePickerDeceso.Value="";


        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBoxArqueologo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Arqueologo Arqueologo = (Arqueologo)listBoxArqueologo.SelectedItem;
            labelArqueologo.Text = Arqueologo.varApellido;
        }
    }
}
