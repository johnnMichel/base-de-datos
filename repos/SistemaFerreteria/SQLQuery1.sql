-----------------------dbFerreteria---------------------------

-----------------------Categoria---------------------------
GO 
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   27/3/2024 21:46:31
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC pCategoriaAdd(
    @IdCategoria int OUTPUT, 
    @nombre varchar(50), 
    @descripcion varchar(256), 
    @estado bit)
AS
BEGIN
    INSERT INTO Categoria VALUES( @nombre, @descripcion, @estado)
    SET @IdCategoria = SCOPE_IDENTITY()
END

GO
GO 
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   27/3/2024 21:46:31
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC pCategoriaUpd(
    @IdCategoria int, 
    @nombre varchar(50), 
    @descripcion varchar(256), 
    @estado bit)
AS 
BEGIN
    UPDATE Categoria SET nombre=@nombre, descripcion=@descripcion, estado=@estado
        WHERE IdCategoria = @IdCategoria
END

GO
GO 
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   27/3/2024 21:46:31
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC pCategoriaDel(
    @IdCategoria int 
)
AS 
BEGIN 
    DELETE FROM Categoria   WHERE IdCategoria = @IdCategoria
END 

GO

-----------------------dbFerreteria---------------------------

-----------------------Cliente---------------------------
GO 
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   27/3/2024 21:46:31
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC pClienteAdd(
    @IdCliente int OUTPUT, 
    @Nombres varchar(100), 
    @Ap_Paterno varchar(20), 
    @Ap_Materno varchar(20), 
    @NIT varchar(15), 
    @RazonSocial varchar(100), 
    @Direccion varchar(70), 
    @Felefono varchar(20), 
    @email varchar(50))
AS
BEGIN
    INSERT INTO Cliente VALUES( @Nombres, @Ap_Paterno, @Ap_Materno, @NIT, @RazonSocial, @Direccion, @Felefono, @email)
    SET @IdCliente = SCOPE_IDENTITY()
END

GO
GO 
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   27/3/2024 21:46:31
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC pClienteUpd(
    @IdCliente int, 
    @Nombres varchar(100), 
    @Ap_Paterno varchar(20), 
    @Ap_Materno varchar(20), 
    @NIT varchar(15), 
    @RazonSocial varchar(100), 
    @Direccion varchar(70), 
    @Felefono varchar(20), 
    @email varchar(50))
AS 
BEGIN
    UPDATE Cliente SET Nombres=@Nombres, Ap_Paterno=@Ap_Paterno, Ap_Materno=@Ap_Materno, NIT=@NIT, RazonSocial=@RazonSocial, Direccion=@Direccion, Felefono=@Felefono, email=@email
        WHERE IdCliente = @IdCliente
END

GO
GO 
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   27/3/2024 21:46:31
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC pClienteDel(
    @IdCliente int 
)
AS 
BEGIN 
    DELETE FROM Cliente   WHERE IdCliente = @IdCliente
END 

GO

-----------------------dbFerreteria---------------------------

-----------------------Compra---------------------------
GO 
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   27/3/2024 21:46:31
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC pCompraAdd(
    @IdCompra int OUTPUT, 
    @fkIdProveedor int, 
    @fkIdUsuario int, 
    @Tipo_Comprobante varchar(20), 
    @Serie_Comprobante varchar(7), 
    @Num_Comprobante varchar(10), 
    @Fecha datetime, 
    @Impuesto decimal, 
    @Total decimal, 
    @Estado bit)
AS
BEGIN
    INSERT INTO Compra VALUES( @fkIdProveedor, @fkIdUsuario, @Tipo_Comprobante, @Serie_Comprobante, @Num_Comprobante, @Fecha, @Impuesto, @Total, @Estado)
    SET @IdCompra = SCOPE_IDENTITY()
END

