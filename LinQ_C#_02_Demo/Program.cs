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
        }
    }
}
