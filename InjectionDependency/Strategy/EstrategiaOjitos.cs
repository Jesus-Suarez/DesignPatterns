using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
	public class EstrategiaOjitos : IBorracho
	{
		public void conquistar()
		{
			Console.WriteLine("Le hago ojitos a la chica");
		}
	}
}