GO
GO 
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   27/3/2024 21:46:31
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC pCompraUpd(
    @IdCompra int, 
    @fkIdProveedor int, 
    @fkIdUsuario int, 
    @Tipo_Comprobante varchar(20), 
    @Serie_Comprobante varchar(7), 
    @Num_Comprobante varchar(10), 
    @Fecha datetime, 
    @Impuesto decimal, 
    @Total decimal, 
    @Estado bit)
AS 
BEGIN
    UPDATE Compra SET fkIdProveedor=@fkIdProveedor, fkIdUsuario=@fkIdUsuario, Tipo_Comprobante=@Tipo_Comprobante, Serie_Comprobante=@Serie_Comprobante, Num_Comprobante=@Num_Comprobante, Fecha=@Fecha, Impuesto=@Impuesto, Total=@Total, Estado=@Estado
        WHERE IdCompra = @IdCompra
END

GO
GO 
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   27/3/2024 21:46:31
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC pCompraDel(
    @IdCompra int 
)
AS 
BEGIN 
    DELETE FROM Compra   WHERE IdCompra = @IdCompra
END 

GO

-----------------------dbFerreteria---------------------------

-----------------------DetalleCompra---------------------------
GO 
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   27/3/2024 21:46:31
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC pDetalleCompraAdd(
    @IdDetalleCompra int OUTPUT, 
    @fkIdCompra int, 
    @fkIdProducto int, 
    @cantidad int, 
    @precio decimal)
AS
BEGIN
    INSERT INTO DetalleCompra VALUES( @fkIdCompra, @fkIdProducto, @cantidad, @precio)
    SET @IdDetalleCompra = SCOPE_IDENTITY()
END

GO
GO 
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   27/3/2024 21:46:31
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC pDetalleCompraUpd(
    @IdDetalleCompra int, 
    @fkIdCompra int, 
    @fkIdProducto int, 
    @cantidad int, 
    @precio decimal)
AS 
BEGIN
    UPDATE DetalleCompra SET fkIdCompra=@fkIdCompra, fkIdProducto=@fkIdProducto, cantidad=@cantidad, precio=@precio
        WHERE IdDetalleCompra = @IdDetalleCompra
END

GO
GO 
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   27/3/2024 21:46:31
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC pDetalleCompraDel(
    @IdDetalleCompra int 
)
AS 
BEGIN 
    DELETE FROM DetalleCompra   WHERE IdDetalleCompra = @IdDetalleCompra
END 

GO

-----------------------dbFerreteria---------------------------

-----------------------DetalleVenta---------------------------
GO 
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   27/3/2024 21:46:31
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC pDetalleVentaAdd(
    @IdDetalleVenta int OUTPUT, 
    @fkIdVenta int, 
    @fkIdProducto int, 
    @cantidad int, 
    @precio decimal, 
    @descuento decimal)
AS
BEGIN
    INSERT INTO DetalleVenta VALUES( @fkIdVenta, @fkIdProducto, @cantidad, @precio, @descuento)
    SET @IdDetalleVenta = SCOPE_IDENTITY()
END

GO
GO 
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   27/3/2024 21:46:31
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC pDetalleVentaUpd(
    @IdDetalleVenta int, 
    @fkIdVenta int, 
    @fkIdProducto int, 
    @cantidad int, 
    @precio decimal, 
    @descuento decimal)
AS 
BEGIN
    UPDATE DetalleVenta SET fkIdVenta=@fkIdVenta, fkIdProducto=@fkIdProducto, cantidad=@cantidad, precio=@precio, descuento=@descuento
        WHERE IdDetalleVenta = @IdDetalleVenta
END

GO
GO 
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   27/3/2024 21:46:31
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC pDetalleVentaDel(
    @IdDetalleVenta int 
)
AS 
BEGIN 
    DELETE FROM DetalleVenta   WHERE IdDetalleVenta = @IdDetalleVenta
END 

GO

-----------------------dbFerreteria---------------------------

