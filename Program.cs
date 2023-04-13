namespace ConsoleApp3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			Console.WriteLine("1 - BMW");
			Console.WriteLine("2 - Mers");
			Console.WriteLine("3 - Audi");

			int num = int.Parse(Console.ReadLine());

			switch (num)
			{
				case 1: //BMW
					Show(new BmwCar());
					break;
				case 2: //Mers
					Show(new MersCar());
					break;
				case 3: //Audi
					Show(new AudiCar());
					break;
				default: Console.WriteLine("Error...");
					break;
			}
		}

		private static void Show(Car car)
		{
			Console.WriteLine($"Name: {car.Name}");
			Console.WriteLine($"EngineType: {car.EngineType}");
			Console.WriteLine($"Price: {car.Price}");
			Console.WriteLine($"Body: {car.Body}");
			Console.WriteLine($"Description: {car.Description}");
			Console.WriteLine($"MaxSpeed: {car.MaxSpeed}");
			car.Drive();
		} 
	}
}