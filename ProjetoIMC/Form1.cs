using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIMC
{
    public partial class IMC : Form
    {
        public IMC()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso = 0, altura = 0, resultado = 0;
            try
            {
                peso = Convert.ToDouble(txtPeso.Text);
                altura = Convert.ToDouble(txtAltura.Text);

                altura = altura * altura; // Altura ao quadrado

                resultado = peso / altura;

                txtResultado.Text = resultado.ToString("F");
                txtResultado.Visible = true;

                if (resultado < 18.5)
                {
                    MessageBox.Show("Classificação: Magreza", "Resultado IMC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultado > 18.4 && resultado < 25.0)
                {
                    MessageBox.Show("Classificação: Normal", "Resultado IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (resultado > 24.9 && resultado < 30.0)
                {
                    MessageBox.Show("Classificação: Sobrepeso", "Resultado IMC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultado > 29.9 && resultado < 40.0)
                {
                    MessageBox.Show("Classificação: Obesidade", "Resultado IMC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultado > 40.0)
                {
                    MessageBox.Show("Classificação: Obesidade Grave", "Resultado IMC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPeso.Text = "";
            txtAltura.Text = "";
        }

    }
}
