using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using static LINQDemo_2.ListGenerator;

namespace LINQDemo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Filtration Operators
            // LINQ 40 Method.
            // 13 Catigory.

            // Filtration Operator : Where - TypeOf


            // All Product out of stock Using Fluent Syntax.

            //var Result = ProductList.Where(P => P.UnitsInStock == 0);

            // All Product out of stock using query syntax

            //var Result = from P in ProductList
            //             where P.UnitsInStock == 0
            //             select P;

            // Using Flent syntax;
            //var Result = ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Meat/Poultry");

            // Using query syntax 

            //var Result = from P in ProductList
            //             where P.UnitsInStock > 0 && P.Category == "Meat/Poultry"
            //             select P; 

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"{item} ");
            //}

            // Indexed Where Valid only in fluent syntax

            //var Result = ProductList.Where((P, Index) => Index > 10 && P.UnitsInStock == 0);
            //var Result = ProductList.Where( P => P.UnitsInStock > 0).Where((P, I) => I < 5);

            //ArrayList List = new ArrayList() { 1, 23, 4, 3.5, "Ahmed", 'D' };

            //var Result = List.OfType<int>();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"{item} ");
            //} 
            #endregion

            #region Transformation Operator
            // 2.Transformation Operators : Select - SelectMany

            // Fluent syntax : 
            //var Result = ProductList.Select(P => P.ProductName);


            // Query syntax :
            //var Result = from P in ProductList
            //             select P.ProductName;

            //var Result = ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Seafood")
            //    .Select(P => new { Name = P.ProductName,
            //        Category = P.Category,
            //        OldPrice = P.UnitPrice,
            //        newPrice = P.UnitPrice * 0.1M });

            //var Result = from P in ProductList
            //             where P.UnitsInStock > 0 && P.Category == "Seafood"
            //             select new
            //             {
            //                 Name = P.ProductName,
            //                 Category = P.Category,
            //                 OldPrice = P.UnitPrice,
            //                 NewPrice = P.UnitPrice * 1.0m
            //             };


            //var Result = CustomerList.SelectMany(C => C.Orders);

            //var Result = from C in CustomerList
            //             from O in C.Orders
            //             select O;

            //var Result = CustomerList.Select((P, Index) => new {Index, P.CustomerName}).Where(P => P.Index > 5);

            //foreach(var item in Result)
            //{
            //    Console.WriteLine($"{item} ");
            //} 
            #endregion

            #region Ordering Operators
            // 3.Ordering Operators :


            //var Result = ProductList.OrderBy(P => P.UnitPrice);
            //var Result = ProductList.OrderByDescending (P => P.UnitPrice).ThenBy(P => P.UnitsInStock).Select(P => new {Name = P.ProductName,
            //P.UnitPrice, P.UnitsInStock});

            //var Result = from P in ProductList
            //             orderby P.UnitPrice, P.UnitsInStock
            //             select P;

            //var Result = ProductList.Reverse<Product>();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"{item} ");
            //} 
            #endregion

            #region Element Operators

            // Element Operators : Immediate Execute

            //ProductList = new List<Product>();

            //Console.WriteLine(ProductList.First());
            //Console.WriteLine(ProductList.Last());

            //Console.WriteLine(ProductList.First(P => P.UnitsInStock == 0));
            //Console.WriteLine(ProductList.Last(P => P.UnitsInStock == 0));

            /*  Console.WriteLine(ProductList.FirstOrDefault());*/// if the sequence is empty it returns the default value

            //Console.WriteLine(ProductList.LastOrDefault());

            //Console.WriteLine(ProductList.FirstOrDefault(new Product() { ProductName = "Default Product" }));

            //Console.WriteLine(ProductList.FirstOrDefault(p => p.UnitsInStock == 0, new Product() { ProductName = "Default Product" }));

            //Console.WriteLine(ProductList.ElementAt(0));

            //Console.WriteLine(ProductList.ElementAtOrDefault(300));

            //Console.WriteLine(ProductList.Single()); // Single Product in Sequence otherwise he throw Exception.

            //Console.WriteLine(ProductList.SingleOrDefault());

            //var Result = ProductList.DefaultIfEmpty();

            //foreach(var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Aggregate Operators - Immediate Execution
            //Aggregate Operators : Immediate Execution 
            // Count - Max - Min - Avg - Sum

            //Console.WriteLine(ProductList.Count);
            //Console.WriteLine(ProductList.Count());

            //Console.WriteLine(ProductList.Count(P => P.UnitsInStock == 0));

            //Console.WriteLine(ProductList.Sum(P => P.UnitPrice));

            //var Result = ProductList.Sum(P => P.UnitsInStock);

            //var Result = ProductList.Average(P => P.UnitPrice);

            //var Result = ProductList.Max();

            //var Result = ProductList.Max(new ProductComparerUnitsInStock());

            //var Result = ProductList.Max(P => P.UnitPrice);

            //var Result = ProductList.MaxBy(p => p.UnitPrice);


            //var Result = ProductList.Min(p => p.UnitPrice);
            //var Result = ProductList.MinBy(P => P.UnitPrice);

            //List<string> Names = new List<string>() { "Mostafa", "Fayez", "Kasem", "Hamad" };
            //var Result = Names.Aggregate((s01, s02) => $"{s01} {s02}");

            //Console.WriteLine(Result); 
            #endregion

            #region Casting Operator

            // Casting Operator -- Immediate Execution 

            //List<Product> Products = ProductList.Where(P => P.UnitsInStock == 0).ToList();

            //foreach (Product Product in Products)
            //{
            //    Console.WriteLine(Product);
            //}
            #endregion

            #region Generation operator
            // Generation Operators
            // Range, Empty, Repeat

            //var Result = Enumerable.Range(1, 100);

            //var Result = Enumerable.Empty<Product>();

            //var Result = Enumerable.Repeat(ProductList[0], 3);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Set Operators
            // Set OPerators - Union - Union all - Intersect - Except

            //var Seq01 = Enumerable.Range(1, 100);
            //var Seq02 = Enumerable.Range(50, 100);

            ////var Result = Seq01.Union(Seq02);

            //var Result = Seq01.Concat(Seq02);

            ////Result = Result.Distinct(); // Remove Duplication.

            //Result = Result.Except(Seq02); 

            //foreach(var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Quantifiers Operators
            //// Quantifiers Operators - return Boolean

            //// any - all - contains - sequenceequal

            //var Seq01 = Enumerable.Range(1, 100);
            //var Seq02 = Enumerable.Range(50, 100);

            //// Any : 

            ////var Result = Seq01.Any();

            ////var Result = Seq01.Any(O => O == 12);

            ////var Result = Seq01.All(O => O % 2 == 0);

            ////var Result = Seq01.SequenceEqual(Seq02);

            ////var Result = Seq01.Contains(12);

            //Console.WriteLine(Result); 
            #endregion

            #region  Grouping Operators
            // Grouping Operator 

            //var Result = ProductList.GroupBy(P => P.Category);
            //var Result = from p in ProductList
            //             group p by p.Category;

            //foreach(var item in Result)
            //{
            //    Console.WriteLine(item.Key);

            //    foreach(var  Product in item)
            //    {
            //        Console.WriteLine(Product);
            //    }

            //    Console.WriteLine();
            //}

            //var Result = from p in ProductList
            //             where p.UnitsInStock == 0
            //             group p by p.Category
            //             into C
            //             where C.Count() < 10
            //             select new {CategoryName = C.Key, CategoryCount = C.Count() };

            //var Result = ProductList.Where(P => P.UnitsInStock > 0)
            //    .GroupBy(P => P.Category)
            //    .Where(C => C.Count() > 10).Select(C => new { CategoryName = C.Key, CategoryCount = C.Count() });


            //foreach(var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.Key);

            //    foreach (var Product in item)
            //    {
            //        Console.WriteLine(Product);
            //    }

            //    Console.WriteLine();
            //} 
            #endregion

            #region Partitioning Operators
            // Partitioning Operators : Take, TakeLast, Skip, SkipLast, TakeWhile, SkipWhile

            //var Result = ProductList.Take(5);

            //var Result = ProductList.Where(P => P.UnitsInStock == 0).TakeLast(5);

            //var Result = ProductList.Skip(5);
            //var Result = ProductList.SkipLast(5);

            //int[] Numbers = { 1, 3, 5, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            ////var Result = Numbers.TakeWhile(N => N % 2 != 0);

            //var Result = Numbers.SkipWhile(N => N % 2 != 0);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Let / Into
            // Let / Into 

            //List<string> Namse = new List<string> { "Mostafa", "Fayez", "Kasem", "Hamad" };

            //var Result = from Name in Namse
            //             select Regex.Replace(Name, "[aeuioAEUIO]", string.Empty)
            //             into NewNames
            //             where NewNames.Length > 3
            //             select NewNames;


            //List<string> Namse = new List<string> { "Mostafa", "Fayez", "Kasem", "Hamad" };

            //var Result = from Name in Namse
            //             let NewNames = Regex.Replace(Name, "[aeuioAEUIO]", string.Empty)
            //             where NewNames.Length > 3
            //             select NewNames;

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            //var Result = Regex.Replace("Ahmed", "[aeuioAEUIO]", string.Empty);

            //Console.WriteLine(Result);

            #endregion

        }
    }
}
