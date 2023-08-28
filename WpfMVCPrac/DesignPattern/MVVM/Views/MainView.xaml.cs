using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace WpfDesignPatternPrac.DesignPattern.MVVM.Views
{
    /// <summary>
    /// MainView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();

            txtId.TextChanged += Txt_Textchanged;
            txtName.TextChanged += Txt_Textchanged;
            txtSex.TextChanged += Txt_Textchanged;
            txtAge.TextChanged += Txt_Textchanged;
        }

        private void Txt_Textchanged(object sender, TextChangedEventArgs e)
        {
            BindingExpression be = ((TextBox)sender).GetBindingExpression(TextBox.TextProperty);
            be.UpdateSource();
        }
    }
}
