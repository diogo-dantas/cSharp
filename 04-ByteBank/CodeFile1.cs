using _04_ByteBank;

public class ContaCorrente 
{
    private Cliente _titular;
    private int _agencia;
    private int _numero;
    private double _saldo = 100;
    public static int  TotalDeContas { get; private set; }



    //propriedades (encapsulamento)
    public Cliente Titular { get; set; }
    public int Agencia { get; set; }
    public int Numero { get; set; }
    public double Saldo {
        get
        {
            return _saldo;
        }
        set
        {
            if (_saldo < 0)
            {
                return;
            }
            else
            {
                _saldo = value;
            }
        }
    }

    public ContaCorrente(int agencia, int numero)
    {
        Agencia = agencia;
        Numero = numero;

        TotalDeContas++;
    }

    public bool Sacar(double valor)
    {
        if (this._saldo < valor)
        {
            return false;
        }

        this._saldo -= valor;
        return true;
    }

    public void Depositar(double valor)
    {
        this._saldo += valor;
    }

    public bool Transferir( double valor, ContaCorrente ContaDestino)
    {
        if(this._saldo < valor)
        {
            return false;
        }

        this._saldo -= valor;
        ContaDestino.Depositar(valor);
        return true;
    }


}


