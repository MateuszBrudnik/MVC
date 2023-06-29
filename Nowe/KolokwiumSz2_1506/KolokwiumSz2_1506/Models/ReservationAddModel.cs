using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SzkolenieKolokwium.storage.Dto;

namespace KolokwiumSz2_1506.Models
{
    public class ReservationAddModel: ReservationDto
    {
        public List<SelectListItem> Rooms { get; set; }
    }
}
