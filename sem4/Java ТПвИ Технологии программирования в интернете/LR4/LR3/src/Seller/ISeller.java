package Seller;
import PaperMedia.PaperMedia;

public interface ISeller {

    public PaperMedia[] SortBooks(PaperMedia[] PM);
    public int FindBook(PaperMedia[] main, String elem);
    public PaperMedia[] SellBook(PaperMedia[] main, String elem);
    public PaperMedia[] AddBook(PaperMedia[] main, PaperMedia elem);
}
