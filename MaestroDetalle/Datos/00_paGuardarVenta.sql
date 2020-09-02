SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE paGuardarVenta 
	@Cliente VARCHAR(100),
	@lstDetalle Detalle READONLY --Pasa una tabla No Modificable como parametro
AS
BEGIN

	DECLARE @idVenta INT

	INSERT INTO tbVenta (cliente_vta, fecha_vta) VALUES (@Cliente, GETDATE());

	SET @idVenta = @@IDENTITY

	INSERT INTO tbDetalleVta (id_venta, producto_detv, cantidad_detv, precio_detv)
		SELECT @idVenta, Producto, Cantidad, Precio FROM @lstDetalle

END
GO
