namespace WF_CalcularIMC
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
            this.lblResultado = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.TextBoxPeso = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.TextBoxAltura = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(77, 206);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 25);
            this.lblResultado.TabIndex = 19;
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GroupBox2.Controls.Add(this.Label9);
            this.GroupBox2.Controls.Add(this.Label10);
            this.GroupBox2.Controls.Add(this.Label19);
            this.GroupBox2.Controls.Add(this.Label20);
            this.GroupBox2.Controls.Add(this.Label21);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Controls.Add(this.Label18);
            this.GroupBox2.Controls.Add(this.Label11);
            this.GroupBox2.Controls.Add(this.Label12);
            this.GroupBox2.Controls.Add(this.Label13);
            this.GroupBox2.Controls.Add(this.Label14);
            this.GroupBox2.Controls.Add(this.Label15);
            this.GroupBox2.Controls.Add(this.Label16);
            this.GroupBox2.Controls.Add(this.Label17);
            this.GroupBox2.Location = new System.Drawing.Point(83, 286);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(518, 272);
            this.GroupBox2.TabIndex = 18;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Interpretação do IMC";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(370, 199);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(16, 16);
            this.Label9.TabIndex = 18;
            this.Label9.Text = "III";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(370, 172);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(13, 16);
            this.Label10.TabIndex = 17;
            this.Label10.Text = "II";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Location = new System.Drawing.Point(370, 141);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(10, 16);
            this.Label19.TabIndex = 16;
            this.Label19.Text = "I";
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(370, 107);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(14, 16);
            this.Label20.TabIndex = 15;
            this.Label20.Text = "0";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(373, 78);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(14, 16);
            this.Label21.TabIndex = 14;
            this.Label21.Text = "0";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(195, 199);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(135, 16);
            this.Label3.TabIndex = 13;
            this.Label3.Text = "OBESIDADE GRAVE";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(195, 172);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(85, 16);
            this.Label5.TabIndex = 12;
            this.Label5.Text = "OBESIDADE";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(195, 141);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(91, 16);
            this.Label6.TabIndex = 11;
            this.Label6.Text = "SOBREPESO";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(195, 107);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(64, 16);
            this.Label7.TabIndex = 10;
            this.Label7.Text = "NORMAL";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(198, 78);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(73, 16);
            this.Label8.TabIndex = 9;
            this.Label8.Text = "MAGREZA";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Location = new System.Drawing.Point(30, 199);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(109, 16);
            this.Label18.TabIndex = 8;
            this.Label18.Text = "MAIOR QUE 40,0";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(30, 172);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(120, 16);
            this.Label11.TabIndex = 7;
            this.Label11.Text = "ENTRE 30,0 E 39,9";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(30, 141);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(120, 16);
            this.Label12.TabIndex = 6;
            this.Label12.Text = "ENTRE 25,0 E 29,9";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(30, 107);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(120, 16);
            this.Label13.TabIndex = 5;
            this.Label13.Text = "ENTRE 18,5 E 24,9";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(33, 78);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(116, 16);
            this.Label14.TabIndex = 4;
            this.Label14.Text = "MENOR QUE 18,5";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(361, 37);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(132, 16);
            this.Label15.TabIndex = 3;
            this.Label15.Text = "OBESIDADE(GRAU)";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(182, 37);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(110, 16);
            this.Label16.TabIndex = 2;
            this.Label16.Text = "CLASSIFICAÇÃO";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(63, 37);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(30, 16);
            this.Label17.TabIndex = 1;
            this.Label17.Text = "IMC";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(379, 126);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(226, 42);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // TextBoxPeso
            // 
            this.TextBoxPeso.Location = new System.Drawing.Point(379, 88);
            this.TextBoxPeso.Name = "TextBoxPeso";
            this.TextBoxPeso.Size = new System.Drawing.Size(226, 22);
            this.TextBoxPeso.TabIndex = 16;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(376, 51);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(97, 16);
            this.Label4.TabIndex = 15;
            this.Label4.Text = "Peso (ex.: 69,2)";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(83, 126);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(226, 42);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // TextBoxAltura
            // 
            this.TextBoxAltura.Location = new System.Drawing.Point(83, 88);
            this.TextBoxAltura.Name = "TextBoxAltura";
            this.TextBoxAltura.Size = new System.Drawing.Size(226, 22);
            this.TextBoxAltura.TabIndex = 13;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(80, 51);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(96, 16);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Altura(ex.: 1,70)";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(80, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(52, 16);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "Cálculo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 605);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.TextBoxPeso);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.TextBoxAltura);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "IMC";
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblResultado;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Button btnLimpar;
        internal System.Windows.Forms.TextBox TextBoxPeso;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnCalcular;
        internal System.Windows.Forms.TextBox TextBoxAltura;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}

