/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/WebServices/WebService.java to edit this template
 */
package pe.edu.pucp.lp2soft.services;

import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author Danie
 */
// etiqueta
@WebService(serviceName = "ServicioWeb")
public class ServicioWeb {

    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "hello")
    public String hello(@WebParam(name = "name") String txt) {
        return "Hello " + txt + " !";
    }
    
//     en la máquina servidora se crea una instancia de esta clase, los clientes
//    que se conecten van a tener referencia de este objeto y van a poder llamar a
//    estos métodos
    @WebMethod(operationName = "sumar")
    public int sumar(@WebParam(name = "a") int a, 
            @WebParam(name = "b") int b) {
        return a + b;
    }
    
    @WebMethod(operationName = "restar")
    public int restar(@WebParam(name = "a") int a, 
            @WebParam(name = "b") int b) {
        return a - b;
    }
}
