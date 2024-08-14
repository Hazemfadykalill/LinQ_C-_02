namespace LinQ_C__02_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Filtration [Restriction]
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
        }
    }
}
