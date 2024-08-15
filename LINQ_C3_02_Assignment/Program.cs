using LinQ_C3_02_Assignment;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using System.Xml.Linq;

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

        }
        }
}
