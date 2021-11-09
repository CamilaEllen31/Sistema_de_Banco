public abstract class Funcionario : PessoaFisica
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public double Salario { get; set; }
    public double Comissao { get; set; }
    protected double _bonificacao;

    public virtual double Bonificacao
    {
        get
        {
            return _bonificacao;
        }
        set
        {
            _bonificacao += Salario * 0.01;
        }
    }

    public double RemuneracaoTotal(double Salario)
    {
        return Salario * 13;
    }

    public double RemuneracaoTotal(double Salario, double Bonificacao)
    {
        return Salario * 13 + Bonificacao;
    }

    public abstract int CalcularFerias();
}