
namespace DesignPatterns.Mediator
{
	public class User : IColleage
	{
		/// <summary>
		/// Constructor que inicializa tambien el contructor padre(de la que hereda)
		/// </summary>
		/// <param name="iMediator"></param>
		public User(IMediator iMediator) : base(iMediator)
		{

		}

		public override void Receive(string message)
		{
			Console.WriteLine("Recibe mensaje usuario normal: " + message);
		}
	}
}
