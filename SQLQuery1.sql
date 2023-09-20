CREATE DATABASE pruebabyb;
USE pruebabyb;

-- Crear tabla Productos con los campos (Nombre, Precio, Fecha) y 
-- realice aplicación para CRUD en C#, desarrollo web o escritorio a su elección.

CREATE TABLE productos(
	id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	codigoProducto INT UNIQUE,
	nombreProducto VARCHAR(100),
	precioProducto NUMERIC(10,2),
	fechaProducto DATE
);

-- Crear un procedimiento almacenado para CRUD de tabla Productos.

--SELECT
CREATE PROCEDURE selectProductos
AS
SELECT * FROM productos
GO;

--INSERT
CREATE PROCEDURE insertProductos
    @codigoProducto INT,
	@nombreProducto VARCHAR(50),
	@precioProducto NUMERIC(10,2),
	@fechaProducto DATE
AS
BEGIN
    INSERT INTO productos(codigoProducto, nombreProducto, precioProducto, fechaProducto)
    VALUES (@codigoProducto, @nombreProducto, @precioProducto, @fechaProducto);
END;


--UPDATE
CREATE PROCEDURE updateProductos
	@id INT, 
	@codigoProducto INT,
	@nombreProducto VARCHAR(50),
	@precioProducto NUMERIC(10,2),
	@fechaProducto DATE
AS
BEGIN
	UPDATE productos SET codigoProducto = @codigoProducto,
	nombreProducto = @nombreProducto, precioProducto = @precioProducto,
	fechaProducto = @fechaProducto WHERE id = @id;
END;

--DELETE
CREATE PROCEDURE deleteProductos
	@id INT
AS
BEGIN
	DELETE FROM productos WHERE id = @id;
END;

