package Seller;

import PaperMedia.PaperMedia;
import Seller.ISeller;

import static java.util.Arrays.copyOf;

public class Seller implements ISeller {

    @Override
    public PaperMedia[] SortBooks(PaperMedia[] PM) {
        for (int i = 0; i < PM.length - 1; i++) {
            for(int j = 0; j < PM.length - i - 1; j++) {
                if(PM[j + 1].getYearPublic() < PM[j].getYearPublic()) {
                    PaperMedia swap = PM[j];
                    PM[j] = PM[j + 1];
                    PM[j + 1] = swap;
                }
            }
        }
        return PM;
    }

    @Override
    public int FindBook(PaperMedia[] main, String elem) {
        for(int i = 0; i < main.length; i++){
            if(main[i].getAuthor() == elem){
                return i;
            }
        }
        return -1;
    }

    @Override
    public PaperMedia[] SellBook(PaperMedia[] main, String elem) {
        int bookposition = -1;

        for(int i = 0; i < main.length; i++){
            if(main[i].getName() == elem){
                bookposition = i;
                break;
            }
        }

        if(bookposition != -1)
            for(int j = bookposition; j < main.length - 1; j++){
                main[j] = main[j + 1];
            };
        main = copyOf(main, main.length - 1);
        return main;
    }

    @Override
    public PaperMedia[] AddBook(PaperMedia[] main, PaperMedia elem) {
        main = copyOf(main, main.length + 1);
        main[main.length - 1] = elem;
        return main;
    }
}
