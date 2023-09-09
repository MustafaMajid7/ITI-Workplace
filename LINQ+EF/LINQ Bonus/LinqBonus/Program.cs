using System.Collections.Immutable;
using System.Xml.Linq;

namespace LinqBonus
{
    public class Customer
    {
        public Customer(string customerID, string companyName)
        {
            CustomerID = customerID;
            CompanyName = companyName;
            Orders = new Order[10];
        }

        public Customer() { }

        public string CustomerID;
        public string CompanyName;
        public string Address;
        public string City;
        public string Region;
        public string PostalCode;
        public string Country;
        public string Phone;
        public string Fax;
        public Order[] Orders;


        public override string ToString()
        {
            return $"{CustomerID},{CompanyName},{Address}, {City} , {Region}, {PostalCode} , {Country} , {Phone} , {Fax}";
        }
    }

    public class Order
    {
        public Order(int orderID, DateTime orderDate, decimal total)
        {
            OrderID = orderID;
            OrderDate = orderDate;
            Total = total;
        }

        public Order() { }

        public int OrderID;
        public DateTime OrderDate;
        public decimal Total;

        public override string ToString()
        {
            return $"Order Id: {OrderID},Date: {OrderDate.ToShortTimeString()},Total: {Total}";
        }
    }

    public class Product
    {
        public Int64 ProductID { get; set; }
        public String ProductName { get; set; }
        public String Category { get; set; }
        public Decimal UnitPrice { get; set; }
        public Int32 UnitsInStock { get; set; }

        public override string ToString()
        {
            return $"ProductID:{ProductID}, ProductName:{ProductName}, Category{Category}, UnitPrice:{UnitPrice}, UnitsInStock:{UnitsInStock}";
        }
    }


