using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class Alkohol
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Nazwa { get; set; }
        public string KrajPochodzenia { get; set; }
    }
}
