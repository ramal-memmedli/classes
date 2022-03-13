using System;

namespace Classes.Models
{
    public class Film
    {
        /// <summary>
        /// Returns name of film
        /// </summary>
        /// <param name="filmName">this is the name of film</param>
        public Film(string filmName)
        {
            this.filmName = filmName;
        }

        /// <summary>
        /// Returns name and release date of film
        /// </summary>
        /// <param name="filmName">this is name of film</param>
        /// <param name="releaseYear">this is release year of film</param>
        /// <param name="releaseMonth">this is release month of film</param>
        /// <param name="releaseDay">this is release day of film</param>
        public Film(string filmName, int releaseYear, string releaseMonth, int releaseDay) : this(filmName)
        {
            this.releaseYear = releaseYear;
            this.releaseMonth = releaseMonth;
            this.releaseDay = releaseDay;
        }

        /// <summary>
        /// Returns name , release date and IMDB point of film
        /// </summary>
        /// <param name="filmName">this is name of film</param>
        /// <param name="releaseYear">this is release year of film</param>
        /// <param name="releaseMonth">this is release month of film</param>
        /// <param name="releaseDay">this is release day of film</param>
        /// <param name="imdbPoint">this is IMDB point of film</param>
        public Film(string filmName, int releaseYear, string releaseMonth, int releaseDay, double imdbPoint) : this(filmName, releaseYear, releaseMonth, releaseDay)
        {
            this.imdbPoint = imdbPoint;
        }

        /// <summary>
        /// Returns name, release date, IMDB point and genre of film
        /// </summary>
        /// <param name="filmName">this is name of film</param>
        /// <param name="releaseYear">this is release year of film</param>
        /// <param name="releaseMonth">this is release month of film</param>
        /// <param name="releaseDay">this is release day of film</param>
        /// <param name="imdbPoint">this is IMDB point of film</param>
        /// <param name="genre">this is genre of film</param>
        public Film(string filmName, int releaseYear, string releaseMonth, int releaseDay, double imdbPoint, string genre) : this(filmName,releaseYear,releaseMonth,releaseDay,imdbPoint)
        {
            this.genre = genre;
        }

        /// <summary>
        /// Returns all information about film
        /// </summary>
        /// <returns>string type of information about film</returns>
        public string GetFilmInformation()
        {
            return "Film name : " + this.filmName + "\nRelease date of film : " + this.releaseDay + "-" + this.releaseMonth + "-" + this.releaseYear + "\nIMDB point of film : " + this.imdbPoint + "\nGenre of film : " + this.genre;
        }

        public string filmName;
        public int releaseYear;
        public string releaseMonth;
        public int releaseDay;
        public double imdbPoint;
        public string genre;
    }
}
