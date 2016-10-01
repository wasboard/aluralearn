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

        private void button8_Click(object sender, EventArgs e)
        {/*
            int total = 2;
            for (int i = 0; i < 5; i += 1)
            {
                total = total * 2;
            }
            MessageBox.Show("O total é: " + total);
            */
            int total = 0;
            for (int i = 0; i < 10; i++)
            {
                total += 1;
            }
            MessageBox.Show("Resultado: " + total);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            /*int i = 8;
            while (i > 1)
            {
                MessageBox.Show("Dividindo por dois");
                i = i / 2;
            }*/

            int i = 1;
            //int j = 1;
            while (i > 1)
            {
                MessageBox.Show("Dividindo por dois ");
                i = i / 2;
                //j++;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //O que podemos colocar no lugar de "LOOP" para calcular qual vai ser o saldo da conta depois de 18 meses?

            double saldo = 200.0;
          
            for(int i = 1;i<=18;i++)
            {
                saldo = saldo * 1.01;
            }
            MessageBox.Show("saldo = " +saldo);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            int i = 10;
            while (i < 5)
            {
                MessageBox.Show("Entrei no while");
            }

            do
            {
                MessageBox.Show("Entrei no do..while");
            } while (i < 5);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Faça um programa em C# que imprima a soma dos números de 1 até 1000
            int i = 1;
            int resultado = 0;

            do
            {
                resultado = i += i;
                i++;
            } while (i <= 1000);
            MessageBox.Show("Resultado = " +resultado);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Faça um programa em C# que imprima todos os múltiplos de 3, entre 1 e 100.
            //Para saber se um número é múltiplo de 3, você pode fazer if (numero % 3 == 0).
            int saida = 0;
            for (int i = 1; i<=100;i++)
            {
                if(i%3 == 0)
                {
                    MessageBox.Show("Resultado = " + i);
                }
            }
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            /*
            Faça um programa em C# que imprima os fatoriais de 1 a 10.
            O fatorial de um número n é n* n-1 * n - 2...até n = 1.Lembre - se de utilizar os parênteses.

            O fatorial de 0 é 1
            O fatorial de 1 é(0!) * 1 = 1
            O fatorial de 2 é(1!) * 2 = 2
            O fatorial de 3 é(2!) * 3 = 6
            O fatorial de 4 é(3!) * 4 = 24
            Faça um for que inicie uma variável n(número) como 1 e fatorial(resultado) como 1 e varia n de 1 até 10:
            */

            int fatorial = 1;
            //int saida = 0;
            for (int n = 1; n <= 10; n++)
            {
                fatorial = fatorial * n;
                MessageBox.Show("Resultado = " + fatorial);
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            string serieFibonacci = "";
            int anterior = 0;
            int atual = 1;
            while (atual <= 100)
            {
                serieFibonacci += atual + " ";
                int proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
            }
            MessageBox.Show("A série de Fibonacci até 100: " + serieFibonacci);

        }

        private void button16_Click(object sender, EventArgs e)
        {
            int qtdLinhas = 5;
            string triangulo = "";
            for (int linha = 1; linha <= qtdLinhas; linha++)
            {
                for (int coluna = 1; coluna <= linha; coluna++)
                {
                    triangulo += (linha * coluna) + " ";
                }
                triangulo += "\n";
            }
            MessageBox.Show(triangulo);

        }

        private void button17_Click(object sender, EventArgs e)
        {
           
            for(int i = 0; i <= 30; i++)
            {
                if (i % 3 ==0 || i % 4 == 0)
                {
                    MessageBox.Show("Divisivel por 3 -> " + i);
                }
                /*else if (i % 4 != 1)
                {
                    MessageBox.Show("não é divisel 3");
                }*/
            }
            
        }
    }
}
