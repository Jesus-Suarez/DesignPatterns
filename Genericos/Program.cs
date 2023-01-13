namespace genericos
{
	class Program
	{
		static void Main(string[] args)
		{
			AlmacenaObjetos<String> archivos = new AlmacenaObjetos<String>(4);
			archivos.add("Juan");
			archivos.add("Jesus");
			archivos.add("Michel");
			String nombrePerson = archivos.getElement(1);
			Console.WriteLine(nombrePerson);

			Console.WriteLine(new DateTime());
			/*archivos.add(new Empleado(1500));
			archivos.add(new Empleado(1600));
			archivos.add(new Empleado(1700));

			Console.WriteLine(archivos);*/
		}
	}

	/// <summary>
	/// Clase generica
	/// </summary>
	/// <typeparam name="T"></typeparam>
	class AlmacenaObjetos<T>
	{
		private T[] datosElemento;
		private int i = 0;

		/// <summary>
		/// constructor
		/// </summary>
		/// <param name="z"></param>
		public AlmacenaObjetos(int z)
		{
			datosElemento = new T[z];
		}

		public void add(T obj)
		{
			datosElemento[i] = obj;
			i++;
		}

		public T getElement(int i)
		{
			return datosElemento[i];
		}
	}

	class Empleado
	{
		private double Salary;
		public Empleado(double Salary)
		{
			this.Salary = Salary;
		}

		public double showSalary()
		{
			return Salary;
		}
	}
}