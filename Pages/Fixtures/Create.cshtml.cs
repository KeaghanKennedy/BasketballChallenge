using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FinalChallenge.Data;
using FinalChallenge.Models;

namespace FinalChallenge.Pages.Fixtures
{
    public class CreateModel : PageModel
    {
        private readonly FinalChallenge.Data.FinalChallengeContext _context;

        public CreateModel(FinalChallenge.Data.FinalChallengeContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Fixture Fixture { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Fixture.Add(Fixture);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
