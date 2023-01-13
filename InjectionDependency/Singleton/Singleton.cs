namespace DesignPatterns
{
	public class Singleton
	{
		private static Singleton? instance; // es private y por eso no se podra acceder
		public string message = "";

		/// <summary>
		/// Constructor
		/// </summary>
		protected Singleton()
		{
			message = "Hola mundo";
		}
		
		public static Singleton Instance //se hace para dar el valor a "instance" que esta private
		{
			get
			{
				if (instance == null) instance = new Singleton();
				return instance;
			}
		}
	}
}
