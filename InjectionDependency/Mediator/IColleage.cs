
namespace DesignPatterns.Mediator
{
	public abstract class IColleage
	{
		private IMediator iMediator;

		/// <summary>
		/// Contructor de la clase
		/// </summary>
		public IColleage(IMediator iMediator)
		{
			this.iMediator = iMediator;
		}

		/// <summary>
		/// Envia mensaje a todos los colegas registrados
		/// </summary>
		public void Comunicate(string message)
		{
			iMediator.Send(message, this);
		}

		public abstract void Receive(string message);
	}
}
