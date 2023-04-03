package Serrialize;

import PaperMedia.PaperMedia;
import Seller.Seller;
import org.xml.sax.Attributes;
import org.xml.sax.SAXException;
import org.xml.sax.helpers.DefaultHandler;
import Shop.Library;
import static java.util.Arrays.copyOf;
import PaperMedia.PaperMediaType;
public class SaxParser extends DefaultHandler {
    Library lib1 = new Library();
    String thisElement = "";
    int num = 0;

    public SaxParser() {
    }

    public void startDocument() throws SAXException {
        System.out.println("----> Start parse XML...");
    }

    public void startElement(String namespaceURI, String localName, String qName, Attributes atts) throws SAXException {
        this.thisElement = qName;
    }

    public Library getResult() {
        return this.lib1;
    }

    public void characters(char[] ch, int start, int length) throws SAXException {
        if (this.thisElement.equals("Seller")) {
            this.lib1.Seller = new Seller();
        } else if (this.thisElement.equals("ARRAY_PM")) {
            this.lib1.ARRAY_PM = new PaperMedia[0];
        } else if(this.thisElement.equals("PaperMedia")){
            this.lib1.ARRAY_PM = copyOf(this.lib1.ARRAY_PM, this.lib1.ARRAY_PM.length + 1);
            this.lib1.ARRAY_PM[this.lib1.ARRAY_PM.length - 1] = new PaperMedia();
        } else if(this.thisElement.equals("YearPublic")){
            this.lib1.ARRAY_PM[this.lib1.ARRAY_PM.length - 1].setYearPublic(Integer.parseInt(new String(ch, start, length)));
        } else if(this.thisElement.equals("Pages")){
            this.lib1.ARRAY_PM[this.lib1.ARRAY_PM.length - 1].setPages(Integer.parseInt(new String(ch, start, length)));
        } else if(this.thisElement.equals("Price")){
            this.lib1.ARRAY_PM[this.lib1.ARRAY_PM.length - 1].setPrice(Integer.parseInt(new String(ch, start, length)));
        } else if(this.thisElement.equals("Author")){
            this.lib1.ARRAY_PM[this.lib1.ARRAY_PM.length - 1].setAuthor((new String(ch, start, length)));
        } else if(this.thisElement.equals("PMT")){
            String buff = (new String(ch, start, length));
            if(buff.equals("Book")){
                this.lib1.ARRAY_PM[this.lib1.ARRAY_PM.length - 1].setPMT(PaperMediaType.Book);
            }
            if(buff.equals("Jrnl")){
                this.lib1.ARRAY_PM[this.lib1.ARRAY_PM.length - 1].setPMT(PaperMediaType.Jrnl);
            }
            if(buff.equals("Nwsp")){
                this.lib1.ARRAY_PM[this.lib1.ARRAY_PM.length - 1].setPMT(PaperMediaType.Nwsp);
            }
        } else if(this.thisElement.equals("Name")){
            this.lib1.ARRAY_PM[this.lib1.ARRAY_PM.length - 1].setName((new String(ch, start, length)));
        }

    }

    public void endElement(String namespaceURI, String localName, String qName) throws SAXException {
        this.thisElement = "";
    }

    public void endDocument() {
        System.out.println("----> Stop parse XML...");
    }
}
