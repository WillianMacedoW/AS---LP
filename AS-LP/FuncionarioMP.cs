public class FuncionarioMeioPeriodo: Funcionario, IBonus 
{
    protected double SalarioPorHora;
    protected double NumeroDeHorasTrabalhadas;

    public FuncionarioMeioPeriodo(string nome, int matricula, double salarioPorHora,double numeroDeHorasTrabalhadas) : base(nome,matricula)
    {
        this.SalarioPorHora = salarioPorHora;
        this.NumeroDeHorasTrabalhadas = numeroDeHorasTrabalhadas;

    }
    public override double CalcularSalario()
    {
        return SalarioPorHora * NumeroDeHorasTrabalhadas;
    }
    public override void Exibirinformacoes()
    {
        Console.WriteLine($"nome {nome} salrio por hora {SalarioPorHora} matricula {matricula} numero de horas trabalhadas  {NumeroDeHorasTrabalhadas}");    
    }
    public double  CalcularBonus()
    {
        return CalcularSalario () * 0.05;
    }
}