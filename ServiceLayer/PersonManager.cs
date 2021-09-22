using CoreLayer;
using CoreLayer.IRepository;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class PersonManager : IPersonManager
    {
        readonly IPersonsRepository _personsRepository;
        public PersonManager(IPersonsRepository personsRepository)
        {
            _personsRepository = personsRepository;
        }
        public List<Person> GetPersonById(int id)
        {
            return _personsRepository.GetPersonById(id);
        }

        public List<Person> GetPersonsAll()
        {
            return _personsRepository.GetPersonsAll();
        }
    }
}
