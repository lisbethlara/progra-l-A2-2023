
namespace Suma_y_multiplicacion
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
            this.btncalculadora = new System.Windows.Forms.Button();
            this.textnum1 = new System.Windows.Forms.TextBox();
            this.textnum2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncalculadora
            // 
            this.btncalculadora.Location = new System.Drawing.Point(247, 228);
            this.btncalculadora.Name = "btncalculadora";
            this.btncalculadora.Size = new System.Drawing.Size(100, 23);
            this.btncalculadora.TabIndex = 0;
            this.btncalculadora.Text = "button1";
            this.btncalculadora.UseVisualStyleBackColor = true;
            this.btncalculadora.Click += new System.EventHandler(this.btncalculadora_Click);
            // 
            // textnum1
            // 
            this.textnum1.Location = new System.Drawing.Point(247, 105);
            this.textnum1.Name = "textnum1";
            this.textnum1.Size = new System.Drawing.Size(100, 20);
            this.textnum1.TabIndex = 1;
            // 
            // textnum2
            // 
            this.textnum2.Location = new System.Drawing.Point(247, 164);
            this.textnum2.Name = "textnum2";
            this.textnum2.Size = new System.Drawing.Size(100, 20);
            this.textnum2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textnum2);
            this.Controls.Add(this.textnum1);
            this.Controls.Add(this.btncalculadora);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalculadora;
        private System.Windows.Forms.TextBox textnum1;
        private System.Windows.Forms.TextBox textnum2;
    }
}

