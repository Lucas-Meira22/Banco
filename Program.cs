using System;
namespace primeiro_programa
{
    class Program
    {
        static void Main(string[] args)
        {
            opcoesInicio();
            var opcaoUsuario = pegaAcaoUsuario();
            fazAcaoUsuario(opcaoUsuario);

            void opcoesInicio()
            {
                    Console.WriteLine("Bem Vindo ao Banco Batata!");
                    Console.WriteLine("Entre ou faca o cadastro.");
                    Console.WriteLine("1-Criar Conta :"); 
                    Console.WriteLine("2-Fazer Login :");
            }
            string pegaAcaoUsuario()
            {
                string opcaoEscolhida = Console.ReadLine();
                return opcaoEscolhida; 
            }
            void fazAcaoUsuario(string opcaoUsuario)
            {
                // loop repeticao
                switch(opcaoUsuario)
                {
                    case "1" :  //Cria Conta
                        System.Console.WriteLine("Bem vindo ao nosso banco!");
                        System.Console.WriteLine("Insira os dados a seguir:");

                        System.Console.WriteLine("Primeiro Nome:");
                        string primeiroNomeUsuario = Console.ReadLine();

                        System.Console.WriteLine("Ultimo Nome:");
                        string ultimoNomeUsuario = Console.ReadLine();

                         System.Console.WriteLine("CPF: ");
                        string cpfUsuario = Console.ReadLine(); //mudar depois para long / aplicas o regEx

                         System.Console.WriteLine("Rg:");
                        string rgUsuario = Console.ReadLine();// mudar depois para long /Aplicar o regEx

                        System.Console.WriteLine("Senha:");
                        string senhaUsuario = Console.ReadLine();
                            // manipular Json aqui
                        Usuario novoUsuario = new Usuario(primeiroNomeUsuario, ultimoNomeUsuario ,cpfUsuario , rgUsuario , senhaUsuario);
                        break;
                    case "2" : //Faz loguin
                        
                        break;
                }
            }
           
        }
    }
}
