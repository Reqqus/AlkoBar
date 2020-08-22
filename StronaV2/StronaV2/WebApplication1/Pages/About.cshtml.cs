using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class AboutModel : PageModel
    {

        public string Wiadomosc { get; set; }
        public void OnGet()
        {
            Wiadomosc = "W sumie kazdy ma w sobie coœ ze œcieka, jeden ma mniej a drugi wiêcej, ale œwiat krêci siê wokó³ œcieka";
        }
    }
}
