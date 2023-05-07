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
            this.dtviewvisualizarEmplazamiento.Location = new System.Drawing.Point(56, 10);
            this.dtviewvisualizarEmplazamiento.Margin = new System.Windows.Forms.Padding(2);
            this.dtviewvisualizarEmplazamiento.Name = "dtviewvisualizarEmplazamiento";
            this.dtviewvisualizarEmplazamiento.RowHeadersWidth = 51;
            this.dtviewvisualizarEmplazamiento.RowTemplate.Height = 24;
            this.dtviewvisualizarEmplazamiento.Size = new System.Drawing.Size(412, 163);
            this.dtviewvisualizarEmplazamiento.TabIndex = 0;
            // 
            // dtviewsinEmplazamiento
            // 
            this.dtviewsinEmplazamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtviewsinEmplazamiento.Location = new System.Drawing.Point(56, 192);
            this.dtviewsinEmplazamiento.Margin = new System.Windows.Forms.Padding(2);
            this.dtviewsinEmplazamiento.Name = "dtviewsinEmplazamiento";
            this.dtviewsinEmplazamiento.RowHeadersWidth = 51;
            this.dtviewsinEmplazamiento.RowTemplate.Height = 24;
            this.dtviewsinEmplazamiento.Size = new System.Drawing.Size(412, 163);
            this.dtviewsinEmplazamiento.TabIndex = 1;
            // 
            // btnsalirvisualizar
            // 
            this.btnsalirvisualizar.Location = new System.Drawing.Point(552, 309);
            this.btnsalirvisualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnsalirvisualizar.Name = "btnsalirvisualizar";
            this.btnsalirvisualizar.Size = new System.Drawing.Size(94, 46);
            this.btnsalirvisualizar.TabIndex = 2;
            this.btnsalirvisualizar.Text = "Salir";
            this.btnsalirvisualizar.UseVisualStyleBackColor = true;
            this.btnsalirvisualizar.Click += new System.EventHandler(this.btnsalirvisualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(542, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cobro total con Emplazamiento";
            // 
            // lbcobroemplazamiento
            // 
            this.lbcobroemplazamiento.AutoSize = true;
            this.lbcobroemplazamiento.Location = new System.Drawing.Point(623, 76);
            this.lbcobroemplazamiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbcobroemplazamiento.Name = "lbcobroemplazamiento";
            this.lbcobroemplazamiento.Size = new System.Drawing.Size(23, 13);
            this.lbcobroemplazamiento.TabIndex = 4;
            this.lbcobroemplazamiento.Text = "NN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(542, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cobro total sin Emplazamiento";
            // 
            // lbcobrosinemplazamiento
            // 
            this.lbcobrosinemplazamiento.AutoSize = true;
            this.lbcobrosinemplazamiento.Location = new System.Drawing.Point(623, 244);
            this.lbcobrosinemplazamiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbcobrosinemplazamiento.Name = "lbcobrosinemplazamiento";
            this.lbcobrosinemplazamiento.Size = new System.Drawing.Size(23, 13);
            this.lbcobrosinemplazamiento.TabIndex = 6;
            this.lbcobrosinemplazamiento.Text = "NN";
            // 
            // VisualizarEmplezamientoySinEmplezamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 434);
            this.Controls.Add(this.lbcobrosinemplazamiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbcobroemplazamiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsalirvisualizar);
            this.Controls.Add(this.dtviewsinEmplazamiento);
            this.Controls.Add(this.dtviewvisualizarEmplazamiento);
            this.Margin = new System.Windows.Forms.Padding(2);
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