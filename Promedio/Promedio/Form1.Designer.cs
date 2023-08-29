
namespace Promedio
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
            this.textNum1Calculadora = new System.Windows.Forms.TextBox();
            this.textNum2Calculadora = new System.Windows.Forms.TextBox();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textNum1Calculadora
            // 
            this.textNum1Calculadora.Location = new System.Drawing.Point(206, 93);
            this.textNum1Calculadora.Name = "textNum1Calculadora";
            this.textNum1Calculadora.Size = new System.Drawing.Size(58, 20);
            this.textNum1Calculadora.TabIndex = 0;
            this.textNum1Calculadora.TextChanged += new System.EventHandler(this.textNum1_TextChanged);
            // 
            // textNum2Calculadora
            // 
            this.textNum2Calculadora.Location = new System.Drawing.Point(206, 134);
            this.textNum2Calculadora.Name = "textNum2Calculadora";
            this.textNum2Calculadora.Size = new System.Drawing.Size(58, 20);
            this.textNum2Calculadora.TabIndex = 1;
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculadora.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCalculadora.Location = new System.Drawing.Point(155, 169);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(109, 43);
            this.btnCalculadora.TabIndex = 2;
            this.btnCalculadora.Text = "Calcular";
            this.btnCalculadora.UseVisualStyleBackColor = true;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sumar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(155, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Num1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Num2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculadora);
            this.Controls.Add(this.textNum2Calculadora);
            this.Controls.Add(this.textNum1Calculadora);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNum1Calculadora;
        private System.Windows.Forms.TextBox textNum2Calculadora;
        private System.Windows.Forms.Button btnCalculadora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

