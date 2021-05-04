using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string cpf) : base(3000, cpf)
        {
            Console.WriteLine("Seja bem vindo Desenvolvedor! Seu salário é de R$ " + Salario + ",00");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.30;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.35;
        }
    }
}
