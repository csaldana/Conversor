namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblpeso = new System.Windows.Forms.Label();
            this.lblcambio = new System.Windows.Forms.Label();
            this.Dolares = new System.Windows.Forms.Label();
            this.textpeso = new System.Windows.Forms.TextBox();
            this.textcambio = new System.Windows.Forms.TextBox();
            this.textdolares = new System.Windows.Forms.TextBox();
            this.convertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.Location = new System.Drawing.Point(23, 13);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(36, 13);
            this.lblpeso.TabIndex = 0;
            this.lblpeso.Text = "Pesos";
            // 
            // lblcambio
            // 
            this.lblcambio.AutoSize = true;
            this.lblcambio.Location = new System.Drawing.Point(190, 13);
            this.lblcambio.Name = "lblcambio";
            this.lblcambio.Size = new System.Drawing.Size(74, 13);
            this.lblcambio.TabIndex = 1;
            this.lblcambio.Text = "Tipo de camio";
            // 
            // Dolares
            // 
            this.Dolares.AutoSize = true;
            this.Dolares.Location = new System.Drawing.Point(26, 165);
            this.Dolares.Name = "Dolares";
            this.Dolares.Size = new System.Drawing.Size(43, 13);
            this.Dolares.TabIndex = 2;
            this.Dolares.Text = "Dolares";
            // 
            // textpeso
            // 
            this.textpeso.Location = new System.Drawing.Point(26, 30);
            this.textpeso.Name = "textpeso";
            this.textpeso.Size = new System.Drawing.Size(100, 20);
            this.textpeso.TabIndex = 3;
            // 
            // textcambio
            // 
            this.textcambio.Location = new System.Drawing.Point(193, 29);
            this.textcambio.Name = "textcambio";
            this.textcambio.Size = new System.Drawing.Size(100, 20);
            this.textcambio.TabIndex = 4;
            // 
            // textdolares
            // 
            this.textdolares.Location = new System.Drawing.Point(29, 198);
            this.textdolares.Name = "textdolares";
            this.textdolares.Size = new System.Drawing.Size(100, 20);
            this.textdolares.TabIndex = 5;
            // 
            // convertir
            // 
            this.convertir.Location = new System.Drawing.Point(193, 226);
            this.convertir.Name = "convertir";
            this.convertir.Size = new System.Drawing.Size(75, 23);
            this.convertir.TabIndex = 6;
            this.convertir.Text = "convetir";
            this.convertir.UseVisualStyleBackColor = true;
            this.convertir.Click += new System.EventHandler(this.convertir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.convertir);
            this.Controls.Add(this.textdolares);
            this.Controls.Add(this.textcambio);
            this.Controls.Add(this.textpeso);
            this.Controls.Add(this.Dolares);
            this.Controls.Add(this.lblcambio);
            this.Controls.Add(this.lblpeso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpeso;
        private System.Windows.Forms.Label lblcambio;
        private System.Windows.Forms.Label Dolares;
        private System.Windows.Forms.TextBox textpeso;
        private System.Windows.Forms.TextBox textcambio;
        private System.Windows.Forms.TextBox textdolares;
        private System.Windows.Forms.Button convertir;
    }
}

