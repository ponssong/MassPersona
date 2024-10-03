using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MassPersona.RazorPageApp.Models;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MassPersona.RazorPageApp.Pages.Reviews
{
    public class IndexModel : PageModel
    {
        private readonly MassPersona.RazorPageApp.Models.ApplicationDbContext _context;

        public IndexModel(MassPersona.RazorPageApp.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public string TitleSort { get; set; }
        public string RatingSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public IList<Review> Review { get;set; } = default!;

        public async Task OnGetAsync( string sortOrder, string searchString)
        {
            // using System;
            TitleSort = String.IsNullOrEmpty(sortOrder) ? "title_desc" : "";
            RatingSort = sortOrder == "Rating" ? "rating_desc" : "Rating";

            CurrentFilter = searchString;

            IQueryable<Review> reviews = from s in _context.Reviews
                                             select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                reviews = reviews.Where(s => s.Title.ToUpper().Contains(searchString.ToUpper())
                                       || s.ReviewText.ToUpper().Contains(searchString.ToUpper())
                                       || s.Category.ToUpper().Contains(searchString.ToUpper()));
            }


            switch (sortOrder)
            {
                case "title_desc":
                    reviews = reviews.OrderByDescending(s => s.Title);
                    break;
                case "Rating":
                    reviews = reviews.OrderBy(s => s.Rating);
                    break;
                case "rating_desc":
                    reviews = reviews.OrderByDescending(s => s.Rating);
                    break;
                default:
                    reviews = reviews.OrderBy(s => s.Title);
                    break;
            }


            Review = await reviews.AsNoTracking().ToListAsync();
        }
    }
}
