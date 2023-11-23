
package pe.edu.pucp.lp2soft.servicioweb;

import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebResult;
import javax.jws.WebService;
import javax.xml.bind.annotation.XmlSeeAlso;
import javax.xml.ws.Action;
import javax.xml.ws.RequestWrapper;
import javax.xml.ws.ResponseWrapper;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 2.3.5
 * Generated source version: 2.2
 * 
 */
@WebService(name = "ServicioWeb", targetNamespace = "http://services.lp2soft.pucp.edu.pe/")
@XmlSeeAlso({
    ObjectFactory.class
})
public interface ServicioWeb {


    /**
     * 
     * @param a
     * @param b
     * @return
     *     returns int
     */
    @WebMethod
    @WebResult(targetNamespace = "")
    @RequestWrapper(localName = "sumar", targetNamespace = "http://services.lp2soft.pucp.edu.pe/", className = "pe.edu.pucp.lp2soft.servicioweb.Sumar")
    @ResponseWrapper(localName = "sumarResponse", targetNamespace = "http://services.lp2soft.pucp.edu.pe/", className = "pe.edu.pucp.lp2soft.servicioweb.SumarResponse")
    @Action(input = "http://services.lp2soft.pucp.edu.pe/ServicioWeb/sumarRequest", output = "http://services.lp2soft.pucp.edu.pe/ServicioWeb/sumarResponse")
    public int sumar(
        @WebParam(name = "a", targetNamespace = "")
        int a,
        @WebParam(name = "b", targetNamespace = "")
        int b);

    /**
     * 
     * @param a
     * @param b
     * @return
     *     returns int
     */
    @WebMethod
    @WebResult(targetNamespace = "")
    @RequestWrapper(localName = "restar", targetNamespace = "http://services.lp2soft.pucp.edu.pe/", className = "pe.edu.pucp.lp2soft.servicioweb.Restar")
    @ResponseWrapper(localName = "restarResponse", targetNamespace = "http://services.lp2soft.pucp.edu.pe/", className = "pe.edu.pucp.lp2soft.servicioweb.RestarResponse")
    @Action(input = "http://services.lp2soft.pucp.edu.pe/ServicioWeb/restarRequest", output = "http://services.lp2soft.pucp.edu.pe/ServicioWeb/restarResponse")
    public int restar(
        @WebParam(name = "a", targetNamespace = "")
        int a,
        @WebParam(name = "b", targetNamespace = "")
        int b);

    /**
     * 
     * @param name
     * @return
     *     returns java.lang.String
     */
    @WebMethod
    @WebResult(targetNamespace = "")
    @RequestWrapper(localName = "hello", targetNamespace = "http://services.lp2soft.pucp.edu.pe/", className = "pe.edu.pucp.lp2soft.servicioweb.Hello")
    @ResponseWrapper(localName = "helloResponse", targetNamespace = "http://services.lp2soft.pucp.edu.pe/", className = "pe.edu.pucp.lp2soft.servicioweb.HelloResponse")
    @Action(input = "http://services.lp2soft.pucp.edu.pe/ServicioWeb/helloRequest", output = "http://services.lp2soft.pucp.edu.pe/ServicioWeb/helloResponse")
    public String hello(
        @WebParam(name = "name", targetNamespace = "")
        String name);

}