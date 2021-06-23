namespace Banco
{
    public class Usuario
    {
        public Usuario(string primeiroNomeUsuario , string ultimoNomeUsuario , string cpfUsuario ,string rgUsuario, string senhaUsuario,string dataNascimentoUsuario)
        {
            this.primeiroNome = primeiroNomeUsuario;
            this.ultimoNome = ultimoNomeUsuario;
            this.cpf = cpfUsuario;
            this.rg = rgUsuario;
            this.senha = senhaUsuario;
            this.dataNascimento = dataNascimentoUsuario;
        }
        public string primeiroNome {get; set;}
        public string ultimoNome {get; set;}
        public  string cpf {get; set;} //mudar para long  
        public string rg {get; set;} //mudar para long
        public string senha {get; set;}
        public string dataNascimento {get; set;}
    }
}