
namespace Promedios
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
            this.textlab1 = new System.Windows.Forms.TextBox();
            this.textlab2 = new System.Windows.Forms.TextBox();
            this.texttareas = new System.Windows.Forms.TextBox();
            this.textparcial = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblnotafinal = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textlab1
            // 
            this.textlab1.Location = new System.Drawing.Point(239, 64);
            this.textlab1.Name = "textlab1";
            this.textlab1.Size = new System.Drawing.Size(100, 20);
            this.textlab1.TabIndex = 0;
            // 
            // textlab2
            // 
            this.textlab2.Location = new System.Drawing.Point(239, 102);
            this.textlab2.Name = "textlab2";
            this.textlab2.Size = new System.Drawing.Size(100, 20);
            this.textlab2.TabIndex = 1;
            // 
            // texttareas
            // 
            this.texttareas.Location = new System.Drawing.Point(239, 155);
            this.texttareas.Name = "texttareas";
            this.texttareas.Size = new System.Drawing.Size(100, 20);
            this.texttareas.TabIndex = 2;
            // 
            // textparcial
            // 
            this.textparcial.Location = new System.Drawing.Point(239, 201);
            this.textparcial.Name = "textparcial";
            this.textparcial.Size = new System.Drawing.Size(100, 20);
            this.textparcial.TabIndex = 3;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(239, 255);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(100, 32);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lblnotafinal
            // 
            this.lblnotafinal.AutoSize = true;
            this.lblnotafinal.Location = new System.Drawing.Point(521, 67);
            this.lblnotafinal.Name = "lblnotafinal";
            this.lblnotafinal.Size = new System.Drawing.Size(13, 13);
            this.lblnotafinal.TabIndex = 5;
            this.lblnotafinal.Text = "?";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(505, 109);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(10, 13);
            this.lblresultado.TabIndex = 6;
            this.lblresultado.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nota Final:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "1° Laboratorio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "2° Laboratorio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tarea:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Parcial:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblnotafinal);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.textparcial);
            this.Controls.Add(this.texttareas);
            this.Controls.Add(this.textlab2);
            this.Controls.Add(this.textlab1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textlab1;
        private System.Windows.Forms.TextBox textlab2;
        private System.Windows.Forms.TextBox texttareas;
        private System.Windows.Forms.TextBox textparcial;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblnotafinal;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

