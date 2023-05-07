namespace Plantilla_examen
{
    partial class REGISTRAR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnsalirRegistrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtsalarioMinimo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbcobroResultado = new System.Windows.Forms.Label();
            this.lbcobro = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbnumeroFormulario = new System.Windows.Forms.Label();
            this.dtfechaDeclaracion = new System.Windows.Forms.DateTimePicker();
            this.txtvalorDeclarado = new System.Windows.Forms.TextBox();
            this.lbvalorDeclarado = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lbFecha = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbNit = new System.Windows.Forms.Label();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.dtviewRegistra = new System.Windows.Forms.DataGridView();
            this.rbEmplazamiento = new System.Windows.Forms.RadioButton();
            this.rbnoEmplazamiento = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtviewRegistra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsalirRegistrar
            // 
            this.btnsalirRegistrar.Location = new System.Drawing.Point(411, 398);
            this.btnsalirRegistrar.Name = "btnsalirRegistrar";
            this.btnsalirRegistrar.Size = new System.Drawing.Size(137, 54);
            this.btnsalirRegistrar.TabIndex = 0;
            this.btnsalirRegistrar.Text = "Salir";
            this.btnsalirRegistrar.UseVisualStyleBackColor = true;
            this.btnsalirRegistrar.Click += new System.EventHandler(this.btnsalirRegistrar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtsalarioMinimo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbcobroResultado);
            this.panel1.Controls.Add(this.lbcobro);
            this.panel1.Controls.Add(this.lbNumero);
            this.panel1.Controls.Add(this.lbnumeroFormulario);
            this.panel1.Controls.Add(this.dtfechaDeclaracion);
            this.panel1.Controls.Add(this.txtvalorDeclarado);
            this.panel1.Controls.Add(this.lbvalorDeclarado);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.lbFecha);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lbNombre);
            this.panel1.Controls.Add(this.lbNit);
            this.panel1.Controls.Add(this.txtNit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(573, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 503);
            this.panel1.TabIndex = 1;
            // 
            // txtsalarioMinimo
            // 
            this.txtsalarioMinimo.Location = new System.Drawing.Point(146, 198);
            this.txtsalarioMinimo.Name = "txtsalarioMinimo";
            this.txtsalarioMinimo.Size = new System.Drawing.Size(166, 22);
            this.txtsalarioMinimo.TabIndex = 14;
            this.txtsalarioMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsalarioMinimo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "SalarioMinimo";
            // 
            // lbcobroResultado
            // 
            this.lbcobroResultado.AutoSize = true;
            this.lbcobroResultado.Location = new System.Drawing.Point(143, 232);
            this.lbcobroResultado.Name = "lbcobroResultado";
            this.lbcobroResultado.Size = new System.Drawing.Size(27, 16);
            this.lbcobroResultado.TabIndex = 12;
            this.lbcobroResultado.Text = "NN";
            // 
            // lbcobro
            // 
            this.lbcobro.AutoSize = true;
            this.lbcobro.Location = new System.Drawing.Point(34, 232);
            this.lbcobro.Name = "lbcobro";
            this.lbcobro.Size = new System.Drawing.Size(44, 16);
            this.lbcobro.TabIndex = 11;
            this.lbcobro.Text = "Cobro";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(222, 25);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(27, 16);
            this.lbNumero.TabIndex = 10;
            this.lbNumero.Text = "NN";
            // 
            // lbnumeroFormulario
            // 
            this.lbnumeroFormulario.AutoSize = true;
            this.lbnumeroFormulario.Location = new System.Drawing.Point(34, 25);
            this.lbnumeroFormulario.Name = "lbnumeroFormulario";
            this.lbnumeroFormulario.Size = new System.Drawing.Size(122, 16);
            this.lbnumeroFormulario.TabIndex = 9;
            this.lbnumeroFormulario.Text = "Numero Formulario";
            // 
            // dtfechaDeclaracion
            // 
            this.dtfechaDeclaracion.Location = new System.Drawing.Point(146, 141);
            this.dtfechaDeclaracion.Name = "dtfechaDeclaracion";
            this.dtfechaDeclaracion.Size = new System.Drawing.Size(251, 22);
            this.dtfechaDeclaracion.TabIndex = 8;
            // 
            // txtvalorDeclarado
            // 
            this.txtvalorDeclarado.Location = new System.Drawing.Point(146, 171);
            this.txtvalorDeclarado.Name = "txtvalorDeclarado";
            this.txtvalorDeclarado.Size = new System.Drawing.Size(166, 22);
            this.txtvalorDeclarado.TabIndex = 7;
            this.txtvalorDeclarado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalorDeclarado_KeyPress);
            // 
            // lbvalorDeclarado
            // 
            this.lbvalorDeclarado.AutoSize = true;
            this.lbvalorDeclarado.Location = new System.Drawing.Point(34, 174);
            this.lbvalorDeclarado.Name = "lbvalorDeclarado";
            this.lbvalorDeclarado.Size = new System.Drawing.Size(106, 16);
            this.lbvalorDeclarado.TabIndex = 6;
            this.lbvalorDeclarado.Text = "Valor Declarado";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(120, 398);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(137, 54);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(34, 141);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(45, 16);
            this.lbFecha.TabIndex = 5;
            this.lbFecha.Text = "Fecha";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(146, 100);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(166, 22);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(34, 106);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(56, 16);
            this.lbNombre.TabIndex = 2;
            this.lbNombre.Text = "Nombre";
            // 
            // lbNit
            // 
            this.lbNit.AutoSize = true;
            this.lbNit.Location = new System.Drawing.Point(34, 64);
            this.lbNit.Name = "lbNit";
            this.lbNit.Size = new System.Drawing.Size(23, 16);
            this.lbNit.TabIndex = 1;
            this.lbNit.Text = "Nit";
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(146, 61);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(166, 22);
            this.txtNit.TabIndex = 0;
            this.txtNit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNit_KeyPress);
            // 
            // dtviewRegistra
            // 
            this.dtviewRegistra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtviewRegistra.Location = new System.Drawing.Point(61, 25);
            this.dtviewRegistra.Name = "dtviewRegistra";
            this.dtviewRegistra.RowHeadersWidth = 51;
            this.dtviewRegistra.RowTemplate.Height = 24;
            this.dtviewRegistra.Size = new System.Drawing.Size(487, 254);
            this.dtviewRegistra.TabIndex = 2;
            // 
            // rbEmplazamiento
            // 
            this.rbEmplazamiento.AutoSize = true;
            this.rbEmplazamiento.Location = new System.Drawing.Point(49, 21);
            this.rbEmplazamiento.Name = "rbEmplazamiento";
            this.rbEmplazamiento.Size = new System.Drawing.Size(121, 20);
            this.rbEmplazamiento.TabIndex = 15;
            this.rbEmplazamiento.TabStop = true;
            this.rbEmplazamiento.Text = "Emplezamiento";
            this.rbEmplazamiento.UseVisualStyleBackColor = true;
            this.rbEmplazamiento.Click += new System.EventHandler(this.rbEmplazamiento_Click);
            // 
            // rbnoEmplazamiento
            // 
            this.rbnoEmplazamiento.AutoSize = true;
            this.rbnoEmplazamiento.Location = new System.Drawing.Point(49, 63);
            this.rbnoEmplazamiento.Name = "rbnoEmplazamiento";
            this.rbnoEmplazamiento.Size = new System.Drawing.Size(141, 20);
            this.rbnoEmplazamiento.TabIndex = 16;
            this.rbnoEmplazamiento.TabStop = true;
            this.rbnoEmplazamiento.Text = "No emplazamiento";
            this.rbnoEmplazamiento.UseVisualStyleBackColor = true;
            this.rbnoEmplazamiento.Click += new System.EventHandler(this.rbnoEmplazamiento_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnoEmplazamiento);
            this.groupBox1.Controls.Add(this.rbEmplazamiento);
            this.groupBox1.Location = new System.Drawing.Point(91, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // REGISTRAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 503);
            this.Controls.Add(this.dtviewRegistra);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsalirRegistrar);
            this.Name = "REGISTRAR";
            this.Text = "REGISTRAR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.REGISTRAR_FormClosing);
            this.Load += new System.EventHandler(this.REGISTRAR_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtviewRegistra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsalirRegistrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtviewRegistra;
        private System.Windows.Forms.TextBox txtvalorDeclarado;
        private System.Windows.Forms.Label lbvalorDeclarado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbNit;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.DateTimePicker dtfechaDeclaracion;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbnumeroFormulario;
        private System.Windows.Forms.Label lbcobroResultado;
        private System.Windows.Forms.Label lbcobro;
        private System.Windows.Forms.TextBox txtsalarioMinimo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnoEmplazamiento;
        private System.Windows.Forms.RadioButton rbEmplazamiento;
    }
}