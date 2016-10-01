using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluraCsharpBasico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double saldo = 2000000.0;
            if (saldo < 0.0)
            {
                MessageBox.Show("Você está no negativo!");
            }
            else if (saldo < 1000000.0)
            {
                MessageBox.Show("Você é um bom cliente");
            }
            else
            {
                MessageBox.Show("Você é milionário!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int resposta = 42;
            
            if(resposta==(42))
            {
                MessageBox.Show("Resposta correta");
            }
            int idade = 21;

            if (idade >= 18 && idade <= 65)
            {
                MessageBox.Show("Você trabalha?");
            }
            else
            {
                MessageBox.Show("Você é um cliente especial!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool nomeNoSPC = true;
            int idade = 21;

            if (idade < 18 || nomeNoSPC)
            {
                MessageBox.Show("Estamos analisando sua proposta");
            }
            else
            {
                MessageBox.Show("Você pode adquirir um cartão de crédito");
            }
        }
    }
}
