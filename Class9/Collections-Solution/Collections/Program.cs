using System.Collections.Generic;
using System;
using System.Linq;
using Models;
namespace Collections
{
    class Program
    {

        static void Main(string[] args)
        {
            var product = ProductsList.GetProducts();

            List<Product> searchedByCategory = SearchByCategory(product, Category.LapTop);
            PrintProducts(searchedByCategory);

            List<Product> searchByRange = SearchByPriceRange(product, 100, 18000);
            PrintProducts(searchByRange);

            List<Product> byPartOfName = FindByPartOfName(product, "Sa");
            PrintProducts(byPartOfName);
            GetIds(product);
            GetPrice(product, 47);
            CheapestProduct(product);
            MostExpensiveProduct(product);
            AddElement(product, "Smsung Galaxy S8", 890, Category.ItEquipment);
            PrintProducts(product);
            removeElement(product, 47);
            PrintProducts(product);
        }


        //  1. Search products by category // return all products from given category
        static List<Product> SearchByCategory(List<Product> product, Category category)
        {
            return product.Where(product => product.Category == category).ToList();
        }

        // 2. Filter products by price range(from min to max) // return all products that fall in the given price range 
        static List<Product> SearchByPriceRange(List<Product> product, int min, int max)
        {
            return product.OrderByDescending(item => item.Price).Where(element => element.Price >= min && element.Price <= max).ToList();
        }

        //3. Find products by part of name // get all products that consist the part in their names
        static List<Product> FindByPartOfName (List<Product> product, string str)
        {
            return product.Where(product => product.Name.Contains(str)).ToList();
        }

        //4. Get only products ids // return only the ids of the products
        static void GetIds(List<Product> product)
        {
            product.ForEach(product => Console.WriteLine(product.Id));
        }

        //5. Get product price // get the price of the product - give the id as parameter
        static void GetPrice(List<Product> product, int id)
        {
            List<Product> x = product.Where(product => product.Id == id).ToList();
            x.ForEach(product => Console.WriteLine(product.Price));
        }

        //6. Get cheapest product // return the cheapest product
        static void CheapestProduct(List<Product> product)
        {
            Product x = product.OrderBy(product => product.Price).FirstOrDefault();
            Console.WriteLine(x.GetInfo());
        }


        //7. Get most expensive product // return the most expensive one
        static void MostExpensiveProduct(List<Product> product)
        {
            Product x = product.OrderBy(product => product.Price).LastOrDefault();
            //Select(product => product.Name).LastOrDefault().ToList();
            Console.WriteLine(x.GetInfo());
        }
      
        //8. Add product // create method to add product to the list of products
        static void AddElement(List<Product> productList, string x, int y, Category category)
        {
            Product productToBeAdded = new Product() {Name = x, Price = y, Category = category};
            productList.Add(productToBeAdded);
        }

        // 9. Remove product // and a method to remove it - use id as parameter
        static bool removeElement(List<Product> product, int id)
         {
             Product x = product.Where(prod => prod.Id == id).FirstOrDefault();
           return  product.Remove(x);
         }


        static void PrintProducts(List<Product> product)
        {
            Console.WriteLine("----------------------------------------------");
            product.ForEach(product => Console.WriteLine(product.GetInfo()));
        }
      
        static void PrintProducts(List<string> product)
        {
            Console.WriteLine("----------------------------------------------");
            product.ForEach(product => Console.WriteLine());
        }
       

    }
}
