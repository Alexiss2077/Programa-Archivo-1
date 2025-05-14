namespace programaArchivo1
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
            this.txtWrite1 = new System.Windows.Forms.TextBox();
            this.txtWrite3 = new System.Windows.Forms.TextBox();
            this.txtWrite2 = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWrite1
            // 
            this.txtWrite1.Location = new System.Drawing.Point(108, 69);
            this.txtWrite1.Multiline = true;
            this.txtWrite1.Name = "txtWrite1";
            this.txtWrite1.Size = new System.Drawing.Size(365, 73);
            this.txtWrite1.TabIndex = 0;
            // 
            // txtWrite3
            // 
            this.txtWrite3.Location = new System.Drawing.Point(108, 306);
            this.txtWrite3.Multiline = true;
            this.txtWrite3.Name = "txtWrite3";
            this.txtWrite3.Size = new System.Drawing.Size(365, 73);
            this.txtWrite3.TabIndex = 1;
            // 
            // txtWrite2
            // 
            this.txtWrite2.Location = new System.Drawing.Point(108, 178);
            this.txtWrite2.Multiline = true;
            this.txtWrite2.Name = "txtWrite2";
            this.txtWrite2.Size = new System.Drawing.Size(365, 73);
            this.txtWrite2.TabIndex = 2;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Myanmar Text", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGenerar.Location = new System.Drawing.Point(607, 119);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(249, 161);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar documento";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(929, 508);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtWrite2);
            this.Controls.Add(this.txtWrite3);
            this.Controls.Add(this.txtWrite1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWrite1;
        private System.Windows.Forms.TextBox txtWrite3;
        private System.Windows.Forms.TextBox txtWrite2;
        private System.Windows.Forms.Button btnGenerar;
    }
}

