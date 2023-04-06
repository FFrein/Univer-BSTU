using System;
using System.Text.Json.Serialization;
using System.Windows;

namespace __4_5__ООТПиСП
{
    public class Product
    {
        /*
        Каждый товар/услуга должен иметь название краткое и полное, 
        описание, изображение (можно несколько), категория, рейтинг, цену, 
        количество и другие параметры (цвет, размер, страна доставки, скидки, 
        нет в наличии, связанные товары/услуги, количество купленных, 
        производство). Товары/услуги сохраняйте в фале любого формата (json, 
        xml, binary, text ..).
        */
        public string ProdName_lng { get; set; }
        public string ProdName_shrt;
        public string About;
        public string srcIMG;
        private string _category;
        public string Cotegory { 
            get {
                return _category;
            }
            set {
            if(value == "Манга" ||
               value == "Манхва" ||
               value == "Маньхуа" ||
               value == "Новелла"
               )
                    _category = value;
            } 
        }
        private string _prodAvailable;
        public string ProdAvailb {
            get {
                return _prodAvailable;
            }
            set { 
                if(value == "Available" ||
                   value == "NoAvailable"
                  )
                    _prodAvailable = value;
            }    
        }
        public int rating;
        public int price;
        public int amount;
        public int discount;

        public Product()
        {
        }

        public Product( string lngName, string shrtname, string about, string _srcIMG,
                        string prodc, string avlb,
                        int _rating, int _price, int _amount, int _discount = 0
                        )
        {
            ProdName_lng= lngName;
            ProdName_shrt= shrtname;
            About= about;
            Cotegory = prodc;
            ProdAvailb = avlb;
            rating =  _rating;
            price = _price;
            amount = _amount;
            srcIMG = _srcIMG;
        }

    }
}
