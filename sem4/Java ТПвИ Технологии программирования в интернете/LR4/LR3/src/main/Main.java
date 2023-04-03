package main;
import PaperMedia.PaperMedia;
import PaperMedia.PaperMediaType;
import Serrialize.SaxParser;
import Shop.Library;
import Seller.Seller;

import javax.management.openmbean.ArrayType;
import java.io.FileInputStream;
import java.io.IOException;
import java.util.Arrays;
import java.util.logging.Logger;

import javax.xml.stream.XMLInputFactory;
import javax.xml.stream.XMLStreamException;
import javax.xml.stream.XMLStreamReader;
import javax.xml.stream.events.XMLEvent;
import java.nio.file.Files;
import java.nio.file.Paths;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import java.io.File;
import java.io.FileOutputStream;
import java.util.Iterator;
import java.util.Scanner;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.xml.parsers.SAXParser;
import javax.xml.parsers.SAXParserFactory;


public class Main {

    private static final Logger LOG = Logger.getLogger(Main.class.getName());

    public static void getInfoOfLib(Library lib){
        for (int i = 0; i < lib.ARRAY_PM.length; i++) {
            System.out.println(
                    "\nName " +
                            lib.ARRAY_PM[i].getName() + "\nYearPublic " +
                            lib.ARRAY_PM[i].getYearPublic() + "\nAuthor " +
                            lib.ARRAY_PM[i].getAuthor() + "\nPages " +
                            lib.ARRAY_PM[i].getPages() + "\nPMT " +
                            lib.ARRAY_PM[i].getPMT() + "\nPrice " +
                            lib.ARRAY_PM[i].getPrice() + "\n "
            );
        }
    }

    public static void main(String[] args) throws XMLStreamException, IOException {

        Library.key rkey = new Library.key();

        Object arObj = new float[5];

        System.out.println(PaperMediaType.Book);

        LOG.info("Start program");
        Library lib1 = new Library();
        lib1.Seller = new Seller();
        lib1.ARRAY_PM = new PaperMedia[0];
        lib1.ARRAY_PM = lib1.Seller.AddBook(
                lib1.ARRAY_PM,
                new PaperMedia("Cookie Jar",2000, 279, 30, "King", PaperMediaType.Book)
        );
        lib1.ARRAY_PM = lib1.Seller.AddBook(
                lib1.ARRAY_PM,
                new PaperMedia("The Long Road",2002, 150, 70, "King", PaperMediaType.Book)
        );
        lib1.ARRAY_PM = lib1.Seller.AddBook(
                lib1.ARRAY_PM,
                new PaperMedia("Scratch-End",2001, 250, 50, "King", PaperMediaType.Book)
        );

        getInfoOfLib(lib1);

        lib1.Seller.SortBooks(lib1.ARRAY_PM);

        getInfoOfLib(lib1);

        lib1.ARRAY_PM = lib1.Seller.SellBook( lib1.ARRAY_PM,"Scratch-End");

        getInfoOfLib(lib1);

        ///////////////// LR4

        //XML
        try {
            final String filename = "F:\\MyFile\\Универ\\4sem\\Java ТПвИ Технологии программирования в интернете\\LR4\\LR3\\src\\main\\Library.xml";
            SAXParserFactory factory = SAXParserFactory.newInstance();
            SAXParser parser = factory.newSAXParser();
            SaxParser saxp = new SaxParser();
            parser.parse(new File(filename), saxp);
            Library lib22 = saxp.getResult();

            getInfoOfLib(lib22);
        }
        catch (Exception var18) {
            LOG.warning("Fatal error! " + var18.getMessage());
        }

        //JSON
        System.out.println("--------------JSON Serialization---------------");
        Gson gson = (new GsonBuilder()).create();
        String json = gson.toJson(lib1);
        System.out.println(json);
        new FileOutputStream("F:\\MyFile\\Универ\\4sem\\Java ТПвИ Технологии программирования в интернете\\LR4\\LR3\\src\\main\\Serialize.json");

        System.out.println("--------------JSON Deserialization---------------");
        Scanner scanner = new Scanner(new File("F:\\MyFile\\Универ\\4sem\\Java ТПвИ Технологии программирования в интернете\\LR4\\LR3\\src\\main\\Serialize.json"));

        String res;
        for(res = ""; scanner.hasNext(); res = res + scanner.nextLine()) {
        }

        scanner.close();

        Library lib3 = (Library)gson.fromJson(json, Library.class);

        getInfoOfLib(lib3);


        System.out.println("-------------------Stream API-------------");
        Arrays.stream(lib3.ARRAY_PM).filter((s)->{
            return s.getPrice() < 200;
        }).forEach((s)-> {
            System.out.println(s.getName());
        });


        int i = 128;
        Integer a = i;
        Integer b = i;
        System.out.println((a==b));

        System.out.println(lib3.i);
    }
}