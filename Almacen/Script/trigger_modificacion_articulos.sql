-- DROP TRIGGER TR_CRUD_ARTICULOS ON tb_articulosalmacen
-- DROP FUNCTION SP_crud_articulos()

CREATE FUNCTION SP_crud_articulos() RETURNS TRIGGER
AS
$$

	BEGIN
	
		IF (TG_OP = 'INSERT' OR TG_OP = 'UPDATE') THEN
			INSERT INTO tb_his_articulos_almacen
			VALUES (
				new.folio_articulo,
				new.numero_categoria_id,
				new.nombre_articulo,
				new.cantidad,
				new.stock,
				new.presentacion_id,
				new.proveedor_id,
				new.requisicion,
				new.flag_caducidad,
				new.fecha_caducidad,
				new.lote_caducidad,
				new.marca_caducidad,
				new.status,
				new.observacion,
				new.id_empleado
			);
			RETURN NEW;
		ELSIF (TG_OP = 'DELETE') THEN
			INSERT INTO tb_his_articulos_almacen
			VALUES (
				old.folio_articulo,
				old.numero_categoria_id,
				old.nombre_articulo,
				old.cantidad,
				old.stock,
				old.presentacion_id,
				old.proveedor_id,
				old.requisicion,
				old.flag_caducidad,
				old.fecha_caducidad,
				old.lote_caducidad,
				old.marca_caducidad,
				old.status,
				old.observacion,
				old.id_empleado
			);
			RETURN NEW;
		END IF;
	
	END

$$
LANGUAGE 'plpgsql';

CREATE TRIGGER TR_CRUD_ARTICULOS BEFORE INSERT OR UPDATE OR DELETE ON tb_articulosalmacen
FOR EACH ROW
EXECUTE PROCEDURE SP_crud_articulos()