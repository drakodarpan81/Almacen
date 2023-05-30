namespace Almacen
{
    partial class frmAltaArticulos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbGral = new System.Windows.Forms.GroupBox();
            this.grbCaducidad = new System.Windows.Forms.GroupBox();
            this.txtMarcaCaducidad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLoteCaducidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaCaducidad = new System.Windows.Forms.DateTimePicker();
            this.chkCaducidad = new System.Windows.Forms.CheckBox();
            this.txtFolioAlmacen = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grbDescripcionArticulo = new System.Windows.Forms.GroupBox();
            this.btnCategoria = new FontAwesome.Sharp.IconButton();
            this.cmbCategoria = new UCCOMBOBOX.cmbComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProveedor = new UCCOMBOBOX.cmbComboBox();
            this.cmbPresentacion = new UCCOMBOBOX.cmbComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRequisicion = new System.Windows.Forms.TextBox();
            this.btnProveedor = new FontAwesome.Sharp.IconButton();
            this.txtNombreArticulo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPresentacion = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.ucComboBox1 = new UCCOMBOBOX.UCComboBox();
            this.grbGral.SuspendLayout();
            this.grbCaducidad.SuspendLayout();
            this.grbDescripcionArticulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbGral
            // 
            this.grbGral.Controls.Add(this.grbCaducidad);
            this.grbGral.Controls.Add(this.chkCaducidad);
            this.grbGral.Controls.Add(this.txtFolioAlmacen);
            this.grbGral.Controls.Add(this.label10);
            this.grbGral.Controls.Add(this.grbDescripcionArticulo);
            this.grbGral.Location = new System.Drawing.Point(12, 71);
            this.grbGral.Name = "grbGral";
            this.grbGral.Size = new System.Drawing.Size(567, 532);
            this.grbGral.TabIndex = 0;
            this.grbGral.TabStop = false;
            // 
            // grbCaducidad
            // 
            this.grbCaducidad.Controls.Add(this.txtMarcaCaducidad);
            this.grbCaducidad.Controls.Add(this.label12);
            this.grbCaducidad.Controls.Add(this.txtLoteCaducidad);
            this.grbCaducidad.Controls.Add(this.label11);
            this.grbCaducidad.Controls.Add(this.label7);
            this.grbCaducidad.Controls.Add(this.dtpFechaCaducidad);
            this.grbCaducidad.Location = new System.Drawing.Point(6, 374);
            this.grbCaducidad.Name = "grbCaducidad";
            this.grbCaducidad.Size = new System.Drawing.Size(551, 145);
            this.grbCaducidad.TabIndex = 17;
            this.grbCaducidad.TabStop = false;
            // 
            // txtMarcaCaducidad
            // 
            this.txtMarcaCaducidad.Location = new System.Drawing.Point(178, 108);
            this.txtMarcaCaducidad.MaxLength = 50;
            this.txtMarcaCaducidad.Name = "txtMarcaCaducidad";
            this.txtMarcaCaducidad.Size = new System.Drawing.Size(361, 20);
            this.txtMarcaCaducidad.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(109, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 19);
            this.label12.TabIndex = 19;
            this.label12.Text = "Marca:";
            // 
            // txtLoteCaducidad
            // 
            this.txtLoteCaducidad.Location = new System.Drawing.Point(180, 71);
            this.txtLoteCaducidad.MaxLength = 20;
            this.txtLoteCaducidad.Name = "txtLoteCaducidad";
            this.txtLoteCaducidad.Size = new System.Drawing.Size(361, 20);
            this.txtLoteCaducidad.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(112, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 19);
            this.label11.TabIndex = 17;
            this.label11.Text = "LOTE:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fecha de alta:";
            // 
            // dtpFechaCaducidad
            // 
            this.dtpFechaCaducidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCaducidad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCaducidad.Location = new System.Drawing.Point(176, 31);
            this.dtpFechaCaducidad.Name = "dtpFechaCaducidad";
            this.dtpFechaCaducidad.Size = new System.Drawing.Size(147, 26);
            this.dtpFechaCaducidad.TabIndex = 16;
            // 
            // chkCaducidad
            // 
            this.chkCaducidad.AutoSize = true;
            this.chkCaducidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCaducidad.Location = new System.Drawing.Point(457, 351);
            this.chkCaducidad.Name = "chkCaducidad";
            this.chkCaducidad.Size = new System.Drawing.Size(86, 17);
            this.chkCaducidad.TabIndex = 16;
            this.chkCaducidad.Text = "Caducidad";
            this.chkCaducidad.UseVisualStyleBackColor = true;
            this.chkCaducidad.CheckedChanged += new System.EventHandler(this.chkCaducidad_CheckedChanged);
            // 
            // txtFolioAlmacen
            // 
            this.txtFolioAlmacen.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolioAlmacen.Location = new System.Drawing.Point(365, 19);
            this.txtFolioAlmacen.Name = "txtFolioAlmacen";
            this.txtFolioAlmacen.Size = new System.Drawing.Size(178, 29);
            this.txtFolioAlmacen.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(296, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 19);
            this.label10.TabIndex = 14;
            this.label10.Text = "FOLIO:";
            // 
            // grbDescripcionArticulo
            // 
            this.grbDescripcionArticulo.Controls.Add(this.btnCategoria);
            this.grbDescripcionArticulo.Controls.Add(this.cmbCategoria);
            this.grbDescripcionArticulo.Controls.Add(this.label2);
            this.grbDescripcionArticulo.Controls.Add(this.cmbProveedor);
            this.grbDescripcionArticulo.Controls.Add(this.cmbPresentacion);
            this.grbDescripcionArticulo.Controls.Add(this.label4);
            this.grbDescripcionArticulo.Controls.Add(this.txtCantidad);
            this.grbDescripcionArticulo.Controls.Add(this.label5);
            this.grbDescripcionArticulo.Controls.Add(this.txtStock);
            this.grbDescripcionArticulo.Controls.Add(this.label3);
            this.grbDescripcionArticulo.Controls.Add(this.label6);
            this.grbDescripcionArticulo.Controls.Add(this.label9);
            this.grbDescripcionArticulo.Controls.Add(this.txtRequisicion);
            this.grbDescripcionArticulo.Controls.Add(this.btnProveedor);
            this.grbDescripcionArticulo.Controls.Add(this.txtNombreArticulo);
            this.grbDescripcionArticulo.Controls.Add(this.label8);
            this.grbDescripcionArticulo.Controls.Add(this.btnPresentacion);
            this.grbDescripcionArticulo.Controls.Add(this.label1);
            this.grbDescripcionArticulo.Controls.Add(this.dateTimePicker1);
            this.grbDescripcionArticulo.Location = new System.Drawing.Point(6, 46);
            this.grbDescripcionArticulo.Name = "grbDescripcionArticulo";
            this.grbDescripcionArticulo.Size = new System.Drawing.Size(551, 299);
            this.grbDescripcionArticulo.TabIndex = 13;
            this.grbDescripcionArticulo.TabStop = false;
            // 
            // btnCategoria
            // 
            this.btnCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(184)))), ((int)(((byte)(198)))));
            this.btnCategoria.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            this.btnCategoria.IconColor = System.Drawing.Color.Black;
            this.btnCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCategoria.IconSize = 20;
            this.btnCategoria.Location = new System.Drawing.Point(509, 17);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(28, 24);
            this.btnCategoria.TabIndex = 23;
            this.btnCategoria.UseVisualStyleBackColor = false;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(176, 20);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(328, 21);
            this.cmbCategoria.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Categoría:";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(176, 180);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(328, 21);
            this.cmbProveedor.TabIndex = 20;
            // 
            // cmbPresentacion
            // 
            this.cmbPresentacion.FormattingEnabled = true;
            this.cmbPresentacion.Location = new System.Drawing.Point(176, 134);
            this.cmbPresentacion.Name = "cmbPresentacion";
            this.cmbPresentacion.Size = new System.Drawing.Size(328, 21);
            this.cmbPresentacion.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Presentación:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(176, 95);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(112, 20);
            this.txtCantidad.TabIndex = 4;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Proveedor:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(428, 96);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(109, 20);
            this.txtStock.TabIndex = 5;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Requisición:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(363, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Stock:";
            // 
            // txtRequisicion
            // 
            this.txtRequisicion.Location = new System.Drawing.Point(176, 219);
            this.txtRequisicion.Name = "txtRequisicion";
            this.txtRequisicion.Size = new System.Drawing.Size(363, 20);
            this.txtRequisicion.TabIndex = 11;
            // 
            // btnProveedor
            // 
            this.btnProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(184)))), ((int)(((byte)(198)))));
            this.btnProveedor.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnProveedor.IconColor = System.Drawing.Color.Black;
            this.btnProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProveedor.IconSize = 20;
            this.btnProveedor.Location = new System.Drawing.Point(510, 178);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(28, 24);
            this.btnProveedor.TabIndex = 16;
            this.btnProveedor.UseVisualStyleBackColor = false;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // txtNombreArticulo
            // 
            this.txtNombreArticulo.Location = new System.Drawing.Point(176, 60);
            this.txtNombreArticulo.MaxLength = 50;
            this.txtNombreArticulo.Name = "txtNombreArticulo";
            this.txtNombreArticulo.Size = new System.Drawing.Size(361, 20);
            this.txtNombreArticulo.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(54, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Fecha de alta:";
            // 
            // btnPresentacion
            // 
            this.btnPresentacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(184)))), ((int)(((byte)(198)))));
            this.btnPresentacion.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            this.btnPresentacion.IconColor = System.Drawing.Color.Black;
            this.btnPresentacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPresentacion.IconSize = 20;
            this.btnPresentacion.Location = new System.Drawing.Point(510, 132);
            this.btnPresentacion.Name = "btnPresentacion";
            this.btnPresentacion.Size = new System.Drawing.Size(28, 24);
            this.btnPresentacion.TabIndex = 15;
            this.btnPresentacion.UseVisualStyleBackColor = false;
            this.btnPresentacion.Click += new System.EventHandler(this.btnPresentacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del artículo:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(176, 255);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(328, 26);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(42, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(502, 31);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "ALTA DE ARTICULOS EN ALMACEN";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(195)))), ((int)(((byte)(149)))));
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardar.IconColor = System.Drawing.Color.Black;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 32;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(278, 609);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(127, 48);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Brown;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.btnSalir.IconColor = System.Drawing.Color.Black;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 32;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(432, 609);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(127, 48);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(195)))), ((int)(((byte)(119)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimpiar.IconColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 32;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(123, 609);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(127, 48);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // ucComboBox1
            // 
            this.ucComboBox1.Location = new System.Drawing.Point(1033, 599);
            this.ucComboBox1.Name = "ucComboBox1";
            this.ucComboBox1.Size = new System.Drawing.Size(128, 28);
            this.ucComboBox1.TabIndex = 7;
            // 
            // frmAltaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(184)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(593, 667);
            this.Controls.Add(this.ucComboBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grbGral);
            this.Name = "frmAltaArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAltaArticulos_Load);
            this.grbGral.ResumeLayout(false);
            this.grbGral.PerformLayout();
            this.grbCaducidad.ResumeLayout(false);
            this.grbCaducidad.PerformLayout();
            this.grbDescripcionArticulo.ResumeLayout(false);
            this.grbDescripcionArticulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbGral;
        private System.Windows.Forms.TextBox txtRequisicion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnPresentacion;
        private FontAwesome.Sharp.IconButton btnProveedor;
        private FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private System.Windows.Forms.GroupBox grbDescripcionArticulo;
        private System.Windows.Forms.TextBox txtFolioAlmacen;
        private System.Windows.Forms.Label label10;
        private UCCOMBOBOX.UCComboBox ucComboBox1;
        private UCCOMBOBOX.cmbComboBox cmbProveedor;
        private UCCOMBOBOX.cmbComboBox cmbPresentacion;
        private System.Windows.Forms.CheckBox chkCaducidad;
        private UCCOMBOBOX.cmbComboBox cmbCategoria;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnCategoria;
        private System.Windows.Forms.GroupBox grbCaducidad;
        private System.Windows.Forms.TextBox txtMarcaCaducidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLoteCaducidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaCaducidad;
    }
}

