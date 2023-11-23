namespace CalculoIMC
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAcima = new System.Windows.Forms.Label();
            this.lblAbaixo = new System.Windows.Forms.Label();
            this.lblObeso = new System.Windows.Forms.Label();
            this.lblNormal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblObeso3 = new System.Windows.Forms.Label();
            this.lblObeso2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(30, 101);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(360, 26);
            this.txtPeso.TabIndex = 0;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(30, 173);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(360, 26);
            this.txtAltura.TabIndex = 1;
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cmbSexo.Location = new System.Drawing.Point(30, 245);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(360, 28);
            this.cmbSexo.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(142, 307);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(137, 48);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.White;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultado.Location = new System.Drawing.Point(30, 396);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(360, 31);
            this.lblResultado.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Peso(KG):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Altura(m):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sexo:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(420, 60);
            this.label5.TabIndex = 8;
            this.label5.Text = "Calculadora de IMC";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "IMC:";
            // 
            // lblAcima
            // 
            this.lblAcima.BackColor = System.Drawing.Color.White;
            this.lblAcima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAcima.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcima.Location = new System.Drawing.Point(3, 85);
            this.lblAcima.Name = "lblAcima";
            this.lblAcima.Size = new System.Drawing.Size(354, 35);
            this.lblAcima.TabIndex = 10;
            this.lblAcima.Text = "Você esta acima do peso";
            this.lblAcima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAbaixo
            // 
            this.lblAbaixo.BackColor = System.Drawing.Color.White;
            this.lblAbaixo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAbaixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbaixo.Location = new System.Drawing.Point(3, 15);
            this.lblAbaixo.Name = "lblAbaixo";
            this.lblAbaixo.Size = new System.Drawing.Size(354, 35);
            this.lblAbaixo.TabIndex = 0;
            this.lblAbaixo.Text = "Você está abaixo do peso";
            this.lblAbaixo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblObeso
            // 
            this.lblObeso.BackColor = System.Drawing.Color.White;
            this.lblObeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblObeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObeso.Location = new System.Drawing.Point(3, 120);
            this.lblObeso.Name = "lblObeso";
            this.lblObeso.Size = new System.Drawing.Size(354, 35);
            this.lblObeso.TabIndex = 8;
            this.lblObeso.Text = "Você está com obesidade 1";
            this.lblObeso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNormal
            // 
            this.lblNormal.BackColor = System.Drawing.Color.White;
            this.lblNormal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNormal.Location = new System.Drawing.Point(3, 50);
            this.lblNormal.Name = "lblNormal";
            this.lblNormal.Size = new System.Drawing.Size(354, 35);
            this.lblNormal.TabIndex = 9;
            this.lblNormal.Text = "Seu peso está normal";
            this.lblNormal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.lblObeso3);
            this.panel1.Controls.Add(this.lblObeso2);
            this.panel1.Controls.Add(this.lblAbaixo);
            this.panel1.Controls.Add(this.lblNormal);
            this.panel1.Controls.Add(this.lblObeso);
            this.panel1.Controls.Add(this.lblAcima);
            this.panel1.Location = new System.Drawing.Point(30, 443);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 242);
            this.panel1.TabIndex = 11;
            // 
            // lblObeso3
            // 
            this.lblObeso3.BackColor = System.Drawing.Color.White;
            this.lblObeso3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblObeso3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObeso3.Location = new System.Drawing.Point(3, 190);
            this.lblObeso3.Name = "lblObeso3";
            this.lblObeso3.Size = new System.Drawing.Size(354, 35);
            this.lblObeso3.TabIndex = 12;
            this.lblObeso3.Text = "Você está com obesidade morbida";
            this.lblObeso3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblObeso2
            // 
            this.lblObeso2.BackColor = System.Drawing.Color.White;
            this.lblObeso2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblObeso2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObeso2.Location = new System.Drawing.Point(3, 155);
            this.lblObeso2.Name = "lblObeso2";
            this.lblObeso2.Size = new System.Drawing.Size(354, 35);
            this.lblObeso2.TabIndex = 11;
            this.lblObeso2.Text = "Você está com obesidade 2";
            this.lblObeso2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(421, 697);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAcima;
        private System.Windows.Forms.Label lblAbaixo;
        private System.Windows.Forms.Label lblObeso;
        private System.Windows.Forms.Label lblNormal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblObeso3;
        private System.Windows.Forms.Label lblObeso2;
    }
}

