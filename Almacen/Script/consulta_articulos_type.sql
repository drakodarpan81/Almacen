-- DROP FUNCTION consulta_articulos_type (num_folio INTEGER);
-- DROP TYPE type_articulos;

CREATE TYPE type_articulos AS (
	numero_categoria_id	INTEGER,
	nombre_articulo 	VARCHAR(50),
	cantidad 			INTEGER,
	stock 				INTEGER,
	presentacion_id 	INTEGER,
	proveedor_id 		INTEGER,
	requisicion 		VARCHAR(20),
	flag_caducidad		SMALLINT,
	fecha_caducidad		DATE,
	lote_caducidad		VARCHAR(20),
	marca_caducidad		VARCHAR(50)
);

CREATE OR REPLACE FUNCTION consulta_articulos_type (num_folio INTEGER)
RETURNS SETOF type_articulos AS
$$

	DECLARE
		reg RECORD;
		
	BEGIN
	
		FOR reg IN SELECT numero_categoria_id, nombre_articulo, cantidad, stock, presentacion_id, proveedor_id, requisicion, 
						  flag_caducidad, fecha_caducidad, lote_caducidad, marca_caducidad
				   FROM tb_articulosalmacen
				   WHERE folio_articulo = num_folio AND status = 0
		LOOP
			RETURN NEXT reg;
		END LOOP;
		RETURN;
	
	END

$$
LANGUAGE 'plpgsql';