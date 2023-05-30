CREATE OR REPLACE FUNCTION insertar_articulos_almacen(opcion SMALLINT,
													  folio_art INTEGER,
													  categoria INTEGER, -- Categoría del catalogo
													  nom_articulo VARCHAR(50), -- Nombre del articulo
													  cant INTEGER, -- Cantidad del articulo
													  stk INTEGER, -- Stock del articulo
													  presentacion INTEGER, -- Presentación del catalogo
													  proveedor INTEGER, -- Proveedores del catalogo
													  requi VARCHAR(20), -- Requisición
													  chk_caducidad SMALLINT, -- Flag de caducidad
													  date_caducidad DATE, -- Fecha de caducidad
													  lt_caducidad VARCHAR(20), -- Lote de caducidad
													  mark_caducidad VARCHAR(50)) -- Marca de caducidad
RETURNS INTEGER AS
$$

	DECLARE
		folio INTEGER;

	BEGIN
	
		IF opcion = 0 THEN
	
			folio := (SELECT generar_folio(categoria::INTEGER));

			INSERT INTO tb_articulosalmacen (folio_articulo, numero_categoria_id, nombre_articulo, cantidad, stock, presentacion_id, proveedor_id, requisicion, flag_caducidad, fecha_caducidad, lote_caducidad, marca_caducidad)
			VALUES (folio, categoria, nom_articulo, cant, stk, presentacion, proveedor, requi, chk_caducidad, date_caducidad, lt_caducidad, mark_caducidad);

			RETURN folio;
	
		ELSIF opcion = 1 THEN
		
			UPDATE tb_articulosalmacen
			SET numero_categoria_id = categoria, 
				nombre_articulo = nom_articulo, 
				cantidad = cant, 
				stock = stk, 
				presentacion_id = presentacion, 
				proveedor_id = proveedor, 
				requisicion = requi,
				flag_caducidad = chk_caducidad, 
				fecha_caducidad =  date_caducidad, 
				lote_caducidad = lt_caducidad, 
				marca_caducidad = mark_caducidad
			WHERE folio_articulo = folio_art;
			
			RETURN folio_art;
		
		ELSIF opcion = 2 THEN
		
			UPDATE tb_articulosalmacen
			SET status = 1
			WHERE folio_articulo = folio_art;
			
			RETURN folio_art;
			
		END IF;
	
	END

$$
LANGUAGE 'plpgsql';