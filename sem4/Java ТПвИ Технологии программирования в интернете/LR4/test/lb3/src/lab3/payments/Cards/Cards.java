package lab3.payments.Cards;
import lab3.payments.account.account;
import lab3.payments.Cards.*;
import lab3.payments.Cards.CardsType;
public class Cards extends account{
    public static CardsType.cardType type;


    public static credit cr;
    public static debit db;
    public Cards(int n, int b) throws cardException {
        if (n<0 || n/10000<0 || n/10000>9)
            throw new cardException("Неверный номер карты");
        this.number=n;
        this.balance=b;
    }
public Cards(){};


    public Cards(int n, int b, CardsType.cardType t)
    {
        this.number=n;
        this.balance=b;
        if(t==CardsType.cardType.credit){
            cr=new credit();
            this.type=t;
        }
        else{
            this.type=t;
            db=new debit();
        }

       /* else*/

    }


    public String Show(){
        System.out.println(super.Show()+" Type:"+type);
        return super.Show()+"Type:"+type;
    }

    public class credit extends AbstCard {
        private String kind = "credit";

        public void Print() {
            System.out.println("This is credit card");
        }

    }
    public class debit extends AbstCard {
        private String kind = "debit";
        public void Print() {
            System.out.println("This is debit card");
        }
    }

}
