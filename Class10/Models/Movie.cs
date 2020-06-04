using System;
namespace Models
{
    public class Movie
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public int TicketPrice { get; set; }
        public Movie(string title, Genre genre, int rating)
        {
            Title = title;
            Genre = genre;
            if (rating < 0 || rating > 5)
            {
                throw new Exception("The rating can not be higher then 6 or less then 1");
            }
            Rating = rating;
            TicketPrice = rating * 5;
        }
       
    }
}
