USE almacen
GO
IF Exists( SELECT * FROM Sysobjects WHERE NAME ='Proc_UtileriasAlmacen' )
    DROP PROCEDURE dbo.Proc_UtileriasAlmacen
GO
SET QUOTED_IDENTIFIER OFF
GO
SET ANSI_NULLS ON
GO

Create Procedure dbo.Proc_UtileriasAlmacen @nOpcion INT
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

	IF @nOpcion = 0
	BEGIN
		SELECT id AS Identificador, presentacion AS Descripcion FROM almacen.dbo.c_presentacion (NOLOCK)
	END
	ELSE IF @nOpcion = 1
	BEGIN
		SELECT id AS Identificador, nombre_proveedor AS Descripcion FROM almacen.dbo.c_proveedor (NOLOCK)
	END
END
