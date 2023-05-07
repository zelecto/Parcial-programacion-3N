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
    public partial class VisualizarEmplezamientoySinEmplezamiento : Form
    {
        public VisualizarEmplezamientoySinEmplezamiento()
        {
            InitializeComponent();
        }
        ServidiosFormulario servidiosFormulario = new ServidiosFormulario();
        private void cerrar()
        {
            this.Close();
        }
        void Salir()
        {
            this.Owner.Show();
            Dispose();
        }
        private void btnsalirvisualizar_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void VisualizarEmplezamientoySinEmplezamiento_FormClosing(object sender, FormClosingEventArgs e)
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
        void cargarGrillaEmplazamiento() 
        {
            dtviewvisualizarEmplazamiento.DataSource = servidiosFormulario.GetListaEmplazamiento();
            
        }

        void cargarGrillasinEmplazamiento()
        {
            dtviewsinEmplazamiento.DataSource = servidiosFormulario.GetListaSinEmplazamiento();   
            
        }

        private void VisualizarEmplezamientoySinEmplezamiento_Load(object sender, EventArgs e)
        {
            cargarGrillaEmplazamiento();
            cargarGrillasinEmplazamiento(); 
            lbcobroemplazamiento.Text = servidiosFormulario.CobroAllEmplazamiento().ToString();
            lbcobrosinemplazamiento.Text = servidiosFormulario.CobroAllSinEmplazamiento().ToString();
        }
    }
}
