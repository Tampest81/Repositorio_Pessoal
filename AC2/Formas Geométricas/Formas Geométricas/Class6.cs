using System;
using Course.Entities.Enums;
namespace Course.Entities
{
    class Retangulo : Forma // herança da classe Forma
    { 
    public double Largura { get; set; } // variavel largura
    public double Altura { get; set; } // variavel altura

    public Retangulo(double largura, double altura, Color cor) : base(cor) // construtor e herdando "cor" da classe forma
    {
        Largura = largura; 
        Altura = altura;
    }
    public override double Area() // método que irá calcular a area do retangulo
    {
        return Largura * Altura;
    }
}
}
