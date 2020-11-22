using System;

public class Info
{

	// variaveis
	public int ID { get; set; }
	public string nome { get; set; }
	public double salario { get; set; }

	public float porcentagem { get; set; }
	public Info() {}
	// construtores
	public Info(int ID, string nome, double salario)
    {
		this.ID = ID;
		this.nome = nome;
		this.salario = salario;
    }

}
