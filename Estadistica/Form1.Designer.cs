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
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.txtserie = new System.Windows.Forms.TextBox();
            this.btnestandar = new System.Windows.Forms.Button();
            this.btntipica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnmedia
            // 
            this.btnmedia.Location = new System.Drawing.Point(21, 136);
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
            this.lblserie.Location = new System.Drawing.Point(18, 53);
            this.lblserie.Name = "lblserie";
            this.lblserie.Size = new System.Drawing.Size(42, 13);
            this.lblserie.TabIndex = 1;
            this.lblserie.Text = "SERIE:";
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Location = new System.Drawing.Point(23, 89);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(14, 13);
            this.lblrespuesta.TabIndex = 2;
            this.lblrespuesta.Text = "X";
            // 
            // txtserie
            // 
            this.txtserie.Location = new System.Drawing.Point(66, 47);
            this.txtserie.Name = "txtserie";
            this.txtserie.Size = new System.Drawing.Size(197, 20);
            this.txtserie.TabIndex = 3;
            // 
            // btnestandar
            // 
            this.btnestandar.Location = new System.Drawing.Point(117, 136);
            this.btnestandar.Name = "btnestandar";
            this.btnestandar.Size = new System.Drawing.Size(75, 23);
            this.btnestandar.TabIndex = 4;
            this.btnestandar.Text = "D_Estandar";
            this.btnestandar.UseVisualStyleBackColor = true;
            this.btnestandar.Click += new System.EventHandler(this.btnestandar_Click);
            // 
            // btntipica
            // 
            this.btntipica.Location = new System.Drawing.Point(212, 136);
            this.btntipica.Name = "btntipica";
            this.btntipica.Size = new System.Drawing.Size(75, 23);
            this.btntipica.TabIndex = 5;
            this.btntipica.Text = "D_Tipica";
            this.btntipica.UseVisualStyleBackColor = true;
            this.btntipica.Click += new System.EventHandler(this.btntipica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 211);
            this.Controls.Add(this.btntipica);
            this.Controls.Add(this.btnestandar);
            this.Controls.Add(this.txtserie);
            this.Controls.Add(this.lblrespuesta);
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
        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.TextBox txtserie;
        private System.Windows.Forms.Button btnestandar;
        private System.Windows.Forms.Button btntipica;
    }
}

