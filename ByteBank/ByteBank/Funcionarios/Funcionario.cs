using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {    
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; protected set; }
        

        public Funcionario(double salario, string cpf)
        {

            CPF = cpf;
            Salario = salario;
            
            TotalDeFuncionarios++;

        }

       
        public abstract void AumentarSalario();

        //* Explicação das palavras reservadas virtual e override
        //Trocamos pelo método abstract
        //public virtual void AumentarSalario()
        //{
        // Salario = Salario + (Salario * 0.1);
        // Salario = Salario * 1.1;
        //Salario *= 1.1;
        //}

        public abstract double GetBonificacao();

        //* Explicação das palavras reservadas virtual e override
        //Trocamos pelo método abstract
        //public virtual double GetBonificacao()
        //{                      
        //    return Salario * 0.10;
        //}
    }
}
