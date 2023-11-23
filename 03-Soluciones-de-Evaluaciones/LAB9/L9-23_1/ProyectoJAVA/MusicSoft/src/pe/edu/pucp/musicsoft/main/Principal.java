package pe.edu.pucp.musicsoft.main;

import javax.swing.JFrame;
import static javax.swing.JFrame.EXIT_ON_CLOSE;

public class Principal {
    public static void main(String[] args){
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info 
                    : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Windows".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        
        frmGestionarAlbumes panelGestAlbumes = new frmGestionarAlbumes();
        JFrame formGestEmp = new JFrame();
        formGestEmp.add(panelGestAlbumes);
        formGestEmp.pack();
        formGestEmp.setVisible(true);
        formGestEmp.setResizable(false);
        formGestEmp.setFocusable(true);
        formGestEmp.setTitle("Formulario de Gestión de Álbumes de Vinilo");
        formGestEmp.setDefaultCloseOperation(EXIT_ON_CLOSE);
    }
}