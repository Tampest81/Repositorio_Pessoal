using System;

public class Funcionario
{
	public string nome;
	public double salario;
	public double imposto;
    public double aumento;

    public override string ToString()
    {
        return "Nome: "
               + nome
               + "// salário: "
               + salario
               + "// aumento em %: "
               + aumento
               + "// imposto: "
               + imposto
               + "// dinheiro restante: "
               + (((salario * (aumento / 100))+salario) - imposto);
    }


}
