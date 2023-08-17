using Ex1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.Models
{
    internal class ContaPopanca : Conta, IContaInvestimento
    {
        public decimal Taxa { get; set; }
        public TipoConta Tipo { get; set; }
        public decimal _rendimento { get; set; }

        public ContaPopanca(decimal taxa, TipoConta tipo, decimal rendimento)
        {
            Taxa = taxa;
            Tipo = tipo;

            _rendimento = rendimento;

        }

        public override decimal Depositar(decimal valor)
        {
            this.Saldo += valor;
            return Saldo;
        }

        public override decimal Retirar(decimal valor)
        {
            base.Saldo += valor;
            return Saldo;
        }

        public void CaluculaRetornoInvestimento()
        {

        }
    }
}
