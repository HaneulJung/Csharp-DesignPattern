using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfDesignPatternPrac.DesignPattern.MVC.Controllers;

namespace WpfDesignPatternPrac.DesignPattern.MVC.Views
{
    /// <summary>
    /// MainView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainView : Window, IMainView
    {
        private MainController _controller = default!;

        public MainView()
        {
            InitializeComponent();
        }

        public void SetController(MainController controller)
        {
            _controller = controller;
        }
    }
}
