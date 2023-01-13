

namespace DesignPatterns.Prototype
{
	/// <summary>
	/// Clonacion de objeto superficial
	/// </summary>
	public class Animal : ICloneable
	{
		public int Patas { get; set; }
		public string Name { get; set; }

		/// <summary>
		/// Implementacion de la interface para clonar el objeto
		/// </summary>
		/// <returns></returns>
		public object Clone()
		{
			return this.MemberwiseClone();
		}
	}
}
