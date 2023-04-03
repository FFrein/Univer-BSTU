package lab3.payments.Admin;

import lab3.payments.Cards.CardsType;
import lab3.payments.Client.Client;

public interface IAdmin {

     public void add(Client cl);
    public void newCard(CardsType.cardType last, CardsType.cardType nw);
    public void FindClient(String name);
    public void Block(int n);
}


