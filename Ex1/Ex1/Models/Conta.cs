using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.Models
{
    public abstract class Conta
    {
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public DateTime DataAbertura { get; set; }
        public decimal Saldo { get; set; }

        public abstract decimal Depositar(decimal valor);
        public abstract decimal Retirar(decimal valor);

        public Conta(int agencia, int numero, DateTime dataAbertura, decimal saldo)
        {
            this.Agencia = agencia;
            this.Numero = numero;
            this.DataAbertura = dataAbertura;
            this.Saldo = saldo;
        }

    }
}
