/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

package pe.edu.pucp.lp2soft.main;

import java.rmi.Naming;
import java.rmi.registry.LocateRegistry;
import pe.edu.pucp.lp2soft.imp.ClaseRemota;
import pe.edu.pucp.lp2soft.interfaces.InterfazRemota;

/**
 *
 * Author: Jeremy Aldama (20206228)
 */
public class RMIServer {
    private static String puerto = "1234";
    private static String IP = ""
    
    public static void main(String[] args) {
        try {
            LocateRegistry.createRegistry(Integer.parseInt(puerto));
            InterfazRemota objRemoto = new ClaseRemota(Integer.parseInt(puerto));
            Naming.rebind("//localhost:" + puerto + "/" + "objRemoto", objRemoto);
            System.out.println("El servidor se ha desplegado con exito");
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
    }
}
