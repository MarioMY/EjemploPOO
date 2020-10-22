namespace WindowsFormsApp2
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
            this.btnConsola = new System.Windows.Forms.Button();
            this.btnXbox = new System.Windows.Forms.Button();
            this.btnXboxOneS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsola
            // 
            this.btnConsola.Location = new System.Drawing.Point(155, 37);
            this.btnConsola.Name = "btnConsola";
            this.btnConsola.Size = new System.Drawing.Size(75, 23);
            this.btnConsola.TabIndex = 0;
            this.btnConsola.Text = "Consola";
            this.btnConsola.UseVisualStyleBackColor = true;
            this.btnConsola.Click += new System.EventHandler(this.btnConsola_Click);
            // 
            // btnXbox
            // 
            this.btnXbox.Location = new System.Drawing.Point(155, 106);
            this.btnXbox.Name = "btnXbox";
            this.btnXbox.Size = new System.Drawing.Size(75, 23);
            this.btnXbox.TabIndex = 1;
            this.btnXbox.Text = "Xbox";
            this.btnXbox.UseVisualStyleBackColor = true;
            this.btnXbox.Click += new System.EventHandler(this.btnXbox_Click);
            // 
            // btnXboxOneS
            // 
            this.btnXboxOneS.Location = new System.Drawing.Point(155, 184);
            this.btnXboxOneS.Name = "btnXboxOneS";
            this.btnXboxOneS.Size = new System.Drawing.Size(75, 23);
            this.btnXboxOneS.TabIndex = 2;
            this.btnXboxOneS.Text = "XboxOneS";
            this.btnXboxOneS.UseVisualStyleBackColor = true;
            this.btnXboxOneS.Click += new System.EventHandler(this.btnXboxOneS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 285);
            this.Controls.Add(this.btnXboxOneS);
            this.Controls.Add(this.btnXbox);
            this.Controls.Add(this.btnConsola);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsola;
        private System.Windows.Forms.Button btnXbox;
        private System.Windows.Forms.Button btnXboxOneS;
    }
}

