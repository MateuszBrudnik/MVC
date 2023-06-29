using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieKolokwium.storage.Dto;
using SzkolenieKolokwium.storage.Entities;

namespace SzkolenieKolokwium.storage.Services
{
    public interface IReservationService
    {
        List<ReservationDto> Read();
        void Create(ReservationDto reservation);
        List<Room> ReadRooms();
    }
}
