using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ex1.Models
{
    internal class ContaCorrente : Conta
    {
        public TipoConta Tipo { get; set; }

        public ContaCorrente(TipoConta tipo)
        {
            this.Tipo = tipo;
        }
        public override decimal Depositar(decimal valor)
        {
            this.Saldo += valor;
            return Saldo;
        }

        public override decimal Retirar(decimal valor)
        {
            return base.Saldo - valor > 0 ? (base.Saldo -= valor) : 0;
        }
    }
}
