using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using UCCOMBOBOX;
using CFACADECONN;
using CFACADESTRUC;
using CATEGORIAS;
using System.Reflection;
using CFACADEFUN;
using Npgsql;
using System.Windows.Documents;
using System.Collections;

namespace Almacen
{
    public partial class frmAltaArticulos : CControl
    {
        string sTitulo = "";
        CEstructura ep;

        public frmAltaArticulos(CEstructura ed)
        {
            InitializeComponent();
            ep = ed;
        }

        private void frmAltaArticulos_Load(object sender, EventArgs e)
        {
            txtNombreArticulo.MaxLength = 50;
            txtCantidad.MaxLength = 10;
            txtStock.MaxLength = 10;
            txtRequisicion.MaxLength = 20;

            HabilitarTeclaEscape = true;
            HabilitarTeclasSalir = true;

            switch (ep.Opcion){
                case 0:
                    lblTitulo.Text = "ALTA DE ARTICULOS EN ALMACEN";
                    sTitulo = "ALTA DE ARTICULOS EN ALMACEN";
                    txtFolioAlmacen.ReadOnly = true;
                    txtFolioAlmacen.Enabled = false;
                    AgregarControl(txtFolioAlmacen, null, false, "", false);
                    cmbCategoria.Select();
                    break;
                case 1:
                    lblTitulo.Text = "ACTUALIZACIÓN DE ARTICULOS";
                    sTitulo = "ACTUALIZACIÓN DE ARTICULOS EN ALMACEN";
                    AgregarControl(txtFolioAlmacen, fMostrarInformacion, true, "El campo [ FOLIO ] no puede estar vacío, favor de verificar...", false);
                    txtFolioAlmacen.Select();
                    break;
                case 2:
                    lblTitulo.Text = "ELIMINAR ARTICULOS";
                    sTitulo = "ELIMINAR ARTICULOS EN ALMACEN";
                    AgregarControl(txtFolioAlmacen, fMostrarInformacion, true, "El campo [ FOLIO ] no puede estar vacío, favor de verificar...", false);
                    txtFolioAlmacen.Select();
                    break;
                default:
                    break;
            }

            AgregarControl(cmbCategoria, null, true, "", false);
            AgregarControl(btnCategoria, null, "", false);
            AgregarControl(txtNombreArticulo, null, true, "El campo [ NOMBRE DEL ARTICULO ] no puede estar vacío, favor de verificar...", false);
            AgregarControl(txtCantidad, null, true, "El campo [ CANTIDAD ] no puede estar vacío, favor de verificar...", false);
            AgregarControl(txtStock, null, true, "El campo [ STOCK ] no puede estar vacío, favor de verificar...", false);
            AgregarControl(cmbPresentacion, null, "", false);
            AgregarControl(btnPresentacion, null, "", false);
            AgregarControl(cmbProveedor, null, "", false);
            AgregarControl(btnProveedor, null, "", false);
            AgregarControl(txtRequisicion, null, true, "El campo [ REQUISICION ] no puede estar vacío, favor de verificar...", false);

            AgregarControl(chkCaducidad, null, "", false);
            AgregarControl(dtpFechaCaducidad, null, "", false);
            AgregarControl(txtLoteCaducidad, null, "", false);
            AgregarControl(txtMarcaCaducidad, null, "", false);

            // Botones
            AgregarControl(btnLimpiar, null, "", false);
            AgregarControl(btnGuardar, null, "", false);
            AgregarControl(btnSalir, null, "", false);

            fInicializa();
        }

