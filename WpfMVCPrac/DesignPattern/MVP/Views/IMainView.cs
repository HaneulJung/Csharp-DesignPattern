using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfDesignPatternPrac.DesignPattern.MVP.Views
{
    public interface IMainView
    {
        event RoutedEventHandler OnLoaded;
        event RoutedEventHandler OnSave;
        event RoutedEventHandler OnDelete;
        event RoutedEventHandler OnCancel;
        event Action<Object> OnListItemSelected;

        int Id { get; set; }
        string Name { get; set; }
        string Sex { get; set; }
        int Age { get; set; }

        IEnumerable ItemSource { get; set; }
    }
}
