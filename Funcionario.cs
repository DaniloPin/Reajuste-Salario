public class Funcionario {

    public string Nome { get; set; }
    private double salario;

    public Funcionario(string nome, double salarioInicial) {
        Nome = nome;
        this.salario = salarioInicial;
    }

    public void ReajustarSalario(double novoValor) { 
        
        if (novoValor > salario) {

            salario = novoValor;
        }
        else {
            Console.WriteLine("ERRO: O salário deve ser maior que o atual.");
        }
    }
    public double Salario {
        get { return salario; }
    }

}