
namespace Calcular_Etapa_de_Vida
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
            this.label1 = new System.Windows.Forms.Label();
            this.textedad = new System.Windows.Forms.TextBox();
            this.btnprocesar = new System.Windows.Forms.Button();
            this.lblquesoy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(222, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edad:";
            // 
            // textedad
            // 
            this.textedad.Location = new System.Drawing.Point(263, 77);
            this.textedad.Name = "textedad";
            this.textedad.Size = new System.Drawing.Size(100, 20);
            this.textedad.TabIndex = 2;
            // 
            // btnprocesar
            // 
            this.btnprocesar.Location = new System.Drawing.Point(263, 103);
            this.btnprocesar.Name = "btnprocesar";
            this.btnprocesar.Size = new System.Drawing.Size(100, 23);
            this.btnprocesar.TabIndex = 0;
            this.btnprocesar.Text = "Procesar";
            this.btnprocesar.UseVisualStyleBackColor = true;
            this.btnprocesar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblquesoy
            // 
            this.lblquesoy.AutoSize = true;
            this.lblquesoy.Location = new System.Drawing.Point(263, 152);
            this.lblquesoy.Name = "lblquesoy";
            this.lblquesoy.Size = new System.Drawing.Size(13, 13);
            this.lblquesoy.TabIndex = 3;
            this.lblquesoy.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Que soy:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblquesoy);
            this.Controls.Add(this.textedad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnprocesar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textedad;
        private System.Windows.Forms.Button btnprocesar;
        private System.Windows.Forms.Label lblquesoy;
        private System.Windows.Forms.Label label2;
    }
}

