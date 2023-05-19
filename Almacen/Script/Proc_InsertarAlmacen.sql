USE almacen
GO
IF Exists( SELECT * FROM Sysobjects WHERE NAME ='Proc_InsertarAlmacen' )
    DROP PROCEDURE dbo.Proc_InsertarAlmacen
GO
SET QUOTED_IDENTIFIER OFF
GO
SET ANSI_NULLS ON
GO

Create Procedure dbo.Proc_InsertarAlmacen @cNombre_articulo NVARCHAR(20), @cDescripcion NVARCHAR(500), @nCantidad INT, @nStock INT, @nPresentacion INT, @nProveedor INT, @cRequisicion NVARCHAR(20)
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

	DECLARE @nIdentificador INT

	SET @nIdentificador = 0

	INSERT INTO almacen.dbo.m_articulos (nombre_articulo, descripcion, cantidad, stock, presentacion, proveedor, requisicion)
	VALUES (@cNombre_articulo, @cDescripcion, @nCantidad, @nStock, @nPresentacion, @nProveedor, @cRequisicion)

	SELECT @nIdentificador = id FROM almacen.dbo.m_articulos (NOLOCK) WHERE nombre_articulo = @cNombre_articulo

	INSERT INTO almacen.dbo.m_controlarticulos (id_nombrearticulo, cantidad)
	VALUES (@nIdentificador, @nCantidad)

	SELECT @nIdentificador AS identificador

	COMMIT TRANSACTION 
END