    public static class ListGenerators
    {
        public static List<Customer> CustomerList;
        public static List<Product> ProductList;
        static ListGenerators()
        {
            #region CustomerList
            CustomerList = (
                from e in XDocument.Load("Customers.xml").
                          Root.Elements("customer")
                select new Customer
                {
                    CustomerID = (string)e.Element("id"),
                    CompanyName = (string)e.Element("name"),
                    Address = (string)e.Element("address"),
                    City = (string)e.Element("city"),
                    Region = (string)e.Element("region"),
                    PostalCode = (string)e.Element("postalcode"),
                    Country = (string)e.Element("country"),
                    Phone = (string)e.Element("phone"),
                    Fax = (string)e.Element("fax"),
                    Orders = (
                        from o in e.Elements("orders").Elements("order")
                        select new Order
                        {
                            OrderID = (int)o.Element("id"),
                            OrderDate = (DateTime)o.Element("orderdate"),
                            Total = (decimal)o.Element("total")
                        })
                        .ToArray()
                }
                ).ToList();
            #endregion

            #region ProductList
            ProductList = new List<Product>() {
              new Product{ ProductID = 1, ProductName = "Chai", Category = "Beverages",
                UnitPrice = 18.0000M, UnitsInStock = 39 },
              new Product{ ProductID = 2, ProductName = "Chang", Category = "Beverages",
                UnitPrice = 19.0000M, UnitsInStock = 17 },
              new Product{ ProductID = 3, ProductName = "Aniseed Syrup", Category = "Condiments",
                UnitPrice = 10.0000M, UnitsInStock = 13 },
              new Product{ ProductID = 4, ProductName = "Chef Anton's Cajun Seasoning", Category = "Condiments",
                UnitPrice = 22.0000M, UnitsInStock = 53 },
              new Product{ ProductID = 5, ProductName = "Chef Anton's Gumbo Mix", Category = "Condiments",
                UnitPrice = 21.3500M, UnitsInStock = 0 },
              new Product{ ProductID = 6, ProductName = "Grandma's Boysenberry Spread", Category = "Condiments",
                UnitPrice = 25.0000M, UnitsInStock = 120 },
              new Product{ ProductID = 7, ProductName = "Uncle Bob's Organic Dried Pears", Category = "Produce",
                UnitPrice = 30.0000M, UnitsInStock = 15 },
              new Product{ ProductID = 8, ProductName = "Northwoods Cranberry Sauce", Category = "Condiments",
                UnitPrice = 40.0000M, UnitsInStock = 6 },
              new Product{ ProductID = 9, ProductName = "Mishi Kobe Niku", Category = "Meat/Poultry",
                UnitPrice = 97.0000M, UnitsInStock = 29 },
              new Product{ ProductID = 10, ProductName = "Ikura", Category = "Seafood",
                UnitPrice = 31.0000M, UnitsInStock = 31 },
              new Product{ ProductID = 11, ProductName = "Queso Cabrales", Category = "Dairy Products",
                UnitPrice = 21.0000M, UnitsInStock = 22 },
              new Product{ ProductID = 12, ProductName = "Queso Manchego La Pastora", Category = "Dairy Products",
                UnitPrice = 38.0000M, UnitsInStock = 86 },
              new Product() { ProductID = 13, ProductName = "Konbu", Category = "Seafood",
                UnitPrice = 6.0000M, UnitsInStock = 24 },
              new Product() { ProductID = 14, ProductName = "Tofu", Category = "Produce",
                UnitPrice = 23.2500M, UnitsInStock = 35 },
              new Product() { ProductID = 15, ProductName = "Genen Shouyu", Category = "Condiments",
                UnitPrice = 15.5000M, UnitsInStock = 39 },
              new Product() { ProductID = 16, ProductName = "Pavlova", Category = "Confections",
                UnitPrice = 17.4500M, UnitsInStock = 29 },
              new Product() { ProductID = 17, ProductName = "Alice Mutton", Category = "Meat/Poultry",
                UnitPrice = 39.0000M, UnitsInStock = 0 },
              new Product() { ProductID = 18, ProductName = "Carnarvon Tigers", Category = "Seafood",
                UnitPrice = 62.5000M, UnitsInStock = 42 },
              new Product() { ProductID = 19, ProductName = "Teatime Chocolate Biscuits", Category = "Confections",
                UnitPrice = 9.2000M, UnitsInStock = 25 },
              new Product() { ProductID = 20, ProductName = "Sir Rodney's Marmalade", Category = "Confections",
                UnitPrice = 81.0000M, UnitsInStock = 40 },
              new Product() { ProductID = 21, ProductName = "Sir Rodney's Scones", Category = "Confections",
                UnitPrice = 10.0000M, UnitsInStock = 3 },
              new Product() { ProductID = 22, ProductName = "Gustaf's Knäckebröd", Category = "Grains/Cereals",
                UnitPrice = 21.0000M, UnitsInStock = 104 },
              new Product() { ProductID = 23, ProductName = "Tunnbröd", Category = "Grains/Cereals",
                UnitPrice = 9.0000M, UnitsInStock = 61 },
              new Product() { ProductID = 24, ProductName = "Guaraná Fantástica", Category = "Beverages",
                UnitPrice = 4.5000M, UnitsInStock = 20 },
              new Product() { ProductID = 25, ProductName = "NuNuCa Nuß-Nougat-Creme", Category = "Confections",
                UnitPrice = 14.0000M, UnitsInStock = 76 },
              new Product() { ProductID = 26, ProductName = "Gumbär Gummibärchen", Category = "Confections",
                UnitPrice = 31.2300M, UnitsInStock = 15 },
              new Product() { ProductID = 27, ProductName = "Schoggi Schokolade", Category = "Confections",
                UnitPrice = 43.9000M, UnitsInStock = 49 },
              new Product() { ProductID = 28, ProductName = "Rössle Sauerkraut", Category = "Produce",
                UnitPrice = 45.6000M, UnitsInStock = 26 },
              new Product() { ProductID = 29, ProductName = "Thüringer Rostbratwurst", Category = "Meat/Poultry",
                UnitPrice = 123.7900M, UnitsInStock = 0 },
              new Product() { ProductID = 30, ProductName = "Nord-Ost Matjeshering", Category = "Seafood",
                UnitPrice = 25.8900M, UnitsInStock = 10 },
              new Product() { ProductID = 31, ProductName = "Gorgonzola Telino", Category = "Dairy Products",
                UnitPrice = 12.5000M, UnitsInStock = 0 },
              new Product() { ProductID = 32, ProductName = "Mascarpone Fabioli", Category = "Dairy Products",
                UnitPrice = 32.0000M, UnitsInStock = 9 },
              new Product() { ProductID = 33, ProductName = "Geitost", Category = "Dairy Products",
                UnitPrice = 2.5000M, UnitsInStock = 112 },
              new Product() { ProductID = 34, ProductName = "Sasquatch Ale", Category = "Beverages",
                UnitPrice = 14.0000M, UnitsInStock = 111 },
              new Product() { ProductID = 35, ProductName = "Steeleye Stout", Category = "Beverages",
                UnitPrice = 18.0000M, UnitsInStock = 20 },
              new Product() { ProductID = 36, ProductName = "Inlagd Sill", Category = "Seafood",
                UnitPrice = 19.0000M, UnitsInStock = 112 },
              new Product() { ProductID = 37, ProductName = "Gravad lax", Category = "Seafood",
                UnitPrice = 26.0000M, UnitsInStock = 11 },
              new Product() { ProductID = 38, ProductName = "Côte de Blaye", Category = "Beverages",
                UnitPrice = 263.5000M, UnitsInStock = 17 },
              new Product() { ProductID = 39, ProductName = "Chartreuse verte", Category = "Beverages",
                UnitPrice = 18.0000M, UnitsInStock = 69 },
              new Product() { ProductID = 40, ProductName = "Boston Crab Meat", Category = "Seafood",
                UnitPrice = 18.4000M, UnitsInStock = 123 },
              new Product() { ProductID = 41, ProductName = "Jack's New England Clam Chowder", Category = "Seafood",
                UnitPrice = 9.6500M, UnitsInStock = 85 },
              new Product() { ProductID = 42, ProductName = "Singaporean Hokkien Fried Mee", Category = "Grains/Cereals",
                UnitPrice = 14.0000M, UnitsInStock = 26 },
              new Product() { ProductID = 43, ProductName = "Ipoh Coffee", Category = "Beverages",
                UnitPrice = 46.0000M, UnitsInStock = 17 },
              new Product() { ProductID = 44, ProductName = "Gula Malacca", Category = "Condiments",
                UnitPrice = 19.4500M, UnitsInStock = 27 },
              new Product() { ProductID = 45, ProductName = "Rogede sild", Category = "Seafood",
                UnitPrice = 9.5000M, UnitsInStock = 5 },
              new Product() { ProductID = 46, ProductName = "Spegesild", Category = "Seafood",
                UnitPrice = 12.0000M, UnitsInStock = 95 },
              new Product() { ProductID = 47, ProductName = "Zaanse koeken", Category = "Confections",
                UnitPrice = 9.5000M, UnitsInStock = 36 },
              new Product() { ProductID = 48, ProductName = "Chocolade", Category = "Confections",
                UnitPrice = 12.7500M, UnitsInStock = 15 },
              new Product() { ProductID = 49, ProductName = "Maxilaku", Category = "Confections",
                UnitPrice = 20.0000M, UnitsInStock = 10 },
              new Product() { ProductID = 50, ProductName = "Valkoinen suklaa", Category = "Confections",
                UnitPrice = 16.2500M, UnitsInStock = 65 },
              new Product() { ProductID = 51, ProductName = "Manjimup Dried Apples", Category = "Produce",
                UnitPrice = 53.0000M, UnitsInStock = 20 },
              new Product() { ProductID = 52, ProductName = "Filo Mix", Category = "Grains/Cereals",
                UnitPrice = 7.0000M, UnitsInStock = 38 },
              new Product() { ProductID = 53, ProductName = "Perth Pasties", Category = "Meat/Poultry",
                UnitPrice = 32.8000M, UnitsInStock = 0 },
              new Product() { ProductID = 54, ProductName = "Tourtière", Category = "Meat/Poultry",
                UnitPrice = 7.4500M, UnitsInStock = 21 },
              new Product() { ProductID = 55, ProductName = "Pâté chinois", Category = "Meat/Poultry",
                UnitPrice = 24.0000M, UnitsInStock = 115 },
              new Product() { ProductID = 56, ProductName = "Gnocchi di nonna Alice", Category = "Grains/Cereals",
                UnitPrice = 38.0000M, UnitsInStock = 21 },
              new Product() { ProductID = 57, ProductName = "Ravioli Angelo", Category = "Grains/Cereals",
                UnitPrice = 19.5000M, UnitsInStock = 36 },
              new Product() { ProductID = 58, ProductName = "Escargots de Bourgogne", Category = "Seafood",
                UnitPrice = 13.2500M, UnitsInStock = 62 },
              new Product() { ProductID = 59, ProductName = "Raclette Courdavault", Category = "Dairy Products",
                UnitPrice = 55.0000M, UnitsInStock = 79 },
              new Product() { ProductID = 60, ProductName = "Camembert Pierrot", Category = "Dairy Products",
                UnitPrice = 34.0000M, UnitsInStock = 19 },
              new Product() { ProductID = 61, ProductName = "Sirop d'érable", Category = "Condiments",
                UnitPrice = 28.5000M, UnitsInStock = 113 },
              new Product() { ProductID = 62, ProductName = "Tarte au sucre", Category = "Confections",
                UnitPrice = 49.3000M, UnitsInStock = 17 },
              new Product() { ProductID = 63, ProductName = "Vegie-spread", Category = "Condiments",
                UnitPrice = 43.9000M, UnitsInStock = 24 },
              new Product() { ProductID = 64, ProductName = "Wimmers gute Semmelknödel", Category = "Grains/Cereals",
                UnitPrice = 33.2500M, UnitsInStock = 22 },
              new Product() { ProductID = 65, ProductName = "Louisiana Fiery Hot Pepper Sauce", Category = "Condiments",
                UnitPrice = 21.0500M, UnitsInStock = 76 },
              new Product() { ProductID = 66, ProductName = "Louisiana Hot Spiced Okra", Category = "Condiments",
                UnitPrice = 17.0000M, UnitsInStock = 4 },
              new Product() { ProductID = 67, ProductName = "Laughing Lumberjack Lager", Category = "Beverages",
                UnitPrice = 14.0000M, UnitsInStock = 52 },
              new Product() { ProductID = 68, ProductName = "Scottish Longbreads", Category = "Confections",
                UnitPrice = 12.5000M, UnitsInStock = 6 },
              new Product() { ProductID = 69, ProductName = "Gudbrandsdalsost", Category = "Dairy Products",
                UnitPrice = 36.0000M, UnitsInStock = 26 },
              new Product() { ProductID = 70, ProductName = "Outback Lager", Category = "Beverages",
                UnitPrice = 15.0000M, UnitsInStock = 15 },
              new Product() { ProductID = 71, ProductName = "Flotemysost", Category = "Dairy Products",
                UnitPrice = 21.5000M, UnitsInStock = 26 },
              new Product() { ProductID = 72, ProductName = "Mozzarella di Giovanni", Category = "Dairy Products",
                UnitPrice = 34.8000M, UnitsInStock = 14 },
              new Product() { ProductID = 73, ProductName = "Röd Kaviar", Category = "Seafood",
                UnitPrice = 15.0000M, UnitsInStock = 101 },
              new Product() { ProductID = 74, ProductName = "Longlife Tofu", Category = "Produce",
                UnitPrice = 10.0000M, UnitsInStock = 4 },
              new Product() { ProductID = 75, ProductName = "Rhönbräu Klosterbier", Category = "Beverages",
                UnitPrice = 7.7500M, UnitsInStock = 125 },
              new Product() { ProductID = 76, ProductName = "Lakkalikööri", Category = "Beverages",
                UnitPrice = 18.0000M, UnitsInStock = 57 },
              new Product() { ProductID = 77, ProductName = "Original Frankfurter grüne Soße", Category = "Condiments",
                UnitPrice = 13.0000M, UnitsInStock = 32 }
            };
            #endregion
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] lines = File.ReadAllLines(@"E:\ITI\Month 3\week 1\5-9-2023 LINQ\Lab Bonus\Assignment Files\dictionary_english.txt");

