using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    
    public abstract class FuncionarioPermissao : Funcionario, PermissaoSenha
    {
        public string Senha { get; set; }

        public FuncionarioPermissao(double salario, string cpf)
            : base (salario, cpf)
        {

        }
        
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

        
    }
}
