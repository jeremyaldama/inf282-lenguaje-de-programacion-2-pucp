package pe.edu.pucp.musicsoft.main;

import java.awt.Font;

public class frmBusquedaAlbumes extends javax.swing.JPanel {
    public frmBusquedaAlbumes() {
        initComponents();
        tblAlbumes.getTableHeader().setFont(new Font("Microsoft Sans Serif", 1, 13));
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        tbMenu = new javax.swing.JToolBar();
        lblNombreAlbumNombreArtista = new javax.swing.JLabel();
        txtNombreAlbumNombreArtista = new javax.swing.JTextField();
        btnBuscar = new javax.swing.JButton();
        btnSeleccionar = new javax.swing.JButton();
        jspAlbumes = new javax.swing.JScrollPane();
        tblAlbumes = new javax.swing.JTable();

        tbMenu.setBackground(new java.awt.Color(255, 255, 153));
        tbMenu.setFloatable(false);
        tbMenu.setRollover(true);

        lblNombreAlbumNombreArtista.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 13)); // NOI18N
        lblNombreAlbumNombreArtista.setText("Ingrese el nombre del album o el nombre del artista:");

        txtNombreAlbumNombreArtista.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 13)); // NOI18N

        btnBuscar.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 12)); // NOI18N
        btnBuscar.setText("Buscar");

        btnSeleccionar.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 12)); // NOI18N
        btnSeleccionar.setText("Seleccionar");

        tblAlbumes.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 13)); // NOI18N
        tblAlbumes.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {
                "Nombre del Álbum", "Artista", "Año", "Género", "Precio"
            }
        ) {
            boolean[] canEdit = new boolean [] {
                false, false, false, false, false
            };

            public boolean isCellEditable(int rowIndex, int columnIndex) {
                return canEdit [columnIndex];
            }
        });
        jspAlbumes.setViewportView(tblAlbumes);
        if (tblAlbumes.getColumnModel().getColumnCount() > 0) {
            tblAlbumes.getColumnModel().getColumn(0).setResizable(false);
            tblAlbumes.getColumnModel().getColumn(0).setPreferredWidth(280);
            tblAlbumes.getColumnModel().getColumn(1).setResizable(false);
            tblAlbumes.getColumnModel().getColumn(1).setPreferredWidth(200);
            tblAlbumes.getColumnModel().getColumn(2).setResizable(false);
            tblAlbumes.getColumnModel().getColumn(2).setPreferredWidth(70);
            tblAlbumes.getColumnModel().getColumn(3).setResizable(false);
            tblAlbumes.getColumnModel().getColumn(3).setPreferredWidth(170);
            tblAlbumes.getColumnModel().getColumn(4).setResizable(false);
            tblAlbumes.getColumnModel().getColumn(4).setPreferredWidth(70);
        }

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(this);
        this.setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(tbMenu, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jspAlbumes)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(lblNombreAlbumNombreArtista)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(txtNombreAlbumNombreArtista, javax.swing.GroupLayout.PREFERRED_SIZE, 237, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnBuscar)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 107, Short.MAX_VALUE)
                        .addComponent(btnSeleccionar)))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(tbMenu, javax.swing.GroupLayout.PREFERRED_SIZE, 25, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(lblNombreAlbumNombreArtista)
                    .addComponent(txtNombreAlbumNombreArtista, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(btnBuscar)
                    .addComponent(btnSeleccionar))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jspAlbumes, javax.swing.GroupLayout.DEFAULT_SIZE, 255, Short.MAX_VALUE)
                .addContainerGap())
        );
    }// </editor-fold>//GEN-END:initComponents


    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnBuscar;
    private javax.swing.JButton btnSeleccionar;
    private javax.swing.JScrollPane jspAlbumes;
    private javax.swing.JLabel lblNombreAlbumNombreArtista;
    private javax.swing.JToolBar tbMenu;
    private javax.swing.JTable tblAlbumes;
    private javax.swing.JTextField txtNombreAlbumNombreArtista;
    // End of variables declaration//GEN-END:variables
}
