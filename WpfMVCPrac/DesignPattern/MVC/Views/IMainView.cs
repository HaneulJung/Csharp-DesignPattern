using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDesignPatternPrac.DesignPattern.MVC.Controllers;

namespace WpfDesignPatternPrac.DesignPattern.MVC.Views
{
    public interface IMainView
    {
        void SetController(MainController controller);
    }
}
