using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieKolokwium.storage.Dto
{
    public class ReservationDto
    {
        [Required]
        [StringLength(128, ErrorMessage = "Imię nie może przekraczać 128 znaków")]
        public string Name { get; set; }

        [Required]
        [StringLength(128, ErrorMessage = "Nazwisko nie może przekraczać 128 znaków")]
        public string LastName { get; set; }

        [Required]
        [StringLength(128, ErrorMessage = "Email nie może przekraczać 128 znaków")]
        public string Email { get; set; }

        [Required]
        [StringLength(12, ErrorMessage = "Telefon nie może przekraczać 12 znaków")]
        public string Phone { get; set; }

        public int RoomId { get; set; }

        [Required]
        public DateTime DateFrom { get; set; }

        [Required]
        public DateTime DateTo { get; set; }

        public string RoomName { get; set; }
        public int Id { get; set; }
    }
}
