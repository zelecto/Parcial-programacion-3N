namespace Plantilla_examen
{
    partial class visualizartotaldeclarado
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
            this.dtviewtodo = new System.Windows.Forms.DataGridView();
            this.btnsalirIvisualizarTotal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbcobroconemplazamiento = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbcobrosinemplazamiento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtviewtodo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtviewtodo
            // 
            this.dtviewtodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtviewtodo.Location = new System.Drawing.Point(142, 47);
            this.dtviewtodo.Name = "dtviewtodo";
            this.dtviewtodo.RowHeadersWidth = 51;
            this.dtviewtodo.RowTemplate.Height = 24;
            this.dtviewtodo.Size = new System.Drawing.Size(642, 202);
            this.dtviewtodo.TabIndex = 0;
            // 
            // btnsalirIvisualizarTotal
            // 
            this.btnsalirIvisualizarTotal.Location = new System.Drawing.Point(808, 427);
            this.btnsalirIvisualizarTotal.Name = "btnsalirIvisualizarTotal";
            this.btnsalirIvisualizarTotal.Size = new System.Drawing.Size(118, 56);
            this.btnsalirIvisualizarTotal.TabIndex = 2;
            this.btnsalirIvisualizarTotal.Text = "Salir";
            this.btnsalirIvisualizarTotal.UseVisualStyleBackColor = true;
            this.btnsalirIvisualizarTotal.Click += new System.EventHandler(this.btnsalirIvisualizarTotal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "CobrototalConEmplazamiento";
            // 
            // lbcobroconemplazamiento
            // 
            this.lbcobroconemplazamiento.AutoSize = true;
            this.lbcobroconemplazamiento.Location = new System.Drawing.Point(205, 321);
            this.lbcobroconemplazamiento.Name = "lbcobroconemplazamiento";
            this.lbcobroconemplazamiento.Size = new System.Drawing.Size(27, 16);
            this.lbcobroconemplazamiento.TabIndex = 4;
            this.lbcobroconemplazamiento.Text = "NN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "CobrototalsinEmplazamiento";
            // 
            // lbcobrosinemplazamiento
            // 
            this.lbcobrosinemplazamiento.AutoSize = true;
            this.lbcobrosinemplazamiento.Location = new System.Drawing.Point(607, 321);
            this.lbcobrosinemplazamiento.Name = "lbcobrosinemplazamiento";
            this.lbcobrosinemplazamiento.Size = new System.Drawing.Size(27, 16);
            this.lbcobrosinemplazamiento.TabIndex = 6;
            this.lbcobrosinemplazamiento.Text = "NN";
            // 
            // visualizartotaldeclarado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 541);
            this.Controls.Add(this.lbcobrosinemplazamiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbcobroconemplazamiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsalirIvisualizarTotal);
            this.Controls.Add(this.dtviewtodo);
            this.Name = "visualizartotaldeclarado";
            this.Text = "visualizartotaldeclarado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.visualizartotaldeclarado_FormClosing);
            this.Load += new System.EventHandler(this.visualizartotaldeclarado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtviewtodo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtviewtodo;
        private System.Windows.Forms.Button btnsalirIvisualizarTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbcobroconemplazamiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbcobrosinemplazamiento;
    }
}