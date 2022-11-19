using System;
using System.Collections.Generic;

namespace Indexer_Reflection {
    public class PersonService : IPersonService {
        public List<string> GetFullData(Predicate<Person> predicate)
        {
            var people = GetAllPeople();

            var res = people.FindAll(predicate);

            return GetPeopleDetails(res);
        }
        private List<Person> GetAllPeople()
        {
            List<Person> people = new List<Person>();

            Person person1 = new Person();
            person1.Name = "Resul";
            person1.Surname = "Hesenov";
            person1.Address = "Xalqlar";
            person1.Salary = 400;

            Person person2 = new Person();
            person2.Name = "Novrasta";
            person2.Surname = "Aslanzada";
            person2.Address = "Azadlig";
            person2.Salary = 700;

            Person person3 = new Person();
            person3.Name = "Rasul";
            person3.Surname = "Hasanov";
            person3.Address = "Khalglar";
            person3.Salary = 4000;

            Person person4 = new Person();
            person4.Name = "Qoshqar";
            person4.Surname = "Narimanli";
            person4.Address = "Ahmedli";
            person4.Salary = 8000;

            Person person5 = new Person();
            person1.Name = "Lala";
            person1.Surname = "Guliyeva";
            person1.Address = "Nesimi";
            person1.Salary = 2000;

            Person person6 = new Person();
            person6.Name = "Gultac";
            person6.Surname = "Cafarova";
            person6.Address = "Tiblisi";
            person6.Salary = 10000;

            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);
            people.Add(person5);
            people.Add(person6);

            return people;
        }

        private List<string> GetPeopleDetails(List<Person> people)
        {
            List<string> fulldatas = new List<string>();

            foreach (var item in people)
            {
                string data = $"{item.Name} - {item.Surname} - {item.Address}";
                fulldatas.Add(data);
            }
            return fulldatas;
        }
    }
}
