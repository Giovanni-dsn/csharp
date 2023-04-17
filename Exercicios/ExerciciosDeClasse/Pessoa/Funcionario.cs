using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeClasse.Pessoa
{
    public class Funcionario : Pessoa
    {
        public double Salario { get; set; }

        public override void GetPessoa()
        {
            base.GetPessoa();
            Console.WriteLine("Salário: R$" + this.Salario);
        }
    }
}
