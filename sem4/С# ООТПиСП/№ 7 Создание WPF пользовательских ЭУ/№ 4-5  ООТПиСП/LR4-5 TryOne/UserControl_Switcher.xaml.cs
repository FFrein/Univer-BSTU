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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LR4_5_TryOne
{
    /// <summary>
    /// Логика взаимодействия для UserControl_Switcher.xaml
    /// </summary>
    public partial class UserControl_Switcher : UserControl
    {
        public event RoutedEventHandler NextStyle;

        public UserControl_Switcher()
        {
            InitializeComponent();
        }

        private void SwitchStyle_Click(object sender, RoutedEventArgs e)
        {
            if (NextStyle != null) NextStyle.Invoke(sender, e);
        }
    }
}
