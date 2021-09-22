using CoreLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Interfaces
{
    public interface IPersonManager
    {
        List<Person> GetPersonsAll();
        List<Person> GetPersonById(int id);

    }
}
