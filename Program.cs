Funcionario func = new Funcionario("Débora Pinheiro", 4000);

func.ReajustarSalario(3500);
func.ReajustarSalario(4200);

Console.WriteLine($"Funcionário: {func.Nome}");
Console.WriteLine($"Novo salario: R$ {func.Salario.ToString("F2")} reais");

