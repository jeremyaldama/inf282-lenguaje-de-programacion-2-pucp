package pe.edu.pucp.musicsoft.main;

import java.awt.Font;

public class frmBusquedaArtistas extends javax.swing.JPanel {
    public frmBusquedaArtistas() {
        initComponents();
        tblArtistas.getTableHeader().setFont(new Font("Microsoft Sans Serif", 1, 13));

    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        tbMenu = new javax.swing.JToolBar();
        lblNombreArtista = new javax.swing.JLabel();
        txtNombreArtista = new javax.swing.JTextField();
        btnBuscar = new javax.swing.JButton();
        btnSeleccionar = new javax.swing.JButton();
        jspArtistas = new javax.swing.JScrollPane();
        tblArtistas = new javax.swing.JTable();

        tbMenu.setBackground(new java.awt.Color(255, 255, 153));
        tbMenu.setFloatable(false);
        tbMenu.setRollover(true);

        lblNombreArtista.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 13)); // NOI18N
        lblNombreArtista.setText("Ingrese el nombre del artista:");

        txtNombreArtista.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 13)); // NOI18N

        btnBuscar.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 12)); // NOI18N
        btnBuscar.setText("Buscar");

        btnSeleccionar.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 12)); // NOI18N
        btnSeleccionar.setText("Seleccionar");

        tblArtistas.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 13)); // NOI18N
        tblArtistas.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {
                "Nombre Artístico", "País de Origen"
            }
        ) {
            boolean[] canEdit = new boolean [] {
                false, false
            };

            public boolean isCellEditable(int rowIndex, int columnIndex) {
                return canEdit [columnIndex];
            }
        });
        jspArtistas.setViewportView(tblArtistas);
        if (tblArtistas.getColumnModel().getColumnCount() > 0) {
            tblArtistas.getColumnModel().getColumn(0).setResizable(false);
            tblArtistas.getColumnModel().getColumn(1).setResizable(false);
        }

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(this);
        this.setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(tbMenu, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jspArtistas)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(lblNombreArtista)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(txtNombreArtista, javax.swing.GroupLayout.PREFERRED_SIZE, 214, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnBuscar)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 88, Short.MAX_VALUE)
                        .addComponent(btnSeleccionar)))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(tbMenu, javax.swing.GroupLayout.PREFERRED_SIZE, 25, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(lblNombreArtista)
                    .addComponent(txtNombreArtista, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(btnBuscar)
                    .addComponent(btnSeleccionar))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jspArtistas, javax.swing.GroupLayout.PREFERRED_SIZE, 215, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(0, 11, Short.MAX_VALUE))
        );
    }// </editor-fold>//GEN-END:initComponents


    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnBuscar;
    private javax.swing.JButton btnSeleccionar;
    private javax.swing.JScrollPane jspArtistas;
    private javax.swing.JLabel lblNombreArtista;
    private javax.swing.JToolBar tbMenu;
    private javax.swing.JTable tblArtistas;
    private javax.swing.JTextField txtNombreArtista;
    // End of variables declaration//GEN-END:variables
}
