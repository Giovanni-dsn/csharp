using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAutomovel
{
    public abstract class Veiculo
    {
        public double Velocidade { set; private get; }

        private string Placa { set; get; }

        private string Chassi { get; set; }

        public double Ano { get; set; }

        public bool Estado { get; private set; }

        public bool Ligar()
        {
            Console.WriteLine("O automóvel acaba de ser ligado");
            return Estado = true;
        }

        public bool Desligar()
        {
            Console.WriteLine("O automóvel acaba de ser desligado");
            return Estado = false;
        }

        public string GetVelocidade()
        {
            if (Velocidade == 0)
            {
                return "A velocidade do automóvel ainda é indefinida";
            }
            return $"A velocidade do automóvel é: {this.Velocidade}";
        }

        public string GetPlaca()
        {
            if (this.Placa == null)
            {
                return "A placa do automóvel ainda não foi definida !";
            }
            else
            {
                return $"A placa do automóvel é: {this.Placa}";
            }
            
        }

        public string GetChassi()
        {
            if (this.Chassi == null)
            {
                return "O chassi do automóvel é indefinido";
            }
            else
            {
                return $"O chassi do automóvel é: {this.Chassi}";
            }
        }

        public void SetChassi(string chassi)
        {
            this.Chassi = chassi;
            Console.WriteLine($"Chassi de {this} definido como {chassi}");
        }

        public void SetPlaca(string placa)
        {
            this.Placa = placa;
            Console.WriteLine($"Placa de {this} definida como {placa}");
        }

        public double CalcularValorVenda(Veiculo objeto)
        {
            double valorVenda = objeto.Ano * 10;
            return valorVenda;
        }


    }
}
