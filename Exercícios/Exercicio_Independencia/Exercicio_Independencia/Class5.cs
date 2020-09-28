using System;

public class Notas
{
	public string aluno;

	public double nota1;
	public double nota2;
	public double nota3;

    public void Contador()
    {
        double somaTotal = (nota1 + nota2 + nota3);

        if(somaTotal > 60 || somaTotal == 60)
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Reprovado por: " + (60 - somaTotal) + " Pontos");
        }

    }
    public override string ToString()
    {
        return "Nome do aluno:"
                + aluno
                + "// primeira nota (0-30): "
                + nota1
                + "// segunda nota (0-35): "
                + nota2
                + "// terceira nota (0-35): "
                + nota3;
                
    }
}
