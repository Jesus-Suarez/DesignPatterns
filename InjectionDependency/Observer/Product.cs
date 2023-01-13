
namespace DesignPatterns.Observer
{
	public class Product : ISujetoProducto
	{
		private List<IObserverUser> _users;
		private string Name { get; set; }
		double _price;

		public double Price
		{
			get { return _price; }
			set
			{
				_price = value;
				this.Notify();
			}
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public Product(string name, double price)
		{
			_users = new List<IObserverUser>();
			Name = name;
			_price = price;
		}

		/// <summary>
		/// Sobreescribimos el metodo heredado
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return $"{Name} (${_price})";
		}

		public void Add(IObserverUser user)
		{
			// Verifica que no exista ya el objeto
			if (!_users.Contains(user))
			{
				_users.Add(user);
			}

			if (_users.Count == 0)
			{

			}
		}

		public void Remove(IObserverUser user)
		{
			// Verifica que exista el objeto para que no de una exception
			if (_users.Contains(user)) _users.Remove(user);
			else throw new Exception($"No existe la suscripcion de: {user as User}");
		}

		public void Notify()
		{
			foreach (var user in _users)
			{
				user.Update(this);
			}

			if (_users.Count == 0) Console.WriteLine("No hay usuarios suscriptores");
		}
	}
}
