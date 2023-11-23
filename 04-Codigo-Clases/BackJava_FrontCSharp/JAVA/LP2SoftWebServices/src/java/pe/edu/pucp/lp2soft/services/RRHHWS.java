/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/WebServices/WebService.java to edit this template
 */
package pe.edu.pucp.lp2soft.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.lp2soft.rrhh.dao.AreaDAO;
import pe.edu.pucp.lp2soft.rrhh.dao.EmpleadoDAO;
import pe.edu.pucp.lp2soft.rrhh.model.Area;
import pe.edu.pucp.lp2soft.rrhh.model.Empleado;
import pe.edu.pucp.lp2soft.rrhh.mysql.AreaMySQL;
import pe.edu.pucp.lp2soft.rrhh.mysql.EmpleadoMySQL;

/**
 *
 * @author Danie
 */
@WebService(serviceName = "RRHHWS")
public class RRHHWS {
    
    private AreaDAO daoArea = new AreaMySQL();
    private EmpleadoDAO daoEmpleado = new EmpleadoMySQL();
    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "hello")
    public String hello(@WebParam(name = "name") String txt) {
        return "Hello " + txt + " !";
    }
    
    @WebMethod(operationName = "listarTodasAreas")
    public ArrayList<Area> listarTodasAreas() {
        ArrayList<Area> areas = new ArrayList<>();
        try {
            areas = daoArea.listarTodas();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return areas;
    }
    
    @WebMethod(operationName = "insertarEmpleado")
    public int insertarEmpleado(@WebParam(name = "empleado")
                            Empleado empleado) {
        int resultado = 0;
        try {
            resultado = daoEmpleado.insertar(empleado);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarEmpleadosPorDNINombre")
    public ArrayList<Empleado> listarEmpleadosPorDNINombre(
            @WebParam(name = "DNInombre") String DNINombre) {
        ArrayList<Empleado> empleados = new ArrayList<>();
        try {
            empleados = daoEmpleado.listarPorNombreDNI(DNINombre);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return empleados;
    }
}
