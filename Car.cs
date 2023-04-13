using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	interface IDrive
	{
		int MaxSpeed { get; }

		void Drive();
	}
	public abstract class Car : IDrive
	{
		public virtual string Name { get; }

		public virtual string EngineType { get; }

		public virtual double Price { get; }

		public virtual string Body { get; }

		public virtual string Description { get; }

		public virtual int MaxSpeed { get; } 

		public virtual void Drive()
		{
			Console.WriteLine("Drive...");
		}
	}

	public class BmwCar : Car
	{

		public override string Name { get { return "BMW M5"; } }

		public override string EngineType { get { return "Gas"; } }

		public override double Price { get { return 9999.9; } }

		public override string Body { get { return "Sedan"; } }

		public override string Description { get { return "Auto"; } }

		public override int MaxSpeed { get { return 220; } }

		public override void Drive()
		{
			Console.WriteLine($"Drive: {Name}");
		}

	}

	public class MersCar : Car
	{

		public override string Name { get { return "Mers 140"; } }

		public override string EngineType { get { return "Gas"; } }

		public override double Price { get { return 7599.9; } }

		public override string Body { get { return "Sedan"; } }

		public override string Description { get { return "Auto"; } }

		public override int MaxSpeed { get { return 230; } }

		public override void Drive()
		{
			Console.WriteLine($"Drive: {Name}");
		}

	}

	public class AudiCar : Car
	{

		public override string Name { get { return "Audi A5"; } }

		public override string EngineType { get { return "Gas"; } }

		public override double Price { get { return 8572.9; } }

		public override string Body { get { return "Sedan"; } }

		public override string Description { get { return "Auto"; } }

		public override int MaxSpeed { get { return 225; } }

		public override void Drive()
		{
			Console.WriteLine($"Drive: {Name}");
		}

	}

}
