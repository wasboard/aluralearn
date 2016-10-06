using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    public class ContaPoupanca : Conta
    {
        public override void Saca(double valorASerSacado)
        {
            this.saldo -= (valorASerSacado + 0.10);
        }

        /*
            Adicione a classe ContaPoupanca na aplicação. 
            Essa classe deve herdar da Conta e sobrescrever o comportamento do método 
            Deposita para que todos os depositos realizados na conta poupança ganhem uma taxa de 0.10.
        */
        public override void Deposita(double valorDespositado)
        {
            /*
                Precisamos validar um depósito. Não podemos permitir um depósito de um valor negativo.
                Qual a condição a ser colocada em CONDICAO para fazer essa implementação?
             */
            if (valorDespositado > 0)
            {
                this.saldo += valorDespositado * 1.01;
            }


        }
    }
}


