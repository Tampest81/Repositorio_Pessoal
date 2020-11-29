using System;
using Course.Entities.Enums;
namespace Course.Entities
{
    class Circulo : Forma // herança da classe forma
    {
        public double Raio { get; set; } // variavel que irá guardar o raio
        public Circulo(double raio, Color cor) : base(cor) // construtor que recebe como herança o parametro cor
        {
            Raio = raio;
        }
        public override double Area() // método que irá calcular a Area
        {
            return Math.PI * Raio * Raio;
        }
    }

}
