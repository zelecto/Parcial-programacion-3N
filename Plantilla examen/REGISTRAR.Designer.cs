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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnoEmplazamiento = new System.Windows.Forms.RadioButton();
            this.rbEmplazamiento = new System.Windows.Forms.RadioButton();
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
            this.lbSalarioMinimo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtviewRegistra)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsalirRegistrar
            // 
            this.btnsalirRegistrar.Location = new System.Drawing.Point(308, 323);
            this.btnsalirRegistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsalirRegistrar.Name = "btnsalirRegistrar";
            this.btnsalirRegistrar.Size = new System.Drawing.Size(103, 44);
            this.btnsalirRegistrar.TabIndex = 0;
            this.btnsalirRegistrar.Text = "Salir";
            this.btnsalirRegistrar.UseVisualStyleBackColor = true;
            this.btnsalirRegistrar.Click += new System.EventHandler(this.btnsalirRegistrar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbSalarioMinimo);
            this.panel1.Controls.Add(this.groupBox1);
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
            this.panel1.Location = new System.Drawing.Point(429, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 409);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnoEmplazamiento);
            this.groupBox1.Controls.Add(this.rbEmplazamiento);
            this.groupBox1.Location = new System.Drawing.Point(68, 237);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(150, 81);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rbnoEmplazamiento
            // 
            this.rbnoEmplazamiento.AutoSize = true;
            this.rbnoEmplazamiento.Location = new System.Drawing.Point(37, 51);
            this.rbnoEmplazamiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbnoEmplazamiento.Name = "rbnoEmplazamiento";
            this.rbnoEmplazamiento.Size = new System.Drawing.Size(112, 17);
            this.rbnoEmplazamiento.TabIndex = 16;
            this.rbnoEmplazamiento.TabStop = true;
            this.rbnoEmplazamiento.Text = "No emplazamiento";
            this.rbnoEmplazamiento.UseVisualStyleBackColor = true;
            
            // 
            // rbEmplazamiento
            // 
            this.rbEmplazamiento.AutoSize = true;
            this.rbEmplazamiento.Location = new System.Drawing.Point(37, 17);
            this.rbEmplazamiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbEmplazamiento.Name = "rbEmplazamiento";
            this.rbEmplazamiento.Size = new System.Drawing.Size(96, 17);
            this.rbEmplazamiento.TabIndex = 15;
            this.rbEmplazamiento.TabStop = true;
            this.rbEmplazamiento.Text = "Emplezamiento";
            this.rbEmplazamiento.UseVisualStyleBackColor = true;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "SalarioMinimo";
            // 
            // lbcobroResultado
            // 
            this.lbcobroResultado.AutoSize = true;
            this.lbcobroResultado.Location = new System.Drawing.Point(107, 188);
            this.lbcobroResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbcobroResultado.Name = "lbcobroResultado";
            this.lbcobroResultado.Size = new System.Drawing.Size(23, 13);
            this.lbcobroResultado.TabIndex = 12;
            this.lbcobroResultado.Text = "NN";
            // 
            // lbcobro
            // 
            this.lbcobro.AutoSize = true;
            this.lbcobro.Location = new System.Drawing.Point(26, 188);
            this.lbcobro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbcobro.Name = "lbcobro";
            this.lbcobro.Size = new System.Drawing.Size(35, 13);
            this.lbcobro.TabIndex = 11;
            this.lbcobro.Text = "Cobro";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(166, 20);
            this.lbNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(23, 13);
            this.lbNumero.TabIndex = 10;
            this.lbNumero.Text = "NN";
            // 
            // lbnumeroFormulario
            // 
            this.lbnumeroFormulario.AutoSize = true;
            this.lbnumeroFormulario.Location = new System.Drawing.Point(26, 20);
            this.lbnumeroFormulario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbnumeroFormulario.Name = "lbnumeroFormulario";
            this.lbnumeroFormulario.Size = new System.Drawing.Size(95, 13);
            this.lbnumeroFormulario.TabIndex = 9;
            this.lbnumeroFormulario.Text = "Numero Formulario";
            // 
            // dtfechaDeclaracion
            // 
            this.dtfechaDeclaracion.Location = new System.Drawing.Point(110, 115);
            this.dtfechaDeclaracion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtfechaDeclaracion.Name = "dtfechaDeclaracion";
            this.dtfechaDeclaracion.Size = new System.Drawing.Size(189, 20);
            this.dtfechaDeclaracion.TabIndex = 8;
            // 
            // txtvalorDeclarado
            // 
            this.txtvalorDeclarado.Location = new System.Drawing.Point(110, 139);
            this.txtvalorDeclarado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtvalorDeclarado.Name = "txtvalorDeclarado";
            this.txtvalorDeclarado.Size = new System.Drawing.Size(126, 20);
            this.txtvalorDeclarado.TabIndex = 7;
            this.txtvalorDeclarado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalorDeclarado_KeyPress);
            // 
            // lbvalorDeclarado
            // 
            this.lbvalorDeclarado.AutoSize = true;
            this.lbvalorDeclarado.Location = new System.Drawing.Point(26, 141);
            this.lbvalorDeclarado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbvalorDeclarado.Name = "lbvalorDeclarado";
            this.lbvalorDeclarado.Size = new System.Drawing.Size(83, 13);
            this.lbvalorDeclarado.TabIndex = 6;
            this.lbvalorDeclarado.Text = "Valor Declarado";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(90, 323);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 44);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(26, 115);
            this.lbFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(37, 13);
            this.lbFecha.TabIndex = 5;
            this.lbFecha.Text = "Fecha";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(110, 81);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(126, 20);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(26, 86);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 2;
            this.lbNombre.Text = "Nombre";
            // 
            // lbNit
            // 
            this.lbNit.AutoSize = true;
            this.lbNit.Location = new System.Drawing.Point(26, 52);
            this.lbNit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNit.Name = "lbNit";
            this.lbNit.Size = new System.Drawing.Size(20, 13);
            this.lbNit.TabIndex = 1;
            this.lbNit.Text = "Nit";
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(110, 50);
            this.txtNit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(126, 20);
            this.txtNit.TabIndex = 0;
            this.txtNit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNit_KeyPress);
            // 
            // dtviewRegistra
            // 
            this.dtviewRegistra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtviewRegistra.Location = new System.Drawing.Point(46, 20);
            this.dtviewRegistra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtviewRegistra.Name = "dtviewRegistra";
            this.dtviewRegistra.RowHeadersWidth = 51;
            this.dtviewRegistra.RowTemplate.Height = 24;
            this.dtviewRegistra.Size = new System.Drawing.Size(365, 206);
            this.dtviewRegistra.TabIndex = 2;
            // 
            // lbSalarioMinimo
            // 
            this.lbSalarioMinimo.AutoSize = true;
            this.lbSalarioMinimo.Location = new System.Drawing.Point(107, 166);
            this.lbSalarioMinimo.Name = "lbSalarioMinimo";
            this.lbSalarioMinimo.Size = new System.Drawing.Size(23, 13);
            this.lbSalarioMinimo.TabIndex = 17;
            this.lbSalarioMinimo.Text = "NN";
            // 
            // REGISTRAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 409);
            this.Controls.Add(this.dtviewRegistra);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsalirRegistrar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "REGISTRAR";
            this.Text = "REGISTRAR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.REGISTRAR_FormClosing);
            this.Load += new System.EventHandler(this.REGISTRAR_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtviewRegistra)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnoEmplazamiento;
        private System.Windows.Forms.RadioButton rbEmplazamiento;
        private System.Windows.Forms.Label lbSalarioMinimo;
    }
}