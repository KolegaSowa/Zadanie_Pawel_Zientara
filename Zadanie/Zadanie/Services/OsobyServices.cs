using Microsoft.EntityFrameworkCore;
using Zadanie.Models;
using Zadanie.Services.Interfaces;

namespace Zadanie.Services
{
    public class OsobyServices : IOsosbyServices
    {
        private readonly DataBaseContext _dataBaseContext;

        public OsobyServices(DataBaseContext context)
        {
            _dataBaseContext = context;
        }

        public List<Osoby> GetAll()
        {
            var osoba = _dataBaseContext.Osoby.ToList();
            return osoba;
        }

        public Osoby GetById(int id)
        {
            var osoba = _dataBaseContext.Osoby.Find(id);
            return osoba;
        }

        public void Save(Osoby osoby)
        {
            _dataBaseContext.Osoby.Add(osoby);
            if (_dataBaseContext.SaveChanges() > 0)
            {
                System.Console.WriteLine("Sukces");
            }
           
        }
    }
}