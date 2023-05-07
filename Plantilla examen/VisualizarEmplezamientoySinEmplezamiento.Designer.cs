namespace Plantilla_examen
{
    partial class VisualizarEmplezamientoySinEmplezamiento
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
            this.dtviewvisualizarEmplazamiento = new System.Windows.Forms.DataGridView();
            this.dtviewsinEmplazamiento = new System.Windows.Forms.DataGridView();
            this.btnsalirvisualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbcobroemplazamiento = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbcobrosinemplazamiento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtviewvisualizarEmplazamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtviewsinEmplazamiento)).BeginInit();
            this.SuspendLayout();
            // 
            // dtviewvisualizarEmplazamiento
            // 
            this.dtviewvisualizarEmplazamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtviewvisualizarEmplazamiento.Location = new System.Drawing.Point(75, 12);
            this.dtviewvisualizarEmplazamiento.Name = "dtviewvisualizarEmplazamiento";
            this.dtviewvisualizarEmplazamiento.RowHeadersWidth = 51;
            this.dtviewvisualizarEmplazamiento.RowTemplate.Height = 24;
            this.dtviewvisualizarEmplazamiento.Size = new System.Drawing.Size(550, 201);
            this.dtviewvisualizarEmplazamiento.TabIndex = 0;
            // 
            // dtviewsinEmplazamiento
            // 
            this.dtviewsinEmplazamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtviewsinEmplazamiento.Location = new System.Drawing.Point(75, 236);
            this.dtviewsinEmplazamiento.Name = "dtviewsinEmplazamiento";
            this.dtviewsinEmplazamiento.RowHeadersWidth = 51;
            this.dtviewsinEmplazamiento.RowTemplate.Height = 24;
            this.dtviewsinEmplazamiento.Size = new System.Drawing.Size(550, 201);
            this.dtviewsinEmplazamiento.TabIndex = 1;
            // 
            // btnsalirvisualizar
            // 
            this.btnsalirvisualizar.Location = new System.Drawing.Point(736, 380);
            this.btnsalirvisualizar.Name = "btnsalirvisualizar";
            this.btnsalirvisualizar.Size = new System.Drawing.Size(126, 57);
            this.btnsalirvisualizar.TabIndex = 2;
            this.btnsalirvisualizar.Text = "Salir";
            this.btnsalirvisualizar.UseVisualStyleBackColor = true;
            this.btnsalirvisualizar.Click += new System.EventHandler(this.btnsalirvisualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(722, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "CobrototalconEmplazamiento";
            // 
            // lbcobroemplazamiento
            // 
            this.lbcobroemplazamiento.AutoSize = true;
            this.lbcobroemplazamiento.Location = new System.Drawing.Point(722, 93);
            this.lbcobroemplazamiento.Name = "lbcobroemplazamiento";
            this.lbcobroemplazamiento.Size = new System.Drawing.Size(27, 16);
            this.lbcobroemplazamiento.TabIndex = 4;
            this.lbcobroemplazamiento.Text = "NN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(722, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "CobrototalsinEmplazamiento";
            // 
            // lbcobrosinemplazamiento
            // 
            this.lbcobrosinemplazamiento.AutoSize = true;
            this.lbcobrosinemplazamiento.Location = new System.Drawing.Point(722, 271);
            this.lbcobrosinemplazamiento.Name = "lbcobrosinemplazamiento";
            this.lbcobrosinemplazamiento.Size = new System.Drawing.Size(27, 16);
            this.lbcobrosinemplazamiento.TabIndex = 6;
            this.lbcobrosinemplazamiento.Text = "NN";
            // 
            // VisualizarEmplezamientoySinEmplezamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 534);
            this.Controls.Add(this.lbcobrosinemplazamiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbcobroemplazamiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsalirvisualizar);
            this.Controls.Add(this.dtviewsinEmplazamiento);
            this.Controls.Add(this.dtviewvisualizarEmplazamiento);
            this.Name = "VisualizarEmplezamientoySinEmplezamiento";
            this.Text = "VisualizarEmplezamientoySinEmplezamiento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VisualizarEmplezamientoySinEmplezamiento_FormClosing);
            this.Load += new System.EventHandler(this.VisualizarEmplezamientoySinEmplezamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtviewvisualizarEmplazamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtviewsinEmplazamiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtviewvisualizarEmplazamiento;
        private System.Windows.Forms.DataGridView dtviewsinEmplazamiento;
        private System.Windows.Forms.Button btnsalirvisualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbcobroemplazamiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbcobrosinemplazamiento;
    }
}