            #region Task Restriction

            //foreach (var item in ListGenerators.ProductList.Where(x => x.UnitsInStock == 0))
            //{
            //    Console.WriteLine(item);
            //}

            //---------------------------------------------------------------------------------------

            //foreach (var item in ListGenerators.ProductList.Where(x => x.UnitsInStock > 0 && x.UnitPrice > 3.00m))
            //{
            //    Console.WriteLine(item);
            //}

            //---------------------------------------------------------------------------------------

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //int index = 0;
            //foreach (var item in Arr)
            //{
            //    if(item.Length <index++) {
            //        Console.WriteLine(item);
            //    }

            //}

            #endregion

            #region Task Element

            //Console.WriteLine(ListGenerators.ProductList.Where(x => x.UnitsInStock == 0).First());

            //---------------------------------------------------------------------------------------

            //Console.WriteLine(ListGenerators.ProductList.Where(x => x.UnitPrice>1000).FirstOrDefault());

            //---------------------------------------------------------------------------------------

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //Console.WriteLine(Arr.Where(x=>x>5).Take(2).Last());

            #endregion

            #region Task Set

            //foreach (var item in ListGenerators.ProductList.Select(x => x.Category).Distinct())
            //{
            //    Console.WriteLine(item);
            //}

            //---------------------------------------------------------------------------------------

