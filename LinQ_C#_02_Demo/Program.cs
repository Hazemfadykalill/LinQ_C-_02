﻿using System.Diagnostics;
using System.Numerics;

namespace LinQ_C__02_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Category : Filtration [Restriction]
            #region Where
            #region Get Product out of stock
            //get product out of stock
            //By Use Fluent Syntax
            //var Result = ListGenerator.ProductsList.Where(P => P.UnitsInStock == 0);

            ////By Use Query Syntax
            // Result =from P in ListGenerator.ProductsList
            //         where P.UnitsInStock==0
            //         select P;

            //foreach (var product in Result)
            //{
            //    Console.WriteLine(product); 

            //} 
            #endregion

            #region Get product in stock and category  Of Meat/Poultry 


            ////By Use Fluent Syntax
            //var Result = ListGenerator.ProductsList.Where(P => P.UnitsInStock > 0 && P.Category== "Meat/Poultry");

            ////By Use Query Syntax
            //Result = from P in ListGenerator.ProductsList
            //         where P.UnitsInStock > 0 && P.Category == "Meat/Poultry"
            //         select P;

            //foreach (var product in Result)
            //{
            //    Console.WriteLine(product);

            //}
            #endregion
            #endregion

            #region Indexed Where
            //Note This use only with fluent syntax
            //By Use Fluent Syntax
            //var Result = ListGenerator.ProductsList.Where((P,Index )=> P.UnitsInStock > 0 && Index>10);



            //foreach (var product in Result)
            //{
            //    Console.WriteLine(product);

            //}
            #endregion
            #endregion

            #region 2.Category : Transformation [Projection] Operators [Select , Select Many]


            #region Select

            #region Select Product Name
            ////fluent Syntax
            //var Result = ListGenerator.ProductsList.Select(P => P.ProductName);

            ////use Query Syntax
            //Result=from P in ListGenerator.ProductsList
            //       select P.ProductName;
            //foreach (var Product in Result)
            //{
            //    Console.WriteLine(Product);
            //}

            #endregion


            #region Select Customer Name

            ////fluent Syntax
            //var Result = ListGenerator.CustomersList.Select(P => P.CustomerName);

            ////use Query Syntax
            //Result = from P in ListGenerator.CustomersList
            //         select P.CustomerName;
            //foreach (var Product in Result)
            //{
            //    Console.WriteLine(Product);
            //}
            #endregion


            #region Select Customer Orders
            ////fluent Syntax
            //var Result = ListGenerator.CustomersList.SelectMany(C=>C.Orders);

            ////use Query Syntax
            //Result = from C in ListGenerator.CustomersList
            //         from O in C.Orders
            //         select O;
            //foreach (var order in Result)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion

            #region Select Product Id and Product Name
            ////fluent Syntax
            //var Result = ListGenerator.ProductsList.Select(P => new {ProductId=P.ProductID,ProductName=P.ProductName });

            ////use Query Syntax
            //Result = from P in ListGenerator.ProductsList
            //         select new { ProductId = P.ProductID,ProductName = P.ProductName };
            //foreach (var order in Result)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion


            #region Select Product In Stock And Apply Discount 10 % On Its Price
            //fluent Syntax
            //var Result = ListGenerator.ProductsList.Where(P => P.UnitsInStock > 0)
            //                                       .Select(P => new
            //                                       {
            //                                           P.ProductID,
            //                                           P.ProductName,
            //                                           OldPrice=P.UnitPrice,
            //                                           NewPrice=P.UnitPrice-(P.UnitPrice*0.1M),
            //                                           P.UnitsInStock

            //                                       });

            ////use Query Syntax
            //Result = from P in ListGenerator.ProductsList
            //         where P.UnitsInStock > 0
            //         select new {
            //             P.ProductID,
            //             P.ProductName,
            //             OldPrice = P.UnitPrice,
            //             NewPrice = P.UnitPrice - (P.UnitPrice * 0.1M),
            //             P.UnitsInStock
            //         };
            //foreach (var Product in Result)
            //{
            //    Console.WriteLine(Product);
            //}
            #endregion
            #endregion
            #region Index Select

            //var Result = ListGenerator.ProductsList.Where(P => P.UnitsInStock > 0)
            //                                       .Select((P, Index) => new
            //                                       {
            //                                          IndexProduct=Index,
            //                                           P.ProductName,

            //                                       });


            //foreach (var Product in Result)
            //{
            //    Console.WriteLine(Product);
            //}

            #endregion
            #endregion

            #region 3.Category : Ordering Operators [Ascending , Descending , Reverse , ThenBy , ThenByDescending]

            #region Get Products Ordered By Price Asc
            ////Fluent Syntax
            //var Result = ListGenerator.ProductsList.OrderBy(P=>P.UnitPrice);

            ////Query Syntax
            //Result=from P in ListGenerator.ProductsList
            //       orderby P.UnitPrice
            //       select P;
            //foreach (var ResultItem in Result)
            //{
            //    Console.WriteLine(ResultItem);
            //}


            #endregion

            #region Get Products Ordered By Price Desc

            ////Fluent Syntax
            //var Result = ListGenerator.ProductsList.OrderByDescending(P => P.UnitPrice);

            ////Query Syntax
            //Result = from P in ListGenerator.ProductsList
            //         orderby P.UnitPrice descending
            //         select P;
            //foreach (var ResultItem in Result)
            //{
            //    Console.WriteLine(ResultItem);
            //}

            #endregion


            #region Get Products Ordered By Price Asc and Number Of Items In Stock
            ////Fluent Syntax ThenBy Asc
            //var Result = ListGenerator.ProductsList.OrderBy(P => P.UnitPrice)
            //                                       .ThenBy(P=>P.UnitsInStock);

            ////Fluent Syntax ThenBy Des
            //var Result02 = ListGenerator.ProductsList.OrderBy(P => P.UnitPrice)
            //                                       .ThenByDescending(P => P.UnitsInStock);


            //foreach (var ResultItem in Result)
            //{
            //    Console.WriteLine(ResultItem);
            //}

            #endregion

            #region Reverse
            //Fluent Syntax Reverse
            //var Result = ListGenerator.ProductsList.OrderBy(P => P.UnitPrice);
            //ProductID: 33,ProductName: Geitost,CategoryDairy Products, UnitPrice:2.5000,UnitsInStock: 112
            //ProductID: 24,ProductName: Guaran? Fant?stica,CategoryBeverages,UnitPrice: 4.5000,UnitsInStock: 20
            //ProductID: 13,ProductName: Konbu,CategorySeafood,UnitPrice: 6.0000,UnitsInStock: 24
            //ProductID: 52,ProductName: Filo Mix, CategoryGrains/ Cereals,UnitPrice: 7.0000,UnitsInStock: 38
            //ProductID: 54,ProductName: Tourtière,CategoryMeat / Poultry,UnitPrice: 7.4500,UnitsInStock: 21
            //ProductID: 75,ProductName: Rh? nbr?u Klosterbier, CategoryBeverages, UnitPrice:7.7500,UnitsInStock: 125
            //ProductID: 23,ProductName: Tunnbr? d, CategoryGrains/ Cereals,UnitPrice: 9.0000,UnitsInStock: 61

            //foreach (var ResultItem in Result)
            //{
            //    Console.WriteLine(ResultItem);
            //}

            //var  Result02 = ListGenerator.ProductsList.OrderBy(P => P.UnitPrice).Reverse();
            //ProductID: 38,ProductName: Côte de Blaye,CategoryBeverages,UnitPrice: 263.5000,UnitsInStock: 17
            //ProductID: 29,ProductName: Th? ringer Rostbratwurst,CategoryMeat / Poultry,UnitPrice: 123.7900,UnitsInStock: 0
            //ProductID: 9,ProductName: Mishi Kobe Niku,CategoryMeat / Poultry,UnitPrice: 97.0000,UnitsInStock: 29
            //ProductID: 20,ProductName: Sir Rodney's Marmalade,CategoryConfections,UnitPrice:81.0000,UnitsInStock:40
            //ProductID: 18,ProductName: Carnarvon Tigers, CategorySeafood, UnitPrice:62.5000,UnitsInStock: 42
            //ProductID: 59,ProductName: Raclette Courdavault, CategoryDairy Products,UnitPrice: 55.0000,UnitsInStock: 79


            //foreach (var ResultItem in Result02)
            //{
            //    Console.WriteLine(ResultItem);
            //}
            #endregion


            #endregion

            #region 4.Category : Elements Operator [ First , Last , LastOrDefault , FirstOrDefault , ElementAt , ElementAtOrDefault , Single , SingleOrDefault ]

            // - Immediate Execution
            // [Valid Only With Fluent Syntax]

            #endregion


        }
    }
}
