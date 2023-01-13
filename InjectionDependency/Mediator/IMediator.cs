using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
	public interface IMediator
	{
		public void Send(string message, IColleage colleague);
	}
}