            //var products = ListGenerators.ProductList.Select(x => x.ProductName[0]).Distinct().ToList();
            //var customers = ListGenerators.CustomerList.Select(x => x.CompanyName[0]).Distinct().ToList();

            //foreach (var item in products.Union(customers).Distinct().Order())
            //{
            //    Console.WriteLine(item);
            //}

            //---------------------------------------------------------------------------------------

            //var products = ListGenerators.ProductList.Select(x => x.ProductName[0]).Distinct().ToList();
            //var customers = ListGenerators.CustomerList.Select(x => x.CompanyName[0]).Distinct().ToList();

            //foreach (var item in products.Intersect(customers))
            //{
            //    Console.WriteLine(item);
            //}

            //---------------------------------------------------------------------------------------

            //var products = ListGenerators.ProductList.Select(x => x.ProductName[0]).Distinct().ToList();
            //var customers = ListGenerators.CustomerList.Select(x => x.CompanyName[0]).Distinct().ToList();

            //foreach (var item in products.Except(customers))
            //{
            //    Console.WriteLine(item);
            //}

            //---------------------------------------------------------------------------------------


            //var products = ListGenerators.ProductList.Select(x => x.ProductName.Substring(x.ProductName.Length - 3)).ToList();
            //var customers = ListGenerators.CustomerList.Select(x => x.CompanyName.Substring(x.CompanyName.Length - 3)).ToList();

