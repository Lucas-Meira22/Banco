namespace Banco
{
    public class Usuario
    {
        public Usuario(string primeiroNomeUsuario , string ultimoNomeUsuario , string cpfUsuario ,string rgUsuario, string senhaUsuario)
        {
            this.primeiroNome = primeiroNomeUsuario;
            this.ultimoNome = ultimoNomeUsuario;
            this.cpf = cpfUsuario;
            this.rg = rgUsuario;
            this.senha = senhaUsuario;
        }
        public string primeiroNome {get; set;}
        public string ultimoNome {get; set;}
        public  string cpf {get; set;} //mudar para long  
        public string rg {get; set;} //mudar para long
        public string senha {get; set;}
    }
}