public class Gerente : Funcionario
{
    public int NumeroDeAgencias { get; set; }

    public override double Bonificacao
    {
        get
        {
            return _bonificacao;
        }
        set
        {
            _bonificacao += value * 0.05;
        }
    }

    public override int CalcularFerias()
    {
        return 30 + NumeroDeAgencias * 5;
    }
}