using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WpfDesignPatternPrac.Properties;

namespace WpfDesignPatternPrac.DesignPattern.Models
{
    public class PersonRepository : IPersonRepository
    {
        private void SaveSettings(IEnumerable<Person> people)
        {
            string jsonData = JsonSerializer.Serialize(people);
            Settings settings = new Settings();
            settings.PeopleJson= jsonData;
            settings.Save();
        }

        private List<Person> GetPeople() 
        {
            IEnumerable<Person>? people = GetAll();

            List<Person> list;

            if (people == null)
            {
                list = new List<Person>();
            }
            else
            {
                list = people.ToList();
            }

            return list;
        }

        public IEnumerable<Person>? GetAll()
        {
            string jsonData = new Settings().PeopleJson;
            return string.IsNullOrWhiteSpace(jsonData)
                ? null
                : JsonSerializer.Deserialize<IEnumerable<Person>>(jsonData);
        }

        public bool DeleteOne(int id)
        {
            
        }

        public bool Exist(int id)
        {
            throw new NotImplementedException();
        }


        public bool SaveOne(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
