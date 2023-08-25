using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDesignPatternPrac.DesignPattern.MVC.Views;

namespace WpfDesignPatternPrac.DesignPattern.MVC.Controllers
{
    public class MainController
    {
        private readonly IMainView _view;

        public MainController(IMainView view) 
        { 
            _view = view;
            _view.SetController(this);
        } 
    }
}
