
namespace Parcial1
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
            this.cboDeConversor = new System.Windows.Forms.ComboBox();
            this.cboAConversor = new System.Windows.Forms.ComboBox();
            this.textCantidadConversor = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboDeConversor
            // 
            this.cboDeConversor.FormattingEnabled = true;
            this.cboDeConversor.Items.AddRange(new object[] {
            "Pie Cuadrado ",
            "Vara Cuadrada ",
            "Yarda Cuadrada ",
            "Metro Cuadrado ",
            "Tareas ",
            "Manzana ",
            "Hectarea "});
            this.cboDeConversor.Location = new System.Drawing.Point(411, 117);
            this.cboDeConversor.Name = "cboDeConversor";
            this.cboDeConversor.Size = new System.Drawing.Size(121, 21);
            this.cboDeConversor.TabIndex = 1;
            // 
            // cboAConversor
            // 
            this.cboAConversor.FormattingEnabled = true;
            this.cboAConversor.Items.AddRange(new object[] {
            "Pie Cuadrado ",
            "Vara Cuadrada ",
            "Yarda Cuadrada ",
            "Metro Cuadrado ",
            "Tareas ",
            "Manzana ",
            "Hectarea "});
            this.cboAConversor.Location = new System.Drawing.Point(411, 157);
            this.cboAConversor.Name = "cboAConversor";
            this.cboAConversor.Size = new System.Drawing.Size(121, 21);
            this.cboAConversor.TabIndex = 2;
            // 
            // textCantidadConversor
            // 
            this.textCantidadConversor.Location = new System.Drawing.Point(411, 215);
            this.textCantidadConversor.Name = "textCantidadConversor";
            this.textCantidadConversor.Size = new System.Drawing.Size(121, 20);
            this.textCantidadConversor.TabIndex = 3;
            this.textCantidadConversor.TextChanged += new System.EventHandler(this.textCantidadConversor_TextChanged);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(411, 266);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(121, 23);
            this.btnConvertir.TabIndex = 4;
            this.btnConvertir.Text = "button1";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // textResultado
            // 
            this.textResultado.Location = new System.Drawing.Point(411, 310);
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(121, 20);
            this.textResultado.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.textCantidadConversor);
            this.Controls.Add(this.cboAConversor);
            this.Controls.Add(this.cboDeConversor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboDeConversor;
        private System.Windows.Forms.ComboBox cboAConversor;
        private System.Windows.Forms.TextBox textCantidadConversor;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.TextBox textResultado;
    }
}

