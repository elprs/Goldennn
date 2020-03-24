using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Goldennn.Database;
using Goldennn.Entities;
using Goldennn.Services;

namespace Goldenn.Desktop
{
    partial class Program
    {
        static void Main(string[] args)
        {
            using(MyDatabase db = new MyDatabase())
            {
                //var movies = db.Movies; //san I quirable interfase // tha steilei SQL QUERY STI BASI //zitao ka8e fora apo toservar na mou stelnei thn katallili pliroforia // de me endiaferei gia ena sugkekrimeno query sti basi kai exo para polu RAM 
                

                var movies = db.Movies.ToList(); //simbato me IEnumerable //tha stalei query sti basi poy 8a sou ferei ol aosa xxreiazomai sato run time
                //tha to xrismopoiiso gia polla//tha ferei osa xreiazomai sto run time
                //fere mou AUTOO apo ti basi, stoxeuMENA!!!!! me linq 

                foreach (var movie in movies)
                {
                    Console.WriteLine("{0,-6}{0,-15}", movie.MovieId, movie.Title);
                }
            }

            Console.ReadKey();
        }

        public  class App
        {
            public  static void PrintMovie()
            {
                Goldennn.Services.MovieRepository movieRepository = new MovieRepository();
                var movies = movieRepository.GetAll().Where(x => x.Title.Contains("e"));
                //auti ti stigmi i linq psaxnei sto run, momeory (oxi ston sql server, auto einai allos dromos). 


                foreach (var movie in movies)
                {
                    Console.WriteLine("{0,-6}{0,-15}", movie.MovieId, movie.Title);
                }


                //App.PrintMovies();
                Console.WriteLine("psakse tainia");
                string choice = Console.ReadLine();

                int id;
                if (Int32.TryParse(choice, out id))
                {
                    App.PrintById(2);
                }
                else
                {
                    App.PrintById(null);
                }













                //app.PrintMovie()
                Movie m = new Movie() { Title = "Battleship Potemkin" };
                movieRepository.Insert(m);

                App.PrintMovie(); // kai ektipono gt exo ftiaksei auton ton mixanismo
            }

            public static void PrintById(int? id) //fernei tin tainia me to Id tis
            {
                Goldennn.Services.MovieRepository movieRepository = new MovieRepository();
                var movie = movieRepository.GetById(id);
                
                    Console.WriteLine("{0,-6}{0,-15}", movie.MovieId, movie.Title);
                
            }
        
        }

        
        
    }
}

