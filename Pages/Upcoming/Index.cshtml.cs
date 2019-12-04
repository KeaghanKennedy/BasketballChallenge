using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalChallenge.Data;
using FinalChallenge.Models;

namespace FinalChallenge.Pages.Upcoming
{
    public class IndexModel : PageModel
    {
        private readonly FinalChallenge.Data.FinalChallengeContext _context;

        public IndexModel(FinalChallenge.Data.FinalChallengeContext context)
        {
            _context = context;
        }

        public IList<Fixture> Fixture { get;set; }

        public async Task OnGetAsync()
        {
            Fixture = await _context.Fixture.ToListAsync();
        }
    }
}
