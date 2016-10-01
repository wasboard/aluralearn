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
        /*
        Além do operador && (AND), temos o operador || (OR), que verifica se uma das duas condições é verdadeira. Por exemplo:
            bool podeSacar = saldo >= 0 || chequeEspecial < limiteChequeEspecial;
            Também podemos inverter um valor de uma variável bool com o operador !:

            bool menorDeIdade = idade < 18;
            bool maiorDeIdade = !menorDeIdade;
            Sabendo disso, qual a mensagem exibida pelo código abaixo?
         */
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

        /*
        if == Sugerir melhoria
            Qual é a mensagem exibida pelo código abaixo?
            
                */
        private void button4_Click(object sender, EventArgs e)
        {
            double saldo = 100.0;
            saldo -= 80.0;

            if (saldo == 0)
            {
                MessageBox.Show("Você não possui saldo em sua conta");
            }
            else
            {
                MessageBox.Show("Você possui saldo em sua conta");
            }
        }
        /*
        Cálculo de Imposto Sugerir melhoria
        Crie um programa que tenha uma variável double valorDaNotaFiscal, e de acordo com esse valor, o imposto deve ser calculado. As regras de cálculo são:
        Se o valor for menor que 1000, o imposto deve ser de 2%
        Se o valor for maior ou igual a 1000 e menor do que 3000, o imposto deve ser de 2.5%
        Se o valor for maior ou igual a 3000 e menor do que 7000 o imposto deve ser de 2.8%
        Se for maior ou igual a 7000, o imposto deve ser de 3%
        Imprima o valor do imposto que você calculou utilizando as regras acima em um MessageBox.
            */
        private void button5_Click(object sender, EventArgs e)
        {
            //Declaração das variaveis
            double valorDaNotaFiscal;
            double result;

            //incialização
            valorDaNotaFiscal = 7000;
            result = 0;

            //Se o valor for menor que 1000, o imposto deve ser de 2%
            if (valorDaNotaFiscal == 1000)
            {
                result = valorDaNotaFiscal * 0.02;
            }
            //Se o valor for maior ou igual a 1000 e menor do que 3000, o imposto deve ser de 2.5%
            else if (valorDaNotaFiscal>=100 && valorDaNotaFiscal<=3000)
            {
                result = valorDaNotaFiscal * 0.025;
            }
            //Se o valor for maior ou igual a 3000 e menor do que 7000 o imposto deve ser de 2.8%
            else if (valorDaNotaFiscal >= 3000 && valorDaNotaFiscal<7000)
            {
                result = valorDaNotaFiscal * 0.028;
            }
            //Se for maior ou igual a 7000, o imposto deve ser de 3%
            else if (valorDaNotaFiscal>=7000)
            {
                result = valorDaNotaFiscal * 0.03;
            }
            MessageBox.Show("Imposto a pagas = " + result);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double valorEnvestido = 1000;
            int i;

            for(i = 1; i <= 12; i++)
            {
                valorEnvestido = valorEnvestido * 1.01;
            }
            MessageBox.Show("Valor Reajusado = "   +valorEnvestido);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double valorEnvestido = 1000;

            int i = 1;
            while (i<=12)
            {
                valorEnvestido = valorEnvestido * 1.01;
                i++;
            }
            MessageBox.Show("Valor Reajusado = " + valorEnvestido);
            
        }
    }
}
