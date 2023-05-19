USE almacen
GO
IF Exists( SELECT * FROM Sysobjects WHERE NAME ='Proc_ActualizarAlmacen' )
    DROP PROCEDURE dbo.Proc_ActualizarAlmacen
GO
SET QUOTED_IDENTIFIER OFF
GO
SET ANSI_NULLS ON
GO

Create Procedure dbo.Proc_ActualizarAlmacen @nFolioReferencia INT, @cNombre_articulo NVARCHAR(20), @cDescripcion NVARCHAR(500), @nCantidad INT, @nStock INT, @nPresentacion INT, @nProveedor INT, @nRequisicion NVARCHAR(20)
WITH EXECUTE AS OWNER
/***********************************************************************
-- DROP PROCEDURE Proc_ConsultarOrigen
EXECUTE dbo.Proc_ConsultarOrigen

FECHA: 04/Septiembre/2020
Descripcion: Consultar las coordinaciones

Modifico: David Arámbula Rodríguez
***********************************************************************/
As
BEGIN
SET NOCOUNT ON

	SET XACT_ABORT ON
	BEGIN TRANSACTION

	UPDATE almacen.dbo.m_articulos 
	SET nombre_articulo = @cNombre_articulo, 
		descripcion = @cDescripcion, 
		cantidad = @nCantidad, 
		stock = @nStock, 
		presentacion = @nPresentacion, 
		proveedor = @nProveedor, 
		requisicion = @nRequisicion
	WHERE id = @nFolioReferencia

	COMMIT TRANSACTION 
END