namespace WindowsFormsApp1
{
    partial class Form1
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
            this.txtPseso = new System.Windows.Forms.TextBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPseso
            // 
            this.txtPseso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPseso.Location = new System.Drawing.Point(147, 60);
            this.txtPseso.Name = "txtPseso";
            this.txtPseso.Size = new System.Drawing.Size(164, 20);
            this.txtPseso.TabIndex = 0;
            // 
            // Calcular
            // 
            this.Calcular.BackColor = System.Drawing.SystemColors.Control;
            this.Calcular.Location = new System.Drawing.Point(147, 158);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(164, 23);
            this.Calcular.TabIndex = 1;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = false;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(147, 112);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(164, 20);
            this.txtAltura.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(144, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Peso (kg)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(147, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Altura (cm)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(469, 301);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.txtPseso);
            this.Name = "Form1";
            this.Text = "Calculadora de IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPseso;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