            //foreach (var item in products.Union(customers))
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Task Aggregate

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //Console.WriteLine(Arr.Where(x=>x%2==1).Count());

            //---------------------------------------------------------------------------------------

            //foreach (var item in ListGenerators.CustomerList.Select(x=>new {x.CompanyName,noOfOrders = x.Orders.Length}))
            //{
            //    Console.WriteLine(item);
            //}

            //---------------------------------------------------------------------------------------

            //foreach (var item in ListGenerators.ProductList.GroupBy(x=>x.Category))
            //{
            //    Console.WriteLine($"{item.Key} has {item.Count()} products");
            //}

            //---------------------------------------------------------------------------------------

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //Console.WriteLine(Arr.Sum());

            //---------------------------------------------------------------------------------------

            //Console.WriteLine(lines.Select(x => x.Length).Sum());

            //---------------------------------------------------------------------------------------

            //foreach (var item in ListGenerators.ProductList.GroupBy(x => x.Category))
            //{
            //    Console.WriteLine($"{item.Key} has {item.Select(x => x.UnitsInStock).Sum()} units in stocks");
            //}

            //---------------------------------------------------------------------------------------

            //Console.WriteLine(lines.Select(x => x.Length).Min());

            //---------------------------------------------------------------------------------------

            //foreach (var item in ListGenerators.ProductList.GroupBy(x => x.Category))
            //{
            //    Console.WriteLine($"the lowest price in {item.Key} is {item.Select(x => x.UnitPrice).Min()}$");
            //}

