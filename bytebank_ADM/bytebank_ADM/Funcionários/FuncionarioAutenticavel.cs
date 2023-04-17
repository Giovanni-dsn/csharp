using bytebank_ADM.Parceria;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionários
{
    public abstract class FuncionarioAutenticavel:Funcionario, IAutenticavel
    {
        public FuncionarioAutenticavel(string cpf, double salario):base(cpf, salario)
        {
        }

        public string Senha { get; set; }
    }
}
