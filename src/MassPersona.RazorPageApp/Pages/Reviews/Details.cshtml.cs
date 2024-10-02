using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MassPersona.RazorPageApp.Models;

namespace MassPersona.RazorPageApp.Pages.Reviews
{
    public class DetailsModel : PageModel
    {
        private readonly MassPersona.RazorPageApp.Models.ApplicationDbContext _context;

        public DetailsModel(MassPersona.RazorPageApp.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public Review Review { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Reviews.FirstOrDefaultAsync(m => m.ReviewID == id);
            if (review == null)
            {
                return NotFound();
            }
            else
            {
                Review = review;
            }
            return Page();
        }
    }
}