            //Console.WriteLine("-----------------------------------------------------------");

            //foreach (var item in from g in ListGenerators.ProductList
            //                     group g by g.Category into x
            //                     let cats = new {catgoryName=x.Key,minPrice=x.Select(i =>i.UnitPrice).Min()}
            //                     select cats)
            //{
            //    Console.WriteLine($"the lowest price in {item.catgoryName} is {item.minPrice}$");
            //}

            //---------------------------------------------------------------------------------------

            //Console.WriteLine(lines.Select(x => x.Length).Max());

            //---------------------------------------------------------------------------------------

            //foreach (var item in ListGenerators.ProductList.GroupBy(x => x.Category))
            //{
            //    Console.WriteLine($"the lowest price in {item.Key} is {item.Select(x => x.UnitPrice).Max()}$");
            //}

            //---------------------------------------------------------------------------------------

            //foreach (var item in ListGenerators.ProductList.GroupBy(x => x.Category))
            //{
            //    var maxPrice = item.Select(x => x.UnitPrice).Max();
            //    var expensiveProducts = item.Where(x => x.UnitPrice == maxPrice).ToList();
            //    Console.Write($"{item.Key}'s expensive products are [ ");
            //    foreach (var item1 in expensiveProducts)
            //    {
            //        Console.Write($"{item1.ProductName} ");
            //    }
            //    Console.WriteLine("].");
            //}

            //---------------------------------------------------------------------------------------

            //Console.WriteLine(lines.Select(x => x.Length).Average());

            //---------------------------------------------------------------------------------------

            //foreach (var item in ListGenerators.ProductList.GroupBy(x => x.Category))
            //{
            //    Console.WriteLine(item.Select(x => x.UnitPrice).Average());
            //}

            #endregion

            #region Task Ordering

            //foreach (var item in ListGenerators.ProductList.OrderBy(x=>x.ProductName))
            //{
            //    Console.WriteLine(item);
            //}

            //---------------------------------------------------------------------------------------

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //foreach (var item in Arr.OrderBy(x => x.ToLower()))
            //{
            //    Console.WriteLine(item);
            //}

            //---------------------------------------------------------------------------------------

            //foreach (var item in ListGenerators.ProductList.OrderBy(x => x.UnitsInStock))
            //{
            //    Console.WriteLine(item);
            //}

            //---------------------------------------------------------------------------------------

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //foreach (var item in Arr.OrderBy(x => x.Length).ThenBy(x=>x))
            //{
            //    Console.WriteLine(item);
            //}

            //---------------------------------------------------------------------------------------

            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //foreach (var item in words.OrderBy(x => x.Length).ThenBy(x => x.ToLower()))
            //{
            //    Console.WriteLine(item);
            //}

            //---------------------------------------------------------------------------------------

            //foreach (var item in ListGenerators.ProductList.OrderBy(x => x.Category).
            //    ThenByDescending(x => x.UnitPrice))
            //{
            //    Console.WriteLine(item);
            //}

            //---------------------------------------------------------------------------------------

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //foreach (var item in Arr.OrderBy(x => x.Length).ThenByDescending(x => x.ToLower()))
            //{
            //    Console.WriteLine(item);
            //}

            //---------------------------------------------------------------------------------------

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //foreach (var item in Arr.Where(x => x[1] =='i').Reverse())
            //{
            //    Console.WriteLine(item);
            //}

            //---------------------------------------------------------------------------------------

            #endregion

            #region Task Partitioning

            //foreach (var item in ListGenerators.CustomerList.Where(x => x.Region == "WA").Take(3))
            //{
            //    Console.WriteLine(item);
            //}

            //---------------------------------------------------------------------------------------

            //foreach (var item in ListGenerators.CustomerList.Where(x => x.Region == "WA").Skip(2))
            //{
            //    Console.WriteLine(item);
            //}

