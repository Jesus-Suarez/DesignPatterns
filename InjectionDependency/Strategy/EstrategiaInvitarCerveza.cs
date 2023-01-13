using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
	public class EstrategiaInvitarCerveza : IBorracho
	{
		public void conquistar()
		{
			Console.WriteLine("Le invito una cerveza");
		}
	}
}
