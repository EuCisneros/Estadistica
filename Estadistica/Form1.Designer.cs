namespace Estadistica
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
            this.btnmedia = new System.Windows.Forms.Button();
            this.lblserie = new System.Windows.Forms.Label();
            this.lblrespuestaserie = new System.Windows.Forms.Label();
            this.txtserie = new System.Windows.Forms.TextBox();
            this.btnestandar = new System.Windows.Forms.Button();
            this.btntipica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnmedia
            // 
            this.btnmedia.Location = new System.Drawing.Point(50, 136);
            this.btnmedia.Name = "btnmedia";
            this.btnmedia.Size = new System.Drawing.Size(75, 23);
            this.btnmedia.TabIndex = 0;
            this.btnmedia.Text = "Calcular X";
            this.btnmedia.UseVisualStyleBackColor = true;
            this.btnmedia.Click += new System.EventHandler(this.btnmedia_Click);
            // 
            // lblserie
            // 
            this.lblserie.AutoSize = true;
            this.lblserie.Location = new System.Drawing.Point(47, 53);
            this.lblserie.Name = "lblserie";
            this.lblserie.Size = new System.Drawing.Size(42, 13);
            this.lblserie.TabIndex = 1;
            this.lblserie.Text = "SERIE:";
            // 
            // lblrespuestaserie
            // 
            this.lblrespuestaserie.AutoSize = true;
            this.lblrespuestaserie.Location = new System.Drawing.Point(47, 89);
            this.lblrespuestaserie.Name = "lblrespuestaserie";
            this.lblrespuestaserie.Size = new System.Drawing.Size(14, 13);
            this.lblrespuestaserie.TabIndex = 2;
            this.lblrespuestaserie.Text = "X";
            // 
            // txtserie
            // 
            this.txtserie.Location = new System.Drawing.Point(95, 46);
            this.txtserie.Name = "txtserie";
            this.txtserie.Size = new System.Drawing.Size(197, 20);
            this.txtserie.TabIndex = 3;
            // 
            // btnestandar
            // 
            this.btnestandar.Location = new System.Drawing.Point(143, 136);
            this.btnestandar.Name = "btnestandar";
            this.btnestandar.Size = new System.Drawing.Size(75, 23);
            this.btnestandar.TabIndex = 4;
            this.btnestandar.Text = "D_Estandar";
            this.btnestandar.UseVisualStyleBackColor = true;
            // 
            // btntipica
            // 
            this.btntipica.Location = new System.Drawing.Point(240, 136);
            this.btntipica.Name = "btntipica";
            this.btntipica.Size = new System.Drawing.Size(75, 23);
            this.btntipica.TabIndex = 5;
            this.btntipica.Text = "D_Tipica";
            this.btntipica.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 206);
            this.Controls.Add(this.btntipica);
            this.Controls.Add(this.btnestandar);
            this.Controls.Add(this.txtserie);
            this.Controls.Add(this.lblrespuestaserie);
            this.Controls.Add(this.lblserie);
            this.Controls.Add(this.btnmedia);
            this.Name = "Form1";
            this.Text = "Calculos basicos de estadistica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmedia;
        private System.Windows.Forms.Label lblserie;
        private System.Windows.Forms.Label lblrespuestaserie;
        private System.Windows.Forms.TextBox txtserie;
        private System.Windows.Forms.Button btnestandar;
        private System.Windows.Forms.Button btntipica;
    }
}

