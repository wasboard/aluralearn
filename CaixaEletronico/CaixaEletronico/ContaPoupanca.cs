using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    public class ContaPoupanca:Conta
    {
        /* public override void Saca(double valorASerSacado)
         {
             this.saldo -= (valorASerSacado + 0.10);
         }*/
        public void CalculaRendimento()
        {
            this.saldo += 100.0;
        }
        public override void Atualiza(double taxa)
        {
            this.saldo += this.saldo * 3 * taxa;
        }
    }
}
