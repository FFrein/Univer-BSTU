
public class Main {

    public static void main(String[] args) throws ClassNotFoundException {
        SQLHandler sqlH = new SQLHandler();

        sqlH.logInfo();

        if(sqlH.getConnection()){
            sqlH.Task1();
            sqlH.closeConnection();
        }

        if(sqlH.getConnection()){
            sqlH.Task2();
            sqlH.closeConnection();
        }

        if(sqlH.getConnection()){
            sqlH.Task3();
            sqlH.closeConnection();
        }

        if(sqlH.getConnection()){
            sqlH.Task4();
            sqlH.closeConnection();
        }
    }
}
//DESKTOP-SFBEA64