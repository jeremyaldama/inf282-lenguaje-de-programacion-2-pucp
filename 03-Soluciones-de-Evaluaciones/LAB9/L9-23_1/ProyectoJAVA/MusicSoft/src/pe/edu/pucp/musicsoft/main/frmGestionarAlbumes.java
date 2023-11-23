package pe.edu.pucp.musicsoft.main;

import java.awt.Font;
import java.awt.Image;
import java.io.File;
import java.net.URL;
import java.time.Year;
import javax.swing.ImageIcon;
import javax.swing.JFileChooser;
import javax.swing.SwingConstants;
import javax.swing.filechooser.FileNameExtensionFilter;

public class frmGestionarAlbumes extends javax.swing.JPanel {
    
    private File archivoFoto;
    private Estado estado;
    
    /* Colocar sus datos:
    -----------------------------------------
    Código PUCP: 
    Nombre Completo:
    Fecha:
    -----------------------------------------
    */
    
    public frmGestionarAlbumes() {
        initComponents();
        colocarIconos();
        
        limpiarComponentes();
        estado = Estado.Inicial;
        estadoComponentes();
    }
    
    public void limpiarComponentes(){
        txtIDAlbum.setText("");
        txtNombreAlbum.setText("");
        txtArtista.setText("");
        jycAnho.setValue(Year.now().getValue());
        cboGenero.setSelectedIndex(-1);
        txtPrecio.setText("");
        txtCantCanciones.setText("");
        cbGatefold.setSelected(false);
        cbCD.setSelected(false);
        cbColor.setSelected(false);
        txtDescripcion.setText("");
        pbFoto.setIcon(null);
        archivoFoto = null;
        jycAnho.setFont(new Font("Microsoft Sans Serif", 1, 13));
    }
    
    public void estadoComponentes(){
        switch(estado){
            case Inicial:
                btnNuevo.setEnabled(true);
                btnGuardar.setEnabled(false);
                btnBuscar.setEnabled(true);
                btnCancelar.setEnabled(true);
                txtIDAlbum.setEnabled(false);
                txtNombreAlbum.setEnabled(false);
                txtArtista.setEnabled(false);
                btnBuscarArtista.setEnabled(false);
                jycAnho.setEnabled(false);
                cboGenero.setEnabled(false);
                txtPrecio.setEnabled(false);
                txtCantCanciones.setEnabled(false);
                btnSubirFoto.setEnabled(false);
                pbFoto.setEnabled(false);
                txtDescripcion.setEnabled(false);
                cbGatefold.setEnabled(false);
                cbCD.setEnabled(false);
                cbColor.setEnabled(false);
                break;
            case Nuevo:
                btnNuevo.setEnabled(false);
                btnGuardar.setEnabled(true);
                btnBuscar.setEnabled(false);
                btnCancelar.setEnabled(true);
                txtIDAlbum.setEnabled(true);
                txtIDAlbum.setEditable(false);
                txtNombreAlbum.setEnabled(true);
                txtNombreAlbum.setEditable(true);
                txtArtista.setEnabled(true);
                txtArtista.setEditable(false);
                btnBuscarArtista.setEnabled(true);
                jycAnho.setEnabled(true);
                cboGenero.setEnabled(true);
                txtPrecio.setEnabled(true);
                txtPrecio.setEditable(true);
                txtCantCanciones.setEnabled(true);
                txtCantCanciones.setEditable(true);
                btnSubirFoto.setEnabled(true);
                pbFoto.setEnabled(true);
                txtDescripcion.setEnabled(true);
                txtDescripcion.setEditable(true);
                cbGatefold.setEnabled(true);
                cbCD.setEnabled(true);
                cbColor.setEnabled(true);
                break;
            case Buscar:
                btnNuevo.setEnabled(false);
                btnGuardar.setEnabled(false);
                btnBuscar.setEnabled(false);
                btnCancelar.setEnabled(true);
                txtIDAlbum.setEnabled(true);
                txtIDAlbum.setEditable(false);
                txtNombreAlbum.setEnabled(true);
                txtNombreAlbum.setEditable(false);
                txtArtista.setEnabled(true);
                txtArtista.setEditable(false);
                btnBuscarArtista.setEnabled(false);
                jycAnho.setEnabled(false);
                cboGenero.setEnabled(false);
                txtPrecio.setEnabled(true);
                txtPrecio.setEditable(false);
                txtCantCanciones.setEnabled(true);
                txtCantCanciones.setEditable(false);
                btnSubirFoto.setEnabled(false);
                pbFoto.setEnabled(true);
                txtDescripcion.setEnabled(true);
                txtDescripcion.setEditable(false);
                cbGatefold.setEnabled(false);
                cbCD.setEnabled(false);
                cbColor.setEnabled(false);
                break;
        }
    }
    
