using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        private Conta conta = new Conta();
        private ContaPoupanca poup = new ContaPoupanca();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double strDep = Convert.ToDouble(textoValor.Text);
            this.conta.Deposita(strDep);
            textoSaldo.Text = Convert.ToString(this.conta.saldo);
            //textoValor.Text = Convert.ToString( this.conta.saldo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.conta = new Conta();
            this.conta.titular = "Victor";
            this.conta.numero = 1;

            /*
                textoNumero.Text = Convert.ToString(this.conta.numero);
                textoSaldo.Text = Convert.ToString(this.conta.saldo);
                textoTitular.Text = this.conta.titular;
            */
            this.MostraConta();
        }

        private void MostraConta()
        {
            textoNumero.Text = Convert.ToString(this.conta.numero);
            textoSaldo.Text = Convert.ToString(this.conta.saldo);
            textoTitular.Text = this.conta.titular;
        }

        private void textoTitular_TextChanged(object sender, EventArgs e)
        {
            //textoTitular.Text = "Texto da minha caixa da texto";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textoValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.conta.saldo = (Convert.ToDouble(textoSaldo.Text));
            this.conta.Saca(Convert.ToDouble(textoValor.Text));
            textoSaldo.Text = Convert.ToString(this.conta.saldo);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.poup.saldo = (Convert.ToDouble(textoSaldo.Text));
            this.poup.Saca(Convert.ToDouble(textoValor.Text));
            textoSaldo.Text = Convert.ToString(this.poup.saldo);

        }
    }
}
