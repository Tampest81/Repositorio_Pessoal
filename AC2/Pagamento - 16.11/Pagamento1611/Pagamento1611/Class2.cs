using System;

namespace Pagamento1611
{
	public class terceiros : funcionario
	{
		public double adicional { get; set; }
		public void porcentagem()
        {

			adicional = (adicional / 100) + 1;

        }
	}
}
