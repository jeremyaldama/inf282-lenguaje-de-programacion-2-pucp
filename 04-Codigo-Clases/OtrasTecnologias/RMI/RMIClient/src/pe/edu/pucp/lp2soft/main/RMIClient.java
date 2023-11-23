/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

package pe.edu.pucp.lp2soft.main;

import java.rmi.Naming;
import pe.edu.pucp.lp2soft.interfaces.InterfazRemota;

/**
 *
 * Author: Jeremy Aldama (20206228)
 */
public class RMIClient {
    public static void main(String[] args) {
        try {
            InterfazRemota objRemoto = (InterfazRemota) Naming.lookup("//localhost:1234/objRemoto");
            
            System.out.println(objRemoto.sumar(10, 20));
            objRemoto.imprimir("Cadena de ejemplo");
            System.out.println(objRemoto.saludar("Jeremy"));
        } catch(Exception ex) {
            System.out.println(ex.getMessage());
        }
    }
}
