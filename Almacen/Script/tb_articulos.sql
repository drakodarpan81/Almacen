SELECT eliminartabla('tb_articulosalmacen');

CREATE TABLE tb_articulosalmacen(
	Id 					SERIAL,
	folio_articulo		INTEGER NOT NULL,
	numero_categoria_id	INTEGER REFERENCES tb_categorias(id),
	nombre_articulo 	VARCHAR(50) NOT NULL,
	cantidad 			INTEGER NOT NULL DEFAULT 0,
	stock 				INTEGER NOT NULL DEFAULT 0,
	presentacion_id 	INTEGER REFERENCES tb_presentacion(id),
	proveedor_id 		INTEGER REFERENCES tb_proveedor(id),
	requisicion 		VARCHAR(20) NOT NULL DEFAULT '',
	flag_caducidad		SMALLINT NOT NULL DEFAULT 0,
	fecha_caducidad		DATE NOT NULL DEFAULT '1900-01-01',
	lote_caducidad		VARCHAR(20) NOT NULL DEFAULT '',
	marca_caducidad		VARCHAR(50) NOT NULL DEFAULT '',
	status 				SMALLINT NOT NULL DEFAULT 0,
	observacion 		VARCHAR(100) NOT NULL DEFAULT '',
	fecha_alta 			DATE NOT NULL DEFAULT CURRENT_DATE,
	PRIMARY KEY (nombre_articulo, presentacion_id)
);