-----------------------Producto---------------------------
GO 
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   27/3/2024 21:46:31
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC pProductoAdd(
    @IdProducto int OUTPUT, 
    @fkIdCategoria int, 
    @Codigo varchar(50), 
    @Nombre varchar(100), 
    @Precio_Compra decimal, 
    @Fecha_Ultima_Compra datetime, 
    @Precio_Venta decimal, 
    @Stock int, 
    @Descripcion varchar(256), 
    @Estado bit)
AS
BEGIN
    INSERT INTO Producto VALUES( @fkIdCategoria, @Codigo, @Nombre, @Precio_Compra, @Fecha_Ultima_Compra, @Precio_Venta, @Stock, @Descripcion, @Estado)
    SET @IdProducto = SCOPE_IDENTITY()
END

GO
GO 
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   27/3/2024 21:46:31
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC pProductoUpd(
    @IdProducto int, 
    @fkIdCategoria int, 
    @Codigo varchar(50), 
    @Nombre varchar(100), 
    @Precio_Compra decimal, 
    @Fecha_Ultima_Compra datetime, 
    @Precio_Venta decimal, 
    @Stock int, 
    @Descripcion varchar(256), 
    @Estado bit)
AS 
BEGIN
    UPDATE Producto SET fkIdCategoria=@fkIdCategoria, Codigo=@Codigo, Nombre=@Nombre, Precio_Compra=@Precio_Compra, Fecha_Ultima_Compra=@Fecha_Ultima_Compra, Precio_Venta=@Precio_Venta, Stock=@Stock, Descripcion=@Descripcion, Estado=@Estado
        WHERE IdProducto = @IdProducto
END

GO
GO 
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   27/3/2024 21:46:31
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC pProductoDel(
    @IdProducto int 
)
AS 
BEGIN 
    DELETE FROM Producto   WHERE IdProducto = @IdProducto
END 

GO

-----------------------dbFerreteria---------------------------

-----------------------Proveedor---------------------------
GO 
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   27/3/2024 21:46:31
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC pProveedorAdd(
    @IdPersona int , 
    @Nombre varchar(100), 
    @Ap_Paterno varchar(20), 
    @Ap_Maerno varchar(20), 
    @NombreEmpresa varchar(50), 
    @NombreContacto varchar(50), 
    @Direccion varchar(70), 
    @Telefono varchar(20), 
    @email varchar(50))
AS
BEGIN
    INSERT INTO Proveedor VALUES(@IdPersona, @Nombre, @Ap_Paterno, @Ap_Maerno, @NombreEmpresa, @NombreContacto, @Direccion, @Telefono, @email)
END

GO
GO 
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   27/3/2024 21:46:31
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC pProveedorUpd(
    @IdPersona int, 
    @Nombre varchar(100), 
    @Ap_Paterno varchar(20), 
    @Ap_Maerno varchar(20), 
    @NombreEmpresa varchar(50), 
    @NombreContacto varchar(50), 
    @Direccion varchar(70), 
    @Telefono varchar(20), 
    @email varchar(50))
AS 
BEGIN
    UPDATE Proveedor SET Nombre=@Nombre, Ap_Paterno=@Ap_Paterno, Ap_Maerno=@Ap_Maerno, NombreEmpresa=@NombreEmpresa, NombreContacto=@NombreContacto, Direccion=@Direccion, Telefono=@Telefono, email=@email
        WHERE IdPersona = @IdPersona
END

GO
GO 
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   27/3/2024 21:46:31
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC pProveedorDel(
    @IdPersona int 
)
AS 
BEGIN 
    DELETE FROM Proveedor   WHERE IdPersona = @IdPersona
END 

GO

-----------------------dbFerreteria---------------------------

-----------------------Rol---------------------------
GO 
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   27/3/2024 21:46:31
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC pRolAdd(
    @IdRol int OUTPUT, 
    @nombre varchar(30), 
    @descripcion varchar(100), 
    @estado bit)
