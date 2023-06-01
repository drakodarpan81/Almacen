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
													  mark_caducidad VARCHAR(50), -- Marca de caducidad
													  empleado INTEGER ) -- Empleado que está realizando los movimientos
RETURNS INTEGER AS
$$

	DECLARE
		folio INTEGER;
		nId INTEGER;

	BEGIN
	
		IF opcion = 0 THEN
	
			SELECT id
			INTO nId
			FROM tb_categorias
			WHERE numero_categoria = categoria;
			
			folio := (SELECT generar_folio(nId::INTEGER));

			INSERT INTO tb_articulosalmacen (folio_articulo, numero_categoria_id, nombre_articulo, cantidad, stock, presentacion_id, proveedor_id, requisicion, flag_caducidad, fecha_caducidad, lote_caducidad, marca_caducidad, id_empleado)
			VALUES (folio, nId, nom_articulo, cant, stk, presentacion, proveedor, requi, chk_caducidad, date_caducidad, lt_caducidad, mark_caducidad, empleado);

			RETURN folio;
	
		ELSIF opcion = 1 THEN
		
			SELECT id
			INTO nId
			FROM tb_categorias
			WHERE numero_categoria = categoria;
		
			UPDATE tb_articulosalmacen
			SET numero_categoria_id = nId, 
				nombre_articulo = nom_articulo, 
				cantidad = cant, 
				stock = stk, 
				presentacion_id = presentacion, 
				proveedor_id = proveedor, 
				requisicion = requi,
				flag_caducidad = chk_caducidad, 
				fecha_caducidad =  date_caducidad, 
				lote_caducidad = lt_caducidad, 
				marca_caducidad = mark_caducidad,
				id_empleado = empleado
			WHERE folio_articulo = folio_art AND numero_categoria_id = nId;
			
			RETURN folio_art;
		
		ELSIF opcion = 2 THEN
		
			SELECT id
			INTO nId
			FROM tb_categorias
			WHERE numero_categoria = categoria;
			
			UPDATE tb_articulosalmacen
			SET status = 1
			WHERE folio_articulo = folio_art AND numero_categoria_id = nId;
			
			RETURN folio_art;
			
		END IF;
	
	END

$$
LANGUAGE 'plpgsql';