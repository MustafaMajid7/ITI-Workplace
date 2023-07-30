using System;
using System.Collections.Generic;
using ConsoleApp1;

namespace Testing
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region extension method
            //double x = 555.33;

            //Console.WriteLine(x.getFractionPart()); 
            #endregion

            #region anonymous class

            //var manager = new { Name = "mostafa" , Department = "Tech" , Age = 25 };

            //var manager2 = new { Name = "mahmoud", Age = 25, Department = "Tech" };


            //Console.WriteLine(manager.GetType().Name);
            //Console.WriteLine(manager2.GetType().Name); 
            #endregion

            var range1 = Enumerable.Range(0, 100);
            var range2 = Enumerable.Range(0, 100);

            List<Product> products = new List<Product>() { new Product(100,"Car",222.30),
                new Product(101, "MotorCycle", 100.60) ,new Product(102,"Lorry",500.99),
                new Product(103,"Bicycle",30.555),new Product(104,"Plane",787.111)};

            #region Filteration
            //List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,10};

            //var EvenNumbers = list.Where(i => i % 2 == 0);

            //list.AddRange(new List<int> { 12,13,14,15,16,17,18,19,20});

            //foreach (var item in EvenNumbers)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region transformation and ordering

            //var Result = products.Select(P=>new { Name = P.Name,Price = P.Price })
            //    .OrderByDescending(P=>P.Price);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region element operators

            //var result = products.Where(P => P.Price == 500.99).FirstOrDefault(products[0]);

            //var result = products.Where(P => P.Price >200).LastOrDefault(products[0]);

            //var result = products.ElementAtOrDefault(2);

            //var result = products.SingleOrDefault(P => P.Id == 104);

            //Console.WriteLine(result);

            #endregion

            #region aggregate operators

            //var result = products.Count(P=>P.Price>100);

            //var result = products.Max();

            //var result = products.Min();

            //var result = products.Sum(x => x.Price);

            //var result = products.Average(x => x.Price);

            //var result = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }.Aggregate(0, (x, y) => (x + y), result => (double)result / 10);

            //Console.WriteLine(result);

            #endregion

            #region Generators

            //var range1 = Enumerable.Range(0, 100);
            //var range2 = Enumerable.Repeat(50, 10);
            //var empty = Enumerable.Empty<Product>(); 
            #endregion

            #region Merging


            //var result = range1.Union(range2);

            //result = range1.Concat(range2);

            //result = result.Distinct();

            //result = range1.Except(range2);

            //result = range1.Intersect(range2);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region c# 8.0 features

            //Console.WriteLine(products[0]);

            //Console.WriteLine(products[^1]);

            //foreach (var item in range1[^10..^4])
            //{
            //Console.WriteLine(item);
            //}

            #endregion

            #region quantifiers

            //Console.WriteLine(products.Any(p=>p.Price>100));
            //Console.WriteLine(products.All(p => p.Price > 10));

            Console.WriteLine(range1.SequenceEqual(range2));

            #endregion

            #region Zip

            //var result = range1.Zip(range2,products);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


        }
    }
}