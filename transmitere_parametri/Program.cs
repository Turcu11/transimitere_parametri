using System;

namespace transmitere_parametri
{
	class Program
	{
		static void Main(string[] args)
		{
			int i = 10;
			Console.WriteLine($"Before Increment :: i={i}");
			IncrementByRef(ref i);
			Console.WriteLine($"After Increment :: i={i}");
            Console.WriteLine("-------------------------------------");
			Person p = new Person("John", "Doe");
            Console.WriteLine($"Before ChangePersonName :: full name = {p.FirstName} {p.LastName}");
			ChangePersonNameByRef(ref p);
			Console.WriteLine($"Before ChangePersonName :: full name = {p.FirstName} {p.LastName}");
		}

		static void IncrementByRef(ref int i)
		{
			i = i + 1;
			Console.WriteLine($"Inside Increment :: i={i}");
		}

		static void ChangePersonNameByRef(ref Person p)
        {
            Console.WriteLine($"Inside change ChangePersonName {p.FirstName} {p.LastName}");
			//p.FirstName = "Changed John";
			p = new Person("Changed John", "Doe");
			Console.WriteLine($"Inside change ChangePersonName {p.FirstName} {p.LastName}");
		}
	}
}