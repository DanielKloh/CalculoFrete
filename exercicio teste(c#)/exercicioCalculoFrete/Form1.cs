using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicioCalculoFrete
{
    public partial class Form1 : Form
    {
        void calcularFrete()
        {
            try
            {
                //Declaração de variavel
                decimal valor = 0;
                decimal frete = 0;
                string cbx = cbxUF.Text;
                decimal total = 0;
                valor = decimal.Parse(txtValor.Text);

                //Calcula o frete
                if (cbx == "São Paulo")
                {
                    frete = 5;
                }
                else if (valor > 1000)
                {
                    frete = 0;
                }
                else if (cbx == "Rio de Janeiro")
                {
                    frete = 10;
                }
                else if (cbx == "Amazonas")
                {
                    frete = 20;
                }
                else
                {
                    frete = 15;
                }


                //Calcula o total
                total = frete + valor;


                //exibe os valores
                // "c" significa moeda local
                lbTotal.Text = total.ToString("C");
                lbValorCompra.Text= valor.ToString("C");
                lbFrete.Text = frete.ToString("C");
            }
            catch (Exception e)
            {                  //Mensagem do componente      Titilo   botão q vai aparecer   icone
                MessageBox.Show("Preencha todos os campos.","ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        void LimparCampos()
        {
            //Limpa os campos
            lbTotal.Text = "__________";
            lbValorCompra.Text = "__________";
            lbFrete.Text = "__________";
            cbxUF.Text = "";
            txtValor.Text = "";
            txtNome.Text = "";
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Chama a função de calcular
            calcularFrete();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Chama a função de limpar campos
            LimparCampos();
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtValor.Select();
            }
        }

        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbxUF.Select();
            }
        }

        private void cbxUF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalcular.Select();
            }
        }
    }
}
