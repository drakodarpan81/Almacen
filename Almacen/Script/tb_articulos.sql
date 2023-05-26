SELECT eliminartabla('tb_articulosalmacen');

CREATE TABLE tb_articulosalmacen(
	Id 					SERIAL,
	numero_categoria_id INTEGER NOT NULL,
	nombre_articulo 	VARCHAR(50) NOT NULL,
	cantidad 			INT NOT NULL DEFAULT 0,
	stock 				INT NOT NULL DEFAULT 0,
	presentacion_id 	VARCHAR(50) NOT NULL DEFAULT 0,
	proveedor_id 		VARCHAR(50) NOT NULL,
	requisicion 		VARCHAR(20) NOT NULL DEFAULT '',
	status 				SMALLINT NOT NULL DEFAULT 0,
	observacion 		VARCHAR(100) NOT NULL DEFAULT '',
	fecha_alta 			DATE NOT NULL DEFAULT CURRENT_DATE,
	PRIMARY KEY 	(nombre_articulo, presentacion_id),
	CONSTRAINT fk_categoria FOREIGN KEY (numero_categoria_id) REFERENCES tb_categorias(numero_categoria),
	CONSTRAINT fk_presentacion FOREIGN KEY (presentacion_id) REFERENCES tb_presentacion(des_presentacion),
	CONSTRAINT fk_proveedores FOREIGN KEY (numero_categoria_id) REFERENCES tb_proveedor(nombre_proveedor)
);
