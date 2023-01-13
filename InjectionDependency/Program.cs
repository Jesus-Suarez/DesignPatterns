using DesignPatterns.FactoryMethod;
using DesignPatterns.Mediator;
using DesignPatterns.Prototype;
using DesignPatterns.Strategy;
using System.Reflection;

namespace DesignPatterns
{
	class Program
	{
		static void Main(string[] args)
		{
			MainMenu();

			#region Dependency Injection
			/*Michelada michelada = new Michelada("Corona");
			Cantinero cantinero = new Cantinero(michelada);
			cantinero.Preparar();

			Michelada michelaDos = new Michelada(Cerveza: "Tecate");
			Cantinero cantineroDos = new Cantinero(michelaDos);
			cantineroDos.Preparar();*/
			#endregion
		}

		static void MainMenu()
		{
			Console.WriteLine("*** DesignPatterns ***");
			Console.WriteLine("1- Creacionales      Creationals");
			Console.WriteLine("2- Estructurales     Structurals");
			Console.WriteLine("3- De comportamiento Behavioral");
			Console.WriteLine("4- Salir             Exit");

			string option = Console.ReadLine();
			switch (option)
			{
				case "1":
					CreationalPatterns();
					break;
				case "2":
					StructuralPatterns();
					break;
				case "3":
					BehavioralPatterns();
					break;
				default:
					Console.WriteLine("No match found");
					Exit();
					break;
			}
		}

		static void CreationalPatterns()
		{
			Console.Clear();
			Console.WriteLine("*** Creacionales ***");

			string[] options = new string[]
			{
			"Abstract Factory",
			"Builder Patterns",
			"Factory Method",
			"Prototype",
			"Singleton",
			"Exit"
			};
			foreach (var item in options.Select((value, index) => new { index, value }))
			{
				Console.WriteLine(item.index + " - " + item.value);
			}

			string option = Console.ReadLine();
			switch (option)
			{
				case "2":
					#region Builder					
					#endregion
					break;
				case "3":
					#region Factory Method
					/*
					* Factory Method: Retorna un nuevo objeto segun 2
					* el valor que le pasemos como paramentro
					*/
					BebidaEmbriagante oBebida = Creator.CreatorBebida(Creator.CERVEZA);
					Console.WriteLine("Esta bebida embriaga: " + oBebida.CuantoMeEmbriaga());
					#endregion
					break;
				case "4":
					#region  Prototype: Clona objetos
					/*
					* Cuando clonas a = b se toma como una referencia hacia el primero
					* por lo que si cambias el otro cambia el original, y prototype lo soluciona
					*/
					Animal animal = new Animal() { Name = "Pelusa", Patas = 4 };
					Animal otroAnimalClonado = new Animal();
					otroAnimalClonado = animal.Clone() as Animal;
					otroAnimalClonado.Patas = 5;
					Console.WriteLine(animal.Patas);

					// Esto solo clona la referencia en memoria
					Animal animalClonado = animal;
					animalClonado.Patas = 5;
					Console.WriteLine(animal.Patas);
					#endregion
					break;
				case "5":
					#region Singleton: Siempre una sola instancia de clase
					Console.WriteLine(Singleton.Instance.message);
					Singleton.Instance.message = "Hola Marte";
					Console.WriteLine(Singleton.Instance.message);
					#endregion
					break;
				default:
					break;
			}
		}

		static void StructuralPatterns()
		{
			Console.Clear();
			Console.WriteLine("*** Structural Patterns ***");

			string[] options = new string[]
			{
			"Adapter",
			"Bridge",
			"Composite",
			"Decorator",
			"Facade",
			"Flyweight",
			"Proxy",
			"Exit"
			};
			foreach (var item in options.Select((value, index) => new { index, value }))
			{
				Console.WriteLine(item.index + " - " + item.value);
			}

			string option = Console.ReadLine();
			switch (option)
			{
				case "":
					break;
				default:
					Console.WriteLine("No match found");
					Exit();
					break;
			}
		}

		static void BehavioralPatterns()
		{
			Console.Clear();
			Console.WriteLine("*** Behavioral Patterns ***");

			string[] options = new string[]
	 {
				"Chain of responsibility",
				"Command",
				"Interpreter",
				"Iterator",
				"Mediator",
				"Observer",
				"State",
				"Strategy",
				"Template method",
				"Vositor",
				"Memento",
				"Exit"
	 };
			foreach (var item in options.Select((value, index) => new { index, value }))
			{
				Console.WriteLine(item.index + " - " + item.value);
			}

			string option = Console.ReadLine();
			switch (option)
			{
				case "4":
					#region Mediator: Es como una sala a la que se puede acceder a traves de una puerta
					Mediatorr mediador = new Mediatorr();

					IColleage oUserJesus = new User(mediador);
					IColleage oUserAdminPepe = new UserAdmin(mediador);

					// añadimos los colegas al mismo mediator(lista)
					mediador.Add(oUserJesus);
					mediador.Add(oUserAdminPepe);

					// enviamos mensaje a todos los colegas
					oUserJesus.Comunicate("Hola Admin tengo un problema");
					#endregion
					break;
				case "5":
					#region Observer: Define una dependencia de uno-a-muchos entre objetos; Cuando un objeto cambia, notifica a todos los demas para que se actualizen
					Console.WriteLine("Pendiente por implementar");
					#endregion
					break;
				case "8":
					#region Strategy: de comportamiento
					/*
					 * Adquiere el comportamiento que le pases como parametro a una clase que 
					 * eligira la clase que se debera ejecutar segun el parametro
					 */
					EstrategiasDelBorrachoContexto estrategia = new EstrategiasDelBorrachoContexto();
					estrategia.Conquistar(EstrategiasDelBorrachoContexto.Comportamiento.HacerOjitos);
					estrategia.Conquistar(EstrategiasDelBorrachoContexto.Comportamiento.InvitarCerveza);
					#endregion
					break;
				case "":
					break;
				default:
					Console.WriteLine("No match found");
					Exit();
					break;
			}

		}

		static void Exit()
		{
			Environment.Exit(0);
		}
	}
}
