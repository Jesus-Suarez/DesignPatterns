
namespace DesignPatterns.Mediator
{
	public class Mediatorr : IMediator
	{
		private List<IColleage> colleages;

		/// <summary>
		/// Constructor: create new instance of List of IColleage
		/// </summary>
		public Mediatorr()
		{
			colleages = new List<IColleage>();
		}

		/// <summary>
		/// Add new element at list
		/// </summary>
		/// <param name="iColleage"></param>
		public void Add(IColleage iColleage)
		{
			this.colleages.Add(iColleage);
		}

		public void Send(string message, IColleage colleague)
		{
			foreach (var c in this.colleages)
			{
				if (colleague != c)
				{
					c.Receive(message);
				}
			}
		}
	}
}
