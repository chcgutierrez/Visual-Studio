
CREATE TYPE Detalle AS TABLE(
	ID INT,
    Producto VARCHAR(50),
    Cantidad INT,
    Precio DECIMAL(18,2)
	PRIMARY KEY(ID)
	)

select * from tbVenta

SELECT * FROM tbDetalleVta

DECLARE @lstDetalle Detalle
		INSERT INTO @lstDetalle (ID, Producto, Cantidad, Precio)
	VALUES(1, 'PAPEL HIG. SCOTT', 3, 12350)

		INSERT INTO @lstDetalle (ID, Producto, Cantidad, Precio)
	VALUES(2, 'PAÑUELOS KLEENEX', 4, 3500)

		INSERT INTO @lstDetalle (ID, Producto, Cantidad, Precio)
	VALUES(3, 'GEL ANTIBACTERIAL', 4, 21300)

		INSERT INTO @lstDetalle (ID, Producto, Cantidad, Precio)
	VALUES(4, 'JABON DE BAÑO', 2, 7600)

EXEC paGuardarVenta 'Alberto Pruebas', @lstDetalle