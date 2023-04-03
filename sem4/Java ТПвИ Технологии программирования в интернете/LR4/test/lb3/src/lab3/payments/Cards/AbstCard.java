package lab3.payments.Cards;

public abstract class AbstCard {
    private String kind;
    public void Print(){
        System.out.println("You make:"+this.kind);
    }
}
