using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.IRepository
{
    public interface IPersonsRepository
    {
        List<Person> GetPersonsAll();
        List<Person> GetPersonById(int id);

    }
}
