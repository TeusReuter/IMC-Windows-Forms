using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_CalcularIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();


        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double peso = Convert.ToDouble(TextBoxPeso.Text);
                double altura = Convert.ToDouble(TextBoxAltura.Text);
                double imc = (peso / (altura * altura));
                string textoAdicional = "";

                if (imc < 18.5)
                {
                    textoAdicional = "Você está magro";
                }
                else if (imc >= 18.5 && imc <= 24.9)
                {
                    textoAdicional = "Você está com o IMC considerado normal";
                }
                else if (imc >= 25.9 && imc <= 29.9)
                {
                    textoAdicional = "Você está com sobrepeso";
                }
                else if (imc >= 30 && imc <= 39.9)
                {
                    textoAdicional = "Você está obeso";
                }
                else if (imc > 40)
                {
                    textoAdicional = "Você tem obesidade grave";
                }

                string exibirResultado = "Seu IMC é: " + imc.ToString("n2") + "\r\n" + textoAdicional;

                if (TextBoxPeso.Text.Contains(".") || TextBoxAltura.Text.Contains("."))
                {
                    MessageBox.Show("Por favor, informe os valores separados por vírgula ao invés de ponto ");
                    LimparCampos();
                    exibirResultado = "";

                }
                lblResultado.Text = exibirResultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operação inválida");
            }


        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            TextBoxPeso.Text = "";
            TextBoxAltura.Text = "";
            lblResultado.Text = "";
        }
    }
}
