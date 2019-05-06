namespace ConversorMoedas
{
    partial class frmConversor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bntCalcular = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.cboMoeadas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bntCalcular
            // 
            this.bntCalcular.Location = new System.Drawing.Point(90, 189);
            this.bntCalcular.Name = "bntCalcular";
            this.bntCalcular.Size = new System.Drawing.Size(141, 23);
            this.bntCalcular.TabIndex = 0;
            this.bntCalcular.Text = "Calcular";
            this.bntCalcular.UseVisualStyleBackColor = true;
            this.bntCalcular.Click += new System.EventHandler(this.bntCalcular_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(90, 82);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(141, 20);
            this.txtValor.TabIndex = 1;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(87, 66);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(90, 133);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(141, 20);
            this.txtResultado.TabIndex = 3;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(87, 117);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado";
            // 
            // cboMoeadas
            // 
            this.cboMoeadas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMoeadas.FormattingEnabled = true;
            this.cboMoeadas.Location = new System.Drawing.Point(90, 27);
            this.cboMoeadas.Name = "cboMoeadas";
            this.cboMoeadas.Size = new System.Drawing.Size(141, 21);
            this.cboMoeadas.TabIndex = 5;
            this.cboMoeadas.SelectedIndexChanged += new System.EventHandler(this.cboMoeadas_SelectedIndexChanged);
            // 
            // frmConversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 294);
            this.Controls.Add(this.cboMoeadas);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.bntCalcular);
            this.Name = "frmConversor";
            this.Text = "Conversor";
            this.Load += new System.EventHandler(this.frmConversor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntCalcular;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ComboBox cboMoeadas;
    }
}

