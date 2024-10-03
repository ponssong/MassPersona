using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MassPersona.RazorPageApp.Models;
using System.ComponentModel;

namespace MassPersona.RazorPageApp.Pages.Reviews
{
    public class CreateModel : PageModel
    {
        private readonly MassPersona.RazorPageApp.Models.ApplicationDbContext _context;

        public CreateModel(MassPersona.RazorPageApp.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Review Review { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Reviews.Add(Review);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        public enum CategoriesSelectList
        {
            [Description("Media")]
            Select = 0,
            [Description("Movies")]
            Movies = 1,
            [Description("Books")]
            Books = 2,
            [Description("Shows")]
            Shows = 3,
            [Description("Game")]
            Game= 4
        }
    }
}
