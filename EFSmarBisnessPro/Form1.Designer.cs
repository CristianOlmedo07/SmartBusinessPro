namespace EFSmarBisnessPro
{
    partial class FrmProductos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblNombre = new Label();
            lblCategoria = new Label();
            lblFecha = new Label();
            lblActivo = new Label();
            lblPrecio = new Label();
            lblStock = new Label();
            lblProveedor = new Label();
            txtNombre = new TextBox();
            cmbCategoria = new TextBox();
            txtFechaIngreso = new TextBox();
            txtActivo = new TextBox();
            txtPrecio = new TextBox();
            cmbProveedor = new TextBox();
            txtStock = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 12F);
            lblTitulo.ForeColor = Color.FromArgb(56, 189, 248);
            lblTitulo.Location = new Point(140, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(511, 25);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "SMARTBUSINESSPRO | GESTIÓN DE PRODUCTOS   ";
            lblTitulo.Click += label1_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 10F);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(34, 57);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(73, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Microsoft Sans Serif", 10F);
            lblCategoria.ForeColor = Color.White;
            lblCategoria.Location = new Point(34, 92);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(86, 20);
            lblCategoria.TabIndex = 3;
            lblCategoria.Text = "Categoría:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Microsoft Sans Serif", 10F);
            lblFecha.ForeColor = Color.White;
            lblFecha.Location = new Point(36, 128);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(120, 20);
            lblFecha.TabIndex = 4;
            lblFecha.Text = "Fecha ingreso:";
            // 
            // lblActivo
            // 
            lblActivo.AutoSize = true;
            lblActivo.Font = new Font("Microsoft Sans Serif", 10F);
            lblActivo.ForeColor = Color.White;
            lblActivo.Location = new Point(296, 131);
            lblActivo.Name = "lblActivo";
            lblActivo.Size = new Size(60, 20);
            lblActivo.TabIndex = 5;
            lblActivo.Text = "Activo:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Microsoft Sans Serif", 10F);
            lblPrecio.ForeColor = Color.White;
            lblPrecio.Location = new Point(380, 57);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(62, 20);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "Precio:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Microsoft Sans Serif", 10F);
            lblStock.ForeColor = Color.White;
            lblStock.Location = new Point(623, 57);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(56, 20);
            lblStock.TabIndex = 7;
            lblStock.Text = "Stock:";
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Font = new Font("Microsoft Sans Serif", 10F);
            lblProveedor.ForeColor = SystemColors.ButtonHighlight;
            lblProveedor.Location = new Point(380, 92);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(90, 20);
            lblProveedor.TabIndex = 8;
            lblProveedor.Text = "Proveedor:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(30, 41, 59);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(113, 54);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 9;
            // 
            // cmbCategoria
            // 
            cmbCategoria.BackColor = Color.FromArgb(30, 41, 59);
            cmbCategoria.ForeColor = Color.White;
            cmbCategoria.Location = new Point(126, 87);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(125, 27);
            cmbCategoria.TabIndex = 10;
            // 
            // txtFechaIngreso
            // 
            txtFechaIngreso.BackColor = Color.FromArgb(30, 41, 59);
            txtFechaIngreso.ForeColor = Color.White;
            txtFechaIngreso.Location = new Point(162, 128);
            txtFechaIngreso.Name = "txtFechaIngreso";
            txtFechaIngreso.Size = new Size(125, 27);
            txtFechaIngreso.TabIndex = 11;
            // 
            // txtActivo
            // 
            txtActivo.BackColor = Color.FromArgb(30, 41, 59);
            txtActivo.ForeColor = Color.White;
            txtActivo.Location = new Point(362, 131);
            txtActivo.Name = "txtActivo";
            txtActivo.Size = new Size(39, 27);
            txtActivo.TabIndex = 12;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.FromArgb(30, 41, 59);
            txtPrecio.ForeColor = Color.White;
            txtPrecio.Location = new Point(448, 56);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 13;
            // 
            // cmbProveedor
            // 
            cmbProveedor.BackColor = Color.FromArgb(30, 41, 59);
            cmbProveedor.ForeColor = Color.White;
            cmbProveedor.Location = new Point(476, 92);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(125, 27);
            cmbProveedor.TabIndex = 14;
            // 
            // txtStock
            // 
            txtStock.BackColor = Color.FromArgb(30, 41, 59);
            txtStock.ForeColor = Color.White;
            txtStock.Location = new Point(685, 56);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(125, 27);
            txtStock.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(56, 178);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(754, 188);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(832, 473);
            Controls.Add(dataGridView1);
            Controls.Add(txtStock);
            Controls.Add(cmbProveedor);
            Controls.Add(txtPrecio);
            Controls.Add(txtActivo);
            Controls.Add(txtFechaIngreso);
            Controls.Add(cmbCategoria);
            Controls.Add(txtNombre);
            Controls.Add(lblProveedor);
            Controls.Add(lblStock);
            Controls.Add(lblPrecio);
            Controls.Add(lblActivo);
            Controls.Add(lblFecha);
            Controls.Add(lblCategoria);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            MaximizeBox = false;
            Name = "FrmProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MARTBUSINESSPRO | GESTIÓN DE PRODUCTOS";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitulo;
        private Label lblNombre;
        private Label lblCategoria;
        private Label lblFecha;
        private Label lblActivo;
        private Label lblPrecio;
        private Label lblStock;
        private Label lblProveedor;
        private TextBox txtNombre;
        private TextBox cmbCategoria;
        private TextBox txtFechaIngreso;
        private TextBox txtActivo;
        private TextBox txtPrecio;
        private TextBox cmbProveedor;
        private TextBox txtStock;
        private DataGridView dataGridView1;
    }
}
