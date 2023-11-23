/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package org.pucp.airsoft.program.main;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.sql.Connection;
import java.sql.Statement;
import java.text.SimpleDateFormat;
import org.pucp.airsoft.companies.model.Aerolinea;
import org.pucp.airsoft.config.DBManager;
/**
 *
 * @author alulab14
 */
public class Principal {
    public static void main(String[] args) throws Exception {
        Connection con = DBManager.getInstance().getConnection();
        Aerolinea aerolinea = new Aerolinea();
        SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
        BufferedReader teclado = new BufferedReader(new InputStreamReader(System.in));
        int opcion = 0;
        do {
            System.out.println("Bienvenido al Sistema de Registro de Aerolineas");
            System.out.println("---------------------------------------------------");
            System.out.println("1. Registrar Aerolinea.");
            System.out.println("2. Salir del sistema");
            System.out.print("Ingrese la opcion: ");
            try {
                opcion = Integer.parseInt(teclado.readLine());
                if (opcion==1) {
                    System.out.print("Ingrese el nombre de la aerolinea: ");
                    aerolinea.setNombre(teclado.readLine());
                    System.out.print("Ingrese el callsign: ");
                    aerolinea.setCallsign(teclado.readLine());
                    System.out.print("¿Tiene programa de fidelidad?: ");
                    aerolinea.setTieneProgramaFidelidad(teclado.readLine().equals("S"));
                    System.out.println("Ingrese la fecha de fundacion: ");
                    aerolinea.setFechaFundacion(sdf.parse(teclado.readLine()));
                    System.out.print("Ingrese la descripcion: ");
                    aerolinea.setDescripcion(teclado.readLine());
                    
                    //Creamos una instrucción SQL
                    Statement st = con.createStatement();
                    String sql = "INSERT INTO aerolinea(nombre,callsign,tiene_programa_fidelidad,fecha_fundacion,descripcion,activa) VALUES()";
                    //Ejecutamos la instrucción SQL
                    int resultado = st.executeUpdate(sql);
                    if(resultado == 1)
                        System.out.println("Se ha realizado de forma exitosa el registro");
                    else
                        System.out.println("Ha ocurrido un error con el registro");
                }
            } catch(Exception ex) {
                System.out.println(ex.getMessage());
            }
        } while (opcion!=2);
        //Cerramos la conexión
        con.close();
    }
}
