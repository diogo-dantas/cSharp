using _03_ByteBank;

public class ContaCorrente 
{
    public Cliente titular;
    public int agencia;
    public int numero;
    public double saldo = 100;

    public bool Sacar(double valor)
    {
        if (this.saldo < valor)
        {
            return false;
        }

        this.saldo -= valor;
        return true;
    }

    public void Depositar(double valor)
    {
        this.saldo += valor;
    }

    public bool Transferir( double valor, ContaCorrente ContaDestino)
    {
        if(this.saldo < valor)
        {
            return false;
        }

        this.saldo -= valor;
        ContaDestino.Depositar(valor);
        return true;
    }


}


