
namespace Simulación_Examen
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarTemperaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDesplegarTemps = new System.Windows.Forms.Button();
            this.buttonOrdenarTemps = new System.Windows.Forms.Button();
            this.buttonPromedioTemps = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarTemperaturaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(688, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarTemperaturaToolStripMenuItem
            // 
            this.registrarTemperaturaToolStripMenuItem.Name = "registrarTemperaturaToolStripMenuItem";
            this.registrarTemperaturaToolStripMenuItem.Size = new System.Drawing.Size(202, 27);
            this.registrarTemperaturaToolStripMenuItem.Text = "Registrar Temperatura";
            this.registrarTemperaturaToolStripMenuItem.Click += new System.EventHandler(this.registrarTemperaturaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "TEMPERATURAS QUETZALTENANGO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(495, 262);
            this.dataGridView1.TabIndex = 2;
            // 
            // buttonDesplegarTemps
            // 
            this.buttonDesplegarTemps.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDesplegarTemps.Location = new System.Drawing.Point(540, 120);
            this.buttonDesplegarTemps.Name = "buttonDesplegarTemps";
            this.buttonDesplegarTemps.Size = new System.Drawing.Size(117, 55);
            this.buttonDesplegarTemps.TabIndex = 3;
            this.buttonDesplegarTemps.Text = "Desplegar temperaturas";
            this.buttonDesplegarTemps.UseVisualStyleBackColor = true;
            this.buttonDesplegarTemps.Click += new System.EventHandler(this.buttonDesplegarTemps_Click);
            // 
            // buttonOrdenarTemps
            // 
            this.buttonOrdenarTemps.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrdenarTemps.Location = new System.Drawing.Point(540, 199);
            this.buttonOrdenarTemps.Name = "buttonOrdenarTemps";
            this.buttonOrdenarTemps.Size = new System.Drawing.Size(117, 55);
            this.buttonOrdenarTemps.TabIndex = 4;
            this.buttonOrdenarTemps.Text = "Ordenar temperaturas";
            this.buttonOrdenarTemps.UseVisualStyleBackColor = true;
            this.buttonOrdenarTemps.Click += new System.EventHandler(this.buttonOrdenarTemps_Click);
            // 
            // buttonPromedioTemps
            // 
            this.buttonPromedioTemps.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPromedioTemps.Location = new System.Drawing.Point(540, 279);
            this.buttonPromedioTemps.Name = "buttonPromedioTemps";
            this.buttonPromedioTemps.Size = new System.Drawing.Size(117, 55);
            this.buttonPromedioTemps.TabIndex = 5;
            this.buttonPromedioTemps.Text = "Promedio temperaturas";
            this.buttonPromedioTemps.UseVisualStyleBackColor = true;
            this.buttonPromedioTemps.Click += new System.EventHandler(this.buttonPromedioTemps_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 383);
            this.Controls.Add(this.buttonPromedioTemps);
            this.Controls.Add(this.buttonOrdenarTemps);
            this.Controls.Add(this.buttonDesplegarTemps);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrarTemperaturaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDesplegarTemps;
        private System.Windows.Forms.Button buttonOrdenarTemps;
        private System.Windows.Forms.Button buttonPromedioTemps;
    }
}

