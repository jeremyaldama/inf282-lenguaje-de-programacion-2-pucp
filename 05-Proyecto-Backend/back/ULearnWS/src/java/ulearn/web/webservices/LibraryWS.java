/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/WebServices/WebService.java to edit this template
 */
package ulearn.web.webservices;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import ulearn.library.dao.AutorDAO;
import ulearn.library.dao.BibliotecaDAO;
import ulearn.library.dao.DigitalDAO;
import ulearn.library.dao.LibroDAO;
import ulearn.library.dao.PrestamoDAO;
import ulearn.library.dao.RecursoBibliotecaDAO;
import ulearn.library.model.Autor;
import ulearn.library.model.Biblioteca;
import ulearn.library.model.Digital;
import ulearn.library.model.Libro;
import ulearn.library.model.Prestamo;
import ulearn.library.model.RecursoBiblioteca;
import ulearn.library.mysql.AutorMySQL;
import ulearn.library.mysql.BibliotecaMySQL;
import ulearn.library.mysql.DigitalMySQL;
import ulearn.library.mysql.LibroMySQL;
import ulearn.library.mysql.PrestamoMySQL;
import ulearn.library.mysql.RecursoBibliotecaMySQL;

@WebService(serviceName = "LibraryWS")
public class LibraryWS {
    
    private AutorDAO daoAutor = new AutorMySQL();
    private BibliotecaDAO daoBiblioteca = new BibliotecaMySQL();
    private RecursoBibliotecaDAO daoRecurso = new RecursoBibliotecaMySQL();
    private LibroDAO daoLibro = new LibroMySQL();
    private DigitalDAO daoDigital = new DigitalMySQL();
    private PrestamoDAO daoPrestamo = new PrestamoMySQL();
    //Autor

