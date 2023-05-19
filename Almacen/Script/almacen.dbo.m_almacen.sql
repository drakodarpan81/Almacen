/********************************************************************************************      
FECHA: 07/Septiembre/2020.
DESCRIPCION: Se crea tabla con la informaci�n de la no conformidad
REALIZ�: David Ar�mbula Rodr�gez
********************************************************************************************/  
USE almacen
GO

CREATE TABLE almacen.dbo.m_articulos(
	Id INT NOT NULL IDENTITY(1, 1),
	nombre_articulo NVARCHAR(50) NOT NULL,
	descripcion NVARCHAR(500) NOT NULL DEFAULT '',
	cantidad INT NOT NULL DEFAULT 0,
	stock INT NOT NULL DEFAULT 0,
	presentacion INT NOT NULL DEFAULT 0,
	proveedor INT NOT NULL DEFAULT 0,
	requisicion NVARCHAR(20) NOT NULL DEFAULT '',
	estado BIT NOT NULL DEFAULT 0,
	observacion NVARCHAR(100) NOT NULL DEFAULT '',
	fecha_alta DATETIME NOT NULL DEFAULT GETDATE(),
	PRIMARY KEY (nombre_articulo)
);
