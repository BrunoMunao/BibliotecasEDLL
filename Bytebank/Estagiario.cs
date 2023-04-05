using Modelos.ADM.Funcionarios;

public class Estagiario : Funcionario
{
    public Estagiario(double salario, string cpf) : base(salario, cpf)
    {

    }
    public override void AumentarSalario()
    {
        throw new NotImplementedException();
    }

    protected override double getBonificacao()
    {
        return 0;
    }
}