            //---------------------------------------------------------------------------------------

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int index = 0;
            //foreach (var item in numbers.TakeWhile(num => num >= index++))
            //{
            //    Console.WriteLine(item);
            //}

            //---------------------------------------------------------------------------------------

            //foreach (var item in numbers.SkipWhile(num => num %3!=0))
            //{
            //    Console.WriteLine(item);
            //}

            //---------------------------------------------------------------------------------------

            //foreach (var item in numbers.SkipWhile(num => num >=index++))
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Task Projection

            //foreach (var item in ListGenerators.ProductList.Select(x=>x.ProductName))
            //{
            //    Console.WriteLine(item);
            //}

            //---------------------------------------------------------------------------------------

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //foreach (var item in words.Select(x => new {upperCase = x.ToUpper()
            //        ,lowerCase = x.ToLower()}))
            //{
            //    Console.WriteLine(item);
            //}

            //---------------------------------------------------------------------------------------

            //foreach (var item in ListGenerators.ProductList.Select(x => new {x.ProductName,
            //        x.Category,Price = x.UnitPrice}))
            //{
            //    Console.WriteLine(item);
            //}

            //---------------------------------------------------------------------------------------

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //foreach (var item in Arr.Select((value,index) => new {value,matched = value == index }))
            //{
            //    Console.WriteLine(item.value+":"+item.matched);
            //}

            //---------------------------------------------------------------------------------------

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };

            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //foreach (var item in from n in numbersA
            //                     from b in numbersB
            //                     where n<b
            //                     select new {output = $"{n} is less than {b}" })
            //{
            //    Console.WriteLine(item.output);
            //}

            //---------------------------------------------------------------------------------------

            //foreach (var item in ListGenerators.CustomerList.SelectMany(cust =>cust.Orders)
            //    .Where(x=>x.Total<500.00m))
            //{
            //    Console.WriteLine(item);
            //}

            //---------------------------------------------------------------------------------------

            //foreach (var item in ListGenerators.CustomerList.SelectMany(cust => cust.Orders)
            //    .Where(x => x.OrderDate.Year >= 1998))
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region Task Quantifiers

            //Console.WriteLine(lines.Any(x => x.Contains("ei")));

            //---------------------------------------------------------------------------------------


            //var groups = (from cat in ListGenerators.ProductList.GroupBy(x => x.Category)
            //              from prd in cat
            //              where prd.UnitsInStock == 0
            //              select cat).Distinct();



            //foreach (var item in groups)
            //{
            //    Console.WriteLine(item.Key);

            //---------------------------------------------------------------------------------------



            #endregion

            #region Task Grouping

            //IEnumerable<int> numbers = Enumerable.Range(0, 15);

            //foreach (var item in numbers.GroupBy(x=>x%5))
            //{
            //    Console.WriteLine($"Numbers with a remainder of {item.Key} when divided by 5:");
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1);
            //    }
            //    Console.WriteLine();
            //}

            //---------------------------------------------------------------------------------------

            //foreach (var line in lines.GroupBy(x => x[0].ToString()))
            //{
            //    Console.WriteLine($"{line.Key}");
            //    foreach (var item in line)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //---------------------------------------------------------------------------------------

            string[] Arr = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " };

            var orderGroups = Arr.GroupBy(
                        w => w.Trim(),
                        new CustomComparer()
                        );

            foreach (var v in orderGroups) { 
            
                Console.WriteLine("...");
                foreach (var item in v)
                {
                    Console.WriteLine(item.Trim());
                }

            }

            #endregion

        }
        public class CustomComparer : IEqualityComparer<string>
        {
            public bool Equals(string x, string y)
            {
                return getCanonicalString(x) == getCanonicalString(y);
            }

            public int GetHashCode(string obj)
            {
                return getCanonicalString(obj).GetHashCode();
            }

            private string getCanonicalString(string word)
            {
                char[] wordChars = word.ToCharArray();
                Array.Sort<char>(wordChars);
                return new string(wordChars);
            }
        }
    }
}