    public void colocarIconos(){
        URL iconUrl = this.getClass().getResource("/pe/edu/pucp/musicsoft/icons/New.png");
        Image img = new ImageIcon(iconUrl).getImage();
        Image newimg = img.getScaledInstance(15, 17,  java.awt.Image.SCALE_SMOOTH ) ;
        btnNuevo.setIcon(new ImageIcon(newimg));
        btnNuevo.setHorizontalTextPosition(SwingConstants.RIGHT);
        iconUrl = this.getClass().getResource("/pe/edu/pucp/musicsoft/icons/Save.png");
        img = new ImageIcon(iconUrl).getImage();
        newimg = img.getScaledInstance(18, 17,  java.awt.Image.SCALE_SMOOTH ) ;
        btnGuardar.setIcon(new ImageIcon(newimg));
        btnGuardar.setHorizontalTextPosition(SwingConstants.RIGHT);
        iconUrl = this.getClass().getResource("/pe/edu/pucp/musicsoft/icons/Search.png");
        img = new ImageIcon(iconUrl).getImage();
        newimg = img.getScaledInstance(18, 17,  java.awt.Image.SCALE_SMOOTH ) ;
        btnBuscar.setIcon(new ImageIcon(newimg));
        btnBuscar.setHorizontalTextPosition(SwingConstants.RIGHT);
        btnBuscarArtista.setIcon(new ImageIcon(newimg));
        btnBuscarArtista.setHorizontalTextPosition(SwingConstants.RIGHT);
        iconUrl = this.getClass().getResource("/pe/edu/pucp/musicsoft/icons/Cancel.png");
        img = new ImageIcon(iconUrl).getImage();
        newimg = img.getScaledInstance(18, 17,  java.awt.Image.SCALE_SMOOTH ) ;
        btnCancelar.setIcon(new ImageIcon(newimg));
        btnCancelar.setHorizontalTextPosition(SwingConstants.RIGHT);
        iconUrl = this.getClass().getResource("/pe/edu/pucp/musicsoft/icons/Upload.png");
        img = new ImageIcon(iconUrl).getImage();
        newimg = img.getScaledInstance(18, 17,  java.awt.Image.SCALE_SMOOTH ) ;
        btnSubirFoto.setIcon(new ImageIcon(newimg));
        btnSubirFoto.setHorizontalTextPosition(SwingConstants.RIGHT);
    }
    
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jfcFoto = new javax.swing.JFileChooser();
        jtbMenu = new javax.swing.JToolBar();
        btnNuevo = new javax.swing.JButton();
        btnGuardar = new javax.swing.JButton();
        btnBuscar = new javax.swing.JButton();
        btnCancelar = new javax.swing.JButton();
        pbFoto = new javax.swing.JLabel();
        btnSubirFoto = new javax.swing.JButton();
        lblIDAlbum = new javax.swing.JLabel();
        lblNombreAlbum = new javax.swing.JLabel();
        txtIDAlbum = new javax.swing.JTextField();
        txtNombreAlbum = new javax.swing.JTextField();
        lblAnho = new javax.swing.JLabel();
        jycAnho = new com.toedter.calendar.JYearChooser();
        lblArtista = new javax.swing.JLabel();
        txtArtista = new javax.swing.JTextField();
        btnBuscarArtista = new javax.swing.JButton();
        lblGestionAlbumes = new javax.swing.JLabel();
        lblGenero = new javax.swing.JLabel();
        cboGenero = new javax.swing.JComboBox<>();
        lblPrecio = new javax.swing.JLabel();
        txtPrecio = new javax.swing.JTextField();
        lblPresentacion = new javax.swing.JLabel();
        cbGatefold = new javax.swing.JCheckBox();
        cbCD = new javax.swing.JCheckBox();
        cbColor = new javax.swing.JCheckBox();
        lblCantCanciones = new javax.swing.JLabel();
        txtCantCanciones = new javax.swing.JTextField();
        lblDescripcion = new javax.swing.JLabel();
        jspDescripcion = new javax.swing.JScrollPane();
        txtDescripcion = new javax.swing.JTextArea();

