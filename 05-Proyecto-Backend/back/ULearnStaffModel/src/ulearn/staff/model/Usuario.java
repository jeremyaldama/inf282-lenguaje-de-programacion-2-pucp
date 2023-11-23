package ulearn.staff.model;

import java.nio.charset.Charset;
import java.nio.charset.StandardCharsets;
import java.security.NoSuchAlgorithmException;
import java.security.SecureRandom;
import java.security.spec.InvalidKeySpecException;
import java.security.spec.KeySpec;
import java.util.Date;
import javax.crypto.SecretKeyFactory;
import javax.crypto.spec.PBEKeySpec;

public abstract class Usuario implements IConsultable, IConsultarRecursosBiblioteca{
    private int idUsuario;
    private String nombre;
    private String apellidoPaterno;
    private String apellidoMaterno;
    private String usuario;
    private String password;
    private String salt;
    private String correoElectronico;
    private Date fechaNacimiento;
    private char tipoUsuario;
    private String telefono;
    private char sexo;
    private byte[] foto;

    public Usuario(String nombre, String apellidoPaterno, String apellidoMaterno, String usuario, String password, String correoElectronico, Date fechaNacimiento, char sexo) {
        this.nombre = nombre;
        this.apellidoPaterno = apellidoPaterno;
        this.apellidoMaterno = apellidoMaterno;
        this.usuario = usuario;
        this.password = password;
        this.correoElectronico = correoElectronico;
        this.fechaNacimiento = fechaNacimiento;
        this.sexo = sexo;
    }

    public byte[] getFoto() {
        return foto;
    }

    public void setFoto(byte[] foto) {
        this.foto = foto;
    }

    public Date getFechaNacimiento() {
        return fechaNacimiento;
    }

    public void setFechaNacimiento(Date fechaNacimiento) {
        this.fechaNacimiento = fechaNacimiento;
    }

    public char getSexo() {
        return sexo;
    }

    public void setSexo(char sexo) {
        this.sexo = sexo;
    }

    public Usuario(){
        
    }
    
    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getApellidoPaterno() {
        return apellidoPaterno;
    }

    public void setApellidoPaterno(String apellidoPaterno) {
        this.apellidoPaterno = apellidoPaterno;
    }

    public String getApellidoMaterno() {
        return apellidoMaterno;
    }

    public void setApellidoMaterno(String apellidoMaterno) {
        this.apellidoMaterno = apellidoMaterno;
    }

    public String getUsuario() {
        return usuario;
    }

    public int getIdUsuario() {
        return idUsuario;
    }

    public void setIdUsuario(int idUsuario) {
        this.idUsuario = idUsuario;
    }

    public void setUsuario(String usuario) {
        this.usuario = usuario;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public String getCorreoElectronico() {
        return correoElectronico;
    }

    public void setCorreoElectronico(String correoElectronico) {
        this.correoElectronico = correoElectronico;
    }

    public char getTipoUsuario() {
        return tipoUsuario;
    }

    public void setTipoUsuario(char tipoUsuario) {
        this.tipoUsuario = tipoUsuario;
    }
    public String getTelefono() {
        return telefono;
    }

    public void setTelefono(String telefono) {
        this.telefono = telefono;
    }

    public String getSalt() {
        return salt;
    }

    public void setSalt(String salt) {
        this.salt = salt;
    }
    
    public void generarEncriptacionConSalt() throws NoSuchAlgorithmException, InvalidKeySpecException{
        int saltLength = 12; 
        String characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+";
        StringBuilder _salt = new StringBuilder(saltLength);

        try {
            SecureRandom secureRandom = SecureRandom.getInstanceStrong();
            for (int i = 0; i < saltLength; i++) {
                int randomIndex = secureRandom.nextInt(characters.length());
                _salt.append(characters.charAt(randomIndex));
            }
        } catch (NoSuchAlgorithmException e) {
            e.printStackTrace();
        }
        String valSalt = _salt.toString();
        Charset charset = StandardCharsets.UTF_16; //se utiliza un estandar
        this.setSalt(valSalt);
        KeySpec spec = new PBEKeySpec(this.getPassword().toCharArray(), valSalt.getBytes(charset), 65536, 128);
        SecretKeyFactory factory = SecretKeyFactory.getInstance("PBKDF2WithHmacSHA1");
        byte[] hash = factory.generateSecret(spec).getEncoded();
        this.setPassword(new String(hash, charset));
    }
    static public String generarHashInicioSesion(String pass, String valSalt) throws NoSuchAlgorithmException, InvalidKeySpecException{
        Charset charset = StandardCharsets.UTF_16;
        KeySpec spec = new PBEKeySpec(pass.toCharArray(), valSalt.getBytes(charset), 65536, 128);
        SecretKeyFactory factory = SecretKeyFactory.getInstance("PBKDF2WithHmacSHA1");
        byte[] hash = factory.generateSecret(spec).getEncoded();
        return new String(hash,charset);
    }
    public abstract String consultarDatos();
    public void editarInformacionPersonal(){}
    public abstract void consultarRecursosBiblioteca();
}
