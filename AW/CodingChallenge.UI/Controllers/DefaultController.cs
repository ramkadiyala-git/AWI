using System.Linq;
using System.Web.Mvc;
using CodingChallenge.DataAccess;
using CodingChallenge.DataAccess.Interfaces;
using CodingChallenge.UI.Models;

namespace CodingChallenge.UI.Controllers
{
    public class DefaultController : Controller
    {
        public ILibraryService LibraryService { get; private set; }

        public DefaultController() { }

        public DefaultController(ILibraryService libraryService)
        {
            LibraryService = libraryService;
        }

        public ActionResult Index([ModelBinder(typeof(GridBinder))]GridOptions options)
        {
            options.TotalItems = LibraryService.SearchMoviesCount("");
            if (options.SortColumn == null)
                options.SortColumn = "ID";
            var model = new MovieListViewModel
            {
                GridOptions = options,
                Movies = LibraryService.SearchMovies("", (options.Page - 1) * options.ItemsPerPage, options.ItemsPerPage).ToList()
            };
            return View(model);
        }
    }
}
