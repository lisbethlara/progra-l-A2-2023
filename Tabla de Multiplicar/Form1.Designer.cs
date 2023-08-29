
namespace Tabla_de_Multiplicar
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
            this.btnProcesador = new System.Windows.Forms.Button();
            this.textNtabla = new System.Windows.Forms.TextBox();
            this.lblcalcular = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProcesador
            // 
            this.btnProcesador.Location = new System.Drawing.Point(199, 92);
            this.btnProcesador.Name = "btnProcesador";
            this.btnProcesador.Size = new System.Drawing.Size(103, 23);
            this.btnProcesador.TabIndex = 0;
            this.btnProcesador.Text = "Calcular";
            this.btnProcesador.UseVisualStyleBackColor = true;
            this.btnProcesador.Click += new System.EventHandler(this.btnProcesador_Click);
            // 
            // textNtabla
            // 
            this.textNtabla.Location = new System.Drawing.Point(249, 53);
            this.textNtabla.Name = "textNtabla";
            this.textNtabla.Size = new System.Drawing.Size(53, 20);
            this.textNtabla.TabIndex = 1;
            // 
            // lblcalcular
            // 
            this.lblcalcular.AutoSize = true;
            this.lblcalcular.Location = new System.Drawing.Point(372, 56);
            this.lblcalcular.Name = "lblcalcular";
            this.lblcalcular.Size = new System.Drawing.Size(13, 13);
            this.lblcalcular.TabIndex = 2;
            this.lblcalcular.Text = "?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcalcular);
            this.Controls.Add(this.textNtabla);
            this.Controls.Add(this.btnProcesador);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcesador;
        private System.Windows.Forms.TextBox textNtabla;
        private System.Windows.Forms.Label lblcalcular;
        private System.Windows.Forms.Label label1;
    }
}

