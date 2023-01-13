using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
	public class EstrategiaHacerCaraDeGalan : IBorracho
	{
		public void conquistar()
		{
			Console.WriteLine("Haciendo cara de guapo");
		}
	}
}
