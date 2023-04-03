package PaperMedia;
import PaperMedia.PaperMediaType;
public class PaperMedia {
    private int YearPublic;
    private int Pages;
    private int Price;
    private String Author;
    private PaperMediaType PMT;
    private String Name ;

    public PaperMedia(String name, int year, int pages, int price, String author, PaperMediaType pmt){
        Name = name;
        YearPublic = year;
        Pages = pages;
        Price = price;
        Author = author;
        PMT = pmt;
    }
    public PaperMedia() {

    }
    public String getName() {
        return Name;
    }
    public void setName(String name){
        Name = name;
    }
    public void setPMT(PaperMediaType _pmt){
        PMT = _pmt;
    }
    public PaperMediaType getPMT(){
        return PMT;
    }

    public String getAuthor(){
        return Author;
    }
    public void setAuthor(String Name){
        Author = Name;
    }
    public void setYearPublic(int year){
        YearPublic = year;
    }
    public int getYearPublic(){
        return YearPublic;
    }
    public void setPages(int pages){
        Pages = pages;
    }
    public int getPages(){
        return Pages;
    }
    public int getPrice(){
        return Price;
    }
    public void setPrice(int price){
        Price = price;
    }
}
