using __4_5__ООТПиСП;
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
    /// Логика взаимодействия для UC_AboutProd_ImgAndTextBx.xaml
    /// </summary>
    public partial class UC_AboutProd_ImgAndTextBx : UserControl
    {
        public event RoutedEventHandler EditImage;
        public static RoutedEvent ClickEvent;
        public void InitComp()
        {
 
            //MCO = (MyControlOne)this.TryFindResource("MCO_Key");

            InitializeComponent();
        }

        public UC_AboutProd_ImgAndTextBx()
        {
            
        }

        private void srcIMG_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (EditImage != null) EditImage.Invoke(sender, e);
        }
    }
}
