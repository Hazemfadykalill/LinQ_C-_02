using LinQ_C3_02_Assignment;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics.Metrics;
using System.Threading;
using System.Runtime.Intrinsics.Arm;
using System.Text.RegularExpressions;
using System.Xml;
using System.Data.SqlTypes;

namespace LINQ_C3_02_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators

            #region //1.Find all products that are out of stock.
            //var Result = ListGenerators.ProductList.Where(P => P.UnitsInStock == 0);
            //foreach (var product in Result)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region //2.Find all products that are in stock and cost more than 3.00 per unit.

            //var Result = ListGenerators.ProductList.Where(P => P.UnitsInStock> 0 && P.UnitPrice>3.00M);
            //foreach (var product in Result)
            //{
            //    Console.WriteLine(product);
            //} 
            #endregion

            #region // 3.Returns digits whose name is shorter than their value.

            //string[] Arr =new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result = Arr.Where((Number,Index)=>Number.Length<Index);
            //foreach (var Number in Result)
            //{
            //    Console.Write($"  {Number}");                
            //}

            #endregion



            #endregion

            #region LINQ - Element Operators


            #region //1.Get first Product out of Stock
            //var Result = ListGenerators.ProductList.Where(P => P.UnitsInStock == 0)
            //                               .First();
            //Console.WriteLine(Result);
            #endregion
            #region //2.Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var Result = ListGenerators.ProductList.FirstOrDefault(P=>P.UnitPrice>1000);
            //Console.WriteLine(Result); 
            #endregion

            #region //3.Retrieve the second number greater than 5

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int[] Result = Arr.Where(N => N > 5).ToArray();

            //Console.WriteLine($" the second number greater than 5 : {Result[1]} ");
            #endregion


            #endregion

            #region LINQ - Aggregate Operators
            #region //1.Uses Count to get the number of odd numbers in the array
            //  int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Count(N => N % 2 != 0);
            //Console.WriteLine($" Count to get the number of odd numbers in the array : {Result}"); //5
            #endregion

            #region //2.Return a list of customers and how many orders each has.
            //var Result = from C in ListGenerators.CustomerList
            //             select new {C.CustomerName ,OrderCount= C.Orders.Count() }; ;
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"{item}");
            //}


            #endregion

            #region //3.Return a list of categories and how many products each has
            //var Result = from p in ListGenerators.ProductList
            //             group p by p.Category;


            //foreach (var item in Result)
            //{

            //    Console.WriteLine($" Category is : {item.Key} And Count Is :{item.Count()} ");


            //}





            #endregion

            #region //4.Get the total of the numbers in an array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Sum();
            //Console.WriteLine(Result);
            #endregion

            #region //5.Get the total number of characters of all words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).

            //string[] words = System.IO.File.ReadAllLines("dictionary_english.txt");


            //int totalCharacters = words.Sum(word => word.Length);

            //Console.WriteLine($"Total number of characters: {totalCharacters}");

            #endregion

            #region //6.Get the length of the shortest word in dictionary_english.txt(Read dictionary_english.txt into Array of String First).


            //string[] words = System.IO.File.ReadAllLines("dictionary_english.txt");


            //int minCharacters = words.Min(word => word.Length);

            //Console.WriteLine($"Min number of characters: {minCharacters}");

            #endregion

            #region //7.Get the length of the longest word in dictionary_english.txt(Read dictionary_english.txt into Array of String First).

            //string[] words = System.IO.File.ReadAllLines("dictionary_english.txt");


            //int maxCharacters = words.Max(word => word.Length);

            //Console.WriteLine($"Max number of characters: {maxCharacters}");
            #endregion
            #region //8.Get the average length of the words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).


            //string[] words = System.IO.File.ReadAllLines("dictionary_english.txt");


            //var aveCharacters = words.Average(word=>word.Length);

            //Console.WriteLine($"Average number of characters: {aveCharacters}");
            #endregion

            #region //9.Get the total units in stock for each product category.
            //var Result = ListGenerators.ProductList.GroupBy(p => p.Category)
            //                                        .Select(g => new
            //                                                        {
            //                                                            Category = g.Key,
            //                                                            TotalUnitsInStock = g.Sum(p => p.UnitsInStock)
            //                                                        })
            //                                        .ToList();





            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}









            #endregion
            #region //10.Get the cheapest price among each category's products
            //var Result = ListGenerators.ProductList.GroupBy(p => p.Category)
            //                                        .Select(g => new
            //                                        {
            //                                            Category = g.Key,
            //                                            cheapestPrice = g.Min(p => p.UnitPrice)
            //                                        })
            //                                        .ToList();





            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion
            #region //11.Get the products with the cheapest price in each category(Use Let)





            //var  Result02=from P in ListGenerators.ProductList
            //         group P by P.Category into productGroup
            //         let minPrice = productGroup.Min(p => p.UnitPrice)
            //         select new
            //         {
            //             Category = productGroup.Key,
            //             CheapestProduct = productGroup.First(p => p.UnitPrice == minPrice)
            //         };


            //  foreach (var item in Result02)
            //  {
            //      Console.WriteLine(item);
            //  }
            #endregion

            #region //12.Get the most expensive price among each category's products.
            //var Result = ListGenerators.ProductList.GroupBy(p => p.Category)
            //                            .Select(g => new
            //                            {
            //                                Category = g.Key,
            //                                cheapestPrice = g.Max(p => p.UnitPrice)
            //                            })
            //                            .ToList();





            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region //14.Get the average price of each category's products. 

            //var Result = ListGenerators.ProductList.GroupBy(p => p.Category)
            //                            .Select(g => new
            //                            {
            //                                Category = g.Key,
            //                                cheapestPrice = g.Average(p => p.UnitPrice)
            //                            })
            //                            .ToList();





            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

            #region LINQ - Ordering Operators
            #region             //1.Sort a list of products by name
            //var Result = ListGenerators.ProductList.OrderBy(P => P.ProductName);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region             //2.Uses a custom comparer to do a case -insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //Array.Sort(Arr, new System.Collections.CaseInsensitiveComparer());


            //foreach (var word in Arr)
            //{
            //    Console.WriteLine(word);
            //}


            #endregion

            #region             //3.Sort a list of products by units in stock from highest to lowest.
            //var Result = ListGenerators.ProductList.OrderByDescending(P => P.UnitsInStock);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion
            #region             //4.Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var Result = Arr.OrderBy(P => P.Length).ThenBy(N=>N);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region             //5.Sort first by-word length and then by a case -insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedArr = Arr.OrderBy(word => word.Length)           
            //                    .ThenBy(word => word.ToLower())         
            //                    .ToArray();

            //foreach (var word in sortedArr)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion
            #region             //6.Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var Result = ListGenerators.ProductList.OrderByDescending(P => P.Category).ThenByDescending(P => P.UnitPrice);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);    

            //}


            #endregion
            #region             //7.Sort first by-word length and then by a case -insensitive descending sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedArr = Arr.OrderBy(word => word.Length)
            //                    .ThenBy(word => word.ToUpper())
            //                    .ToArray();

            //foreach (var word in sortedArr)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion

            #region             //8.Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var result = Arr
            //          .Where(word => word.Length > 1 && word[1] == 'i')  
            //          .Reverse()                                         
            //          .ToList();

            //foreach (var word in result)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion

            #endregion

            #region LINQ – Transformation Operators
            #region             //1.Return a sequence of just the names of a list of products.

            //List<string> ProductNames=ListGenerators.ProductList.Select(P=>P.ProductName).ToList();
            //foreach (var item in ProductNames)
            //{
            //    Console.WriteLine(item);

            //}
            #endregion
            #region             //2.Produce a sequence of the uppercase and lowercase versions of each word in the original array(Anonymous Types).

            // string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry"}; 
            //var Result=words.Select(x => new { uppercase=x.ToUpper(), lowercase=x.ToLower() });
            //foreach (var x in Result)
            //{
            //   Console.WriteLine($"Uppercase: {item.UpperCase}, Lowercase: {item.LowerCase}");
            //}
            #endregion
            #region             //3.Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var Result = ListGenerators.ProductList.Select(P => new { P.Category, P.ProductID, P.ProductName, P.UnitsInStock, Price = P.UnitPrice });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);    

            //}

            #endregion
            #region            // Determine if the value of int in an array match their position in the array.



            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr
            //   .Select((value, index) => new
            //   {
            //       Value = value,
            //       Index = index,
            //       Matches = value == index
            //   })
            //   .ToList();

            //foreach (var item in result)
            //{
            //    if (item.Matches)
            //    {
            //        Console.WriteLine($"{item.Value} : {item.Matches}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{item.Value} : {item.Matches}");

            //    }
            //}

            #endregion

            #region //5.Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var pairs = from a in numbersA
            //            from b in numbersB
            //            where a < b
            //            select new { A = a, B = b };

            //foreach (var pair in pairs)
            //{
            //    Console.WriteLine($"( {pair.A}is less than {pair.B} )");
            //}

            #endregion

            #region             6.Select all orders where the order total is less than 500.00.

            //var Result = ListGenerators.CustomerList.SelectMany(O => O.Orders).Where(O=>O.Total>500.00m);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region             7.Select all orders where the order was made in 1998 or later.
            //var Result = ListGenerators.CustomerList.
            //    SelectMany(C=>C.Orders).Where(O=>O.OrderDate.Year>=1998);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion
            #endregion

            #region LINQ - Set Operators

            #region             //1. Find the unique Category names from Product List

            //var Result = ListGenerators.ProductList.Select(C => C.Category).Distinct();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region             //2.Produce a Sequence containing the unique first letter from both product and customer names.

            //var ProductName = ListGenerators.ProductList.Select(P => P.ProductName[0]).Distinct();
            //var CustomerName = ListGenerators.CustomerList.Select(P => P.CustomerName[0]).Distinct();
            //var Result = ProductName.Union(CustomerName);
            //foreach (var item in ProductName)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region             //3.Create one sequence that contains the common first letter from both product and customer names.

            //var ProductName = ListGenerators.ProductList.Select(P => P.ProductName[0]).Distinct();
            //var CustomerName = ListGenerators.CustomerList.Select(P => P.CustomerName[0]).Distinct();
            //var Result = ProductName.Intersect(CustomerName).Distinct();
            //foreach (var item in ProductName)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region             //4.Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var ProductName = ListGenerators.ProductList.Select(P => P.ProductName[0]).Distinct();
            //var CustomerName = ListGenerators.CustomerList.Select(P => P.CustomerName[0]).Distinct();
            //var Result = ProductName.Except(CustomerName);
            //foreach (var item in ProductName)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region             //5.Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

            //var ProductName = ListGenerators.ProductList.Select(P => P.ProductName[0]).Distinct();
            //var CustomerName = ListGenerators.CustomerList.Select(P => P.CustomerName[0]).Distinct();
            //var Result = ProductName.Concat(CustomerName);
            //foreach (var item in ProductName)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
            #endregion

            #region LINQ - Partitioning Operators

            #region             //1.Get the first 3 orders from customers in Washington

            //var Result = ListGenerators.CustomerList.SelectMany(c => c.Orders).Take(3).ToList();
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region             //2.Get all but the first 2 orders from customers in Washington.



            //var Result = ListGenerators.CustomerList.SelectMany(c => c.Orders).Take(2).ToList();
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region             //3.Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.


            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            // var Result = numbers.TakeWhile((N, I) => N >= I);
            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);    
            // }

            #endregion

            #region             //            4.Get the elements of the array starting from the first element divisible by 3.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };


            //var Result = numbers.TakeWhile(N=>N%3==0);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region             //            5.Get the elements of the array starting from the first element less than its position.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.TakeWhile((N, I) => N < I);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion
            #region LINQ - Quantifiers

            #region             //1.Determine if any of the words in dictionary_english.txt(Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

            //string[] words = File.ReadAllLines("dictionary_english.txt");


            //bool containsEi = words.Any(word => word.Contains("ei"));

            //if (containsEi)
            //{
            //    Console.WriteLine("At least one word in the dictionary contains the substring 'ei'.");
            //}
            //else
            //{
            //    Console.WriteLine("No words in the dictionary contain the substring 'ei'.");
            //}
            #endregion

            #region             //2.Return a grouped a list of products only for categories that have at least one product that is out of stock.


            //var Result = ListGenerators.ProductList
            //         .Where(p => p.UnitsInStock == 0) 
            //         .GroupBy(p => p.Category)  
            //         .Where(g => g.Any())       
            //         .ToList();

            //foreach (var group in Result)
            //{
            //    Console.WriteLine($"Category: {group.Key}");
            //    foreach (var product in group)
            //    {
            //        Console.WriteLine($" - Product: {product.ProductName}, Stock: {product.UnitsInStock}");
            //    }
            //}
            #endregion

            #region             //3.Return a grouped a list of products only for categories that have all of their products in stock.

           // var Result = ListGenerators.ProductList
           //.GroupBy(p => p.Category)               // Group products by category
           //.Where(g => g.All(p => p.UnitsInStock > 0))    // Filter to include only categories where all products are in stock
           //.ToList();

           // foreach (var group in   Result)
           // {
           //     Console.WriteLine($"Category: {group.Key}");
           //     foreach (var product in group)
           //     {
           //         Console.WriteLine($" - Product: {product.ProductName}, Stock: {product.UnitsInStock}");
           //     }
           // }
            #endregion

            #endregion
        }
    }
}
