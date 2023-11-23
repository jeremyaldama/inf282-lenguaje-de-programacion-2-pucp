/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ulearn.config;

import java.sql.Connection;
import java.sql.DriverManager;


/**
 *
 * @author Eilyn Davila
 */
public class DBManager {
    
    private Connection con;
    private static DBManager dbmanager;
    private String url = "jdbc:mysql://" + "ulearn-final.cuv6drju1tkv.us-east-1.rds.amazonaws.com" 
            + ":3306/" + "ulearn_db?autoReconnect=true&useSSL=false"; 
    private String username = "admin";
    private String password = "lp2-inf282-ulearn";
    
    public Connection getConnection(){
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(url,username,password);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return con;
    }
    
    public static DBManager getInstance(){
        if(dbmanager == null){
            createInstance();
        }
        return dbmanager;
    }
    
    private synchronized static void createInstance(){
        if(dbmanager == null){
            dbmanager = new DBManager();
        }
    }
    
}
