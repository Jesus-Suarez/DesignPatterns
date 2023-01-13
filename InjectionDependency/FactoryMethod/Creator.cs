using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
	/// <summary>
	/// Clase que creara objetos segun el parametro de entrada
	/// </summary>
	public class Creator
	{
		public const int VINO_TINTO = 1;
		public const int CERVEZA = 2;

		public static BebidaEmbriagante CreatorBebida(int Tipo)
		{
			switch (Tipo)
			{
				case VINO_TINTO:
					return new VinoTinto();
				case CERVEZA:
					return new Cerveza();
				default:
					return null;
			}
		}
	}
}
