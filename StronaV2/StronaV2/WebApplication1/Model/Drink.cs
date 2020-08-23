using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class Drink
    {
        [Key]
        public int id_drinka { get; set; }
        [Required]
        public string Nazwa { get; set; }
        public double Objetosc{ get; set; }
        public string Kolor { get; set; }
        public string Rodzaj_drinka { get; set; }
        public decimal Cena { get; set; }
    }
}
