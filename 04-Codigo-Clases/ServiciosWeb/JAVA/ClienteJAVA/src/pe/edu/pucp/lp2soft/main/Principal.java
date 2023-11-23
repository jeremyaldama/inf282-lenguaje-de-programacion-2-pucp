/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

package pe.edu.pucp.lp2soft.main;

import pe.edu.pucp.lp2soft.servicioweb.ServicioWeb;
import pe.edu.pucp.lp2soft.servicioweb.ServicioWeb_Service;

/**
 *
 * Author: Jeremy Aldama (20206228)
 */
public class Principal {
    public static void main(String[] args) {
        ServicioWeb_Service objsw = new ServicioWeb_Service();
        ServicioWeb sw = objsw.getServicioWebPort();
        int resultado = sw.sumar(10, 20);
        System.out.println(resultado);
    }
}
