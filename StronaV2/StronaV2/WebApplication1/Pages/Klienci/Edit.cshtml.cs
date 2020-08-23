using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.CSharp;
using WebApplication1.Model;

namespace WebApplication1.Pages.Klienci
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]

        public Sciek Klient { get; set; }

        public async Task OnGet( int id)
        {
            Klient = await _db.Klienci.FindAsync(id);
        }

        public async Task <IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                var KlientFromDB = await _db.Klienci.FindAsync(Klient.id_klienta);
                KlientFromDB.Imie = Klient.Imie;
                KlientFromDB.Nazwisko = Klient.Nazwisko;
                KlientFromDB.Ulub_alkohol = Klient.Ulub_alkohol;
                KlientFromDB.Ulub_drink = Klient.Ulub_drink;
                KlientFromDB.CzyPelnoletni = Klient.CzyPelnoletni;

                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}
