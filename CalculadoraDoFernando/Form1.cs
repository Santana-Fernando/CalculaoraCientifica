using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDoFernando
{
    public partial class Form1 : Form
    {   
        
        string operador;
        int a = 0;
        bool validar = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumerador_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtValor.Text = txtValor.Text + bt.Text;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txtValor.Clear();
            label1.Text = "";
            a = 0;
            validar = false;

        }

        private void btn_adicao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a + Convert.ToInt32(txtValor.Text);
                label1.Text = Convert.ToString(a) + "+";
                txtValor.Text = "";
                operador = "+";
            }
            else
            {
                label1.Text = txtValor.Text + btn_adicao.Text;
                a = Convert.ToInt32(txtValor.Text);
                txtValor.Text = "";
                operador = "+";
                validar = true;
                    

            }
        }

        private void btn_subitracao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a - Convert.ToInt32(txtValor.Text);
                label1.Text = Convert.ToString(a) + "-";
                txtValor.Text = "";
                operador = "-";
            }
            else
            {
                label1.Text = txtValor.Text + btn_subitracao.Text;
                a = Convert.ToInt32(txtValor.Text);
                txtValor.Text = "";
                operador = "-";
                validar = true;


            }

        }

        private void btn_multiplicacao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a * Convert.ToInt32(txtValor.Text);
                label1.Text = Convert.ToString(a) + "*";
                txtValor.Text = "";
                operador = "*";
            }
            else
            {
                label1.Text = txtValor.Text + btn_multiplicacao.Text;
                a = Convert.ToInt32(txtValor.Text);
                txtValor.Text = "";
                operador = "*";
                validar = true;


            }
        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a / Convert.ToInt32(txtValor.Text);
                label1.Text = Convert.ToString(a) + "/";
                txtValor.Text = "";
                operador = "/";
            }
            else
            {
                label1.Text = txtValor.Text + btn_divisao.Text;
                a = Convert.ToInt32(txtValor.Text);
                txtValor.Text = "";
                operador = "/";
                validar = true;


            }

        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            if (operador == "+")
            {
                label1.Text = label1.Text + txtValor.Text + " = ";
                txtValor.Text = Convert.ToString(a + Convert.ToInt32(txtValor.Text));

            }

            else if (operador == "-")
            {
                label1.Text = label1.Text + txtValor.Text + " = ";
                txtValor.Text = Convert.ToString(a - Convert.ToInt32(txtValor.Text));

            }

            else if (operador == "*")
            {
                label1.Text = label1.Text + txtValor.Text + " = ";
                txtValor.Text = Convert.ToString(a * Convert.ToInt32(txtValor.Text));

            }

            else if (operador == "/")
            {
                label1.Text = label1.Text + txtValor.Text + " = ";
                txtValor.Text = Convert.ToString(a / Convert.ToInt32(txtValor.Text));

            }
        }

        }
    }
}
