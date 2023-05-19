USE almacen
GO
IF Exists( SELECT * FROM Sysobjects WHERE NAME ='Proc_ConsultarArticulo' )
    DROP PROCEDURE dbo.Proc_ConsultarArticulo
GO
SET QUOTED_IDENTIFIER OFF
GO
SET ANSI_NULLS ON
GO

Create Procedure dbo.Proc_ConsultarArticulo @nIdentificador INT
WITH EXECUTE AS OWNER
/***********************************************************************
-- DROP PROCEDURE Proc_ConsultarDecision
EXECUTE dbo.Proc_ConsultarDecision

FECHA: 04/Septiembre/2020
Descripcion: Consultar las coordinaciones

Modifico: David Arámbula Rodríguez
***********************************************************************/
As
BEGIN
SET NOCOUNT ON

	SELECT nombre_articulo, descripcion, cantidad, stock, presentacion, proveedor, requisicion, imagen
	FROM almacen.dbo.m_articulos (NOLOCK)
	WHERE Id = @nIdentificador AND estado= 0

END
