using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Entidades;




namespace Plantilla_examen
{
    public partial class REGISTRAR : Form
    {
        public REGISTRAR()
        {
            InitializeComponent();
            lbNumero.Text = servidiosFormulario.GenerarId().ToString();   
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
        void limpiardato() 
        {
            lbNumero.Text = "";
            txtNit.Clear();
            txtNombre.Clear();
            txtvalorDeclarado.Clear();
            txtsalarioMinimo.Clear();
            rbEmplazamiento.Checked = false;
            rbnoEmplazamiento.Checked = false;
            lbcobroResultado.Text = "";
            dtfechaDeclaracion.Value = DateTime.Now;

        }
        void GUARDAR() 
        {
            Formulario formulario = new Formulario();
            
            if (string.IsNullOrEmpty(txtNit.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtvalorDeclarado.Text))
            {
                MessageBox.Show("Faltan Datos");
            }
            else 
            {
                if (rbEmplazamiento.Checked)
                {
                    formulario.Sancion = true;
                    
                }
                else
                {
                    formulario.Sancion= false;
                    txtsalarioMinimo.Enabled = false;
                }
                formulario.Id = servidiosFormulario.GenerarId();
                lbNumero.Text = formulario.Id.ToString();
                formulario.Cedula = int.Parse(txtNit.Text);
                formulario.Nombre = txtNombre.Text;
                formulario.Fecha = dtfechaDeclaracion.Value;
                formulario.ValorDeclarado = double.Parse(txtvalorDeclarado.Text);
                formulario.SalarioMinimoActual = double.Parse(txtsalarioMinimo.Text);
                formulario.Cobro=formulario.CalcularCobro();
                lbcobroResultado.Text=formulario.Cobro.ToString();
                servidiosFormulario.Add(formulario);
                
                MessageBox.Show("Se Guardo Correctamente");
                limpiardato();

            }
            
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GUARDAR();
            ActualizarGrilla();
        }

        private void txtNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // Evita que se escriban letras
                MessageBox.Show("No debe introducir letras");
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Evita que se escriban números
                MessageBox.Show("No debe introducir numeros");
            }
        }

        private void txtvalorDeclarado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // Evita que se escriban letras
                MessageBox.Show("No debe introducir letras");
            }
        }

        private void txtsalarioMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // Evita que se escriban letras
                MessageBox.Show("No debe introducir letras");
            }
        }

        void cargarGrilla2() 
        {
            dtviewRegistra.DataSource = servidiosFormulario.GetAll();
        }

        private void REGISTRAR_Load(object sender, EventArgs e)
        {
            cargarGrilla2();
        }
        void ActualizarGrilla()
        {
            // Cargar los datos actualizados
            var formulario = servidiosFormulario.GetAll();

            // Establecer los datos de la grilla
            dtviewRegistra.DataSource = formulario;

            // Refrescar la grilla
            dtviewRegistra.Refresh();
        }

        private void rbEmplazamiento_Click(object sender, EventArgs e)
        {
            txtsalarioMinimo.Enabled = false;
        }

        private void rbnoEmplazamiento_Click(object sender, EventArgs e)
        {
            txtsalarioMinimo.Enabled = true;
        }
    }
}
