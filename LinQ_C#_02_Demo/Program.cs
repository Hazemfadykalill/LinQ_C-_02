﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            #region 5.Category : Aggregate Operators  - Immediate Execution [ Count , Sum , Min , Max , Average ]
            #region Count
            //var Result = ListGenerator.ProductsList.Count();
            //Console.WriteLine(Result);// 77
            //Result = ListGenerator.ProductsList.Count(P => P.UnitsInStock > 0);
            //Console.WriteLine(Result);// 72


            #endregion

            #region Sum / Average

            //var Result = ListGenerator.ProductsList.Sum(P => P.UnitPrice);
            //Console.WriteLine(Result);// 2222.7100
            //Result =ListGenerator.ProductsList.Average(P => P.UnitPrice);    
            //Console.WriteLine(Result);// 28.866363636363636363636363636

            #endregion
            #region Max / Min
            //    var MaxPrice = ListGenerator.ProductsList.Max(P => P.UnitPrice);
            //    var Product=(from P in ListGenerator.ProductsList
            //                where P.UnitPrice == MaxPrice
            //                select P).FirstOrDefault();

            //Console.WriteLine(Product); 

            #endregion

            #region Aggregate
            //List<string> Names=new List<string>() { "Hazem","Fady","Mohamed","Khalil"};
            //var Result = Names.Aggregate((st01, st02) => $"{st01} {st02}");
            //Console.WriteLine(Result);  
            #endregion




            #endregion

            #region 6.Category : Casting [Conversion] Operators - Immediate Execution
            #region ToList
            // //Old
            // // var Result = ListGenerator.ProductsList.Where(P=>P.UnitsInStock>0);

            // //New After Casting
            //List<Product> Result = ListGenerator.ProductsList.Where(P=>P.UnitsInStock>0).ToList();

            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion

            #region ToArray
            //Old
            //var Result = ListGenerator.ProductsList.Where(P=>P.UnitsInStock>0);

            ////New After Casting
            //Product[] Result02 = ListGenerator.ProductsList.Where(P => P.UnitsInStock > 0).ToArray();

            //foreach (var item in Result02)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region ToDictionary
            //Old
            //var Result = ListGenerator.ProductsList.Where(P=>P.UnitsInStock>0);

            //New After Casting
            //Dictionary<long,Product> Result = ListGenerator.ProductsList.Where(P => P.UnitsInStock > 0).ToDictionary(P=>P.ProductID);
            //Dictionary<long, string> Result = ListGenerator.ProductsList.Where(P => P.UnitsInStock > 0).ToDictionary(P => P.ProductID,P=>P.ProductName);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Key is  : {item.Key} And Value Is {item.Value}");
            //}
            #endregion

            #region ToHashSet
            //Old
            // var Result = ListGenerator.ProductsList.Where(P=>P.UnitsInStock>0);

            //New After Casting
            //HashSet<Product> Result = ListGenerator.ProductsList.Where(P => P.UnitsInStock > 0).ToHashSet();

            //   foreach (var item in Result)
            //   {
            //       Console.WriteLine(item);
            //   }
            #endregion

            #region OfType
            //ArrayList Result = new ArrayList()
            //{
            //    "Hazem",
            //    "Fasdy",
            //    "buyvb",
            //    ",.m;",
            //    ".,,.m l;",
            //    1,2,3,4,5,6,7,8,9,10,11,12
            //};
            //var Result01=Result.OfType<int>();  
            //foreach (var item in Result01)
            //{
            //    Console.Write($" { item}");//1 2 3 4 5 6 7 8 9 10 11 12
            //}
            #endregion


            #endregion

            #region 7.Category : Generation Operators - Deferred Execution .
            #region Range
            //var Result05=Enumerable.Range(10,50);
            //  foreach (var item in Result05)
            //  {
            //      Console.Write($"{item} ");
            //  }
            #endregion

            #region Repeat
            //List<Product> Result=Enumerable.Repeat(new Product(),10).ToList();
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);    

            //}
            //var Result02=Enumerable.Repeat(2,10);
            //foreach (var item in Result02)
            //{
            //    Console.Write($"{item} ");

            //}

            #endregion

            #region Empty
            //List<Product> list = Enumerable.Empty<Product>().ToList();
            //// ====
            //List<Product> List02=new List<Product>();
            #endregion




            #endregion

            #region 8.Category : Set Operators [Union Family] - Deferred Execution

            //var Seq01 = Enumerable.Range(0, 100);
            //var Seq02 = Enumerable.Range(50, 150);
            //Console.WriteLine("=================Seq01================");
            //foreach (var item in Seq01)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine("\n\n=================Seq01================");
            //foreach (var item in Seq02)
            //{
            //    Console.Write($"{item} ");
            //}

            //Console.WriteLine("\n\n=================Seq01================");

            #region Union

            //var Result = Seq01.Union(Seq02);
            #endregion

            #region Concatenate
            //var Result = Seq01.Concat(Seq02);

            #endregion

            #region Distinct
            //var Result = Seq01.Concat(Seq02);
            //Result = Result.Distinct();


            #endregion

            #region Intersect
            //var Result = Seq01.Intersect(Seq02);

            #endregion

            #region Except
            //var Result = Seq01.Except(Seq02);

            #endregion
            //foreach (var item in Result)
            //{
            //    Console.Write($"{item} ");
            //}

            #endregion

            #region 9.Category : Quantifier Operator - Return boolean
            #region Any
            //var Result = ListGenerator.ProductsList.Any();
            //Console.WriteLine(Result); //True 
            //var Result02 = ListGenerator.ProductsList.Any(P=>P.UnitsInStock<0);//True
            //Console.WriteLine(Result02); //False
            #endregion
            #region All

            //var Result02 = ListGenerator.ProductsList.All(P => P.UnitsInStock > 0);
            //Console.WriteLine(Result02); //False
            #endregion

            #region SequenceEqual
            //var Seq01 = Enumerable.Range(0, 100);
            //var Seq02 = Enumerable.Range(0, 100);
            //var Result = Seq01.SequenceEqual(Seq02);
            //Console.WriteLine(Result);  //true
            //var Seq03 = Enumerable.Range(0, 120);

            //var Result01 = Seq01.SequenceEqual(Seq03);
            //Console.WriteLine(Result01);//false 
            #endregion


            #endregion

            #region 10.Category : Zipping Operator - ZIP

            //List<string> Names= new List<string>() { "Ali","Ahmed","Ramy","Esayed" };
            //int[] Numbers = Enumerable.Range(1, 10).ToArray();
            //char[] Chars = new char[] { 'A', 'B', 'C', 'D', 'E' };
            //var Result=Names.Zip(Numbers);
            //(Ali, 1)
            //(Ahmed, 2)
            //(Ramy, 3)
            //(Esayed, 4)

            //var Result= Names.Zip(Numbers,(Name,Number)  =>new {Index=Number,Name});
            //{ Index = 1, Name = Ali }
            //{ Index = 2, Name = Ahmed }
            //{ Index = 3, Name = Ramy }
            //{ Index = 4, Name = Esayed }
            //var Result=Names.Zip(Numbers, Chars); 
            //(Ali, 1, A)
            //(Ahmed, 2, B)
            //(Ramy, 3, C)
            //(Esayed, 4, D)



            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 11.Category : Grouping Operators

            #region //Get Products Grouped by Category 
            ////fluent syntax
            //var Result = ListGenerator.ProductsList.GroupBy(    P=>P.Category);
            ////Query syntax
            ////var Result = from P in ListGenerator.ProductsList
            ////             group P by P.Category;
            //foreach (var Category in Result)
            //{
            //    Console.WriteLine($"{Category.Key}\n\n");
            //    foreach (var product in Category)
            //    {
            //        Console.WriteLine($"                 {product.ProductName}");
            //    }
            //}

            #endregion


            #region //Get Products in Stock Grouped by Category
            ////fluent syntax
            ////var Result = ListGenerator.ProductsList.Where(P=>P.UnitsInStock>0)
            ////                                .GroupBy(P => P.Category);
            ////Query syntax
            //var Result = from P in ListGenerator.ProductsList
            //             where P.UnitsInStock>0
            //             group P by P.Category;
            //foreach (var Category in Result)
            //{
            //    Console.WriteLine($"{Category.Key}\n\n");
            //    foreach (var product in Category)
            //    {
            //        Console.WriteLine($"                 {product.ProductName}");
            //    }
            //}
            #endregion


            #region //Get Products in Stock Grouped by Category That Contains More Than 10 Product
            //fluent syntax
            //var Result = ListGenerator.ProductsList.Where(P => P.UnitsInStock > 0)
            //                                .GroupBy(P => P.Category)
            //                                .Where(P=>P.Count()>10);
            //Query syntax
            //var Result = from P in ListGenerator.ProductsList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //             into NewCategory
            //             where NewCategory.Count()>10
            //             select NewCategory;
            //foreach (var Category in Result)
            //{
            //    Console.WriteLine($"{Category.Key}\n\n");
            //    foreach (var product in Category)
            //    {
            //        Console.WriteLine($"                 {product.ProductName}");
            //    }
            //} 
            #endregion

            #region //Get Category Name of Products in Stock That Contains More Than 10 Product and Number of Product In Each Category

            //fluent syntax
            //var Result = ListGenerator.ProductsList.Where(P => P.UnitsInStock > 0)
            //                                .GroupBy(P => P.Category)
            //                                .Where(C => C.Count() > 10)
            //                                .Select(X=>new
            //                                {
            //                                    CategoryName=X.Key,
            //                                    Count=X.Count()
            //                                });


            //Query syntax
            //var Result = from P in ListGenerator.ProductsList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //             into NewCategory
            //             where NewCategory.Count() > 10
            //             select new
            //             {
            //                 CategoryName = NewCategory. Key,
            //                                                  Count= NewCategory.Count()
            //             };

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #endregion

            #region 12.Category : Partitioning Operators

            #region Take
            ////Take => Take Number of Elements From First Only
            //var Result = ListGenerator.ProductsList.Take(10);
            //Result = ListGenerator.ProductsList.TakeLast(10); 
            #endregion

            #region Skip
            //Take => Take Number of Elements From First Only
            //var Result = ListGenerator.ProductsList.Skip(10);
            //Result = ListGenerator.ProductsList.SkipLast(10);
            #endregion

            #region TakeWhile &&  TakeWhile Index
            //Take => Take Number of Elements From First Only
            //var Result = ListGenerator.ProductsList.TakeWhile(P=>P.UnitsInStock>0);
            //List<int> list=Enumerable.Range(0,10).ToList();
            //var Result = list.TakeWhile((P,index)=>P==index);

            #endregion

            #region SkipWhile
            //var list = Enumerable.Range(1, 10);
            //var Result = list.SkipWhile(P =>P<3);

            #endregion

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            //Skip => Skip Number of Elements From First And Get Rest Of Elements
            //TakeLast => Take Number of Elements From Last Only
            //SkipLast => Skip Number of Elements From Last And Get Rest Of Elements
            //TakeWhile => Take Elements Till Element That do not Match Condition
            //SkipWhile => Skip Elements Till Element That do not Match Condition

            #endregion

            #region 13.Category : Let and Into [Valid With Query Syntax Only]
            //List<string> list = new List<string> { "Omar", "Ali", "Mohamed", "Sally","Ahmed" };
            //var Result = from N in list
            //             select Regex.Replace(N, "[AOUIEaouie]", string.Empty)
            //           into newTable
            //             where newTable.Length > 3
            //             select newTable;


            //Result= from N in list
            //        let newTable= Regex.Replace(N, "[AOUIEaouie]", string.Empty)
                      
            //        where newTable.Length > 3
            //        select newTable;
            //foreach (var name in Result)
            //{
            //    Console.WriteLine(name);
            //}



            #endregion


        }
    }
}
