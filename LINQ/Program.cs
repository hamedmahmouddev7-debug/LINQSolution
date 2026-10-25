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

			// [Q2] Only product names
			//Console.WriteLine("--- Q2 ---");
			//var q2 = ProductList.Select(p => p.ProductName);
			//foreach (var n in q2)
			//	Console.WriteLine(n);

			// [Q4] UnitPrice between 10 and 30 (inclusive)
			//Console.WriteLine("--- Q4 ---");
			//var q4 = ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);
			//foreach (var p in q4)
			//	Console.WriteLine(p);

			// [Q5] In stock AND Condiments
			//Console.WriteLine("--- Q5 ---");
			//var q5 = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");
			//foreach (var p in q5)
			//	Console.WriteLine(p);


			// [Q6] Anonymous type { Name, Price, StockStatus }
			//Console.WriteLine("--- Q6 ---");
			//var q6 = ProductList.Select(p => new
			//{
			//	Name = p.ProductName,
			//	Price = p.UnitPrice,
			//	StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
			//});
			//foreach (var x in q6)
			//	Console.WriteLine($"{x.Name} | {x.Price} | {x.StockStatus}");



		}
	}
}