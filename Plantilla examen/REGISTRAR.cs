﻿using System;
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

        void GUARDAR() 
        {
            Formulario formulario = new Formulario();
            if (string.IsNullOrEmpty(txtNit.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtvalorDeclarado.Text))
            {
                MessageBox.Show("Faltan Datos");
            }
            else 
            {

                formulario.Id = servidiosFormulario.GenerarId();
                lbNumero.Text = formulario.Id.ToString();
                formulario.Cedula = int.Parse(txtNit.Text);
                formulario.Nombre = txtNombre.Text;
                formulario.Fecha = dtfechaDeclaracion.Value;
                formulario.ValorDeclarado = double.Parse(txtvalorDeclarado.Text);
                formulario.Cobro=formulario.CalcularCobro();
                lbcobroResultado.Text=formulario.Cobro.ToString();
                servidiosFormulario.Add(formulario);
                MessageBox.Show("Se Guardo Correctamente");
                MessageBox.Show("Se Guardo Correctamente");

            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GUARDAR();
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
            
        }
    }
}
