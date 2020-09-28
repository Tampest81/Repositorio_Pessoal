using System;

public class Area
{

	public double altura;
	public double largura;

    public override string ToString()
    {
        return "Area: "
               + (altura * largura)
               + "// Perimetro: "
               + ((altura * 2) + (largura * 2))
               + "// Diagonal :"
               + Math.Sqrt((altura*2)*(largura*2));
    }

}
