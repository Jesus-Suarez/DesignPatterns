
namespace DesignPatterns.Mediator
{
	public class UserAdmin : IColleage
	{
		/// <summary>
		/// Constructor que inicializa tambien el contructor padre(de la que hereda)
		/// </summary>
		/// <param name="iMediator"></param>
		public UserAdmin(IMediator iMediator) : base(iMediator)
		{

		}

		public override void Receive(string message)
		{
			Console.WriteLine("Un administrador recibe: " + message);
		}
	}
}
