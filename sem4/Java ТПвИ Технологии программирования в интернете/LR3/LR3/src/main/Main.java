package main;
import PaperMedia.PaperMedia;
import PaperMedia.PaperMediaType;
import Shop.Library;
import Seller.Seller;

import javax.management.openmbean.ArrayType;
import java.util.logging.Logger;


public class Main {

    private static final Logger LOG = Logger.getLogger(Main.class.getName());

    public static void main(String[] args) {
        LOG.info("Start program");
        Library lib1 = new Library();
        lib1.Seller = new Seller();
        lib1.ARRAY_PM = new PaperMedia[0];
        lib1.ARRAY_PM = lib1.Seller.AddBook(
                lib1.ARRAY_PM,
                new PaperMedia("Cookie Jar",2000, 279, 30, "Стивен Кинг", PaperMediaType.Book)
        );
        lib1.ARRAY_PM = lib1.Seller.AddBook(
                lib1.ARRAY_PM,
                new PaperMedia("The Long Road",2002, 150, 70, "Стивен Кинг", PaperMediaType.Book)
        );
        lib1.ARRAY_PM = lib1.Seller.AddBook(
                lib1.ARRAY_PM,
                new PaperMedia("Scratch-End",2001, 250, 50, "Стивен Кинг", PaperMediaType.Book)
        );

        for(int i = 0; i < lib1.ARRAY_PM.length; i++){
            System.out.println(lib1.ARRAY_PM[i].getName());
        }

        lib1.Seller.SortBooks(lib1.ARRAY_PM);

        for(int i = 0; i < lib1.ARRAY_PM.length; i++){
            System.out.println(lib1.ARRAY_PM[i].getName());
        }

        lib1.ARRAY_PM = lib1.Seller.SellBook( lib1.ARRAY_PM,"Scratch-End");

        for(int i = 0; i < lib1.ARRAY_PM.length; i++){
            System.out.println(lib1.ARRAY_PM[i].getName());
        }
    }
}