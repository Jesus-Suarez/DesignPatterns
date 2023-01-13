
namespace DesignPatterns.Strategy
{

	public class EstrategiasDelBorrachoContexto
	{
		private IBorracho oBorracho;
		public enum Comportamiento
		{
			HacerOjitos,
			InvitarCerveza,
			HacerCaraDeGalan
		}

		/// <summary>
		/// Contructor para darle una estrategia por default
		/// </summary>
		public EstrategiasDelBorrachoContexto()
		{
			this.oBorracho = new EstrategiaOjitos();
		}

		/*public void EstablecerConquistaOjitos()
		{
			this.oBorracho = new EstrategiaOjitos();
		}

		public void EstablecerConquistaInvitarCerveza()
		{
			this.oBorracho = new EstrategiaInvitarCerveza();
		}*/

		public void Conquistar(Comportamiento opcion)
		{
			switch (opcion)
			{
				case Comportamiento.HacerOjitos:
					this.oBorracho = new EstrategiaOjitos();
					break;
				case Comportamiento.InvitarCerveza:
					this.oBorracho = new EstrategiaInvitarCerveza();
					break;
				case Comportamiento.HacerCaraDeGalan:
					this.oBorracho = new EstrategiaHacerCaraDeGalan();
					break;
				default:
					break;
			}
		}
	}
}