        jtbMenu.setBackground(new java.awt.Color(255, 255, 153));
        jtbMenu.setFloatable(false);
        jtbMenu.setRollover(true);

        btnNuevo.setBackground(new java.awt.Color(255, 255, 153));
        btnNuevo.setFont(new java.awt.Font("Segoe UI", 1, 13)); // NOI18N
        btnNuevo.setText("Nuevo");
        btnNuevo.setFocusable(false);
        btnNuevo.setHorizontalTextPosition(javax.swing.SwingConstants.CENTER);
        btnNuevo.setVerticalTextPosition(javax.swing.SwingConstants.BOTTOM);
        btnNuevo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnNuevoActionPerformed(evt);
            }
        });
        jtbMenu.add(btnNuevo);

        btnGuardar.setBackground(new java.awt.Color(255, 255, 153));
        btnGuardar.setFont(new java.awt.Font("Segoe UI", 1, 13)); // NOI18N
        btnGuardar.setText("Guardar");
        btnGuardar.setFocusable(false);
        btnGuardar.setHorizontalTextPosition(javax.swing.SwingConstants.CENTER);
        btnGuardar.setVerticalTextPosition(javax.swing.SwingConstants.BOTTOM);
        btnGuardar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnGuardarActionPerformed(evt);
            }
        });
        jtbMenu.add(btnGuardar);

        btnBuscar.setBackground(new java.awt.Color(255, 255, 153));
        btnBuscar.setFont(new java.awt.Font("Segoe UI", 1, 13)); // NOI18N
        btnBuscar.setText("Buscar");
        btnBuscar.setFocusable(false);
        btnBuscar.setHorizontalTextPosition(javax.swing.SwingConstants.CENTER);
        btnBuscar.setVerticalTextPosition(javax.swing.SwingConstants.BOTTOM);
        btnBuscar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnBuscarActionPerformed(evt);
            }
        });
        jtbMenu.add(btnBuscar);

        btnCancelar.setBackground(new java.awt.Color(255, 255, 153));
        btnCancelar.setFont(new java.awt.Font("Segoe UI", 1, 13)); // NOI18N
        btnCancelar.setText("Cancelar");
        btnCancelar.setFocusable(false);
        btnCancelar.setHorizontalTextPosition(javax.swing.SwingConstants.CENTER);
        btnCancelar.setVerticalTextPosition(javax.swing.SwingConstants.BOTTOM);
        btnCancelar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnCancelarActionPerformed(evt);
            }
        });
        jtbMenu.add(btnCancelar);

        pbFoto.setBorder(javax.swing.BorderFactory.createLineBorder(new java.awt.Color(0, 0, 0)));

        btnSubirFoto.setFont(new java.awt.Font("Segoe UI", 1, 13)); // NOI18N
        btnSubirFoto.setText("Subir Foto");
        btnSubirFoto.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnSubirFotoActionPerformed(evt);
            }
        });

        lblIDAlbum.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 13)); // NOI18N
        lblIDAlbum.setText("ID del Álbum:");

        lblNombreAlbum.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 13)); // NOI18N
        lblNombreAlbum.setText("Nombre del Álbum:");

        txtIDAlbum.setEditable(false);
        txtIDAlbum.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 13)); // NOI18N

        txtNombreAlbum.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 13)); // NOI18N

        lblAnho.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 13)); // NOI18N
        lblAnho.setText("Año de Lanzamiento:");

        lblArtista.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 13)); // NOI18N
        lblArtista.setText("Artista:");

        txtArtista.setEditable(false);
        txtArtista.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 13)); // NOI18N

        btnBuscarArtista.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 12)); // NOI18N
        btnBuscarArtista.setText("...");

        lblGestionAlbumes.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 13)); // NOI18N
        lblGestionAlbumes.setText("Gestión de Álbumes de Vinilo");

        lblGenero.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 13)); // NOI18N
        lblGenero.setText("Género:");

        cboGenero.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 13)); // NOI18N

        lblPrecio.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 13)); // NOI18N
        lblPrecio.setText("Precio:");

        txtPrecio.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 13)); // NOI18N

        lblPresentacion.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 13)); // NOI18N
        lblPresentacion.setText("Presentación del Disco:");
        lblPresentacion.setHorizontalTextPosition(javax.swing.SwingConstants.RIGHT);

        cbGatefold.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 13)); // NOI18N
        cbGatefold.setText("Edición Gatefold");

        cbCD.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 13)); // NOI18N
        cbCD.setText("Acompañado de CD");

        cbColor.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 13)); // NOI18N
        cbColor.setText("Edición de Color");

        lblCantCanciones.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 13)); // NOI18N
        lblCantCanciones.setText("Cantidad de Canciones:");

        txtCantCanciones.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 13)); // NOI18N

        lblDescripcion.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 13)); // NOI18N
        lblDescripcion.setText("Descripción del Álbum:");

        txtDescripcion.setColumns(20);
        txtDescripcion.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 13)); // NOI18N
        txtDescripcion.setLineWrap(true);
        txtDescripcion.setRows(5);
        txtDescripcion.setWrapStyleWord(true);
        jspDescripcion.setViewportView(txtDescripcion);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(this);
        this.setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jtbMenu, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addGroup(layout.createSequentialGroup()
                .addGap(21, 21, 21)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(lblDescripcion)
                    .addComponent(lblGestionAlbumes)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(jspDescripcion, javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                                    .addComponent(btnSubirFoto, javax.swing.GroupLayout.DEFAULT_SIZE, 221, Short.MAX_VALUE)
                                    .addComponent(pbFoto, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                                .addGap(18, 18, 18)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(layout.createSequentialGroup()
                                        .addGap(0, 0, Short.MAX_VALUE)
                                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                            .addComponent(lblPrecio)
                                            .addComponent(lblArtista)
                                            .addComponent(lblAnho)
                                            .addComponent(lblGenero)
                                            .addComponent(lblNombreAlbum)
                                            .addComponent(lblIDAlbum)
                                            .addComponent(lblCantCanciones)))
                                    .addComponent(lblPresentacion, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(layout.createSequentialGroup()
                                        .addComponent(txtArtista, javax.swing.GroupLayout.PREFERRED_SIZE, 445, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                        .addComponent(btnBuscarArtista, javax.swing.GroupLayout.PREFERRED_SIZE, 42, javax.swing.GroupLayout.PREFERRED_SIZE))
                                    .addComponent(cboGenero, 0, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                    .addComponent(txtNombreAlbum)
                                    .addGroup(layout.createSequentialGroup()
                                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                            .addGroup(layout.createSequentialGroup()
                                                .addComponent(cbGatefold)
                                                .addGap(18, 18, 18)
                                                .addComponent(cbCD)
                                                .addGap(18, 18, 18)
                                                .addComponent(cbColor))
                                            .addComponent(txtIDAlbum, javax.swing.GroupLayout.PREFERRED_SIZE, 78, javax.swing.GroupLayout.PREFERRED_SIZE)
                                            .addComponent(jycAnho, javax.swing.GroupLayout.PREFERRED_SIZE, 86, javax.swing.GroupLayout.PREFERRED_SIZE)
                                            .addComponent(txtPrecio, javax.swing.GroupLayout.PREFERRED_SIZE, 105, javax.swing.GroupLayout.PREFERRED_SIZE)
                                            .addComponent(txtCantCanciones, javax.swing.GroupLayout.PREFERRED_SIZE, 105, javax.swing.GroupLayout.PREFERRED_SIZE))
                                        .addGap(0, 0, Short.MAX_VALUE)))))
                        .addGap(21, 21, 21))))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(jtbMenu, javax.swing.GroupLayout.PREFERRED_SIZE, 25, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(12, 12, 12)
                        .addComponent(lblGestionAlbumes)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(pbFoto, javax.swing.GroupLayout.PREFERRED_SIZE, 177, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnSubirFoto))
                    .addGroup(layout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(lblIDAlbum)
                            .addComponent(txtIDAlbum, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(lblNombreAlbum)
                            .addComponent(txtNombreAlbum, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(lblArtista)
                            .addComponent(txtArtista, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(btnBuscarArtista))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jycAnho, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(lblAnho))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(lblGenero)
                            .addComponent(cboGenero, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(lblPrecio)
                            .addComponent(txtPrecio, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(lblCantCanciones)
                            .addComponent(txtCantCanciones, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(lblPresentacion)
                            .addComponent(cbGatefold)
                            .addComponent(cbCD)
                            .addComponent(cbColor))))
                .addGap(15, 15, 15)
                .addComponent(lblDescripcion)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jspDescripcion, javax.swing.GroupLayout.PREFERRED_SIZE, 81, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(21, Short.MAX_VALUE))
        );
    }// </editor-fold>//GEN-END:initComponents

    private void btnSubirFotoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnSubirFotoActionPerformed
        FileNameExtensionFilter filtro = new FileNameExtensionFilter("JPG","PNG","jpg","png");
        jfcFoto.setFileFilter(filtro);
        int resultado = jfcFoto.showOpenDialog(null);
        if(resultado == JFileChooser.APPROVE_OPTION){
            try{
                archivoFoto = jfcFoto.getSelectedFile();
                Image img = new ImageIcon(archivoFoto.toString()).getImage();
                Image newImg = img.getScaledInstance(pbFoto.getWidth(), pbFoto.getHeight(), java.awt.Image.SCALE_SMOOTH);
                pbFoto.setIcon(new ImageIcon(newImg));
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
    }//GEN-LAST:event_btnSubirFotoActionPerformed

    private void btnNuevoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnNuevoActionPerformed
        limpiarComponentes();
        estado = Estado.Nuevo;
        estadoComponentes();
    }//GEN-LAST:event_btnNuevoActionPerformed

    private void btnCancelarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnCancelarActionPerformed
        limpiarComponentes();
        estado = Estado.Inicial;
        estadoComponentes();
    }//GEN-LAST:event_btnCancelarActionPerformed

    private void btnBuscarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnBuscarActionPerformed
        estado = Estado.Buscar;
        estadoComponentes();
    }//GEN-LAST:event_btnBuscarActionPerformed

    private void btnGuardarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnGuardarActionPerformed
        estado = Estado.Inicial;
        estadoComponentes();
    }//GEN-LAST:event_btnGuardarActionPerformed

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnBuscar;
    private javax.swing.JButton btnBuscarArtista;
    private javax.swing.JButton btnCancelar;
    private javax.swing.JButton btnGuardar;
    private javax.swing.JButton btnNuevo;
    private javax.swing.JButton btnSubirFoto;
    private javax.swing.JCheckBox cbCD;
    private javax.swing.JCheckBox cbColor;
    private javax.swing.JCheckBox cbGatefold;
    private javax.swing.JComboBox<String> cboGenero;
    private javax.swing.JFileChooser jfcFoto;
    private javax.swing.JScrollPane jspDescripcion;
    private javax.swing.JToolBar jtbMenu;
    private com.toedter.calendar.JYearChooser jycAnho;
    private javax.swing.JLabel lblAnho;
    private javax.swing.JLabel lblArtista;
    private javax.swing.JLabel lblCantCanciones;
    private javax.swing.JLabel lblDescripcion;
    private javax.swing.JLabel lblGenero;
    private javax.swing.JLabel lblGestionAlbumes;
    private javax.swing.JLabel lblIDAlbum;
    private javax.swing.JLabel lblNombreAlbum;
    private javax.swing.JLabel lblPrecio;
    private javax.swing.JLabel lblPresentacion;
    private javax.swing.JLabel pbFoto;
    private javax.swing.JTextField txtArtista;
    private javax.swing.JTextField txtCantCanciones;
    private javax.swing.JTextArea txtDescripcion;
    private javax.swing.JTextField txtIDAlbum;
    private javax.swing.JTextField txtNombreAlbum;
    private javax.swing.JTextField txtPrecio;
    // End of variables declaration//GEN-END:variables
}
