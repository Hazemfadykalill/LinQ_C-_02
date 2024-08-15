using LinQ_C3_02_Assignment;

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
            
            string[] Arr =new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var Result = Arr.Where((Number,Index)=>Number.Length<Index);
            foreach (var Number in Result)
            {
                Console.Write($"  {Number}");                
            }

            #endregion



            #endregion


        }
    }
}
