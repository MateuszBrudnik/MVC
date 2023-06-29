using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieKolokwium.storage.Dto;
using SzkolenieKolokwium.storage.Entities;

namespace SzkolenieKolokwium.storage.Services
{
    public class ReservationLocalService : IReservationService
    {
        private static List<ReservationDto> reservationDtos = new List<ReservationDto>
        {
            new ReservationDto
            {
                LastName = "Kowalski",
                Name = "Jan",
                Email = "a@b.pl",
                Phone = "1234567",
                DateFrom = DateTime.Now,
                DateTo = DateTime.Now.AddDays(5),
                RoomName = "pokój 5 os.",
                Id = 2
            }
        };

        public void Create(ReservationDto reservation)
        {
            reservationDtos.Add(reservation);
        }

        public List<ReservationDto> Read()
        {
            return reservationDtos;
        }

        public List<Room> ReadRooms()
        {
            return new List<Room>()
            {
                new Room(){ Id = 1, Name = "Pokój 1"},
                new Room(){ Id = 2, Name = "Pokój 2"},
            };
        }
    }
}
