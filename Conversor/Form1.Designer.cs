
namespace Conversor
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
            this.textCantidadConversor = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cboTipoConversor = new System.Windows.Forms.ComboBox();
            this.cboDeConversor = new System.Windows.Forms.ComboBox();
            this.cboAconversar = new System.Windows.Forms.ComboBox();
            this.lblTipoConversor = new System.Windows.Forms.Label();
            this.lblDeConversor = new System.Windows.Forms.Label();
            this.lblAConversor = new System.Windows.Forms.Label();
            this.lblCantidadConversor = new System.Windows.Forms.Label();
            this.lblRespuestaConversor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textCantidadConversor
            // 
            this.textCantidadConversor.Location = new System.Drawing.Point(367, 171);
            this.textCantidadConversor.Name = "textCantidadConversor";
            this.textCantidadConversor.Size = new System.Drawing.Size(154, 20);
            this.textCantidadConversor.TabIndex = 3;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(367, 213);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(154, 51);
            this.btnConvertir.TabIndex = 4;
            this.btnConvertir.Text = "button1";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(367, 328);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(154, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "button2";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cboTipoConversor
            // 
            this.cboTipoConversor.FormattingEnabled = true;
            this.cboTipoConversor.Items.AddRange(new object[] {
            "Moneda",
            "Masa",
            "Volumen",
            "Longitud",
            "Almacenamiento",
            "Tiempo"});
            this.cboTipoConversor.Location = new System.Drawing.Point(367, 34);
            this.cboTipoConversor.Name = "cboTipoConversor";
            this.cboTipoConversor.Size = new System.Drawing.Size(154, 21);
            this.cboTipoConversor.TabIndex = 6;
            this.cboTipoConversor.SelectedIndexChanged += new System.EventHandler(this.cboTipoConversor_SelectedIndexChanged);
            // 
            // cboDeConversor
            // 
            this.cboDeConversor.FormattingEnabled = true;
            this.cboDeConversor.Location = new System.Drawing.Point(367, 84);
            this.cboDeConversor.Name = "cboDeConversor";
            this.cboDeConversor.Size = new System.Drawing.Size(154, 21);
            this.cboDeConversor.TabIndex = 7;
            this.cboDeConversor.SelectedIndexChanged += new System.EventHandler(this.cboDeConversor_SelectedIndexChanged);
            // 
            // cboAconversar
            // 
            this.cboAconversar.FormattingEnabled = true;
            this.cboAconversar.Location = new System.Drawing.Point(367, 130);
            this.cboAconversar.Name = "cboAconversar";
            this.cboAconversar.Size = new System.Drawing.Size(154, 21);
            this.cboAconversar.TabIndex = 8;
            // 
            // lblTipoConversor
            // 
            this.lblTipoConversor.AutoSize = true;
            this.lblTipoConversor.Location = new System.Drawing.Point(303, 42);
            this.lblTipoConversor.Name = "lblTipoConversor";
            this.lblTipoConversor.Size = new System.Drawing.Size(31, 13);
            this.lblTipoConversor.TabIndex = 9;
            this.lblTipoConversor.Text = "Tipo:";
            // 
            // lblDeConversor
            // 
            this.lblDeConversor.AutoSize = true;
            this.lblDeConversor.Location = new System.Drawing.Point(303, 92);
            this.lblDeConversor.Name = "lblDeConversor";
            this.lblDeConversor.Size = new System.Drawing.Size(24, 13);
            this.lblDeConversor.TabIndex = 10;
            this.lblDeConversor.Text = "De:";
            // 
            // lblAConversor
            // 
            this.lblAConversor.AutoSize = true;
            this.lblAConversor.Location = new System.Drawing.Point(303, 138);
            this.lblAConversor.Name = "lblAConversor";
            this.lblAConversor.Size = new System.Drawing.Size(17, 13);
            this.lblAConversor.TabIndex = 11;
            this.lblAConversor.Text = "A:";
            // 
            // lblCantidadConversor
            // 
            this.lblCantidadConversor.AutoSize = true;
            this.lblCantidadConversor.Location = new System.Drawing.Point(303, 178);
            this.lblCantidadConversor.Name = "lblCantidadConversor";
            this.lblCantidadConversor.Size = new System.Drawing.Size(52, 13);
            this.lblCantidadConversor.TabIndex = 12;
            this.lblCantidadConversor.Text = "Cantidad:";
            // 
            // lblRespuestaConversor
            // 
            this.lblRespuestaConversor.AutoSize = true;
            this.lblRespuestaConversor.Location = new System.Drawing.Point(364, 293);
            this.lblRespuestaConversor.Name = "lblRespuestaConversor";
            this.lblRespuestaConversor.Size = new System.Drawing.Size(13, 13);
            this.lblRespuestaConversor.TabIndex = 13;
            this.lblRespuestaConversor.Text = "?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Respuesta:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRespuestaConversor);
            this.Controls.Add(this.lblCantidadConversor);
            this.Controls.Add(this.lblAConversor);
            this.Controls.Add(this.lblDeConversor);
            this.Controls.Add(this.lblTipoConversor);
            this.Controls.Add(this.cboAconversar);
            this.Controls.Add(this.cboDeConversor);
            this.Controls.Add(this.cboTipoConversor);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.textCantidadConversor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCantidadConversor;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cboTipoConversor;
        private System.Windows.Forms.ComboBox cboDeConversor;
        private System.Windows.Forms.ComboBox cboAconversar;
        private System.Windows.Forms.Label lblTipoConversor;
        private System.Windows.Forms.Label lblDeConversor;
        private System.Windows.Forms.Label lblAConversor;
        private System.Windows.Forms.Label lblCantidadConversor;
        private System.Windows.Forms.Label lblRespuestaConversor;
        private System.Windows.Forms.Label label1;
    }
}

