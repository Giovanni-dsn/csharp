using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeClasse.ContaBancaria
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente()
        {
            this.Limite = 400;
        }
        public double Limite { get; private set; }

        public override void Depositar(double valor)
        {
            if (valor < this.Limite)
            {
                base.Depositar(valor);
                Console.WriteLine("Foi realizado um depósito no valor de R$" + valor);
                Console.WriteLine("O novo saldo é de: R$" + this.Saldo);
            }
            else
            {
                Console.WriteLine("O valor de depósito excede o limite permitido ! Operação cancelada.");
            }
        }

        public override void Sacar(double valor)
        {
            if (valor < this.Limite)
            {
                base.Sacar(valor);
                Console.WriteLine("Foi realizado um saque no valor de R$" + valor);
                Console.WriteLine("O novo saldo é de: R$" + this.Saldo);
            }
            else
            {
                Console.WriteLine("O valor de saque excede o limite permitido ! Operação cancelada.");
            }
        }
    }
}
