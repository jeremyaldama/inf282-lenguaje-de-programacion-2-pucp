package pe.edu.pucp.lp2soft.config;
import java.sql.Connection;
import java.sql.DriverManager;
public class DBManager {
    private Connection con;
    private static DBManager dbManager;
    private String url = "jdbc:mysql://"+
            "db-lp2-2023-2.cgv5bfkwja0r.us-east-1.rds.amazonaws.com" 
            + ":3306/" + "inf282";
    private String username = "admin";
    private String password = "inf282lp220232";
    
    public Connection getConnection(){
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(url, username, password);     
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return con;
    }
    
    public static DBManager getInstance(){
        if(dbManager == null){
            createInstance();
        }
        return dbManager;
    }
    
    private synchronized static void createInstance(){
        if(dbManager == null){
            dbManager = new DBManager();
        }
    }
}