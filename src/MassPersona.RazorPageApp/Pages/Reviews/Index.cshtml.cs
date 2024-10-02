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
    public class IndexModel : PageModel
    {
        private readonly MassPersona.RazorPageApp.Models.ApplicationDbContext _context;

        public IndexModel(MassPersona.RazorPageApp.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Review> Review { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Review = await _context.Reviews.ToListAsync();
        }
    }
}
