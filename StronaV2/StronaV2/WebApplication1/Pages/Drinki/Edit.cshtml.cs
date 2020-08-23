using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Model;

namespace WebApplication1.Pages.Drinki
{
    public class EditModel : PageModel
    {

        private ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Drink Drink { get; set; }
        public async Task OnGet(int id)
        {
            Drink = await _db.Drinki.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var DrinkFromDB = await _db.Drinki.FindAsync(Drink.id_drinka);
                DrinkFromDB.Nazwa = Drink.Nazwa;
                DrinkFromDB.Objetosc = Drink.Objetosc;
                DrinkFromDB.Kolor = Drink.Kolor;
                DrinkFromDB.Rodzaj_drinka = Drink.Rodzaj_drinka;
                DrinkFromDB.Cena = Drink.Cena;

                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }

    }
}
