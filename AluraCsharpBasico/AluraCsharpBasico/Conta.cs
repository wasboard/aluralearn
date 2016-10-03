using System;
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
        public double saldo; 
        public string cpf;
        public int agencia;
        public void Saca(double valorASerSacado)
        {
            this.saldo -= valorASerSacado;
            
        }
        public void Transfere(double valorTransferido, Conta titular)
        {
            titular.saldo += valorTransferido;
            this.saldo -= valorTransferido;

        }
        public void Deposita(double valorDespositado)
        {
            this.saldo += valorDespositado;

        }
    }
}
