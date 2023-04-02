using System;

namespace __4_5__ООТПиСП
{
    public enum ProductCategory
    {
        manga,
        novel,
        manhwa,
        manhua
    }
    public enum Availability
    {
       Available,
       NoAvailable
    }
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
        string ProdName_lng;
        string ProdName_shrt;
        string About;
        ProductCategory Cotegory;
        Availability ProdAvailb;
        int rating;
        int price;
        int amount;
        int discount;
       

        public Product( string lngName, string shrtname, string about, 
                        ProductCategory prodc, Availability avlb,
                        int _rating, int _price, int _amount, int _discount = 0
                        )
        {
            ProdName_lng= lngName;
            ProdName_shrt= shrtname;
            About= about;
            ProductCategory Cotegory= prodc;
            Availability ProdAvailb= avlb;
            rating =  _rating;
            price = _price;
            amount = _amount;

        }

    }
}
