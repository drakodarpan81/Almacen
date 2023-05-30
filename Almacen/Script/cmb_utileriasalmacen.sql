-- DROP FUNCTION cmb_utileriasalmacen();
-- DROP TYPE type_categoria;

CREATE TYPE type_categoria AS 
(
	Descripcion VARCHAR(100),
	Identificador INTEGER
);

CREATE OR REPLACE FUNCTION cmb_utileriasalmacen(opcion SMALLINT)
RETURNS SETOF type_categoria AS
$$

	DECLARE
		reg RECORD;

	BEGIN
	
		IF opcion = 0 THEN
			
			
			FOR reg IN SELECT CONCAT( numero_categoria, ' - ', nombre_categoria )::VARCHAR(100) AS descripcion, id AS Identificador
						 FROM tb_categorias
						 WHERE status = 0
						 ORDER BY id 
			LOOP
				RETURN NEXT reg;
			END LOOP;
			RETURN;
			
		ELSIF opcion = 1 THEN
			FOR reg IN SELECT des_presentacion::VARCHAR(100) AS descripcion, id AS Identificador
						 FROM tb_presentacion
						 WHERE status = 0
						 ORDER BY id
			LOOP
				RETURN NEXT reg;
			END LOOP;
			RETURN;
			
		ELSIF opcion = 2 THEN
			FOR reg IN SELECT nombre_proveedor::VARCHAR(100) AS descripcion, id AS Identificador
						 FROM tb_proveedor
						 WHERE status = 0
						 ORDER BY id
			LOOP
				RETURN NEXT reg;
			END LOOP;
			RETURN;
		END IF;
	
	END

$$
LANGUAGE 'plpgsql';
