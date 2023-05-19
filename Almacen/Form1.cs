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
using UtileriasFuncionesLESP;

namespace Almacen
{
    public partial class frmAltaArticulos : CControl
    {
        string sTitulo = "", sRutaImg = "";
        CEstructuraGral ep;

        public frmAltaArticulos(CEstructuraGral ed)
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

            AgregarControl(txtFolioAlmacen, fMostrarInformacion, true, "El campo [ FOLIO ] no puede estar vacío, favor de verificar...", false);
            AgregarControl(txtNombreArticulo, null, true, "El campo [ NOMBRE DEL ARTICULO ] no puede estar vacío, favor de verificar...", false);
            AgregarControl(txtCantidad, null, true, "El campo [ CANTIDAD ] no puede estar vacío, favor de verificar...", false);
            AgregarControl(txtStock, null, true, "El campo [ STOCK ] no puede estar vacío, favor de verificar...", false);
            AgregarControl(cmbPresentacion, null, "", false);
            AgregarControl(btnPresentacion, null, "", false);
            AgregarControl(cmbProveedor, null, "", false);
            AgregarControl(btnProveedor, null, "", false);
            AgregarControl(txtRequisicion, null, true, "El campo [ REQUISICION ] no puede estar vacío, favor de verificar...", false);

            // Botones
            AgregarControl(btnLimpiar, null, "", false);
            AgregarControl(btnGuardar, null, "", false);
            AgregarControl(btnSalir, null, "", false);

            fInicializa();

            switch (ep.Opcion){
                case 0:
                    lblTitulo.Text = "ALTA DE ARTICULOS EN ALMACEN";
                    sTitulo = "ALTA DE ARTICULOS EN ALMACEN";
                    txtFolioAlmacen.ReadOnly = true;
                    txtFolioAlmacen.Enabled = false;
                    txtNombreArticulo.Select();
                    break;
                case 1:
                    lblTitulo.Text = "ACTUALIZACIÓN DE ARTICULOS EN ALMACEN";
                    sTitulo = "ACTUALIZACIÓN DE ARTICULOS EN ALMACEN";
                    txtFolioAlmacen.Select();
                    break;
                default:
                    break;
            } 
        }

        public void fInicializa()
        {
            fLimpiarInformacion();
            fLlenarCombosPresentacion();
            fLlenarCombosProveedores();
        }

        public void fLlenarCombosPresentacion()
        {
            cmbPresentacion.DataSource = null;

            string sPresentacion = "EXECUTE almacen.dbo.Proc_UtileriasAlmacen 0";

            cmbComboBox.fLlenarComboBox(ep, sTitulo, sPresentacion, 3, cmbPresentacion, 1);
        }

        public void fLlenarCombosProveedores()
        {
            cmbProveedor.DataSource = null;

            string sPresentacion = "EXECUTE almacen.dbo.Proc_UtileriasAlmacen 1";

            cmbComboBox.fLlenarComboBox(ep, sTitulo, sPresentacion, 3, cmbProveedor, 1);
        }

        // Limpia la informacion de los campos
        public void fLimpiarInformacion()
        {
            try
            {
                FuncionesLESP.fLimpiarInformacion(grbDescripcionArticulo);
                cmbPresentacion.DataSource = null;
                cmbProveedor.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento un problema al limpiar la información: \n" + ex.Message.ToString(), sTitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool fMostrarInformacion()
        {
            string sConsulta; 
            Int32 nIdentificador, nCantidad, nStock;
            bool valorRegresa = false;

            try
            {
                nIdentificador = Convert.ToInt32(txtFolioAlmacen.Text.ToString().Trim());
                sConsulta = string.Format("EXECUTE almacen.dbo.Proc_ConsultarArticulo {0}", nIdentificador);

                OdbcConnection conn = new OdbcConnection();
                if (FuncionesLESP.conexionSQL(ep, ref conn))
                {
                    OdbcCommand com = new OdbcCommand(sConsulta, conn);
                    OdbcDataReader reader;
                    reader = com.ExecuteReader();

                    if (reader.Read())
                    {
                        txtNombreArticulo.Text = reader["nombre_articulo"].ToString().Trim();

                        nCantidad = Convert.ToInt32(reader["cantidad"].ToString().Trim());
                        txtCantidad.Text = nCantidad.ToString().Trim();

                        nStock = Convert.ToInt32(reader["stock"].ToString().Trim());
                        txtStock.Text = nStock.ToString();

                        cmbPresentacion.SelectedIndex = Convert.ToInt32(reader["presentacion"].ToString().Trim());
                        cmbProveedor.SelectedIndex = Convert.ToInt32(reader["proveedor"].ToString().Trim());

                        txtRequisicion.Text = reader["requisicion"].ToString().Trim();

                        valorRegresa = true;
                    }
                    else
                    {
                        MessageBox.Show("El [ FOLIO ] proporcionado, no contiene información...Verifique!!!", sTitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            fLimpiarInformacion();
            txtNombreArticulo.Select();
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

        private void btnPresentacion_Click(object sender, EventArgs e)
        {
            // Llamado del DLL de las presentaciones
            try
            {
                string sRuta = @"C:\LESP\PRESENTACIONES.DLL", sNombreForm = "PRESENTACIONES.frmPresentacion";

                CCargarDLL.cargarDllNoConformidades(sRuta, sNombreForm, ep);
                fLlenarCombosPresentacion();
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
                string sRuta = @"C:\LESP\PROVEEDORES.DLL", sNombreForm = "PROVEEDORES.frmProveedor";

                CCargarDLL.cargarDllNoConformidades(sRuta, sNombreForm, ep);
                fLlenarCombosProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento un problema al cargar los proveedores: \n" + ex.Message.ToString().Trim(), sTitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            string sNombreArticulo, sCantidad, sStock, sRequisicion, sConsulta;
            Int32 nStock, nCantidad, nPresentacion, nProveedor, nFolioReferencia;
            bool valorRegresa = false;

            sNombreArticulo = txtNombreArticulo.Text.Trim();
            sCantidad = txtCantidad.Text.Trim();
            sStock = txtStock.Text.Trim();
            sRequisicion = txtRequisicion.Text.Trim();

            nCantidad = Convert.ToInt32(sCantidad);
            nStock = Convert.ToInt32(sStock);

            nPresentacion = Convert.ToInt32(cmbPresentacion.SelectedValue);
            nProveedor = Convert.ToInt32(cmbProveedor.SelectedValue);

            if (!string.IsNullOrEmpty(sNombreArticulo) && !string.IsNullOrEmpty(sRequisicion))
            {
                try
                {
                    if (ep.Opcion == 0)
                    {
                        sConsulta = String.Format("EXECUTE almacen.dbo.Proc_InsertarAlmacen '{0}', '{1}', {2}, {3}, {4}, {5}, '{6}'",
                            sNombreArticulo, nCantidad, nStock, nPresentacion, nProveedor, sRequisicion);
                    }
                    else
                    {
                        nFolioReferencia = Convert.ToInt32(txtFolioAlmacen.Text.ToString());
                        sConsulta = String.Format("EXECUTE almacen.dbo.Proc_ActualizarAlmacen {0}, '{1}', '{2}', {3}, {4}, {5}, {6}, '{7}'",
                             nFolioReferencia, sNombreArticulo, nCantidad, nStock, nPresentacion, nProveedor, sRequisicion);
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
    }
}
