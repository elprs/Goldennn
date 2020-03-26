using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Goldennn.Entities;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Goldennn.Entities
{
    public  class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }

        public ICollection<Actor> Actors { get; set; }
        public Director Director { get; set; }
        public Genre Genre { get; set; }
    }
}
