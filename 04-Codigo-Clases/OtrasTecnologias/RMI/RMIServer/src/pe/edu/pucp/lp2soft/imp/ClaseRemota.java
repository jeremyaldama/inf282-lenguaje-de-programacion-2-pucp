/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

package pe.edu.pucp.lp2soft.imp;

import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;
import pe.edu.pucp.lp2soft.interfaces.InterfazRemota;

/**
 *
 * Author: Jeremy Aldama (20206228)
 */
public class ClaseRemota extends UnicastRemoteObject 
        implements InterfazRemota {
       
    public ClaseRemota(int puerto) throws Exception {
        // el objeto se encuentra disponible a través de un puerto que definamos
        super(puerto);
    }
    
    @Override
    public int sumar(int a, int b) throws RemoteException {
        int resultado = a + b;
        return resultado;
    }

    @Override
    public void imprimir(String cadena) throws RemoteException {
        System.out.println(cadena);
    }

    @Override
    public String saludar(String nombre) throws RemoteException {
        String saludo = "Hola " + nombre;
        return saludo;
    }
    
}
