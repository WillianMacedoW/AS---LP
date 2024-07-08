class Programa
{
    static void Main(string[] args)
    {
        Empresa empresa = new Empresa();

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Adicionar funcionário de tempo integral");
            Console.WriteLine("2. Adicionar funcionário de meio período");
            Console.WriteLine("3. Remover funcionário");
            Console.WriteLine("4. Exibir informações de todos os funcionários");
            Console.WriteLine("5. Adicionar projeto(s) a um funcionário");
            Console.WriteLine("6. Sair do programa");

            Console.Write("Opção: ");
            int opcao;
            while (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Opção inválida. Digite um número inteiro.");
                Console.Write("Opção: ");
            }

            switch (opcao)
            {
                case 1:
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Matrícula: ");
                    int matricula;
                    while (!int.TryParse(Console.ReadLine(), out matricula))
                    {
                        Console.WriteLine("Matrícula inválida. Digite um número inteiro.");
                        Console.Write("Matrícula: ");
                    }
                    Console.Write("Salário mensal: ");
                    double salarioMensal;
                    while (!double.TryParse(Console.ReadLine(), out salarioMensal))
                    {
                        Console.WriteLine("Salário mensal inválido. Digite um número decimal.");
                        Console.Write("Salário mensal: ");
                    }
#pragma warning disable CS8604 // Possível argumento de referência nula.
                    empresa.AdicionarFuncionario(new FuncionarioTempoIntegral(nome, matricula, salarioMensal));
#pragma warning restore CS8604 // Possível argumento de referência nula.
                    break;
                case 2:
                    Console.Write("Nome: ");
                    nome = Console.ReadLine();
                    Console.Write("Matrícula: ");
                    while (!int.TryParse(Console.ReadLine(), out matricula))
                    {
                        Console.WriteLine("Matrícula inválida. Digite um número inteiro.");
                        Console.Write("Matrícula: ");
                    }
                    Console.Write("Salário por hora: ");
                    double salarioPorHora;
                    while (!double.TryParse(Console.ReadLine(), out salarioPorHora))
                    {
                        Console.WriteLine("Salário por hora inválido. Digite um número decimal.");
                        Console.Write("Salário por hora: ");
                    }
                    Console.Write("Horas trabalhadas: ");
                    int horasTrabalhadas;
                    while (!int.TryParse(Console.ReadLine(), out horasTrabalhadas))
                    {
                        Console.WriteLine("Horas trabalhadas inválidas. Digite um número inteiro.");
                        Console.Write("Horas trabalhadas: ");
                    }
                    empresa.AdicionarFuncionario(new FuncionarioMeioPeriodo(nome, matricula, salarioPorHora, horasTrabalhadas));
                    break;
                case 3:
                    Console.Write("Matrícula do funcionário a remover: ");
                    while (!int.TryParse(Console.ReadLine(), out matricula))
                    {
                        Console.WriteLine("Matrícula inválida. Digite um número inteiro.");
                        Console.Write("Matrícula do funcionário a remover: ");
                    }
                    empresa.RemoverFuncionario(matricula);
                    break;
                case 4:
                    empresa.ExibirFuncionarios();
                    break;
                case 5:
                    Console.Write("Matrícula do funcionário: ");
                    while (!int.TryParse(Console.ReadLine(), out matricula))
                    {
                        Console.WriteLine("Matrícula inválida. Digite um número inteiro.");
                        Console.Write("Matrícula do funcionário: ");
                    }
                    Funcionario funcionario = empresa.BuscarFuncionario(matricula);
                    if (funcionario!= null)
                    {
                        Console.Write("Número de projetos a adicionar: ");
                        int numeroProjetos;
                        while (!int.TryParse(Console.ReadLine(), out numeroProjetos))
                        {
                            Console.WriteLine("Número de projetos inválido. Digite um número inteiro.");
                            Console.Write("Número de projetos a adicionar: ");
                        }
                        for (int i = 0; i < numeroProjetos; i++)
                        {
                            Console.Write($"Projeto {i + 1}: ");
                            funcionario.AdicionarProjeto(Console.ReadLine());
                        }
                    }
                    else
                    {
                        Console.WriteLine("Funcionário não encontrado.");
                    }
                    break;
                case 6:
                    return;
            }
        }
    }
}