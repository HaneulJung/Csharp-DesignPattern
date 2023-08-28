using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDesignPatternPrac.DesignPattern.Models;
using WpfDesignPatternPrac.DesignPattern.MVC.Views;

namespace WpfDesignPatternPrac.DesignPattern.MVC.Controllers
{
    public class MainController
    {
        private readonly IMainView _view;
        private readonly IPersonRepository _personRepository;

        private Person GetPersonFromView()
        {
            return new Person
            {
                Id = _view.Id,
                Name = _view.Name,
                Sex = _view.Sex,
                Age = _view.Age,
            };
        }

        private bool IsValidSave(Person person)
        {
            if (person.Id <= 0)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.Name))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.Sex))
            {
                return false;
            }

            if (person.Age <= 0)
            {
                return false;
            }

            return true;
        }
        private void LoadPerson(Person? person = null)
        {
            _view.Id = person?.Id ?? 0;
            _view.Name = person?.Name ?? "";
            _view.Sex = person?.Sex ?? "";
            _view.Age = person?.Age ?? 0;
        }

        public MainController(IMainView view, IPersonRepository personRepository) 
        { 
            _view = view;
            _personRepository = personRepository;
            _view.SetController(this);
        }
        internal bool Save()
        {
            Person person = GetPersonFromView();
            if (!IsValidSave(person)) return false;
            return _personRepository.SaveOne(person);
        }


        internal void Delete()
        {
            _personRepository.DeleteOne(_view.Id);
            
        }

        internal void Display()
        {
            _view.ItemSource = _personRepository.GetAll()!;
        }
        internal void Cancel()
        {
            LoadPerson();
        }


        internal void LoadPerson(object dataContext)
        {
            LoadPerson(dataContext as Person);
        }
    }
}
