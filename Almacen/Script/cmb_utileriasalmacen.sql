-- DROP FUNCTION cmb_utileriasalmacen();

CREATE OR REPLACE FUNCTION cmb_utileriasalmacen(opcion SMALLINT)
RETURNS TABLE (Descripcion VARCHAR(50), Identificador INTEGER) AS
$$

	BEGIN
	
		IF opcion = 0 THEN
			RETURN QUERY SELECT nombre_categoria, numero_categoria
						 FROM tb_categorias
						 WHERE status = 0
						 ORDER BY id;
		ELSIF opcion = 1 THEN
			RETURN QUERY SELECT des_presentacion, id
						 FROM tb_presentacion
						 WHERE status = 0
						 ORDER BY id;
		ELSIF opcion = 2 THEN
			RETURN QUERY SELECT nombre_proveedor, id
						 FROM tb_proveedor
						 WHERE status = 0
						 ORDER BY id;		
		END IF;
	
	END

$$
LANGUAGE 'plpgsql';
