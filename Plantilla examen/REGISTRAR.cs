using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plantilla_examen
{
    public partial class REGISTRAR : Form
    {
        public REGISTRAR()
        {
            InitializeComponent();
        }
        private void cerrar()
        {
            this.Close();
        }
       
        private void btnsalirRegistrar_Click(object sender, EventArgs e)
        {
            cerrar();
        }
        void Salir()
        {
            this.Owner.Show();
            Dispose();
        }

        private void REGISTRAR_FormClosing(object sender, FormClosingEventArgs e)
        {
            var respuesta = MessageBox.Show("Desea Salir",
              "REGISTRAR", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                Salir();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
