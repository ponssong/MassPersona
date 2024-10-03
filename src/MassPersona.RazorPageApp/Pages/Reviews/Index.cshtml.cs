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

        public async Task OnGetAsync( string sortOrder)
        {
            // using System;
            TitleSort = String.IsNullOrEmpty(sortOrder) ? "title_desc" : "";
            RatingSort = sortOrder == "Rating" ? "rating_desc" : "Rating";

            IQueryable<Review> reviews = from s in _context.Reviews
                                             select s;

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


            Review = await _context.Reviews.ToListAsync();
        }
    }
}
