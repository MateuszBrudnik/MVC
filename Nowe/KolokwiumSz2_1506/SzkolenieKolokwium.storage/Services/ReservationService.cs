using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieKolokwium.storage.Dto;
using SzkolenieKolokwium.storage.Entities;

namespace SzkolenieKolokwium.storage.Services
{
    public class ReservationService : IReservationService
    {
        private readonly ReservationDbContext _dbContext;

        public ReservationService(ReservationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Create(ReservationDto reservation)
        {
            var reservationEntity = new Reservation()
            {
                Name = reservation.Name,
                LastName = reservation.LastName,
                RoomId = reservation.RoomId,
                DateFrom = reservation.DateFrom,
                DateTo = reservation.DateTo,
                Email = reservation.Email,
                Phone = reservation.Phone
            };
            _dbContext.Set<Reservation>().Add(reservationEntity);
            _dbContext.SaveChanges();
        }

        public List<ReservationDto> Read()
        {
            // Include(x => x.Room).
            var result = _dbContext.Reservations.Select(x => new ReservationDto
            {
                DateFrom = x.DateFrom,
                DateTo = x.DateTo,
                Email = x.Email,
               // RoomName = x.Room.Name,
                Name = x.Name,
                LastName = x.LastName,
                Phone = x.Phone
            }).ToList();
            return result;
        }

        public List<Room> ReadRooms()
        {
            var result = _dbContext.Rooms.ToList();
            return result;
        }
    }
}
