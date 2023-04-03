package lab3.payments.Admin;

import lab3.payments.Cards.Cards;
import lab3.payments.Cards.CardsType;
import lab3.payments.Client.Client;

import java.util.ArrayList;
import java.util.List;

public class Admin extends Client implements IAdmin {
    public List<Client>  clientList;
    public Admin() {
        clientList = new ArrayList<>();
    }

    public void add(Client cl){
        clientList.add(cl);
    }

    public void FindClient(String name){
        for (var a:this.clientList
        ) {
            if(a.name==name){
                a.Show();
                System.out.println("\n This client was find");
            }

        }
    }

    public void newCard(CardsType.cardType last,  CardsType.cardType nw){
        for (var a:this.clientList
        ) {
            for (var b:a.acc.cardList){
                if(b.type==last){
                    b.type=nw;
                    System.out.println("\nnew card successfully issued");
                }

            }


        }
    }

}
