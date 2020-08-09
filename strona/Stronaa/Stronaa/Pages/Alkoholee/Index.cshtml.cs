using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Stronaa.Model;

namespace Stronaa.Pages.Alkoholee
{
    public class IndexModel : PageModel
    {
        private readonly DB _db;

        public IndexModel(DB db)
        {
            _db = db;
        }

        public IEnumerable<Alkohole> Alko { get; set; }

        public async Task OnGet()
        {
            Alko = await _db.Alkoholev2.ToListAsync(); 
        }
    }
}