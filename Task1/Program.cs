using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "E:\\input.txt";
            var jsonText = File.ReadAllText(path);
            var collectionInput = JsonConvert.DeserializeObject<IList<MovieStar>>(jsonText);
            List<MovieStar> movieStars = new List<MovieStar>();

            foreach (var item in collectionInput)
            {
                var birthDate = item.DateOfBirth;
                string name = item.Name;
                string surname = item.Surname;
                string sex = item.Sex;
                string nationality = item.Nationality;

                MovieStar currentMovieStar = new MovieStar(birthDate, name, surname, sex, nationality);
                movieStars.Add(currentMovieStar);
            }

            foreach (var movieStar in movieStars)
            {
                Console.WriteLine(movieStar);
            }
        }
    }
}
