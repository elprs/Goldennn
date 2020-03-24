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
            }
        }

        
        
    }
}

