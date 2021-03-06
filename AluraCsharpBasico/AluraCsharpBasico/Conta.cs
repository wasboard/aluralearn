﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraCsharpBasico
{
    public class Conta
    {
        public int numero;
        public string titular;
        public double saldo = 2000.0; 
        public string cpf;
        public int agencia;
        public string rg;
        public string endereco;

        public Cliente cliente;

        public void Saca(double valorASerSacado)
        {
            //if(valorASerSacado > 0 && valorASerSacado <= this.saldo)
            if(this.saldo >= valorASerSacado && valorASerSacado >=0)
            {
                this.saldo -= valorASerSacado;
            }
            
            
        }
        public void Transfere(double valorTransferido, Conta titular)
        {
            titular.saldo += valorTransferido;
            this.saldo -= valorTransferido;

        }
        public void Deposita(double valorDespositado)
        {
            /*
                Precisamos validar um depósito. Não podemos permitir um depósito de um valor negativo.
                Qual a condição a ser colocada em CONDICAO para fazer essa implementação?
             */
            if (valorDespositado > 0)
            {
                this.saldo += valorDespositado;
            }
            

        }
        public double CalculaRendimentoAnual()
        {
            double saldoNaqueleMes = this.saldo;

            for (int i = 0; i < 12; i++)
            {
                saldoNaqueleMes = saldoNaqueleMes * 1.007;
            }

            double rendimento = saldoNaqueleMes - this.saldo;

            return rendimento;
        }
        /*
         *  Operação de transferência na Conta Sugerir melhoria
            Implemente o método Transfere que recebe o valor da 
            transferência e a conta de destino. Faça com que ele 
            reutilize as implementações dos métodos Saca e Deposita.
         */

        public void TransfereDeposito(double valorTransferido, Conta titular1 ,Conta titular2)
        {
            titular1.Saca(valorTransferido);
            //titular.saldo += valorTransferido;
            //this.saldo -= valorTransferido;
            titular2.Deposita(valorTransferido);

        }
    }
}
