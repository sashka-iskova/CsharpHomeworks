using System;
namespace Models
{
    public class Product
    {
        public int Id { get; set; } = new Random().Next(1,50);
        public string Name { get; set; }
        public int Price { get; set; }
        public Category Category { get; set; }

        public string GetInfo()
        {
            return $"#{Id} {Name} Price: {Price}  {Category}.";
        }


    }
}
