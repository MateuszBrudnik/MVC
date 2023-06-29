using storage.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieKolokwium.storage.DTO
{
    public class AppDTO
    {
        [Required]
        public string Imie { get; set; }

        [Required]
        public string Nazwisko { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        public string KonkursName { get; set; }

        public int Id { get; set; } 

        public int KonkursId { get; set; }
    }
}
