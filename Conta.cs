namespace Banco
{
    public class Conta
    {
        /*
            Saldo: Precisa de metodo?
    Transferir :
    ID Conta:
        */
        void IdConta()
        {
            // fazer com numeros progressivos, como 00001,00002,00003,etc
        }
        int depositar(int saldo , int saldoAdicionado)
        {
            var novoSaldo = saldo + saldoAdicionado;
            return novoSaldo;
        }
        void transferir(int valorTransferido , int saldotitualarRecebedor ,int saldoDoEmissor )
        {
            // nao sei se esta certo
            int saldoEmissorAtual = saldoDoEmissor - valorTransferido ;

            int saldoRecebedorAtual  = saldotitualarRecebedor + valorTransferido;
        }
        int Sacar(int saldo , int valorSacado)
        {
            int saldoAtual = saldo - valorSacado;
            return saldoAtual;
        }
        void exibirSaldo()
        {
            // necessita de um metodo?
        }
    }
}