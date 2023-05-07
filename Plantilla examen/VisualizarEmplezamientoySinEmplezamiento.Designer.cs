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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsalirvisualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtviewvisualizarEmplazamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(75, 290);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(550, 201);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnsalirvisualizar
            // 
            this.btnsalirvisualizar.Location = new System.Drawing.Point(662, 359);
            this.btnsalirvisualizar.Name = "btnsalirvisualizar";
            this.btnsalirvisualizar.Size = new System.Drawing.Size(126, 57);
            this.btnsalirvisualizar.TabIndex = 2;
            this.btnsalirvisualizar.Text = "Salir";
            this.btnsalirvisualizar.UseVisualStyleBackColor = true;
            this.btnsalirvisualizar.Click += new System.EventHandler(this.btnsalirvisualizar_Click);
            // 
            // VisualizarEmplezamientoySinEmplezamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.btnsalirvisualizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtviewvisualizarEmplazamiento);
            this.Name = "VisualizarEmplezamientoySinEmplezamiento";
            this.Text = "VisualizarEmplezamientoySinEmplezamiento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VisualizarEmplezamientoySinEmplezamiento_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dtviewvisualizarEmplazamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtviewvisualizarEmplazamiento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsalirvisualizar;
    }
}