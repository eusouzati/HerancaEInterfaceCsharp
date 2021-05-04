using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class GerenteDeConta : FuncionarioPermissao
    {
            

        public GerenteDeConta(string cpf) : base(4000, cpf)
        {
            Console.WriteLine("Seja bem vindo Gerente de Contas! Seu salário é de R$ " + Salario + ",00");

        }
        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
