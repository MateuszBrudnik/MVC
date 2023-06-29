using storage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieKolokwium.storage.DTO;

namespace SzkolenieKolokwium.storage.Services
{
    public interface IKonkursy
    {
        List<AppDTO> GetAll();

        List<Konkurs> ReadKonkursy();

        void AddUser(AppDTO user);

        void AddKonkurs(Konkurs konkurs);
    }
}
