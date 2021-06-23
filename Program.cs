using System;
namespace Banco
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
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Entre ou faca o cadastro.");
                    Console.WriteLine("1-Criar Conta :"); 
                    Console.WriteLine("2-Fazer Login :");
            }
            string pegaAcaoUsuario()
            {
                string opcaoEscolhida = Console.ReadLine();
                return opcaoEscolhida.ToUpper(); 
            }
            void fazAcaoUsuario(string opcaoUsuario)
            {
                // while(opcaoUsuario != "X")
                switch(opcaoUsuario)
                {
                    case "1" :  //Cria Conta
                        Console.Clear();
                        Console.WriteLine("Bem vindo ao nosso banco!");
                        Console.WriteLine("Insira os dados a seguir:");

                        Console.WriteLine("Primeiro Nome:");
                        string primeiroNomeUsuario = Console.ReadLine();

                        Console.WriteLine("Ultimo Nome:");
                        string ultimoNomeUsuario = Console.ReadLine();

                        Console.WriteLine("CPF: ");
                        string cpfUsuario = Console.ReadLine(); //mudar depois para long / aplicas o regEx

                        Console.WriteLine("Rg:");
                        string rgUsuario = Console.ReadLine();// mudar depois para long /Aplicar o regEx

                        Console.WriteLine("Senha:");
                        string senhaUsuario = Console.ReadLine();

                       Console.WriteLine("Data de Nacimento");
                        string dataNascimentoUsuario = Console.ReadLine();
                            // manipular Json aqui
                        Usuario novoUsuario = new Usuario(primeiroNomeUsuario, ultimoNomeUsuario ,cpfUsuario , rgUsuario , senhaUsuario, dataNascimentoUsuario);
                        break;
                    case "2" : //Faz loguin
                        
                        break;
                }    
            }
           
        }
    }
}
