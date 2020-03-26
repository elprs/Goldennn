using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Goldennn.Entities
{
    public class Director
    {
        public int DirectorId { get; set; }
        public string FirstName { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }
}