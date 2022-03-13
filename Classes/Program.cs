using System;
using Classes.Models;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region NameOfFilm

            Console.Write("Enter film name : ");
            string filmName = Console.ReadLine();

            #endregion

            #region ReleaseDateOfFilm

            Console.Write("Enter release date of film\n");

        ReEnterYear:

            int releaseYear;
            string releaseMonth;
            int releaseDay;
            string releaseDateErrorMsg = "Release date is incorrect! Please re-enter release date : ";

            try
            {
                Console.Write("Year : ");
                releaseYear = Convert.ToInt32(Console.ReadLine());
                if(releaseYear > 1800 && releaseYear < 3000)
                {

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(releaseDateErrorMsg);
                    goto ReEnterYear;
                }
                Console.Write("Month : ");
                ReEnterMonth:
                releaseMonth = Console.ReadLine();

                switch (releaseMonth)
                {
                    case "January":
                        releaseMonth = "January";
                        break;
                    case "February":
                        releaseMonth = "February";
                        break;
                    case "March":
                        releaseMonth = "March";
                        break;
                    case "April":
                        releaseMonth = "April";
                        break;
                    case "May":
                        releaseMonth = "May";
                        break;
                    case "June":
                        releaseMonth = "June";
                        break;
                    case "July":
                        releaseMonth = "July";
                        break;
                    case "August":
                        releaseMonth = "August";
                        break;
                    case "September":
                        releaseMonth = "September";
                        break;
                    case "October":
                        releaseMonth = "October";
                        break;
                    case "November":
                        releaseMonth = "November";
                        break;
                    case "December":
                        releaseMonth = "December";
                        break;
                    default:
                        Console.Clear();
                        Console.Write("Please enter month correctly (ex. April) : ");
                        goto ReEnterMonth;
                }

                Console.Write("Day : ");
                ReEnterDay:
                releaseDay = Convert.ToInt32(Console.ReadLine());

                

                if (releaseDay > 0 && releaseDay < 32)
                {

                }
                else
                {
                    Console.Clear();
                    Console.Write("Day is incorrect! Please re-enter day (ex. 20) : ");
                    goto ReEnterDay;
                }

            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine(releaseDateErrorMsg);
                goto ReEnterYear;
            }

            #endregion

            #region ImdbPointOfFilm

            Console.Write("Enter IMDB point of film : ");

            ImdbPoint:

            string imdbErrorMsg = "Please re-enter IMDB point (ex. 7,2 or 5) : ";
            double imdbPoint = 0;

            try
            {
                imdbPoint = Convert.ToDouble(Console.ReadLine());
                if (imdbPoint > 0 && imdbPoint <= 10)
                {

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(imdbErrorMsg);
                    goto ImdbPoint;
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine(imdbErrorMsg);
                goto ImdbPoint;
            }

        #endregion

            #region GenreOfFilm;

            Console.Write("Enter genre of film : ");

            ReEnterGenre:

            string genre = Console.ReadLine();
            string genreErrorMsg1 = "Unknown genre!!!\n\nGenre List >>>\nAction, Adventure, Comedy, Drama\nHistorical, Horror, Thriller, Fantasy\n";
            string genreErrorMsg2 = "Please enter genre from list : ";

            try
            {
                switch (genre)
                {
                    case "Action":
                        genre = "Action";
                        break;
                    case "Adventure":
                        genre = "Adventure";
                        break;
                    case "Comedy":
                        genre = "Comedy";
                        break;
                    case "Drama":
                        genre = "Drama";
                        break;
                    case "Fantasy":
                        genre = "Fantasy";
                        break;
                    case "Historical":
                        genre = "Historical";
                        break;
                    case "Horror":
                        genre = "Horror";
                        break;
                    case "Thriller":
                        genre = "Thriller";
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine(genreErrorMsg1);
                        Console.Write(genreErrorMsg2);
                        goto ReEnterGenre;
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine(genreErrorMsg1);
                Console.Write(genreErrorMsg2);
                goto ReEnterGenre;
            }

            #endregion

            Film film = new Film(filmName, releaseYear, releaseMonth, releaseDay, imdbPoint, genre);

            Console.Clear();
            Console.WriteLine(film.GetFilmInformation());
        }
    }
}
