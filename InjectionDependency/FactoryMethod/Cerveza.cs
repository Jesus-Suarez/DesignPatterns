using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
	class Cerveza : BebidaEmbriagante
	{
		public override int CuantoMeEmbriaga()
		{
			return 25;
		}
	}
}
