package lab3.payments.Client;
import lab3.payments.account.account;
import lab3.payments.Cards.*;
public class Client extends account {
    public void setName(String name) {
        this.name = name;
    }

    public String name;

    public String getName() {
        return this.name;
    }

    public Cards card;

    public account getAcc() {
        return acc;
    }

    public void setAcc(account acc) {
        this.acc = acc;
    }

    public account acc;

    public void Show(int n) throws cardException {

       // System.out.println("\nFIO:"+this.name+" "+card.Show());
        boolean b = true;
        for (var a:acc.cardList) {
            if(a.number==n){
                System.out.println("\nFIO:"+this.name);
                a.Show();
                b=false;
                return;
            }

        }
        if(b)
        throw new cardException("Account not found");
    }


    public void Block(int n){
        account.number=n;
        account.balance=0;
    }
    public void Addition(int n, int i) {
        account.number = n;
        account.balance += i;
    }
}
