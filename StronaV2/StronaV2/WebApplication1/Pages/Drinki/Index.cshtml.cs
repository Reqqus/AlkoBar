using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Model;

namespace WebApplication1.Pages.Drinki
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }


        public IEnumerable<Drink> Drinki{ get; set; }
        public async Task OnGetAsync()
        {
            Drinki = await _db.Drinki.ToListAsync();
        }

        public async Task<IActionResult> OnPostUsun(int id)
        {
            var Drink = await _db.Drinki.FindAsync(id);
            if (Drink == null)
            {
                return NotFound();
            }
            _db.Drinki.Remove(Drink);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
