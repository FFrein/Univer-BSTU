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
    public partial class AdminWindow : Window
    {
        public List<Product> product_List = new List<Product>();

        //----------buffer-----------

        public string PName_lng_buff;
        public string PName_shrt_buff;
        public string Ab_buff;
        public string srcIMG_buff;
        public string Cot_buff;
        public string PAvailb_buff;
        public int rat_buff;
        public int price_buff;
        public int amount_buff;
        public int disc_buff;



        public AdminWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //ProdName_lng.Text

            PName_lng_buff = ProdName_lng.Text;
        }

        private void ProdName_shrt_TB(object sender, TextChangedEventArgs e)
        {
            //ProdName_shrt.Text
            PName_shrt_buff = ProdName_shrt.Text;
        }

        private void About_TB(object sender, TextChangedEventArgs e)
        {
            //About
            Ab_buff = About.Text;
        }

        private void ProdAvailb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //ProdAvailb
            CheckAvailable();
        }
        //комбобоксы работают через жопу
        private void CheckAvailable()
        {
            PAvailb_buff = ProdAvailb.Text;
        }

        private void srcIMG_TB(object sender, TextChangedEventArgs e)
        {
            //srcIMG
            srcIMG_buff = srcIMG.Text;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CheckCotegory();
        }
        private void CheckCotegory()
        {
            //комбобоксы работают через жопу
            Cot_buff = Janr.Text;
        }

        private void price_TB(object sender, TextChangedEventArgs e)
        {
            //price
            try
            {
                price_buff = Convert.ToInt32(price.Text);
            }
            catch { }
        }

        private void rating_TB(object sender, TextChangedEventArgs e)
        {
            //rating
            try
            {
                rat_buff = Convert.ToInt32(rating.Text);
            }
            catch { }
        }

        private void discount_TB(object sender, TextChangedEventArgs e)
        {
            //discount
            try
            {
                disc_buff = Convert.ToInt32(discount.Text);
            }
            catch { }
        }

        private void amount_TB(object sender, TextChangedEventArgs e)
        {
            //amount
            try
            {
                amount_buff = Convert.ToInt32(amount.Text);
            }
            catch { }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CheckAvailable();
            CheckCotegory();

            product_List.Add(new Product(
                                        PName_lng_buff,
                                        PName_shrt_buff,
                                        Ab_buff,
                                        srcIMG_buff,
                                        Cot_buff,
                                        PAvailb_buff,
                                        rat_buff,
                                        price_buff,
                                        amount_buff,
                                        disc_buff
                                        )
                            );
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //F:\MyFile\Универ\4sem\С# ООТПиСП\№ 4_5_WPF_shop_service\№ 4-5  ООТПиСП\LR4-5 TryOne\img\phonk.jpg
            //F:\MyFile\Универ\4sem\С# ООТПиСП\№ 4_5_WPF_shop_service\№ 4-5  ООТПиСП\LR4-5 TryOne\img\phonk1.jpg
            //F:\MyFile\Универ\4sem\С# ООТПиСП\№ 4_5_WPF_shop_service\№ 4-5  ООТПиСП\LR4-5 TryOne\img\phonk2.jpg
            //F:\MyFile\Универ\4sem\С# ООТПиСП\№ 4_5_WPF_shop_service\№ 4-5  ООТПиСП\LR4-5 TryOne\img\phonk3.jpg
            //F:\MyFile\Универ\4sem\С# ООТПиСП\№ 4_5_WPF_shop_service\№ 4-5  ООТПиСП\LR4-5 TryOne\img\phonk4.jpg
            //F:\MyFile\Универ\4sem\С# ООТПиСП\№ 4_5_WPF_shop_service\№ 4-5  ООТПиСП\LR4-5 TryOne\img\phonk5.jpg

            product_List.Add(new Product(
                            "vendetta",
                            "Mimm",
                            "About",
                            "F:\\MyFile\\Универ\\Univer\\sem4\\С# ООТПиСП\\№ 7 Создание WPF пользовательских ЭУ\\№ 4-5  ООТПиСП\\LR4-5 TryOne\\img\\phonk.jpg",
                            "Манга",
                            "Available",
                            9,
                            100,
                            10,
                            20
                            )
                );
            product_List.Add(new Product(
                            "Murder in my mind",
                            "Mimm",
                            "About",
                            "F:\\MyFile\\Универ\\Univer\\sem4\\С# ООТПиСП\\№ 7 Создание WPF пользовательских ЭУ\\№ 4-5  ООТПиСП\\LR4-5 TryOne\\img\\phonk1.jpg",
                            "Манхва",
                            "Available",
                            9,
                            120,
                            5,
                            20
                            )
                );
            product_List.Add(new Product(
                            "Metamarphosis",
                            "Mimm",
                            "About",
                            "F:\\MyFile\\Универ\\Univer\\sem4\\С# ООТПиСП\\№ 7 Создание WPF пользовательских ЭУ\\№ 4-5  ООТПиСП\\LR4-5 TryOne\\img\\phonk2.jpg",
                            "Маньхуа",
                            "Available",
                            9,
                            140,
                            2,
                            50
                            )
                );
            product_List.Add(new Product(
                            "Rave",
                            "Mimm",
                            "About",
                            "F:\\MyFile\\Универ\\Univer\\sem4\\С# ООТПиСП\\№ 7 Создание WPF пользовательских ЭУ\\№ 4-5  ООТПиСП\\LR4-5 TryOne\\img\\phonk3.jpg",
                            "Новелла",
                            "Available",
                            5,
                            160,
                            12,
                            20
                            )
                );
            product_List.Add(new Product(
                            "SHADOW",
                            "Mimm",
                            "About",
                            "F:\\MyFile\\Универ\\Univer\\sem4\\С# ООТПиСП\\№ 7 Создание WPF пользовательских ЭУ\\№ 4-5  ООТПиСП\\LR4-5 TryOne\\img\\phonk5.jpg",
                            "Манга",
                            "Available",
                            6,
                            180,
                            10,
                            0
                            )
                );
            product_List.Add(new Product(
                            "GHOST!",
                            "Mimm",
                            "About",
                            "F:\\MyFile\\Универ\\Univer\\sem4\\С# ООТПиСП\\№ 7 Создание WPF пользовательских ЭУ\\№ 4-5  ООТПиСП\\LR4-5 TryOne\\img\\phonk6.jpg",
                            "Маньхуа",
                            "Available",
                            7,
                            200,
                            1,
                            20
                            )
                );
            product_List.Add(new Product(
                            "Murder in my mind",
                            "Mimm",
                            "About",
                            "F:\\MyFile\\Универ\\Univer\\sem4\\С# ООТПиСП\\№ 7 Создание WPF пользовательских ЭУ\\№ 4-5  ООТПиСП\\LR4-5 TryOne\\img\\Fight_CLUB.PNG",
                            "Манхва",
                            "Available",
                            8,
                            10,
                            15,
                            10
                            )
                );
        }
    }
}
