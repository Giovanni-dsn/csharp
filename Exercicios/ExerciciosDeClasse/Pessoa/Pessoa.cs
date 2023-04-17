using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeClasse.Pessoa
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public virtual void GetPessoa()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Idade: " + this.Idade);
        }
    }

}
