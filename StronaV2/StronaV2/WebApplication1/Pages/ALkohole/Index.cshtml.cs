using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Model;

namespace WebApplication1.Pages.ALkohole
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel( ApplicationDbContext db)
        {
            _db = db;
        }


        public IEnumerable<Alkohol> Alkohole { get; set; } 
        public async Task OnGetAsync()
        {
            Alkohole = await _db.Alkoholev2.ToListAsync();
        }
    }
}
