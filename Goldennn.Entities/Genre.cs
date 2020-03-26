using System.Collections.Generic;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Goldennn.Entities
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Kind { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}