import java.sql.*;
import org.apache.log4j.BasicConfigurator;
import org.apache.log4j.Logger;
//DAO
public class SQLHandler {
    //логер
    private static final Logger logger = Logger.getLogger(Main.class);

    // LOG
    public void logInfo() {
        BasicConfigurator.configure();
        logger.info("Start Main");
    }
    //SQLHandler
    private static final String url = "jdbc:mysql://localhost:3306/planets";
    private static final String user = "root";
    private static final String password = "12345";

    // JDBC variables for opening and managing connection
    private static Connection con;
    private static Statement stmt;
    private static PreparedStatement prpstmt;
    private static ResultSet rs;
    private static ResultSet rs2;
    public static String  query1 = "select idPlanet, PlanetName, Radius, CoreTemperature, Atmosphere, Life, SatteliteGroup, SatelliteName" +
            " from planet Inner Join satellite" +
            " On SatteliteGroup = SatelliteGroupId" +
            " where Life = 1";

    public static String  query2 = "select idPlanet, PlanetName, Radius, CoreTemperature, Atmosphere, Life, SatteliteGroup " +
            "from planet " +
            "Order by Radius ";

    public static String query3 = "select idPlanet, PlanetName, count(SatelliteName)" +
            " from planet Inner Join satellite" +
            " On SatteliteGroup = SatelliteGroupId" +
            " Group by idPlanet";

    public static String query4 ="select idPlanet, PlanetName, sum(Distancion)" +
            " from planet Inner Join satellite" +
            " On SatteliteGroup = SatelliteGroupId" +
            " Group by idPlanet";
    // Подключение БД в Java
    public Boolean getConnection() {
        try {
            logger.info("Connect to DB (func getConnection())");
            con = DriverManager.getConnection(url, user, password);
            stmt = con.createStatement();
            logger.info("Connect to DB create (func getConnection())");
            return true;
        }
        catch(Exception ex) {
            logger.error("Connect to DB Error (func getConnection())");
            System.out.println(ex);
            return false;
        }
    }
    //закрытие подключения
    public void closeConnection() {
        try {
            logger.info("Close connect to DB (func closeConnection())");
            con.close();
            stmt.close();
            logger.info("Connect to DB close (func closeConnection())");
        }
        catch (Exception ex) {
            logger.error("Close DB Error (func closeConnection())");
            System.out.println(ex);
        }
    }

    public static void Task1() {
        try {
            logger.info("Connect to DB (func Task1())");
            // выполнение запроса и получение результатов
            rs = stmt.executeQuery(query1);
            //вывод результатов
            System.out.println("\tid\tPName\tRadius\tCoreTemp\tAtmsph\tLife\tSatelliteGrp\tSatelliteName");

            while (rs.next()) {

                System.out.println(
                        "\t " + rs.getInt(1) +
                        "\t " + rs.getString(2) +
                        "\t " + rs.getString(3) +
                        "\t " + rs.getString(4) +
                        "\t\t " + rs.getString(5) +
                        "\t\t " + rs.getString(6) +
                        "\t\t " + rs.getString(7) +
                        "\t\t\t\t " + rs.getString(8)
                );
            }

        } catch (SQLException sqlEx) {
            sqlEx.printStackTrace();
            logger.info("Query Error (func Task1())");
        } finally {
            //завершение соединений
            try { con.close(); } catch(SQLException se) { /*can't do anything */ }
            try { stmt.close(); } catch(SQLException se) { /*can't do anything */ }
            try { rs.close(); } catch(SQLException se) { /*can't do anything */ }
            logger.info("Close connect to DB (func Task1())");
        }
    }

    public static void Task2() {
        try {
            logger.info("Connect to DB (func Task2())");
            // выполнение запроса и получение результатов
            rs = stmt.executeQuery(query2);
            //вывод результатов
            System.out.println("\tid\tPName\t\tRadius\tCoreTemp\tAtmsph\tLife\tSatelliteGrp");
            while (rs.next()) {
                System.out.println(
                        "\t " + rs.getInt(1) +
                        "\t " + rs.getString(2) +
                        "\t " + rs.getString(3) +
                        "\t " + rs.getString(4) +
                        "\t\t " + rs.getString(5) +
                        "\t\t " + rs.getString(6) +
                        "\t\t " + rs.getString(7)
                );
                break;
            }

        } catch (SQLException sqlEx) {
            sqlEx.printStackTrace();
            logger.info("Query Error (func Task2())");
        } finally {
            try { rs.close(); } catch(SQLException se) { /*can't do anything */ }
            logger.info("Close connect to DB (func Task2())");
        }
    }
    public static void Task3() {
        try {
            logger.info("Connect to DB (func Task3())");
            // выполнение запроса и получение результатов
            rs = stmt.executeQuery(query3);
            //вывод результатов
            System.out.println("\tid\tPName\t\tSatelliteCount");
            while (rs.next()) {
                System.out.println(
                        "\t " + rs.getInt(1) +
                        "\t " + rs.getString(2) +
                        "\t " + rs.getInt(3)

                );
                break;
            }

        } catch (SQLException sqlEx) {
            sqlEx.printStackTrace();
            logger.info("Query Error (func Task3())");
        } finally {

            try { rs.close(); } catch(SQLException se) { /*can't do anything */ }
            logger.info("Close connect to DB (func Task3())");
        }
    }
    public static void Task4() {
        try {
            logger.info("Connect to DB (func Task4())");
            // выполнение запроса и получение результатов
            prpstmt = con.prepareStatement(query4);
            rs = prpstmt.executeQuery();
            //вывод результатов
            System.out.println("\tid\tPName\t\tSatelliteRadius");
            while (rs.next()) {
                System.out.println(
                        "\t " + rs.getInt(1) +
                        "\t " + rs.getString(2) +
                        "\t " + rs.getInt(3));
                break;
            }

        } catch (SQLException sqlEx) {
            sqlEx.printStackTrace();
            logger.info("Query Error (func Task4())");
        } finally {
            try { rs.close(); } catch(SQLException se) { /*can't do anything */ }
            try { prpstmt.close(); } catch(SQLException se) { /*can't do anything */ }
        }
    }
    //добавление
    public static void Task5() {
        try {
            logger.info("Connect to DB (func Task5())");
            // выполнение запроса и получение результатов
            rs = stmt.executeQuery(query4);
            //вывод результатов
            System.out.println("\tid\tPName\t\tSatelliteRadius");
            while (rs.next()) {
                System.out.println(
                        "\t " + rs.getInt(1) +
                                "\t " + rs.getString(2) +
                                "\t " + rs.getInt(3));
                break;
            }

        } catch (SQLException sqlEx) {
            sqlEx.printStackTrace();
            logger.info("Query Error (func Task5())");
        } finally {
            try { rs.close(); } catch(SQLException se) { /*can't do anything */ }
            logger.info("Close connect to DB (func Task5())");
        }
    }
    //удаление
    public static void Task6() {
        try {
            logger.info("Connect to DB (func Task6())");
            // выполнение запроса и получение результатов
            rs = stmt.executeQuery(query4);
            //вывод результатов
            System.out.println("\tid\tPName\t\tSatelliteRadius");
            while (rs.next()) {
                System.out.println(
                        "\t " + rs.getInt(1) +
                                "\t " + rs.getString(2) +
                                "\t " + rs.getInt(3));
                break;
            }

        } catch (SQLException sqlEx) {
            sqlEx.printStackTrace();
            logger.info("Query Error (func Task6())");
        } finally {
            try { rs.close(); } catch(SQLException se) { /*can't do anything */ }
            logger.info("Close connect to DB (func Task6())");
        }
    }
}
