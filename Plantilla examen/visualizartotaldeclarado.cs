using Logica;
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
    public partial class visualizartotaldeclarado : Form
    {
        public visualizartotaldeclarado()
        {
            InitializeComponent();
        }
        ServidiosFormulario servidiosFormulario = new ServidiosFormulario();
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
        private void btnsalirIvisualizarTotal_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void visualizartotaldeclarado_FormClosing(object sender, FormClosingEventArgs e)
        {
            var respuesta = MessageBox.Show("Desea Salir",
              "VISUALIZARTOTAL", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                Salir();
            }
            else
            {
                e.Cancel = true;
            }
        }

        void cargartotaltodo()
        {
            dtviewtodo.DataSource = servidiosFormulario.GetAll();
        }

        private void visualizartotaldeclarado_Load(object sender, EventArgs e)
        {
            cargartotaltodo();
            lbcobroconemplazamiento.Text = servidiosFormulario.CobroAllEmplazamiento().ToString();
            lbcobrosinemplazamiento.Text = servidiosFormulario.CobroAllSinEmplazamiento().ToString();

        }
    }
}
