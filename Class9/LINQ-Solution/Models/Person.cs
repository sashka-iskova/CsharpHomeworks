using System.Collections.Generic;
using System;

namespace Models
{ 

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Song> FavoriteSong { get; set; }
        public Genre FavoriteMusicType { get; set; }

        public Person(string firstname, string lastname, int age, Genre genre)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            FavoriteMusicType = genre;
        }
        public void GetFavSongs()
        {
            if (FavoriteSong.Count == 0)
            
            Console.WriteLine("I hate music");
            else
                foreach (var item in FavoriteSong)
                {
                    Console.WriteLine(item.Title);
                }
        } 
}
}

     