        public void fInicializa()
        {
            fLimpiarInformacion();
            fLlenarCombosCategorias();
            fLlenarCombosPresentacion();
            fLlenarCombosProveedores();

            this.Size = new Size(609, 552);
            grbCaducidad.Visible = false;
            grbGral.Size = new Size(567, 375);
            btnLimpiar.Location = new Point(121, 453);
            btnGuardar.Location = new Point(276, 453);
            btnSalir.Location = new Point(430, 453);

            cmbCategoria.Enabled = true;
            txtNombreArticulo.Enabled = true;
            txtCantidad.Enabled = true;
            txtStock.Enabled = true;
            cmbPresentacion.Enabled = true;
            cmbProveedor.Enabled = true;
            txtRequisicion.Enabled = true;
            chkCaducidad.Enabled = true;
            txtLoteCaducidad.Enabled = true;
            txtMarcaCaducidad.Enabled = true;
            dtpFechaCaducidad.Enabled = true;

            chkCaducidad.Checked = false;

            switch (ep.Opcion)
            {
                case 0:
                    {
                        cmbCategoria.Select();
                    }
                    break;
                case 1:
                case 2:
                    {
                        txtFolioAlmacen.Select();
                    }
                    break;
                default:
                    break;
            }

        }

        public void fLlenarCombosCategorias()
        {
            cmbCategoria.DataSource = null;

            string sPresentacion = "SELECT descripcion, identificador FROM cmb_utileriasalmacen(0::SMALLINT)";

            cmbComboBox.fLlenarComboBoxPostgres(ep, sTitulo, sPresentacion, 3, cmbCategoria, 1);
        }

        public void fLlenarCombosPresentacion()
        {
            cmbPresentacion.DataSource = null;

            string sPresentacion = "SELECT descripcion, identificador FROM cmb_utileriasalmacen(1::SMALLINT)";

            cmbComboBox.fLlenarComboBoxPostgres(ep, sTitulo, sPresentacion, 3, cmbPresentacion, 1);
        }

        public void fLlenarCombosProveedores()
        {
            cmbProveedor.DataSource = null;

            string sPresentacion = "SELECT descripcion, identificador FROM cmb_utileriasalmacen(2::SMALLINT)";

            cmbComboBox.fLlenarComboBoxPostgres(ep, sTitulo, sPresentacion, 3, cmbProveedor, 1);
        }

