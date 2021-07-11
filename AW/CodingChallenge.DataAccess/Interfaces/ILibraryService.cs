using CodingChallenge.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.DataAccess.Interfaces
{
    public interface ILibraryService
    {
        IEnumerable<Movie> SearchMovies(string title, int? skip = null, int? take = null, string sortColumn = null, SortDirection sortDirection = SortDirection.Ascending);
        int SearchMoviesCount(string title);
    }
}
