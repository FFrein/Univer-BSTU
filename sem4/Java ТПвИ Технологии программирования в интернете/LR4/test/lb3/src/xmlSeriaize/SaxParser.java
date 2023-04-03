package xmlSeriaize;



import javax.xml.stream.*;
import javax.xml.stream.events.XMLEvent;
import java.io.IOException;
import java.io.InputStream;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.ArrayList;


import  lab3.payments.Cards.*;
import  lab3.payments.account.*;
import org.xml.sax.Attributes;
import org.xml.sax.SAXException;
import org.xml.sax.helpers.DefaultHandler;

public class SaxParser extends DefaultHandler {
    /*Cards card1 = new Cards();*/
    account  ac1= new account();
    String thisElement = "";

    public SaxParser() {
    }

    public void startDocument() throws SAXException {
        System.out.println("----> Start parse XML...");
    }

    public void startElement(String namespaceURI, String localName, String qName, Attributes atts) throws SAXException {
        this.thisElement = qName;
    }

    public account getResult() {
       // return this.card1;
        return this.ac1;
    }
  int num=0;
    public void characters(char[] ch, int start, int length) throws SAXException {
       /* if (this.thisElement.equals("Cards")) {
            Cards card1= new Cards();
        }*/

       if (this.thisElement.equals("number")) {
            num = Integer.parseInt(new String(ch, start, length));
        } else if (this.thisElement.equals("balance")) {
            //this.card1.balance = Integer.parseInt(new String(ch, start, length));
           Cards card1 = new Cards();
           card1.balance=Integer.parseInt(new String(ch, start, length));
           card1.number=num;
           this.ac1.cardList.add(card1);
         card1=null;
        }

    }

    public void endElement(String namespaceURI, String localName, String qName) throws SAXException {
        this.thisElement = "";
    }

    public void endDocument() {
        System.out.println("----> Stop parse XML...");
    }
}