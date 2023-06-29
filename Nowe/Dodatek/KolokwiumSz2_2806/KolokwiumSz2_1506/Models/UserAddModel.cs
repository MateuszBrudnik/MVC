using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using SzkolenieKolokwium.storage.DTO;

namespace KolokwiumSz2_1506.Models
{
    public class UserAddModel: AppDTO
    {
        public List<SelectListItem> Konkursy { get; set; }
    }
}
