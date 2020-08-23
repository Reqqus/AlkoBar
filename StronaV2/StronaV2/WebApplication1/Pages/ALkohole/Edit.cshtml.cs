using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Model;

namespace WebApplication1.Pages.ALkohole
{
    public class EditModel : PageModel
    {

        private ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Alkohol Alkohol { get; set; }
        public async Task OnGet(int id)
        {
            Alkohol = await _db.Alkoholev2.FindAsync(id);
        }

        public async Task <IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var AlkoholFromDB = await _db.Alkoholev2.FindAsync(Alkohol.ID);
                AlkoholFromDB.Nazwa = Alkohol.Nazwa;
                AlkoholFromDB.KrajPochodzenia = Alkohol.KrajPochodzenia;

                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }

    }
}
