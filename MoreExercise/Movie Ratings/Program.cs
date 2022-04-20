using System;

namespace _05._Movie_Ratings
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberMovies = int.Parse(Console.ReadLine());
            string max = " ";
            string min = " ";
            double ratingMax = double.MinValue;
            double ratingMin = double.MaxValue;
            double countRating = 0;
            for (int i = 0; i < numberMovies; i++)
            {
                string nameMovie = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());
                countRating += rating;

                if (rating > ratingMax)
                {
                    max = nameMovie;
                    ratingMax = rating;
                }
                else if (rating < ratingMin) 
                {
                    min = nameMovie;
                    ratingMin = rating;
                }
            }

            double ratingaverage = countRating / numberMovies;

            Console.WriteLine($"{max} is with highest rating: {ratingMax:f1}");
            Console.WriteLine($"{min} is with lowest rating: {ratingMin:f1}");
            Console.WriteLine($"Average rating: {ratingaverage:f1}");
        }
    }
}
