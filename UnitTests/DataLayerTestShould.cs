using CoreLayer;
using CoreLayer.IRepository;
using Moq;
using ServiceLayer.Interfaces;
using System;
using Xunit;

namespace UnitTests
{
    public class DataLayerTestShould
    {
        [Fact]
        public void ReturnOneRecord()
        {
            //arrange
            int id = 1;
            var mockPersonRepository = new Mock<IPersonsRepository>();
            mockPersonRepository.Setup(x => x.GetPersonById(id)).Returns(new System.Collections.Generic.List<Person>() { new Person() { Id = 1, Age = 22, Country = "Argentina", Name = "Francisco" } });
            ServiceLayer.PersonManager personManager = new ServiceLayer.PersonManager(mockPersonRepository.Object);

            //act
            var actual = personManager.GetPersonById(id);

            //assert
            Assert.Single(actual);

        }
    }
}
