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

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }


        public IEnumerable<Alkohol> Alkohole { get; set; }
        public async Task OnGetAsync()
        {
            Alkohole = await _db.Alkoholev2.ToListAsync();
        }

        public async Task<IActionResult> OnPostUsun(int id)
        {
            var Alkohol = await _db.Alkoholev2.FindAsync(id);
            if(Alkohol == null)
            {
                return NotFound();
            }
            _db.Alkoholev2.Remove(Alkohol);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
