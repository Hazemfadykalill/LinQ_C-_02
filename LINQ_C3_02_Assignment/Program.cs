﻿using LinQ_C3_02_Assignment;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.ComponentModel;

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


        }
    }
}
