/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package pe.edu.pucp.lp2soft.interfaces;

import java.rmi.Remote;
import java.rmi.RemoteException;

/**
 *
 * @author Danie
 */
public interface InterfazRemota extends Remote {
    // todos los métodos de los clientes deben poder arrojar una excepcion
    int sumar(int a, int b) throws RemoteException;
    void imprimir(String cadena) throws RemoteException;
    String saludar(String nombre) throws RemoteException;
}
