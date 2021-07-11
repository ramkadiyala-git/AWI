using System;
using System.Web.Mvc;
using CodingChallenge.DataAccess;

namespace CodingChallenge.UI.Models
{

    public class GridOptions
    {
        public const string SortColumnKey = "sort";
        public const string SortDirectionKey = "dir";
        public const string PageKey = "page";
        public const string SortAscendingValue = "ASC";
        public const string SortDescendingValue = "DESC";

        public GridOptions()
        {
            ItemsPerPage = 10;
        }

        public string SortColumn { get; set; }
        public SortDirection SortDirection { get; set; }
        public int Page { get; set; }
        public int ItemsPerPage { get; set; }
        public int TotalItems { get; set; }

        public int PageCount
        {
            get { return (TotalItems/ItemsPerPage) + (TotalItems%ItemsPerPage > 0 ? 1 : 0); }
        }
    }

    public class GridBinder : Attribute, IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var request = controllerContext.HttpContext.Request;

            var options = new GridOptions
            {
                SortColumn = request.Params.Get(GridOptions.SortColumnKey),
                Page = 1
            };

            var sortDirection = request.Params.Get(GridOptions.SortDirectionKey);
            if (!string.IsNullOrEmpty(sortDirection))
                options.SortDirection = sortDirection == GridOptions.SortDescendingValue
                    ? SortDirection.Descending
                    : SortDirection.Ascending;

            var page = request.Params.Get(GridOptions.PageKey);
            if (!string.IsNullOrEmpty(page))
                options.Page = Convert.ToInt32(page);

            return options;
        }
    }
}