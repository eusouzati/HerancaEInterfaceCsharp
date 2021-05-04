using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;


namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();

            UsarSistema();

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("545.338.453-52");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("362.827.629-08");
            camila.Nome = "Camila";
            camila.Senha = "1234";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "12345";

            sistemaInterno.Logar(parceiro, "12345");
            

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(roberta, "asd");

            sistemaInterno.Logar(camila, "123");
            sistemaInterno.Logar(camila, "asd");
        }


        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("948.273.298-93");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("545.338.453-52");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("774.738.374-74");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("362.827.629-08");
            camila.Nome = "Camila";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês R$ " + gerenciadorBonificacao.GetTotalBonificacao() + ",00");

        }

                



            


        }
    }

