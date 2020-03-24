using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Goldennn.Database;
using Goldennn.Entities;

namespace Goldenn.Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
            using(MyDatabase db = new MyDatabase())
            {
                //var movies = db.Movies; //san I quirable interfase // tha steilei SQL QUERY STI BASI 

                var movies = db.Movies.ToList(); //simbato me IEnumerable //tha stalei query sti basi poy 8a sou ferei ol aosa xxreiazomai sato run time

                foreach (var movie in movies)
                {
                    Console.WriteLine("{0,-6}{0,-15}", movie.MovieId, movie.Title);
                }
            }


            Console.ReadKey();
        }
    }
}
