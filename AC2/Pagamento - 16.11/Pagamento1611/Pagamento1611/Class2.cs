using System;

namespace Pagamento1611
{
	public class terceiros : funcionario
	{
		public double adicional { get; set; } // variavel para o adicional -> para tercerizados
		public void porcentagem() // metodo do calculo da porcentagem
        {

			adicional = (adicional / 100) + 1; // calculo da porcentagem

        }
	}
}
