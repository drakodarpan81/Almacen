SELECT eliminartabla('tb_his_articulos_almacen');

CREATE TABLE tb_his_articulos_almacen(
	folio_articulo		INTEGER NOT NULL DEFAULT 0,
	numero_categoria_id	INTEGER NOT NULL DEFAULT 0,
	nombre_articulo 	VARCHAR(50) NOT NULL DEFAULT '',
	cantidad 			INTEGER NOT NULL DEFAULT 0,
	stock 				INTEGER NOT NULL DEFAULT 0,
	presentacion_id 	INTEGER NOT NULL DEFAULT 0,
	proveedor_id 		INTEGER NOT NULL DEFAULT 0,
	requisicion 		VARCHAR(20) NOT NULL DEFAULT '',
	flag_caducidad		SMALLINT NOT NULL DEFAULT 0,
	fecha_caducidad		DATE NOT NULL DEFAULT '1900-01-01',
	lote_caducidad		VARCHAR(20) NOT NULL DEFAULT '',
	marca_caducidad		VARCHAR(50) NOT NULL DEFAULT '',
	status 				SMALLINT NOT NULL DEFAULT 0,
	observacion 		VARCHAR(100) NOT NULL DEFAULT '',
	id_empleado			INTEGER NOT NULL DEFAULT 0,
	folio_movimiento	INTEGER NOT NULL DEFAULT 0,
	fecha_modificacion	DATE NOT NULL DEFAULT CURRENT_DATE
);