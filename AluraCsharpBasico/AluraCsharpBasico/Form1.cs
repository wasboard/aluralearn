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
            //int saida = 0;
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

        private void button18_Click(object sender, EventArgs e)
        {
            int soma = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 != 0)
                {
                    soma += i;
                }
            }
            MessageBox.Show("O total é: " + soma);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Conta c1 = new Conta();
            c1.numero = 1;
            c1.titular = "João do Poste";
            c1.saldo = 1000;

            Conta c2 = new Conta();
            c2.numero = 2;
            c2.titular = "Maria do POste";
            c2.saldo = 2000;
            c2.cpf = "09988712390";
            c1.saldo += 200;
            MessageBox.Show("O total é: " + c1.saldo +"CPF = "+c2.cpf);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Conta mauricio = new Conta();
            mauricio.numero = 1;
            mauricio.titular = "Mauricio";
            mauricio.saldo = 100.0;

            Conta mauricio2 = new Conta();
            mauricio2.numero = 1;
            mauricio2.titular = "Mauricio";
            mauricio2.saldo = 100.0;

            if (mauricio == mauricio2)
            {
                MessageBox.Show("As contas são iguais");
            }
            else
            {
                MessageBox.Show("As contas são diferentes");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Conta mauricio = new Conta();
            mauricio.saldo = 2000.0;

            Conta copia = mauricio;
            copia.saldo = 3000.0;

            MessageBox.Show("mauricio = " + mauricio.saldo);
            MessageBox.Show("copia = " + copia.saldo);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            /*
            Crie a classe Conta com os seguintes atributos saldo (sendo double), titular (sendo string), 
            numero (sendo int). Adicione um novo botão em sua aplicação cuja ação é instanciar uma conta preencher 
            seus dados e depois exibir o nome do titular utilizando o MessageBox.
            */
            Conta c = new Conta();
            c.numero = 1;
            c.titular = "Victor";
            c.saldo = 100.0;

            MessageBox.Show(c.titular);
            /*
            Adicione os atributos cpf e agencia na classe Conta. CPF pode ser uma string, enquanto agência pode ser um int.
            Crie um novo objeto da classe Conta e teste esses atributos. Mãos à obra!
            */
            c.agencia = 99999;
       

            MessageBox.Show(c.agencia.ToString());

        }

        private void button23_Click(object sender, EventArgs e)
        {
            // criando duas contas
            Conta mauricio = new Conta();
            Conta guilherme = new Conta();
            mauricio.saldo = 1000.0;
            guilherme.saldo = 2000.0;

            // transferindo dinheiro entre elas
            double valorASerTransferido = 100.0;
            mauricio.saldo -= valorASerTransferido;
            guilherme.saldo += valorASerTransferido;
            
            MessageBox.Show(guilherme.saldo.ToString());
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double saque = 200;
            Conta c = new Conta();
            MessageBox.Show("Saldo anterior = " + c.saldo);
            c.Saca(saque);
            MessageBox.Show("Saldo atual = " + c.saldo);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Conta guilherme = new Conta();
            guilherme.Deposita(2000.0);

            Conta mauricio = new Conta();
            mauricio.Deposita(1000.0);

            guilherme.Transfere(200.0, mauricio);
            guilherme.Deposita(150.0);
            mauricio.Saca(50.0);

            MessageBox.Show("guilherme = " + guilherme.saldo);
            MessageBox.Show("mauricio = " + mauricio.saldo);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Conta guilherme = new Conta();
            Conta maria = new Conta();

            guilherme.saldo = 2000;
            double rend = guilherme.CalculaRendimentoAnual();

            //MessageBox.Show("guilherme = " + guilherme.saldo);
            MessageBox.Show("guilherme = " + rend);

        }

        private void button28_Click(object sender, EventArgs e)
        {
            Conta guilherme = new Conta();
            Conta maria = new Conta();

            maria.saldo = 1000;
            guilherme.saldo = 1000;

            guilherme.TransfereDeposito(200,guilherme , maria);

            MessageBox.Show("Maria saldo = " + maria.saldo);
            MessageBox.Show("Guilherme saldo = " + guilherme.saldo);
        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            Cliente victor = new Cliente();
            victor.nome = "victor";

            Conta umaConta = new Conta();
            umaConta.cliente = victor;

            umaConta.cliente.rg = "12345678-9";

            MessageBox.Show(umaConta.cliente.nome + "\n" + umaConta.cliente.rg);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Conta umaConta = new Conta();
            Cliente clienteGuilherme = new Cliente();
            clienteGuilherme.nome = "Guilherme Silveira";
            umaConta.cliente = clienteGuilherme;

            MessageBox.Show(umaConta.cliente.nome);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Conta umaConta = new Conta();
            Cliente clienteGuilherme = new Cliente();
            clienteGuilherme.rg = "12345678-9";

            umaConta.cliente = clienteGuilherme;
            umaConta.cliente.rg = "98765432-1";

            MessageBox.Show(clienteGuilherme.rg);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Conta umaConta = new Conta();
            umaConta.Deposita(300.0);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            conta.Deposita(200.0);
        }
    }
}