        // Limpia la informacion de los campos
        public void fLimpiarInformacion()
        {
            try
            {
                fLimpiarInformacion(grbGral);
                fLimpiarInformacion(grbDescripcionArticulo);
                cmbCategoria.DataSource = null;
                cmbPresentacion.DataSource = null;
                cmbProveedor.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento un problema al limpiar la información: \n" + ex.Message.ToString(), sTitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void fLimpiarInformacion(GroupBox gb)
        {
            foreach (Control c in gb.Controls)
            {
                if (c is TextBox || c is RichTextBox)
                {
                    c.Text = "";
                }
                else if (c is ComboBox)
                {
                    var tmp = c as ComboBox;
                    tmp.DataSource = null;
                    tmp.Items.Clear();
                }
                else if (c is DataGridView)
                {
                    var tmp = c as DataGridView;
                    tmp.Rows.Clear();
                    tmp.Columns.Clear();
                }
                else if (c is CheckBox)
                {
                    var tmp = c as CheckBox;
                    tmp.Checked = false;
                }
            }
        }

        public bool fMostrarInformacion()
        {
            string sConsulta, sDato; 
            Int32 nIdentificador, nCantidad, nStock, nCategoria;
            bool valorRegresa = false;

            char sDelimitador = '-';

            try
            {
                //nIdentificador = Convert.ToInt32(txtFolioAlmacen.Text.ToString().Trim());

                sDato = txtFolioAlmacen.Text.ToString().Trim();
                string[] valores = sDato.Split(sDelimitador);
                nCategoria = Convert.ToInt32(valores[0].ToString().Trim());
                nIdentificador = Convert.ToInt32(valores[1].ToString().Trim());

                sConsulta = string.Format(" SELECT numero_categoria_id, nombre_articulo, cantidad, stock, presentacion_id, proveedor_id, requisicion, flag_caducidad, fecha_caducidad, lote_caducidad, marca_caducidad " + 
                                          " FROM consulta_articulos_type({0}::INTEGER, {1}::INTEGER) ", nCategoria, nIdentificador);
                txtFolioAlmacen.Text = nCategoria + " - " + nIdentificador.ToString("D4");

                NpgsqlConnection conn = new NpgsqlConnection();
                {
                    if(CConeccion.conexionPostgre(ep, ref conn, ref sError))
                    {
                        NpgsqlCommand com = new NpgsqlCommand(sConsulta, conn);
                        NpgsqlDataReader reader;
                        reader = com.ExecuteReader();

                        if (reader.Read())
                        {
                            cmbCategoria.SelectedIndex = Convert.ToInt32(reader["numero_categoria_id"].ToString().Trim());

                            txtNombreArticulo.Text = reader["nombre_articulo"].ToString().Trim();

                            nCantidad = Convert.ToInt32(reader["cantidad"].ToString().Trim());
                            txtCantidad.Text = nCantidad.ToString().Trim();

                            nStock = Convert.ToInt32(reader["stock"].ToString().Trim());
                            txtStock.Text = nStock.ToString();

                            cmbPresentacion.SelectedIndex = Convert.ToInt32(reader["presentacion_id"].ToString().Trim());
                            cmbProveedor.SelectedIndex = Convert.ToInt32(reader["proveedor_id"].ToString().Trim());

                            txtRequisicion.Text = reader["requisicion"].ToString().Trim();

                            if (Convert.ToInt32(reader["flag_caducidad"].ToString().Trim()) == 1)
                            {
                                chkCaducidad.Checked = true;

                                txtLoteCaducidad.Text = reader["lote_caducidad"].ToString().Trim();
                                txtMarcaCaducidad.Text = reader["marca_caducidad"].ToString().Trim();

                                dtpFechaCaducidad.Format = DateTimePickerFormat.Custom;
                                dtpFechaCaducidad.CustomFormat = "dd/MM/yyyy";
                                dtpFechaCaducidad.Text = reader["fecha_caducidad"].ToString().Trim();
                            }


                            if(ep.Opcion==2)
                            {
                                cmbCategoria.Enabled = false;
                                txtNombreArticulo.Enabled = false;
                                txtCantidad.Enabled = false;
                                txtStock.Enabled = false;
                                cmbPresentacion.Enabled = false;
                                cmbProveedor.Enabled = false;
                                txtRequisicion.Enabled = false;
                                chkCaducidad.Enabled = false;
                                txtLoteCaducidad.Enabled = false;
                                txtMarcaCaducidad.Enabled = false;
                                dtpFechaCaducidad.Enabled = false;
                            }

                            valorRegresa = true;
                        }
                        else
                        {
                            MessageBox.Show("El [ FOLIO ] proporcionado, no contiene información...Verifique!!!", sTitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento un problema al mostrar la información: \n" + ex.Message.ToString(), sTitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return valorRegresa;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            fInicializa();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo se van a permitir numeros
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == (Char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo se van a permitir numeros
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == (Char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        /*
         * Área de botones
         */
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            // Llamado del DLL de las categorias
            string sRuta = @"C:\ALMACEN\CATEGORIAS.DLL", sNombreForm = "CATEGORIAS.frmCategorias";

            if (fCargarDll(sRuta, sNombreForm))
            {
                fLlenarCombosCategorias();
            }
        }

        private void btnPresentacion_Click(object sender, EventArgs e)
        {
            // Llamado del DLL de las presentaciones
            try
            {
                string sRuta = @"C:\ALMACEN\PRESENTACIONES.DLL", sNombreForm = "PRESENTACIONES.frmPresentacion";

                if (fCargarDll(sRuta, sNombreForm))
                {
                    fLlenarCombosPresentacion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento un problema al cargar las presentaciones: \n" + ex.Message.ToString().Trim(), sTitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            // Llamado del DLL de los proveedores
            try
            {
                string sRuta = @"C:\ALMACEN\PROVEEDORES.DLL", sNombreForm = "PROVEEDORES.frmProveedor";

                if (fCargarDll(sRuta, sNombreForm))
                {
                    fLlenarCombosProveedores();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento un problema al cargar los proveedores: \n" + ex.Message.ToString().Trim(), sTitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool fCargarDll(string sRuta, string sNombreForm)
        {
            bool valorRegresa = false;

            try
            {
                CControl objForm = new CControl();
                Assembly DllaCargar = Assembly.LoadFile(sRuta);
                Type DllType = DllaCargar.GetType(sNombreForm);
                object miObjetoDll = Activator.CreateInstance(DllType, ep);
                objForm = (CControl)miObjetoDll;
                objForm.ShowDialog();
                valorRegresa = true;
            }
            catch (IOException ioEx)
            {
                MessageBox.Show(ioEx.Message.ToString(), "Error al Cargar DLL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString(), "Error al Cargar DLL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return valorRegresa;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿Desea guarda la información?", sTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (fGuardarInformacion())
                {
                    fInicializa();
                }
            }
        }

        public bool fGuardarInformacion() 
        {
            string sNombreArticulo, sCantidad, sStock, sRequisicion, sConsulta, sMensaje, sFechaCaducidad = "1900-01-01", sLote, sMarca, sDato, sCategoria;
            Int32 nStock, nCantidad, nFolioReferencia, nCategoria, nPresentacion, nProveedor, nMarcaCaducidad, nLongituTexto;
            bool valorRegresa = false;

            char sDelimitador = '-';

            if (ep.Opcion == 0)
            {
                nFolioReferencia = 0;
            }
            else
            {
                sDato = txtFolioAlmacen.Text.ToString();
                string[] valor = sDato.Split(sDelimitador);
                nFolioReferencia = Convert.ToInt32(valor[1].ToString().Trim());
            }
            
            sNombreArticulo = txtNombreArticulo.Text.Trim();
            sCantidad = txtCantidad.Text.Trim();
            sStock = txtStock.Text.Trim();
            sRequisicion = txtRequisicion.Text.Trim();

            nCantidad = Convert.ToInt32(sCantidad);
            nStock = Convert.ToInt32(sStock);

            sCategoria = cmbCategoria.Text.ToString().Trim();
            string[] valores = sCategoria.Split(sDelimitador);
            nCategoria = Convert.ToInt32(valores[0].ToString().Trim());
            
            nProveedor = Convert.ToInt32(cmbProveedor.SelectedValue);
            nPresentacion = Convert.ToInt32(cmbPresentacion.SelectedValue);

            if (chkCaducidad.Checked)
            {
                nMarcaCaducidad = 1;
                sLote = txtLoteCaducidad.Text.ToString();
                sMarca = txtMarcaCaducidad.Text.ToString();

                sDato = dtpFechaCaducidad.Text.ToString();
                nLongituTexto = 0;
                nLongituTexto = sDato.Length;
                sFechaCaducidad = string.Format("{0}-{1}-{2}", sDato.ToString().Substring(nLongituTexto - 4, 4), sDato.ToString().Substring(3, 2), sDato.ToString().Substring(0, 2));
            }
            else
            {
                sLote = "";
                sMarca = "";
                sFechaCaducidad = "1900-01-01";
                nMarcaCaducidad = 0;
            }

            if (!string.IsNullOrEmpty(sNombreArticulo) && !string.IsNullOrEmpty(sRequisicion))
            {
                try
                {
                    NpgsqlConnection conn = new NpgsqlConnection();
                    if (CConeccion.conexionPostgre(ep, ref conn, ref sError))
                    {
                        sConsulta = String.Format("SELECT insertar_articulos_almacen({0}::SMALLINT, {1}::INTEGER, {2}::INTEGER, '{3}', {4}::INTEGER, {5}::INTEGER, {6}::INTEGER, {7}::INTEGER, '{8}', {9}::SMALLINT, '{10}'::DATE, '{11}', '{12}', {13}::INTEGER)",
                           ep.Opcion, nFolioReferencia, nCategoria, sNombreArticulo, nCantidad, nStock, nPresentacion, nProveedor, sRequisicion, nMarcaCaducidad, sFechaCaducidad, sLote, sMarca, ep.IdEmpleado);

                        if (ep.Opcion == 0)
                        {
                            NpgsqlCommand com = new NpgsqlCommand(sConsulta, conn);
                            NpgsqlDataReader reader;
                            reader = com.ExecuteReader();

                            if (reader.Read())
                            {
                                nFolioReferencia = Convert.ToInt32(reader["insertar_articulos_almacen"].ToString());
                            }
                        }
                        else if (ep.Opcion == 1 || ep.Opcion == 2)
                        {
                            NpgsqlCommand com = new NpgsqlCommand(sConsulta, conn);
                            com.ExecuteNonQuery();
                            valorRegresa = true;
                        }
                    }

                    if(conn.State== ConnectionState.Open)
                    {
                        conn.Close();
                    }

                    switch (ep.Opcion)
                    {
                        case 0:
                            {
                                NpgsqlConnection conn2 = new NpgsqlConnection();
                                if (CConeccion.conexionPostgre(ep, ref conn2, ref sError))
                                {
                                    sConsulta = String.Format("SELECT actualizar_foliador({0}::INTEGER,{1}::INTEGER)", nCategoria, nFolioReferencia);
                                    NpgsqlCommand com2 = new NpgsqlCommand(sConsulta, conn2);
                                    com2.ExecuteNonQuery();
                                }

                                if(conn2.State== ConnectionState.Open)
                                {
                                    conn2.Close();
                                }
                                valorRegresa = true;

                                sMensaje = String.Format("Se dio de alta con exito el artículo: {0} - {1}", nCategoria.ToString("D3").Trim(), nFolioReferencia.ToString("D4"));
                                MessageBox.Show(sMensaje, sTitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            break;
                        case 1:
                            {
                                sMensaje = String.Format("Se actualizo con exito el artículo: {0} - {1}", nCategoria.ToString("D3").Trim(), nFolioReferencia.ToString("D4"));
                                MessageBox.Show(sMensaje, sTitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            break;
                        case 2:
                            {
                                sMensaje = String.Format("Se elimino con exito el artículo: {0} - {1}", nCategoria.ToString("D3").Trim(), nFolioReferencia.ToString("D4"));
                                MessageBox.Show(sMensaje, sTitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            break;
                        default:
                            break;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Se presento un problema al guardar las información: \n" + ex.Message.ToString().Trim(), sTitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Existen campos vacios, favor de llenar la información.", sTitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return valorRegresa;
        }

        private void chkCaducidad_CheckedChanged(object sender, EventArgs e)
        {
            string sFecha = "";

            if (chkCaducidad.Checked)
            {
                this.Size = new Size(609, 706);
                grbCaducidad.Visible = true;
                grbGral.Size = new Size(567, 532);
                btnLimpiar.Location = new Point(123, 609);
                btnGuardar.Location = new Point(278, 609);
                btnSalir.Location = new Point(432, 609);
            }
            else
            {
                this.Size = new Size(609, 552);
                grbCaducidad.Visible = false;
                grbGral.Size = new Size(567, 375);
                btnLimpiar.Location = new Point(121, 453);
                btnGuardar.Location = new Point(276, 453);
                btnSalir.Location = new Point(430, 453);
            }

            dtpFechaCaducidad.Format = DateTimePickerFormat.Custom;
            dtpFechaCaducidad.CustomFormat = "dd/MM/yyyy";
            sFecha = CFuncionesGral.fConsultarFechaServerPostgres(ep, ref sError);
            dtpFechaCaducidad.Text = sFecha.ToString();

            txtLoteCaducidad.Text = "";
            txtMarcaCaducidad.Text = "";
        }
    }
}
