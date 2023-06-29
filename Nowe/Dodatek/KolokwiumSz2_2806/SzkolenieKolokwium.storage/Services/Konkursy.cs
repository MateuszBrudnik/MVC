using Microsoft.EntityFrameworkCore;
using storage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieKolokwium.storage.DTO;

namespace SzkolenieKolokwium.storage.Services
{
    public class Konkursy : IKonkursy
    {
        private readonly AppDbContext _dbContext;

        public Konkursy(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddKonkurs(Konkurs konkurs)
        {
            var konku = new Konkurs()
            {
                Nazwa = konkurs.Nazwa
            };
            _dbContext.Konkurs.Add(konku);
           _dbContext.SaveChanges();
        }

        public void AddUser(AppDTO user)
        {
            var us = new User()
            {
                Imie = user.Imie,
                Nazwisko = user.Nazwisko,
                Email = user.Email,
                KonkursId = user.KonkursId
            };
            _dbContext.Users.Add(us);
            _dbContext.SaveChanges();
        }

        public List<AppDTO> GetAll()
        {
            var result = _dbContext.Users.Include(x => x.Konkurs).Select(x => new AppDTO
            {
                Imie = x.Imie,
                Nazwisko = x.Nazwisko,
                Email = x.Email,
                KonkursName =   x.Konkurs.Nazwa
            }).ToList();

            return result;

        }

        public List<Konkurs> ReadKonkursy()
        {
            var result = _dbContext.Konkurs.ToList();
            return result;
        }
    }
}
