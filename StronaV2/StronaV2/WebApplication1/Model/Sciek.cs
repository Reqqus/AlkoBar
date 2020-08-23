using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class Sciek
    {
        [Key]
        public int id_klienta { get; set; }
        [Required]
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public char CzyPelnoletni { get; set; }
        public int Ulub_alkohol { get; set; }
        public int Ulub_drink { get; set; }

    }
}
