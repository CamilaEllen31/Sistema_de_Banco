public class Vendedor : Funcionario
{
    public int NumeroClientesAtendidos { get; set; }

    public override double Bonificacao
    {
        get
        {
            return _bonificacao;
        }
        set
        {
            _bonificacao += value * 0.02;
        }
    }

    public override int CalcularFerias()
    {
        return 30 + NumeroClientesAtendidos * 1;
    }
}