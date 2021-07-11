using System.Runtime.Serialization;

namespace CodingChallenge.DataAccess.Models
{
    [DataContract (Name = "Movie")]
    public class Movie
    {
        [DataMember(Name = "ID", Order = 1)]
        public int ID { get; set; }
        [DataMember(Name = "Title", Order = 2)]
        public string Title { get; set; }
        [DataMember(Name = "Year", Order = 3)]
        public int Year { get; set; }
        [DataMember(Name = "Rating", Order = 4)]
        public double Rating { get; set; }
    }
}
