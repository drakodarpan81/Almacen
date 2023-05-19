DROP TABLE IF EXISTS tb_articulos;

CREATE TABLE tb_articulos(
	Id 				SERIAL,
	nombre_articulo VARCHAR(50) NOT NULL,
	cantidad 		INT NOT NULL DEFAULT 0,
	stock 			INT NOT NULL DEFAULT 0,
	presentacion 	INT NOT NULL DEFAULT 0,
	proveedor 		INT NOT NULL DEFAULT 0,
	requisicion 	VARCHAR(20) NOT NULL DEFAULT '',
	estado 			BOOL NOT NULL DEFAULT true,
	observacion 	VARCHAR(100) NOT NULL DEFAULT '',
	fecha_alta 		DATE NOT NULL DEFAULT CURRENT_DATE,
	PRIMARY KEY 	(nombre_articulo, presentacion)
);
