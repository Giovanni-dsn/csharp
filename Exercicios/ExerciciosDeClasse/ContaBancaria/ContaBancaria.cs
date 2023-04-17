using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeClasse.ContaBancaria
{
    public class ContaBancaria
    {
        public double Saldo { get; set; }
        public int NumeroConta { get; set; }

        public virtual void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public virtual void Sacar(double valor)
        {
            this.Saldo -= valor;
        }
    }
}
