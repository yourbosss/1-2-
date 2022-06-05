/**********************************************
 * Автор: Копытова К.К.                       *
 * Дата: 05.06.2022                           *
 * Название: Базовые понятия языка С# (2 лаба)*
**********************************************/

using System;

namespace namespaceOne
{

	class Program
	{

		static void Main(string[] args)
		{

			Console.WriteLine("Введите x:");
			var Number = Console.ReadLine();

			int NumberInt;

			if (!int.TryParse(Number, out NumberInt) || NumberInt < 100) // преодразовывает число 
			{

				Console.WriteLine("\n" + "Неправильное число");

				return;
			}

			Console.Clear();

			Console.WriteLine("x: " + Number);

			Number = Number.Remove(1, 1) + Number.Substring(1, Number.Length - (Number.Length - 1)); //удаление + извлечение строки

			Console.WriteLine("n: " + Number);

			Console.ReadKey();
		}
	}
}