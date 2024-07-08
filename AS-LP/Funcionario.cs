public abstract class Funcionario
{
    public String nome;
    public int matricula;
    public List<string> Projetos;


    protected Funcionario(string Nome, int matricula)
    {
        this.nome = Nome;
        this.matricula = matricula;
        Projetos = new List<string>();
    }
    public abstract Double CalcularSalario();
    public abstract void Exibirinformacoes();
    public void AdicionarProjeto(String projetos)
    {
        Projetos.AddRange(Projetos);
    }
}