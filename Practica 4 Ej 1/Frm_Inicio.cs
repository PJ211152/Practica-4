using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Practica_4_Ej_1
{
    public partial class Frm_Inicio : Practica_4_Ej_1.Form1
    {
        public Frm_Inicio()
        {
            InitializeComponent();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            Form2 personas = new Form2();

            this.Hide();
            personas.Show();
        }
    }
}
