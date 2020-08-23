using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Model;

namespace WebApplication1.Pages.Klienci
{
    public class IndexModel : PageModel
    {

        private readonly ApplicationDbContext _db;
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Sciek> Klient { get; set; }
        public async Task OnGet()
        {
            Klient = await _db.Klienci.ToListAsync();
        }

        public async Task<IActionResult> OnPostUsun(int id)
        {
            var Klient = await _db.Klienci.FindAsync(id);
            if (Klient is null)
            {
                return NotFound();
            }
            _db.Klienci.Remove(Klient);
             await _db.SaveChangesAsync();
            return RedirectToPage();
        }
    }
}
