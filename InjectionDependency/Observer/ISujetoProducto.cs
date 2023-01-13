
namespace DesignPatterns.Observer
{
	public interface ISujetoProducto
	{
		void Add(IObserverUser user);

		void Remove(IObserverUser user);

		void Notify();
	}
}
