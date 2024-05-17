using Zadanie.Models;

namespace Zadanie.Services.Interfaces
{
    public interface IOsosbyServices
    {
        void Save(Osoby osoby);
        List<Osoby> GetAll();
        Osoby GetById(int id);
    }
}