using __4_5__ООТПиСП;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace LR4_5_TryOne
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class AboutProduct : Window
    {
        public Product OldProd;
        public Product NewProd = new Product();
        private Image img;
        public AboutProduct()
        {
            InitializeComponent();
        }
        public AboutProduct(object prod)
        {
            img = prod as Image;
            OldProd = img.DataContext as Product;

            InitializeComponent();

            TB_ProdName.Text = OldProd.ProdName_lng;
            TB_Price.Text = OldProd.price.ToString();
            TB_AbProd.Text = OldProd.About;
            TB_Rating.Text = OldProd.rating.ToString();
            TB_Discount.Text = OldProd.discount.ToString();
            TB_Amount.Text = OldProd.amount.ToString();
            NewProd = OldProd;

            IMG_INFO.InitComp();

            IMG_INFO.ProductImage.Source = img.Source;
            IMG_INFO.srcIMG.Text = OldProd.srcIMG;

        }

        private void TB_ProdName_TextChanged(object sender, TextChangedEventArgs e)
        {
            NewProd.ProdName_lng = TB_ProdName.Text;
        }

        private void TB_Price_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                NewProd.price = Convert.ToInt32(TB_Price.Text);
            }
            catch { }
        }

        private void TB_Discount_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                NewProd.discount = Convert.ToInt32(TB_Discount.Text);
            }
            catch { }
            
        }

        private void TB_Amount_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                NewProd.amount = Convert.ToInt32(TB_Amount.Text);
            }
            catch { }
            
        }

        private void TB_Rating_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                NewProd.rating = Convert.ToInt32(TB_Rating.Text);
            }
            catch { }
            
        }

        private void TB_AbProd_TextChanged(object sender, TextChangedEventArgs e)
        {
            NewProd.About = TB_AbProd.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewProd = null;
        }
        //Работа с изображение
        private void ImageEDIT_Loaded(object sender, RoutedEventArgs e)
        {
            if(IMG_INFO.srcIMG.Text != "TextBox")
            {
                try
                {
                    IMG_INFO.ProductImage.Source = new BitmapImage(new Uri(IMG_INFO.srcIMG.Text, UriKind.Absolute));
                    OldProd.srcIMG = IMG_INFO.srcIMG.Text;
                    img.Source = IMG_INFO.ProductImage.Source;
                }
                catch { }
            }
        }

        private void Validate_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(MCO_Name != null &&
                    MCO_Name.DataPrice != null && 
                    MCO_Name.DataPrice.Length > 0
                    )
                    MessageBox.Show(MCO_Name.DataPrice.ToString());
                else
                {
                    MessageBox.Show("Что-то не правильно заполнено");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        //Exemple Bubbling events
        private void Canvas_Button_Click(object sender, RoutedEventArgs e)
        {
            BE_BTN.Content = "Clicked";
        }

        //Exemple Tunneling events
        private void Canvas_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            LBLPMU.Content = "Active Event";
        }


        //возможно довабить кнопку проверки объекта что бы не особо парится с постоянной перезаписью MCO
    }
}
