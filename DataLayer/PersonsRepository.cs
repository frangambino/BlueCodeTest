using CoreLayer.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer
{
    public class PersonsRepository : IPersonsRepository
    {
        //readonly IPersonsRepository _personsRepository;
        //public PersonsRepository(IPersonsRepository personsRepository)
        //{
        //    _personsRepository = personsRepository;
        //}
        public List<Person> GetPersonById(int id)
        {
            
            using (var db = new BluecodeDbContext())
            {
                return db.Persons.Where(x => x.Id == id).ToList();
            }
        }

        public List<Person> GetPersonsAll()
        {
            using (var db = new BluecodeDbContext())
            {
                return db.Persons.ToList();
            }
        }
    }
}
