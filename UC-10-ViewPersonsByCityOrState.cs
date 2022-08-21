using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookManagementSystem
{
    internal class UC_10_ViewPersonsByCityOrState
    {
        private List<Person> _people = new List<Person>();
        var person = new Person();
        person.FirstName = "John";
        person.LastName = "Doe";
        person.Age = 29;
        person.Address.Number = "1234";
        person.Address.Street = "Main Street";
        person.Address.City = "Philadelphia";
        person.Address.State = "PA";
        person.Address.Zipcode = "19101";

        _people.Add(person);

        person = new Person();
        person.FirstName = "Bob";
        person.LastName = "Smith";
        person.Age = 65;
        person.Address.Number = "123";
        person.Address.Street = "Lancaster Avenue";
        person.Address.City = "Paoli";
        person.Address.State = "PA";
        person.Address.Zipcode = "19301";

        _people.Add(person);
    }
}
