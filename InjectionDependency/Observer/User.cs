
namespace DesignPatterns.Observer
{
	public class User : IObserverUser
	{
		public string Name;
		public string Lastname;

		public User(string name, string lastname)
		{
			Name = name;
			Lastname = lastname;
		}

		public override string ToString()
		{
			return $"{Name} {Lastname}";
		}

		public void Update(Product product)
		{
			Console.WriteLine($"El usuario {this} recibio la notificacion del producto: {product}");
		}
	}
}
