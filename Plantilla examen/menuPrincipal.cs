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
    public partial class menuPrincipal : Form
    {
        public menuPrincipal()
        {
            InitializeComponent();
        }
        private void Cerrar()
        {
            this.Close();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Cerrar();
        }
        
        void frmRegistrar(REGISTRAR f) 
        {
            this.Hide();
            f.ShowDialog(this);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            frmRegistrar(new REGISTRAR());
        }
        void frmvisualizaremplazamientoysinemplazamiento(VisualizarEmplezamientoySinEmplezamiento f)
        {
            this.Hide();
            f.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmvisualizaremplazamientoysinemplazamiento(new VisualizarEmplezamientoySinEmplezamiento());
        }
        void frmvisualizartotal(visualizartotaldeclarado f)
        {
            this.Hide();
            f.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmvisualizartotal(new visualizartotaldeclarado());
        }
    }
}
