using bytebank.titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.conta
{
    public class ContaCorrente
    {
        public int nmr_agencia;
        public Cliente titular;
        public string conta;
        public double saldo;

        public void Depositar(double valor)
        {
            saldo += valor;
        }
        public bool Saque(double valor)
        {
            if (valor > saldo)
            {
                Console.WriteLine("Saque cancelado. O valor a ser sacado não pode ser maior do que o saldo atual.");
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (valor > saldo)
            {
                Console.WriteLine("Transferência cancelada. Saldo insuficiente para transferência");
                return false;
            }
            else
            {
                Saque(valor);
                destino.Depositar(valor);
                return true;
            }
        }
    }
}
