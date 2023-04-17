using bytebank_ADM.Funcionários;
using bytebank_ADM.Parceria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool UsuarioAutenticado = funcionario.Autenticar(senha);
            if (UsuarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao nosso Sistema !");
                return true;
            }
            else
            {
                Console.WriteLine("Senha Incorreta");
                return false;
            }
        }
    }
}