AS
BEGIN
    INSERT INTO Rol VALUES( @nombre, @descripcion, @estado)
    SET @IdRol = SCOPE_IDENTITY()
END

GO
GO 
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   27/3/2024 21:46:31
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC pRolUpd(
    @IdRol int, 
    @nombre varchar(30), 
    @descripcion varchar(100), 
    @estado bit)
AS 
BEGIN
    UPDATE Rol SET nombre=@nombre, descripcion=@descripcion, estado=@estado
        WHERE IdRol = @IdRol
END

GO
GO 
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   27/3/2024 21:46:31
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC pRolDel(
    @IdRol int 
)
AS 
BEGIN 
    DELETE FROM Rol   WHERE IdRol = @IdRol
END 

GO

-----------------------dbFerreteria---------------------------

-----------------------Usuario---------------------------
GO 
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   27/3/2024 21:46:31
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC pUsuarioAdd(
    @IdUsuario int OUTPUT, 
    @fkIdRol int, 
    @nombre varchar(100), 
    @direccion varchar(70), 
    @telefono varchar(20), 
    @email varchar(50), 
    @password varbinary, 
    @estado bit)
AS
BEGIN
    INSERT INTO Usuario VALUES( @fkIdRol, @nombre, @direccion, @telefono, @email, @password, @estado)
    SET @IdUsuario = SCOPE_IDENTITY()
END

GO
GO 
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   27/3/2024 21:46:31
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC pUsuarioUpd(
    @IdUsuario int, 
    @fkIdRol int, 
    @nombre varchar(100), 
    @direccion varchar(70), 
    @telefono varchar(20), 
    @email varchar(50), 
    @password varbinary, 
    @estado bit)
AS 
BEGIN
    UPDATE Usuario SET fkIdRol=@fkIdRol, nombre=@nombre, direccion=@direccion, telefono=@telefono, email=@email, password=@password, estado=@estado
        WHERE IdUsuario = @IdUsuario
END

GO
GO 
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   27/3/2024 21:46:31
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC pUsuarioDel(
    @IdUsuario int 
)
AS 
BEGIN 
    DELETE FROM Usuario   WHERE IdUsuario = @IdUsuario
END 

GO

-----------------------dbFerreteria---------------------------

-----------------------Venta---------------------------
GO 
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   27/3/2024 21:46:32
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC pVentaAdd(
    @IdVenta int OUTPUT, 
    @fkIdCliente int, 
    @fkIdUsuario int, 
    @fecha_hora datetime, 
    @NIT varchar(50), 
    @RazonSocial varchar(100), 
    @impuesto decimal, 
    @total decimal, 
    @estado varchar(20))
AS
BEGIN
    INSERT INTO Venta VALUES( @fkIdCliente, @fkIdUsuario, @fecha_hora, @NIT, @RazonSocial, @impuesto, @total, @estado)
    SET @IdVenta = SCOPE_IDENTITY()
END

GO
GO 
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   27/3/2024 21:46:32
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC pVentaUpd(
    @IdVenta int, 
    @fkIdCliente int, 
    @fkIdUsuario int, 
    @fecha_hora datetime, 
    @NIT varchar(50), 
    @RazonSocial varchar(100), 
    @impuesto decimal, 
    @total decimal, 
    @estado varchar(20))
AS 
BEGIN
    UPDATE Venta SET fkIdCliente=@fkIdCliente, fkIdUsuario=@fkIdUsuario, fecha_hora=@fecha_hora, NIT=@NIT, RazonSocial=@RazonSocial, impuesto=@impuesto, total=@total, estado=@estado
        WHERE IdVenta = @IdVenta
END

GO
GO 
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   27/3/2024 21:46:32
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC pVentaDel(
    @IdVenta int 
)
AS 
BEGIN 
    DELETE FROM Venta   WHERE IdVenta = @IdVenta
END 

GO

