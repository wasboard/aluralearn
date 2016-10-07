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
            
            //this.conta.saldo = (Convert.ToDouble(textoSaldo.Text));
            this.conta.Saca(Convert.ToDouble(textoValor.Text));
            textoSaldo.Text = Convert.ToString(this.conta.saldo);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.poup.saldo = (Convert.ToDouble(textoSaldo.Text));
            this.poup.Saca(Convert.ToDouble(textoValor.Text));
            textoSaldo.Text = Convert.ToString(this.poup.saldo);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Conta c1 = new ContaPoupanca();
            c1.Deposita(100.0);
            c1.Saca(50.0);
            MessageBox.Show("conta poupança = " + c1.saldo);

            Conta c2 = new Conta();
            c2.Deposita(100.0);
            c2.Saca(50.0);
            MessageBox.Show("conta = " + c2.saldo);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ContaPoupanca cp = new ContaPoupanca();
            cp.Deposita(200.0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Conta c1 = new Conta();
            Conta c2 = new Conta();

            TotalizadorDeContas t = new TotalizadorDeContas();
            t.Soma(c1);
            t.Soma(c2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Conta c = new ContaPoupanca();
            //c.saldo = Convert.ToDouble(textoSaldo.Text);
            c.CalculaRendimentoAnual();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Conta c = new Conta();
            ContaCorrente cc = new ContaCorrente();
            ContaPoupanca cp = new ContaPoupanca();

            c.Deposita(1000.0);
            cc.Deposita(1000.0);
            cp.Deposita(1000.0);

            AtualizadorDeContas atualizador = new AtualizadorDeContas(0.01);
            atualizador.Roda(c);
            atualizador.Roda(cc);
            atualizador.Roda(cp);

            MessageBox.Show("c = " + c.saldo);
            MessageBox.Show("cc = " + cc.saldo);
            MessageBox.Show("cp = " + cp.saldo);
        }
    }
}
