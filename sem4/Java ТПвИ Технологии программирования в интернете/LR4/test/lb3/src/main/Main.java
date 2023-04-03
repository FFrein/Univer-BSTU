package main;
import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import  lab3.payments.Cards.*;
import  lab3.payments.account.*;
import  xmlSeriaize.*;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Stream;
import java.util.stream.*;
import javax.xml.parsers.SAXParser;
import javax.xml.parsers.SAXParserFactory;

import java.beans.XMLEncoder;
import java.io.File;
import java.io.FileOutputStream;
import java.nio.charset.StandardCharsets;
import java.util.Scanner;
import java.util.logging.*;


public class Main {
    // private static final Logger logger = Logger.getLogger(Main.class);
    public static void main(String[] args) {
        final Logger logger = Logger.getLogger("lab3.payments.main");
        logger.setLevel(Level.INFO);
        try {



            SAXParserFactory factory= SAXParserFactory.newInstance();
            SAXParser parser=factory.newSAXParser();
            SaxParser saxp = new SaxParser();
            parser.parse(new File("C:\\instit\\kurs2-2\\Java\\lab4\\lb3\\files\\CardList.xml"), saxp);
            /*Cards card3 = saxp.getResult();
            System.out.println(card3.number);
            System.out.println(card3.balance);*/
            account acc = saxp.getResult();
            for (Cards a:acc.cardList
                 ) {
                System.out.println("----------------------------------");
                System.out.println(a.number);
                System.out.println(a.balance);

            }
//5
            Cards card1=new Cards(1, 2000);
            System.out.println("--------------JSON Serialization---------------");
            Gson gson = new GsonBuilder().create();
            String json = gson.toJson(card1);
            System.out.println(json);
            FileOutputStream jsonOut = new FileOutputStream("C:\\instit\\kurs2-2\\Java\\lab4\\lb3\\files\\Serialize.json");
            System.out.println("--------------JSON Deserialization---------------");
            Scanner scanner = new Scanner(new File("C:\\instit\\kurs2-2\\Java\\lab4\\lb3\\files\\Serialize.json"));
            String res = "";
            while(scanner.hasNext())
                res += scanner.nextLine();
            scanner.close();
            Cards m3 = gson.fromJson(res, Cards.class);
            System.out.println( m3.number);
            System.out.println(m3.balance);
//6
            Cd card2=new Cd(1, 8300);
            Cd card5=new Cd(1, 8300);
            Cd card3=new Cd(3, 1000);
            Cd card4=new Cd(4, 7000);

            account ac6= new account();
            ac6.ADD(card2);
            ac6.ADD(card3);
            ac6.ADD(card5);
            ac6.ADD(card4);




            System.out.println("-------------------Stream API-------------");
            ac6.cdList.stream() // получаем поток
                    .filter(s->s.balance>3000) // применяем фильтрацию по длине строки
                    .forEach(s->System.out.println(s.balance)); // выводим отфильтрованные строки на консоль
            System.out.println("-------------------------------");
            ac6.cdList.stream() // получаем поток
                    .limit(3) // применяем фильтрацию по длине строки
                    .forEach(s->System.out.println(s.balance));














           // byte[] outText = json.getBytes(StandardCharsets.UTF_8);
           // jsonOut.write(outText, 0, outText.length);
            //LOG.info("JSON serialized");

           /* System.out.println("-----JSON Deserialize-----");
            Scanner scanner = new Scanner(new File("files/info.json"));
            StringBuilder result = new StringBuilder();
            while(scanner.hasNext())
                result.append(scanner.nextLine());
            scanner.close();
            Admin annaJson = gson.fromJson(result.toString(), Admin.class);
            annaJson.show();
            LOG.info("JSON deserialized");*/




            /*SAXParserFactory factory;
            factory = SAXParserFactory.newInstance();
            SAXParser saxParser = factory.newSAXParser();

            // Стартуем разбор XML-документа
            SAXExample ex=new SAXExample();
            ex.handler= new DefaultHandler();
            saxParser.parse("C:\\instit\\kurs2-2\\Java\\lab4\\lb3\\files\\CardList.xml", ex.handler);
*/









          /*  logger.info("Начало выполнения программы");
            Cards card1=new Cards(1, 2000);
            Cards card2=new Cards(1, 2300);
            Cards card3=new Cards(3, 5000);
            Cards card4=new Cards(3, 5000, CardsType.cardType.credit);

            account acc1 = new account();
            account acc2 = new account();
            acc1.add(card1);
            acc1.add(card2);
            acc1.add(card3);
            acc1.add(card4);
            acc2.add(card3);
            acc1.add(card4);

            Client cl1= new Client();
            Client cl2= new Client();
            cl1.name="Ivanov";
            cl2.name="Petrov";
            cl1.acc=acc1;
            cl2.acc=acc2;
            System.out.println("\nShow Information:");
            cl1.Show(3);
            cl1.Block(3);
            System.out.println("\nShow Information after block:");
            cl1.Show(3);
            System.out.println("\nShow Information after addition money:");
            cl1.Addition(3,100);
            cl1.Show(3);

            Admin admin1= new Admin();
            admin1.Block(1);
            admin1.add(cl1);
            admin1.add(cl2);
            admin1.FindClient("Ivanov");
            admin1.newCard(CardsType.cardType.credit, CardsType.cardType.debit);
           // card3.Show();
          logger.info("You successfully ran this program!");
*/

        }
        catch (Exception e){
            logger.warning("Fatal error! " + e.getMessage());
        }

    }
}