-- SP Cliente

CREATE PROC SP_INSERTARCLIENTE
@Documento INT,
@Nombre VARCHAR(250),
@Direccion VARCHAR (250),
@Telefono VARCHAR(10),
@Correo VARCHAR(250)
AS
INSERT INTO Cliente VALUES(@Documento,@Nombre,@Direccion,@Telefono,@Correo)
GO

CREATE PROC SP_MOSTRARCLIENTES
@Documento INT
AS
IF (@Documento != 0)
	BEGIN
		IF EXISTS (SELECT Documento FROM Cliente WHERE Documento = @Documento)
			BEGIN
				SELECT * FROM Cliente WHERE Documento = @Documento
			END
	END
ELSE
	BEGIN
		SELECT * FROM Cliente
	END
GO

CREATE PROC SP_ACTUALIZARCLIENTE
@Documento INT,
@Nombre VARCHAR(250),
@Direccion VARCHAR (250),
@Telefono VARCHAR(10),
@Correo VARCHAR(250)
AS
UPDATE Cliente SET Nombre = @Nombre,Direccion = @Direccion,Telefono = @Telefono,Correo = @Correo WHERE Documento = @Documento
GO

CREATE PROC SP_ELIMINARCLIENTE
@Documento INT
AS
DELETE FROM Cliente WHERE Documento = @Documento
GO

-- SP Vendedor

CREATE PROC SP_INSERTARVENDEDOR
    @Codigo INT,
    @Usuario VARCHAR (50),
    @Contraseña VARCHAR (250),
    @NombreCompleto VARCHAR (60)
AS
    INSERT INTO Vendedores VALUES (@Codigo, @Usuario, @Contraseña, @NombreCompleto)
GO

CREATE PROC SP_AUTENTICARVENDEDOR
@Usuario VARCHAR (15)
AS
SELECT Usuario, Contraseña FROM Vendedores WHERE Usuario = @Usuario
GO

CREATE PROC SP_MOSTRARVENDEDOR
@Codigo INT,
@Usuario VARCHAR (50)
AS
IF (@Codigo != 0 OR @Usuario != '')
        BEGIN
            IF EXISTS (SELECT Codigo FROM Vendedores WHERE Codigo = @Codigo OR Usuario = @Usuario)
                BEGIN
                    SELECT * FROM Vendedores WHERE Codigo = @Codigo OR Usuario = @Usuario
                END
        END
    ELSE
        BEGIN
            SELECT * FROM Vendedores ORDER BY Codigo ASC
        END
GO

CREATE PROC SP_ACTUALIZARVENDEDOR
    @Codigo INT,
    @Usuario VARCHAR (50),
    @Contraseña VARCHAR (250),
    @NombreCompleto VARCHAR (60)
AS
UPDATE Vendedores SET Usuario = @Usuario, Contraseña = @Contraseña, Nombre = @NombreCompleto WHERE Codigo = @Codigo
GO

CREATE PROC SP_ELIMINARVENDEDOR
    @Codigo INT
AS
DELETE FROM Vendedores WHERE Codigo = @Codigo
GO

-- SP Productos

CREATE PROC SP_INSERTARPRODUCTO
@Codigo INT,
@Descripcion VARCHAR(30),
@Valor_Unidad INT,
@Cantidad INT
AS
INSERT INTO Productos VALUES(@Codigo,@Descripcion,@Valor_Unidad,@Cantidad)
GO

CREATE PROC SP_MOSTRARPRODUCTO
    @Codigo INT
AS
    IF (@Codigo != 0)
        BEGIN
            IF EXISTS (SELECT Codigo FROM Productos WHERE Codigo = @Codigo)
                BEGIN
                    SELECT * FROM Productos WHERE Codigo = @Codigo
                END
        END
    ELSE
        BEGIN
            SELECT * FROM Productos ORDER BY Codigo ASC
        END
GO

CREATE PROC SP_ACTUALIZARPRODUCTO
@Codigo INT,
@Descripcion VARCHAR(30),
@Valor_Unidad INT,
@Cantidad INT
AS
UPDATE Productos SET Descripción = @Descripcion, Valor_Unidad = @Valor_Unidad,Cantidad = @Cantidad WHERE Codigo = @Codigo
GO

CREATE PROC SP_ELIMINARPRODUCTO
@Codigo INT
AS
DELETE Productos WHERE Codigo = @Codigo
GO

-- SP Factura

CREATE PROC SP_AGGFACTDETA
@Codigo_Productos INT,
@Cantidad INT,
@Valor_Unidad INT
AS
DECLARE @IDFac INT

SET @IDFac = (SELECT TOP 1 IdFactu FROM Factura ORDER BY IdFactu DESC)

INSERT INTO Factura_Detalle VALUES(@IDFac, @Codigo_Productos, @Cantidad, @Valor_Unidad)
GO

CREATE PROC SP_AGREGARFACTURA
@Fecha DATE,
@Documento_Cliente INT,
@Codigo_Vendedor INT
AS
INSERT INTO Factura (Fecha, Documento_Cliente, Codigo_Vendedor) VALUES (CONVERT(DATE, @Fecha), @Documento_Cliente, @Codigo_Vendedor)
GO

CREATE PROC SP_DESCONTARCANT
@Codprod INT,
@Cantidad INT
AS
UPDATE Productos SET Cantidad = Cantidad - @Cantidad
WHERE Codigo = @Codprod
GO

-- SP Inventario

CREATE PROC SP_BUSCARINVENTARIO
@Prod INT
AS
SELECT P.Descripción,P.Cantidad,SUM(F.Cantidad) AS 'Vendido' FROM Factura_Detalle AS F
JOIN Productos AS P on F.Codigo_Productos = P.Codigo
where P.Codigo = @Prod GROUP BY P.Descripción,P.Cantidad
GO

CREATE PROC SP_BUSCARINVENTARIOS
AS
SELECT P.Descripción,P.Cantidad,SUM(F.Cantidad) AS 'Vendido' FROM Factura_Detalle AS F
JOIN Productos AS P on F.Codigo_Productos = P.Codigo
GROUP BY P.Descripción,P.Cantidad
GO