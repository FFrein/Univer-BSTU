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

        public AboutProduct()
        {
            InitializeComponent();
        }
        public AboutProduct(object prod)
        {
            Image img = prod as Image;
            OldProd = img.DataContext as Product;

            InitializeComponent();

            TB_ProdName.Text = OldProd.ProdName_lng;
            TB_Price.Text = OldProd.price.ToString();
            TB_AbProd.Text = OldProd.About;
            TB_Rating.Text = OldProd.rating.ToString();
            TB_Discount.Text = OldProd.discount.ToString();
            TB_Amount.Text = OldProd.amount.ToString();
            srcIMG.Text = OldProd.srcIMG;
            ProductImage.Source = img.Source;
            NewProd = OldProd;
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

        private void srcIMG_TextChanged(object sender, TextChangedEventArgs e)
        {
            NewProd.srcIMG = srcIMG.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewProd = null;
        }
    }
}
