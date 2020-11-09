using System;

public class Class1
{// criação das varaiveis
    public double iof { get; set; }
    public double dolar { get; set; }
    public double real { get; set; }
    public double cotacao { get; set; }
    public void conversor()
    {
        Console.Write("Qual é o valor do IOF? :");
        iof = double.Parse(Console.ReadLine());

        iofApply();

        Console.Write("Cotação do dolar: ");
        cotacao = double.Parse(Console.ReadLine());

        Console.Write("Quantos Dolares será comprado?: ");
        dolar = double.Parse(Console.ReadLine());

        Converter();

        iofDolarApply();

    }
    // metodos
    public void iofApply() // calculo para sempre deixar o valor inteiro do IOF em um numero decimal que deixe a conta mais facil
    {
        iof = (iof / 100) + 1;
    }

    public void Converter() // conversor de valor
    {
        real = (cotacao * dolar);
        Console.WriteLine("Quantia a ser paga em Reais SEM a aplicação do IOF : " + real);
    }

    public void iofDolarApply() // aplicação do iof na quantia
    {
        real = ((cotacao * dolar) * iof);
        Console.WriteLine("Quantia a ser paga em Reais COM a aplicação do IOF : " + real);
    }
}
