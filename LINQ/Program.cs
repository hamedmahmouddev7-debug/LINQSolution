using static LINQ.DataSources.Source;   // ProductList, CustomerList

namespace LINQ
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// [Q1] Seafood products: name and price
			//Console.WriteLine("--- Q1 ---");
			//var q1 = ProductList.Where(p => p.Category == "Seafood");
			//foreach (var p in q1)
			//	Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");

			// [A1-Q2] Only product names
			//Console.WriteLine("--- Q2 ---");
			//var q2 = ProductList.Select(p => p.ProductName);
			//foreach (var n in q2)
			//	Console.WriteLine(n);


		}
	}
}