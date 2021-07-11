using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CodingChallenge.DataAccess.Models
{
    [DataContract(Name = "Library")]
    public class Library
    {
        [DataMember(Name = "Movies")]
        public List<Movie> Movies { get; set; }
    }
}
