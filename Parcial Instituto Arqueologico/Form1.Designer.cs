
namespace Parcial_Instituto_Arqueologico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxDescubrimientos = new System.Windows.Forms.ListBox();
            this.radioButtonCiudad = new System.Windows.Forms.RadioButton();
            this.radioButtonTumba = new System.Windows.Forms.RadioButton();
            this.radioButtonMonumento = new System.Windows.Forms.RadioButton();
            this.buttonDescubrimiento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPais = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.groupBoxDescubrimiento = new System.Windows.Forms.GroupBox();
            this.labelArqueologo = new System.Windows.Forms.Label();
            this.textBoxPresupuesto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxArqueologo = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCrearArqueologo = new System.Windows.Forms.Button();
            this.dateTimePickerDeceso = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNacimiento = new System.Windows.Forms.DateTimePicker();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.groupBoxDescubrimiento.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxDescubrimientos
            // 
            this.listBoxDescubrimientos.FormattingEnabled = true;
            this.listBoxDescubrimientos.ItemHeight = 15;
            this.listBoxDescubrimientos.Location = new System.Drawing.Point(12, 12);
            this.listBoxDescubrimientos.Name = "listBoxDescubrimientos";
            this.listBoxDescubrimientos.Size = new System.Drawing.Size(198, 304);
            this.listBoxDescubrimientos.TabIndex = 0;
            // 
            // radioButtonCiudad
            // 
            this.radioButtonCiudad.AutoSize = true;
            this.radioButtonCiudad.Checked = true;
            this.radioButtonCiudad.Location = new System.Drawing.Point(15, 173);
            this.radioButtonCiudad.Name = "radioButtonCiudad";
            this.radioButtonCiudad.Size = new System.Drawing.Size(63, 19);
            this.radioButtonCiudad.TabIndex = 1;
            this.radioButtonCiudad.TabStop = true;
            this.radioButtonCiudad.Text = "Ciudad";
            this.radioButtonCiudad.UseVisualStyleBackColor = true;
            // 
            // radioButtonTumba
            // 
            this.radioButtonTumba.AutoSize = true;
            this.radioButtonTumba.Location = new System.Drawing.Point(113, 173);
            this.radioButtonTumba.Name = "radioButtonTumba";
            this.radioButtonTumba.Size = new System.Drawing.Size(62, 19);
            this.radioButtonTumba.TabIndex = 2;
            this.radioButtonTumba.TabStop = true;
            this.radioButtonTumba.Text = "Tumba";
            this.radioButtonTumba.UseVisualStyleBackColor = true;
            // 
            // radioButtonMonumento
            // 
            this.radioButtonMonumento.AutoSize = true;
            this.radioButtonMonumento.Location = new System.Drawing.Point(211, 173);
            this.radioButtonMonumento.Name = "radioButtonMonumento";
            this.radioButtonMonumento.Size = new System.Drawing.Size(92, 19);
            this.radioButtonMonumento.TabIndex = 3;
            this.radioButtonMonumento.TabStop = true;
            this.radioButtonMonumento.Text = "Monumento";
            this.radioButtonMonumento.UseVisualStyleBackColor = true;
            // 
            // buttonDescubrimiento
            // 
            this.buttonDescubrimiento.Location = new System.Drawing.Point(208, 201);
            this.buttonDescubrimiento.Name = "buttonDescubrimiento";
            this.buttonDescubrimiento.Size = new System.Drawing.Size(118, 39);
            this.buttonDescubrimiento.TabIndex = 4;
            this.buttonDescubrimiento.Text = "Nuevo Descubrimiento";
            this.buttonDescubrimiento.UseVisualStyleBackColor = true;
            this.buttonDescubrimiento.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pais:";
            // 
            // textBoxPais
            // 
            this.textBoxPais.Location = new System.Drawing.Point(43, 16);
            this.textBoxPais.Name = "textBoxPais";
            this.textBoxPais.Size = new System.Drawing.Size(68, 23);
            this.textBoxPais.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ciudad:";
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(178, 16);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(100, 23);
            this.textBoxCiudad.TabIndex = 8;
            // 
            // groupBoxDescubrimiento
            // 
            this.groupBoxDescubrimiento.Controls.Add(this.labelArqueologo);
            this.groupBoxDescubrimiento.Controls.Add(this.textBoxPresupuesto);
            this.groupBoxDescubrimiento.Controls.Add(this.label5);
            this.groupBoxDescubrimiento.Controls.Add(this.buttonDescubrimiento);
            this.groupBoxDescubrimiento.Controls.Add(this.dateTimePicker1);
            this.groupBoxDescubrimiento.Controls.Add(this.label4);
            this.groupBoxDescubrimiento.Controls.Add(this.radioButtonMonumento);
            this.groupBoxDescubrimiento.Controls.Add(this.radioButtonTumba);
            this.groupBoxDescubrimiento.Controls.Add(this.radioButtonCiudad);
            this.groupBoxDescubrimiento.Controls.Add(this.label3);
            this.groupBoxDescubrimiento.Controls.Add(this.label1);
            this.groupBoxDescubrimiento.Controls.Add(this.textBoxCiudad);
            this.groupBoxDescubrimiento.Controls.Add(this.textBoxPais);
            this.groupBoxDescubrimiento.Controls.Add(this.label2);
            this.groupBoxDescubrimiento.Location = new System.Drawing.Point(232, 12);
            this.groupBoxDescubrimiento.Name = "groupBoxDescubrimiento";
            this.groupBoxDescubrimiento.Size = new System.Drawing.Size(332, 246);
            this.groupBoxDescubrimiento.TabIndex = 9;
            this.groupBoxDescubrimiento.TabStop = false;
            this.groupBoxDescubrimiento.Text = "Exploración:";
            // 
            // labelArqueologo
            // 
            this.labelArqueologo.AutoSize = true;
            this.labelArqueologo.Location = new System.Drawing.Point(91, 99);
            this.labelArqueologo.Name = "labelArqueologo";
            this.labelArqueologo.Size = new System.Drawing.Size(95, 15);
            this.labelArqueologo.TabIndex = 16;
            this.labelArqueologo.Text = "labelArqueologo";
            // 
            // textBoxPresupuesto
            // 
            this.textBoxPresupuesto.Location = new System.Drawing.Point(113, 137);
            this.textBoxPresupuesto.Name = "textBoxPresupuesto";
            this.textBoxPresupuesto.Size = new System.Drawing.Size(100, 23);
            this.textBoxPresupuesto.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Presupuesto:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(55, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Arqueólogo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha:";
            // 
            // listBoxArqueologo
            // 
            this.listBoxArqueologo.FormattingEnabled = true;
            this.listBoxArqueologo.ItemHeight = 15;
            this.listBoxArqueologo.Location = new System.Drawing.Point(6, 153);
            this.listBoxArqueologo.Name = "listBoxArqueologo";
            this.listBoxArqueologo.Size = new System.Drawing.Size(314, 109);
            this.listBoxArqueologo.TabIndex = 16;
            this.listBoxArqueologo.SelectedIndexChanged += new System.EventHandler(this.listBoxArqueologo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Apellido:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Fecha Nacimiento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Fecha Deceso:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCrearArqueologo);
            this.groupBox1.Controls.Add(this.dateTimePickerDeceso);
            this.groupBox1.Controls.Add(this.listBoxArqueologo);
            this.groupBox1.Controls.Add(this.dateTimePickerNacimiento);
            this.groupBox1.Controls.Add(this.textBoxApellido);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(606, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 268);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arqueologo:";
            // 
            // buttonCrearArqueologo
            // 
            this.buttonCrearArqueologo.Location = new System.Drawing.Point(212, 19);
            this.buttonCrearArqueologo.Name = "buttonCrearArqueologo";
            this.buttonCrearArqueologo.Size = new System.Drawing.Size(89, 39);
            this.buttonCrearArqueologo.TabIndex = 25;
            this.buttonCrearArqueologo.Text = "Crear Arqueologo";
            this.buttonCrearArqueologo.UseVisualStyleBackColor = true;
            this.buttonCrearArqueologo.Click += new System.EventHandler(this.buttonCrearArqueologo_Click);
            // 
            // dateTimePickerDeceso
            // 
            this.dateTimePickerDeceso.Location = new System.Drawing.Point(118, 124);
            this.dateTimePickerDeceso.Name = "dateTimePickerDeceso";
            this.dateTimePickerDeceso.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerDeceso.TabIndex = 24;
            // 
            // dateTimePickerNacimiento
            // 
            this.dateTimePickerNacimiento.Location = new System.Drawing.Point(118, 79);
            this.dateTimePickerNacimiento.Name = "dateTimePickerNacimiento";
            this.dateTimePickerNacimiento.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerNacimiento.TabIndex = 23;
            this.dateTimePickerNacimiento.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(66, 47);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(100, 23);
            this.textBoxApellido.TabIndex = 22;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(66, 19);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 23);
            this.textBoxNombre.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 529);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxDescubrimiento);
            this.Controls.Add(this.listBoxDescubrimientos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxDescubrimiento.ResumeLayout(false);
            this.groupBoxDescubrimiento.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDescubrimientos;
        private System.Windows.Forms.RadioButton radioButtonCiudad;
        private System.Windows.Forms.RadioButton radioButtonTumba;
        private System.Windows.Forms.RadioButton radioButtonMonumento;
        private System.Windows.Forms.Button buttonDescubrimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.GroupBox groupBoxDescubrimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxPresupuesto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxArqueologo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeceso;
        private System.Windows.Forms.DateTimePicker dateTimePickerNacimiento;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelArqueologo;
        private System.Windows.Forms.Button buttonCrearArqueologo;
    }
}

