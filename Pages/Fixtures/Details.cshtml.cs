using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalChallenge.Data;
using FinalChallenge.Models;

namespace FinalChallenge.Pages.Fixtures
{
    public class DetailsModel : PageModel
    {
        private readonly FinalChallenge.Data.FinalChallengeContext _context;

        public DetailsModel(FinalChallenge.Data.FinalChallengeContext context)
        {
            _context = context;
        }

        public Fixture Fixture { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Fixture = await _context.Fixture.FirstOrDefaultAsync(m => m.ID == id);

            if (Fixture == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
