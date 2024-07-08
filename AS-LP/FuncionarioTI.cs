public class FuncionarioTempoIntegral :Funcionario
{
    protected int SalarioMensal;
    private double salarioMensal;

    public FuncionarioTempoIntegral(int SalarioMensal, string nome, int matricula) : base(nome, matricula)
    {
        this.SalarioMensal = SalarioMensal;
    }

    public FuncionarioTempoIntegral(string Nome, int matricula, double salarioMensal) : base(Nome, matricula)
    {
        this.salarioMensal = salarioMensal;
    }

    public override double CalcularSalario()
    {
        return SalarioMensal;
    }
    public override void Exibirinformacoes()
    {
        Console.WriteLine($"nome {nome} Salario mensal {SalarioMensal} matricula {matricula}");
    }
    public double CalcularBonus(){
        return SalarioMensal * 0.1;
    }
}