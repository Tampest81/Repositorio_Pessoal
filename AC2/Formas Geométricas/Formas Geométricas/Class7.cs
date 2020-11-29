using Course.Entities.Enums;

namespace Course.Entities
{
    abstract class Forma // classe abstrata
    {

        public Color color { get; set; } // criação da variavel Color(Enum criado) criada na classe Cores e aplicando um get set

        public Forma() { } // construtor

        public Forma(Color Color) // construtor e sua variavel
        {
            color = Color;
        }

        public abstract double Area(); // método abstrato

    }

}