    @WebMethod(operationName = "insertarAutor")
    public int insertarAutor(@WebParam(name = "autor")Autor autor){
        int resultado = 0;
        try{
            resultado = daoAutor.insertar(autor);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarAutor")
    public int eliminarAutor(@WebParam(name = "idAutor")int idAutor){
        int resultado = 0;
        try{
            resultado = daoAutor.eliminar(idAutor);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarAutoresPorNombre")
    public ArrayList<Autor> listarAutoresXNombre(@WebParam(name = "nombre")String nombre){
        ArrayList<Autor> autores = new ArrayList<>();
        try{
            autores = daoAutor.listarPorNombre(nombre);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return autores;
    }
    
    @WebMethod(operationName = "listarAutoresPorIdRecurso")
    public ArrayList<Autor> listarAutoresXIdRecurso(@WebParam(name = "idRecurso")int idRecurso){
        ArrayList<Autor> autores = new ArrayList<>();
        try{
            autores = daoAutor.listarPorIdRecurso(idRecurso);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return autores;
    }
    
    @WebMethod(operationName = "modificarAutor")
    public int modificarAutor(@WebParam(name = "autor")Autor autor){
        int resultado = 0;
        try{
            resultado = daoAutor.modificar(autor);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }    
    
    //Biblioteca
    @WebMethod(operationName = "insertarBiblioteca")
    public int insertarBiblioteca(@WebParam(name = "biblioteca")Biblioteca biblioteca){
        int resultado = 0;
        try{
            resultado = daoBiblioteca.agregarBiblioteca(biblioteca);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarBiblioteca")
    public int modificarBiblioteca(@WebParam(name = "biblioteca")Biblioteca biblioteca){
        int resultado = 0;
        try{
            resultado = daoBiblioteca.actualizarBiblioteca(biblioteca);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarBiblioteca")
    public int eliminarBiblioteca(@WebParam(name = "idBiblioteca")int idBiblioteca){
        int resultado = 0;
        try{
            resultado = daoBiblioteca.eliminarBiblioteca(idBiblioteca);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarBibliotecasTodas")
    public ArrayList<Biblioteca> listarBibliotecasTodas(){
        ArrayList<Biblioteca> bibliotecas = new ArrayList<>();
        try{
            bibliotecas = daoBiblioteca.listarBiblioteca();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return bibliotecas;
    }
    
    @WebMethod(operationName = "listarBibliotecasIdEncargado")
    public ArrayList<Biblioteca> listarBibliotecasIdEncargado(@WebParam(name = "idEncargado")int idEncargado){
        ArrayList<Biblioteca> bibliotecas = new ArrayList<>();
        try{
            bibliotecas = daoBiblioteca.listarPorIdEncargado(idEncargado);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return bibliotecas;
    }
    
    //Recurso
    @WebMethod(operationName = "listarRecursosPorTituloAutorConFiltros")
    public ArrayList<RecursoBiblioteca> listarRecursosPorTituloAutorConFiltros(@WebParam(name = "tituloAutor")String tituloAutor,
            @WebParam(name = "disponible")int disponible,@WebParam(name = "idBiblioteca")int idBiblioteca,
            @WebParam(name = "tipoRecurso")char tipoRecurso){
        ArrayList<RecursoBiblioteca> recursos = new ArrayList<>();
        try{
            recursos = daoRecurso.listarPorTituloAutorConFiltros(tituloAutor, 
                    disponible, idBiblioteca, tipoRecurso);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return recursos;
    }
    
    //Libro
    
    @WebMethod(operationName = "insertarLibro")
    public int insertarLibro(@WebParam(name = "libro")Libro libro){
        int resultado = 0;
        try{
            resultado = daoLibro.insertar(libro);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarLibro")
    public int modificarLibro(@WebParam(name = "libro")Libro libro){
        int resultado = 0;
        try{
            resultado = daoLibro.modificar(libro);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarLibro")
    public int eliminarLibro(@WebParam(name = "idLibro")int idLibro){
        int resultado = 0;
        try{
            resultado = daoLibro.eliminar(idLibro);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarLibrosTodos")
    public ArrayList<Libro> listarLibrosTodos(){
        ArrayList<Libro> libros = new ArrayList<>();
        try{
            libros = daoLibro.listarTodos();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return libros;
    }
    
    //Digital
    @WebMethod(operationName = "insetarDigital")
    public int insertarDigital(@WebParam(name = "digital")Digital digital){
        int resultado = 0;
        try{
            resultado = daoDigital.insertar(digital);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarDigital")
    public int modificarDigital(@WebParam(name = "digital")Digital digital){
        int resultado = 0;
        try{
            resultado = daoDigital.modificar(digital);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarDigital")
    public int eliminarDigital(@WebParam(name = "idDigital")int idDigital){
        int resultado = 0;
        try{
            resultado = daoDigital.eliminar(idDigital);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarDigitalesTodos")
    public ArrayList<Digital> listarDigitalesTodos(){
        ArrayList<Digital> digitales = new ArrayList<>();
        try{
            digitales = daoDigital.listarTodos();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return digitales;
    }
    
    //Prestamo
    
    @WebMethod(operationName = "registrarPrestamo")
    public int registrarPrestamo(@WebParam(name = "prestamo")Prestamo prestamo,
            @WebParam(name = "diasPrestamo")int diasPrestamo){
        int resultado = 0;
        try{
            resultado = daoPrestamo.insertar(prestamo,diasPrestamo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarPrestamo")
    public int modificarPrestamo(@WebParam(name = "prestamo")Prestamo prestamo){
        int resultado = 0;
        try{
            resultado = daoPrestamo.modificar(prestamo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarPrestamo")
    public int eliminarPrestamo(@WebParam(name = "idPrestamo")int idPrestamo){
        int resultado = 0;
        try{
            resultado = daoPrestamo.eliminar(idPrestamo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarPrestamosConFiltros")
    public ArrayList<Prestamo> listarPrestamosConFiltros(@WebParam(name = "idBiblioteca")int idBiblioteca,
            @WebParam(name = "idResponsable")int idResponsable, 
            @WebParam(name = "fechaInferior") java.util.Date fechaInferior,
            @WebParam(name = "fechaSuperior") java.util.Date fechaSuperior,
            @WebParam(name = "anulado")int anulado, @WebParam(name = "devuelto")int devuelto,
            @WebParam(name = "conRetraso")int conRetraso){
        ArrayList<Prestamo> prestamos = new ArrayList<>();
        try{
            prestamos = daoPrestamo.listarConFiltros(idBiblioteca, idResponsable, 
                    fechaInferior, fechaSuperior, anulado, 
                    devuelto, conRetraso);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return prestamos;
    }
    
    @WebMethod(operationName = "registrarRetiroPrestamo")
    public int registrarRetiroPrestamo(@WebParam(name = "idPrestamo")int idPrestamo){
        int resultado = 0;
        try{
            resultado = daoPrestamo.registrarRetiro(idPrestamo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "registrarDevolucionPrestamo")
    public int registrarDevolucionPrestamo(@WebParam(name = "idPrestamo")int idPrestamo){
        int resultado = 0;
        try{
            resultado = daoPrestamo.registrarDevolucion(idPrestamo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "anularPrestamo")
    public int anularPrestamo(@WebParam(name = "idPrestamo")int idPrestamo){
        int resultado = 0;
        try{
            resultado = daoPrestamo.anularPrestamo(idPrestamo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarPrestamosPorLibro")
    public ArrayList<Prestamo> listarPrestamosPorLibro(@WebParam(name = "idLibro")int idLibro){
        ArrayList<Prestamo> prestamos = new ArrayList<>();
        try{
            prestamos = daoPrestamo.listarPorIdLibro(idLibro);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return prestamos;
    }
    
}
