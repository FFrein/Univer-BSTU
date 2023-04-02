using __4_5__ООТПиСП;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<Product> Main_product_List;
        static Cursor cursor = new Cursor(Application.GetResourceStream(new Uri("pack://application:,,,/Cursor.cur")).Stream);//"pack://application:,,,/Dictionary_Rus.xaml"
        public MainWindow()
        {
            InitializeComponent();

            TB_ProdName.Text = "Название";
            TB_MinPrice.Text = "min";
            TB_MaxPrice.Text = "max";
            TB_Genre.Text = "Жанр";//не используется
            CB_Type.SelectedIndex = 0;
            this.Cursor= cursor;
        }

        private void TextBox_ProductName(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_ProductType(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_PriceMin(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_PriceMax(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_Genre(object sender, TextChangedEventArgs e)
        {

        }

        private void AddProdsOnPanel()
        {

            List<Product> buffer = new List<Product>();
            List<Product> buffer2 = new List<Product>();

            foreach (Product p in Main_product_List)
            {
                if (CB_Type.Text == p.Cotegory)
                {
                    buffer.Add(p);
                }

            }
            buffer2 = buffer.GetRange(0, buffer.Count);
            buffer.Clear();
            try
            {
                if (TB_ProdName.Text != "Название")
                {
                    foreach (Product p in buffer2)
                    {
                        if (p.ProdName_lng.Contains(TB_ProdName.Text))
                        {
                            buffer.Add(p);
                        }
                    }
                    buffer2 = buffer.GetRange(0, buffer.Count);
                    buffer.Clear();
                }
            }
            catch { }
            try
            {
                if (TB_MinPrice.Text != "Min")
                {
                    foreach (Product p in buffer2)
                    {
                        if (Convert.ToInt64(TB_MinPrice.Text) <= p.price)
                        {
                            buffer.Add(p);
                        }
                    }
                    buffer2 = buffer.GetRange(0, buffer.Count);
                    buffer.Clear();
                }

                if (TB_MaxPrice.Text != "Max")
                {
                    foreach (Product p in buffer2)
                    {
                        if (Convert.ToInt64(TB_MaxPrice.Text) >= p.price)
                        {
                            buffer.Add(p);
                        }
                    }
                    buffer2 = buffer.GetRange(0, buffer.Count);
                    buffer.Clear();
                }
            }
            catch { }
            Add_Object(buffer2);
        }

        private void Button_Find(object sender, RoutedEventArgs e)
        {
            Main_product_List = Products_DeSerrializator();

            AddProdsOnPanel();

            SaveState();
        }

        private void Add_Object(List<Product> LP)
        {
            WrapPanel.Children.Clear();
            foreach(Product p in LP)
            {
                try
                {
                    Image img = new Image();

                    img.DataContext = p;
                    img.MouseDown += ShowObject; // подписываю объект на событие

                    img.Width = 100;
                    img.Height = 100;
                    img.Margin = new Thickness(10, 10, 10, 10);
                    img.Source = new BitmapImage(new Uri(p.srcIMG, UriKind.Absolute));
                    WrapPanel.Children.Add(img);
                }
                catch { }
            }
        }

        private void BTN_ADMIN_Click_1(object sender, RoutedEventArgs e)
        {

            AdminWindow AdmWind = new AdminWindow();

            AdmWind.Owner = this;
            
            AdmWind.ShowDialog();

            Main_product_List = AdmWind.product_List;

            Products_Serrializator(Main_product_List);

        }

        private void Products_Serrializator(List<Product> PL)
        {
            Product[] products_buff = new Product[Main_product_List.Count];

            int counter = 0;
            foreach (Product p in Main_product_List)
                products_buff[counter++] = p;

            //серриализация

            string json = JsonConvert.SerializeObject(products_buff);
            File.WriteAllText("Products.json", json);

            Products_DeSerrializator();

        }

        private List<Product> Products_DeSerrializator()
        {
            string json = File.ReadAllText("Products.json");

            List<Product> products = JsonConvert.DeserializeObject<List<Product>>(json);

            return products;
        }

        public void ShowObject(object sender, RoutedEventArgs e)
        {

            AboutProduct AboutProdt = new AboutProduct(sender);

            AboutProdt.Owner = this;

            AboutProdt.ShowDialog();

            Main_product_List.Remove(AboutProdt.OldProd);

            if (AboutProdt.NewProd != null)
                Main_product_List.Add(AboutProdt.NewProd);

            Products_Serrializator(Main_product_List);
        }

        private void ChangeLang(object sender, RoutedEventArgs e)
        {
            if(ChangeLng.Content.ToString().Contains("Lng : RU"))
            {
                this.Resources = new ResourceDictionary() { Source = new Uri("pack://application:,,,/Dictionary_Eng.xaml") };
                ChangeLng.Content = "Lng : EN";
            }
            else if(ChangeLng.Content.ToString().Contains("Lng : EN"))
            {
                this.Resources = new ResourceDictionary() { Source = new Uri("pack://application:,,,/Dictionary_Rus.xaml") };
                ChangeLng.Content = "Lng : RU";
            }

        }

        private void StyleSwithcer_Loaded(object sender, RoutedEventArgs e)
        {
            if (StyleBlack.IsChecked == true)
            {
                StyleCian.IsChecked = true;
                return;
            }
                

            if (StyleCian.IsChecked == true)
            {
                StyleGray.IsChecked = true;
                return;
            }
                

            if (StyleGray.IsChecked == true)
            {
                StyleBlack.IsChecked = true;
                return;
            }

        }


        //Сохранение состоянии для реализации undo redo

        private Memento MememtoObj = new Memento();
        private State CurrentSave;

        private void LoadSave()
        {
            Main_product_List = CurrentSave.MementoProdList;
            CB_Type.Text = CurrentSave.Type;
            TB_ProdName.Text = CurrentSave.Name;
            TB_MinPrice.Text = CurrentSave.PriceMin;
            TB_MaxPrice.Text = CurrentSave.PriceMax;
            AddProdsOnPanel();
        }

        private void Undo()
        {
            CurrentSave = MememtoObj.Undo();

            if (CurrentSave != null)
                LoadSave();
        }
        private void Redo()
        {
            CurrentSave = MememtoObj.Redo();

            if (CurrentSave != null)
                LoadSave();
        }

        private int i;
        private void SaveState()
        {

                try
                {
                    MememtoObj.SaveStatus(new State(
                                                    Main_product_List,
                                                    TB_MaxPrice.Text,
                                                    TB_MinPrice.Text,
                                                    TB_ProdName.Text,
                                                    CB_Type.Text
                                                    )
                                           );
                }
                catch(Exception e)
                {

                }
        }

        private void BTN_Undo_Click(object sender, RoutedEventArgs e)
        {
            Undo();
        }

        private void BTN_Redo_Click(object sender, RoutedEventArgs e)
        {
            Redo();
        }
    }
}