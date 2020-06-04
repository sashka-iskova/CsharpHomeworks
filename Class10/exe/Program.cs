    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    namespace exe
    {
        class Program
        {
            static void Main(string[] args)
            {
                Cinema cineplexx = new Cinema("Cineplexx");
                Cinema babylon = new Cinema("Babylon");


                Movie movie1 = new Movie("The Mountain II", Genre.Action, 5);
                Movie movie2 = new Movie("Seven Samurai", Genre.Action, 2);
                Movie movie3 = new Movie("Big Hero 6", Genre.Action, 1);
                Movie movie4 = new Movie("The Man from Nowhere", Genre.Drama, 4);
                Movie movie5 = new Movie("Gladiator", Genre.Comedy, 3);
                Movie movie6 = new Movie("Avengers: Endgame", Genre.SciFi, 5);
                Movie movie7 = new Movie("Kung Fu Hustle", Genre.Horror, 2);
                Movie movie8 = new Movie("Iron Man", Genre.Horror, 4);
                Movie movie9 = new Movie("The Dark Knight", Genre.Comedy, 3);
                Movie movie10 = new Movie("13 Assassins", Genre.Comedy, 3);

                Movie movie11 = new Movie("Parasite", Genre.Drama, 5);
                Movie movie12 = new Movie("Black Panther", Genre.SciFi, 4);
                Movie movie13 = new Movie("The Irishman", Genre.Action, 2);
                Movie movie14 = new Movie("Captain Marvel", Genre.SciFi, 1);
                Movie movie15 = new Movie("Frozen II", Genre.Comedy, 2);
                Movie movie16 = new Movie("Avengers: Infinity War", Genre.SciFi, 5);
                Movie movie17 = new Movie("Once uppon a time in Hollywood", Genre.Drama, 5);
                Movie movie18 = new Movie("Inception", Genre.Horror, 5);
                Movie movie19 = new Movie("Psycho", Genre.Drama, 2);
                Movie movie20 = new Movie("Taxi driver", Genre.Action, 1);

                cineplexx.AddMovie(movie1);
                cineplexx.AddMovie(movie2);
                cineplexx.AddMovie(movie3);
                cineplexx.AddMovie(movie4);
                cineplexx.AddMovie(movie5);
                cineplexx.AddMovie(movie6);
                cineplexx.AddMovie(movie7);
                cineplexx.AddMovie(movie8);
                cineplexx.AddMovie(movie9);
                cineplexx.AddMovie(movie10);

                babylon.AddMovie(movie11);
                babylon.AddMovie(movie12);
                babylon.AddMovie(movie13);
                babylon.AddMovie(movie14);
                babylon.AddMovie(movie15);
                babylon.AddMovie(movie16);
                babylon.AddMovie(movie17);
                babylon.AddMovie(movie18);
                babylon.AddMovie(movie19);
                babylon.AddMovie(movie20);
                Console.WriteLine("Welcome");
                Console.WriteLine("Please enter 1 for Cineplexx or 2 for Babylon");
                string answer1 = Console.ReadLine();
                int answer1toInt = 0;
                Int32.TryParse(answer1, out answer1toInt);
                if (answer1toInt == 1)
                {
                    Console.WriteLine("Welcome to Cineplexx");
                    Console.WriteLine("Please enter 1 to see all movies or 2 to filter by Genre");
                    string answer2 = Console.ReadLine();
                    int answer2toInt = 0;
                    Int32.TryParse(answer2, out answer2toInt);
                    if (answer2toInt == 1)
                    {
                        MovieTitles(cineplexx.ListOfMovies);
                        Console.WriteLine("Please enter the movie you would like to watch");
                        string chosenMovie = Console.ReadLine();
                        Movie movie = cineplexx.ListOfMovies.SingleOrDefault(movie => movie.Title == chosenMovie);
                        if (movie == null)
                        {
                            throw new Exception("Sorry that movie doesn't exist in our cinema");
                        }
                        Console.WriteLine(cineplexx.MoviePlaying(movie));

                }
                    else if (answer2toInt == 2)
                    {
                        Console.WriteLine("Please enter a genre to filter through");
                        string userInputGenre = Console.ReadLine();
                        Genre genre;
                        switch (userInputGenre.ToLower())
                        {
                            case "comedy":
                                genre = Genre.Comedy;
                                break;
                            case "horror":
                                genre = Genre.Horror;
                                break;
                            case "action":
                                genre = Genre.Action;
                                break;
                            case "drama":
                                genre = Genre.Drama;
                                break;
                            default:
                            case "scifi":
                                genre = Genre.SciFi;
                                break;
                        }
                        List<Movie> fillteredMovies = FilterByGenre(genre, cineplexx.ListOfMovies);
                        MovieTitles(fillteredMovies);
                        string chosenMovie = Console.ReadLine();
                        Movie movie = fillteredMovies.SingleOrDefault(movie => movie.Title == chosenMovie);
                        if (movie == null)
                        {
                            throw new Exception("Sorry that movie doesn't exist in our cinema");
                        }
                        Console.WriteLine(cineplexx.MoviePlaying(movie));
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                else if (answer1toInt == 2)
                {
                    
                    Console.WriteLine("Welcome to Babylon");
                    Console.WriteLine("Please enter 1 to see all movies or 2 to filter by Genre");
                    string answer2 = Console.ReadLine();
                    int answer2toInt = 0;
                    Int32.TryParse(answer2, out answer2toInt);
                    if (answer2toInt == 1)
                    {
                    MovieTitles(babylon.ListOfMovies);
                    Console.WriteLine("Please enter the movie you would like to watch");
                    string chosenMovie = Console.ReadLine();
                    Movie movie = babylon.ListOfMovies.SingleOrDefault(movie => movie.Title == chosenMovie);
                    if (movie == null)
                    {
                        throw new Exception("Sorry that movie doesn't exist in our cinema");
                    }
                    Console.WriteLine(babylon.MoviePlaying(movie));
                }
                    else if (answer2toInt == 2)
                    {
                        Console.WriteLine("Please enter a genre to filter through");
                        string userInputGenre = Console.ReadLine();
                        Genre genre;
                        switch (userInputGenre.ToLower())
                        {
                            case "comedy":
                                genre = Genre.Comedy;
                                break;
                            case "horror":
                                genre = Genre.Horror;
                                break;
                            case "action":
                                genre = Genre.Action;
                                break;
                            case "drama":
                                genre = Genre.Drama;
                                break;
                            default:
                            case "scifi":
                                genre = Genre.SciFi;
                                break;
                        }
                        List<Movie> fillteredMovies = FilterByGenre(genre, babylon.ListOfMovies);
                        MovieTitles(fillteredMovies);
                        string chosenMovie = Console.ReadLine();
                        Movie movie = fillteredMovies.SingleOrDefault(movie => movie.Title == chosenMovie);
                        if (movie == null)
                        {
                            throw new Exception("Sorry that movie doesn't exist in our cinema");
                        }
                        Console.WriteLine(cineplexx.MoviePlaying(movie));
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
        }
                static void MovieTitles(List<Movie> movieList)
                {
                    movieList.ForEach(movie => Console.WriteLine(movie.Title));
                }
                static List<Movie> FilterByGenre(Genre genre, List<Movie> movies)
                {
                    return movies.Where(movie => movie.Genre == genre).ToList();

                }

    }
    }

    
