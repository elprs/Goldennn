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

        public virtual ICollection<Actor> Actors { get; set; }

        public int DirectorId { get; set; }
        public virtual Director Director { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
