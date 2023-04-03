package task1;

public class Client implements Runnable{
    private final static int WAITING_TIME = 200;
    private final int id;
    private final CallCenter callCenter;

    public Client(CallCenter callCenter, int id) {
        this.callCenter = callCenter;
        this.id = id;
    }

    public int getId() {
        return id;
    }

    @Override
    public void run() {
        Operator operator = null;
        try {
            while (operator == null) {
                System.out.println("Client " + id + " try phone");
                operator = callCenter.tryCall(this, WAITING_TIME);
            }
            System.out.println("Client " + id + " phone to operator " + operator.getId());
            operator.talk();
        } catch (Exception e) {
            e.printStackTrace();
        } finally {
            if (operator != null) {
                System.out.println("Client " + id + " finish speak with operator " + operator.getId());
                callCenter.endCall(operator);
            }
        }
    }
}
