Esse e um projeto que simula um banco no console.

Oque deve ter:

Opcao :
Inicio
{
    1-Criar Conta 
    {
        PrimeiroNome:
        UltimoNome:
        CPF:
         RG:
         Senha:
         data de nascimento:
        ....mensagem: Cadastro Feito!
        volta para o Inicio
    }
    2-Fazer Login 
    {
        1- Cliente 
        {
             ID conta :
            Senha :   
            //JSON clientes
        }

        2 - ADM
        ID conta :
        Senha :   
        se bater com alguem no json ,entrar , se nao mensagem de erro
        //ideia para depois... add acesso adm,que consegue ver todas as contas, consultar certa conta e excluir
    }
}

Entrada do Login 
{
    CLiente
    {
        Bem Vindo! {Nome} {UltimoNome}
        Conta : {ID conta}
        Operacoes na conta
        {
            1 - Depositar
            {
                Qual o valor que deseja depositar?
                X
                Seu saldo atual e : Y
                Voltar entrada do Login
            }
            2 - transferir
            {
                voce deseja tranferir para quem ?
                //pesquisar por cpf,nome ?
                qual o valor da transferencia?

                Transferencia realizada
                Vontar entrada do Login
            }
            3 - Sacar
            {
                Qual o valor que voce deseja sacar?
                X
                Valor Sacado com Sucesso
            }
            4 - Exibir Saldo
            {
             seu saldo e de:{saldo}   
            }
        }
        X-Log Out
    ADM
    {
        Listar todas as contas
        {
            //Listar todas as contas de clientes
        }
        Excluir conta
        {
            Pesquisar conta:
            ....conta excluida
        }
        ACessar certa conta
        {
            Pesquiser conta:
        }
    }
}
Conta
{
    //gerar extrato
    Saldo :
    Depositar :
    Transferir :
    Sacar:
    ID Conta:
    Exibir Saldo:
}
Usuario 
{
    primeiroNome 
    ultimoNome 
    cpf 
    rg 
    senha 
    data nascimento
}

Cliete : Usuario
{
    acessar conta()
}

ADM :Usuario
{
    Acessar contar ()
    Excluir conta ()
    acessar conta()
}