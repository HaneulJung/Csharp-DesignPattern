using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfDesignPatternPrac.DesignPattern.Models;
using WpfDesignPatternPrac.DesignPattern.MVP.Views;

namespace WpfDesignPatternPrac.DesignPattern.MVP.Presenters
{
    public class MainPresenter
    {
        private readonly IMainView _view;
        private readonly IPersonRepository _personRepository;

        private void AddEvents()
        {
            _view.OnSave += _view_OnSave;
            _view.OnDelete+= _view_OnDelete;
            _view.OnCancel += _view_OnCancel;
            _view.OnListItemSelected += _view_OnListItemSelected;
            _view.OnLoaded += _view_OnLoaded;
        }

        private void _view_OnLoaded(object sender, RoutedEventArgs e)
        {
            RefreshView();
        }

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

        private void SetPersonInfo(Person? person = null)
        {
            _view.Id = person?.Id ?? 0;
            _view.Name = person?.Name ?? "";
            _view.Sex = person?.Sex ?? "";
            _view.Age = person?.Age ?? 0;
        }

        private void _view_OnSave(object sender, RoutedEventArgs e)
        {
            var person = GetPersonFromView();
            if (_personRepository.SaveOne(person))
            {
                RefreshView();
            }
        }

        private void _view_OnDelete(object sender, RoutedEventArgs e)
        {
            if (_personRepository.DeleteOne(_view.Id))
            {
                RefreshView();
            }
        }

        private void _view_OnCancel(object sender, RoutedEventArgs e)
        {
            SetPersonInfo();
        }

        private void _view_OnListItemSelected(object obj)
        {
            SetPersonInfo(obj as Person);
        }

        private void RefreshView()
        {
            SetPersonInfo();
            _view.ItemSource = _personRepository.GetAll()!;
        }

        public MainPresenter(IMainView view, IPersonRepository personRepository)
        {
            _view = view;
            _personRepository = personRepository;
            AddEvents();
        }
    }
}
