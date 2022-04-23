set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE SpEntidadesInsertar
@IdEntidad AS INT,
@Descripcion AS VARCHAR(120),
@Direccion AS NTEXT,
@Localidad AS VARCHAR(40),
@TipoEntidad AS VARCHAR(8),
@TipoDocumento AS VARCHAR(9),
@NumeroDocumento AS INT,
@Teléfonos AS VARCHAR(60),
@URLPaginaWeb AS VARCHAR(120),
@URLFacebook AS VARCHAR(120),
@URLInstagram AS VARCHAR(120),
@URLTwitter AS VARCHAR(120),
@URLTikTok AS VARCHAR(120),
@IdGrupoEntidad AS INT,
@IdTipoEntidad AS INT,
@LimiteCredito AS INT,
@UserNameEntidad AS VARCHAR(60),
@PassworEntidad AS VARCHAR(30),
@RolUserEntidad AS VARCHAR(10),
@Comentario AS NTEXT,
@Statuss AS VARCHAR(10),
@NoEliminable AS BIT,
@FechaRegistro AS DATE
AS
BEGIN
INSERT INTO Entidades (Descripcion,Direccion,Localidad,TipoEntidad,TipoDocumento,NumeroDocumento,Teléfonos,URLPaginaWeb,URLFacebook,URLInstagram,URLTwitter,URLTikTok,IdGrupoEntidad,IdTipoEntidad,LimiteCredito,UserNameEntidad,PassworEntidad,RolUserEntidad,Comentario,Statuss,NoEliminable,FechaRegistro)
SET @IdEntidad = @@IDENTITY
VALUES (@Descripcion,@Direccion,@Localidad,@TipoEntidad,@TipoDocumento,@NumeroDocumento,@Teléfonos,@URLPaginaWeb,@URLFacebook,@URLInstagram,@URLTwitter,@URLTikTok,@IdGrupoEntidad,@IdTipoEntidad,@LimiteCredito,@UserNameEntidad,@PassworEntidad,@RolUserEntidad,@Comentario,@Statuss,@NoEliminable,@FechaRegistro)
END
GO

CREATE PROCEDURE SpEntidadesActualizar
@IdEntidad AS INT,
@Descripcion AS VARCHAR(120),
@Direccion AS NTEXT,
@Localidad AS VARCHAR(40),
@TipoEntidad AS VARCHAR(8),
@TipoDocumento AS VARCHAR(9),
@NumeroDocumento AS INT,
@Teléfonos AS VARCHAR(60),
@URLPaginaWeb AS VARCHAR(120),
@URLFacebook AS VARCHAR(120),
@URLInstagram AS VARCHAR(120),
@URLTwitter AS VARCHAR(120),
@URLTikTok AS VARCHAR(120),
@IdGrupoEntidad AS INT,
@IdTipoEntidad AS INT,
@LimiteCredito AS INT,
@UserNameEntidad AS VARCHAR(60),
@PassworEntidad AS VARCHAR(30),
@RolUserEntidad AS VARCHAR(10),
@Comentario AS NTEXT,
@Statuss AS VARCHAR(10),
@NoEliminable AS BIT,
@FechaRegistro AS DATE
AS
BEGIN
UPDATE Entidades
SET Descripcion = @Descripcion,
Direccion = @Direccion,
Localidad = @Localidad,
TipoEntidad = @TipoEntidad,
TipoDocumento = @TipoDocumento,
NumeroDocumento = @NumeroDocumento,
Teléfonos = @Teléfonos,
URLPaginaWeb = @URLPaginaWeb,
URLFacebook = @URLFacebook,
URLInstagram = @URLInstagram,
URLTwitter = @URLTwitter,
URLTikTok = @URLTikTok,
IdGrupoEntidad = @IdGrupoEntidad,
IdTipoEntidad = @IdTipoEntidad,
LimiteCredito = @LimiteCredito,
UserNameEntidad = @UserNameEntidad,
PassworEntidad = @PassworEntidad,
RolUserEntidad = @RolUserEntidad,
Comentario = @Comentario,
Statuss = @Statuss,
NoEliminable = @NoEliminable,
FechaRegistro = @FechaRegistro
WHERE IdEntidad = @IdEntidad
END
GO

CREATE PROCEDURE SpEntidadesEliminar
@IdEntidad AS INT
AS
BEGIN
DELETE FROM Entidades
WHERE IdEntidad = @IdEntidad
END
GO

CREATE PROCEDURE SpEntidadesListar
AS
BEGIN
SELECT IdEntidad,
Descripcion,
Direccion,
Localidad,
TipoEntidad,
TipoDocumento,
NumeroDocumento,
Teléfonos,
URLPaginaWeb,
URLFacebook,
URLInstagram,
URLTwitter,
URLTikTok,
IdGrupoEntidad,
IdTipoEntidad,
LimiteCredito,
UserNameEntidad,
PassworEntidad,
RolUserEntidad,
Comentario,
Statuss,
NoEliminable,
FechaRegistro
FROM Entidades
END
GO

CREATE PROCEDURE SpEntidadesObtener
@IdEntidad AS INT
AS
BEGIN
SELECT TOP 1 
IdEntidad,
Descripcion,
Direccion,
Localidad,
TipoEntidad,
TipoDocumento,
NumeroDocumento,
Teléfonos,
URLPaginaWeb,
URLFacebook,
URLInstagram,
URLTwitter,
URLTikTok,
IdGrupoEntidad,
IdTipoEntidad,
LimiteCredito,
UserNameEntidad,
PassworEntidad,
RolUserEntidad,
Comentario,
Statuss,
NoEliminable,
FechaRegistro
FROM Entidades
WHERE IdEntidad = @IdEntidad
END
GO

CREATE PROCEDURE SpEntidadesPrimero
AS
BEGIN
SELECT TOP 1 
IdEntidad,
Descripcion,
Direccion,
Localidad,
TipoEntidad,
TipoDocumento,
NumeroDocumento,
Teléfonos,
URLPaginaWeb,
URLFacebook,
URLInstagram,
URLTwitter,
URLTikTok,
IdGrupoEntidad,
IdTipoEntidad,
LimiteCredito,
UserNameEntidad,
PassworEntidad,
RolUserEntidad,
Comentario,
Statuss,
NoEliminable,
FechaRegistro
FROM Entidades
ORDER BY  IdEntidad ASC
END
GO

CREATE PROCEDURE SpEntidadesUltimo
AS
BEGIN
SELECT TOP 1 
IdEntidad,
Descripcion,
Direccion,
Localidad,
TipoEntidad,
TipoDocumento,
NumeroDocumento,
Teléfonos,
URLPaginaWeb,
URLFacebook,
URLInstagram,
URLTwitter,
URLTikTok,
IdGrupoEntidad,
IdTipoEntidad,
LimiteCredito,
UserNameEntidad,
PassworEntidad,
RolUserEntidad,
Comentario,
Statuss,
NoEliminable,
FechaRegistro
FROM Entidades
ORDER BY  IdEntidad DESC
END
GO

CREATE PROCEDURE SpEntidadesAnterior
@IdEntidad AS INT
AS
IF(SELECT COUNT(IdEntidad) FROM Entidades WHERE IdEntidad < @IdEntidad) > 0
BEGIN
SELECT TOP 1 
IdEntidad,
Descripcion,
Direccion,
Localidad,
TipoEntidad,
TipoDocumento,
NumeroDocumento,
Teléfonos,
URLPaginaWeb,
URLFacebook,
URLInstagram,
URLTwitter,
URLTikTok,
IdGrupoEntidad,
IdTipoEntidad,
LimiteCredito,
UserNameEntidad,
PassworEntidad,
RolUserEntidad,
Comentario,
Statuss,
NoEliminable,
FechaRegistro
FROM Entidades
WHERE IdEntidad < @IdEntidad
ORDER BY  IdEntidad DESC
END
ELSE
BEGIN
SELECT TOP 1 
IdEntidad,
Descripcion,
Direccion,
Localidad,
TipoEntidad,
TipoDocumento,
NumeroDocumento,
Teléfonos,
URLPaginaWeb,
URLFacebook,
URLInstagram,
URLTwitter,
URLTikTok,
IdGrupoEntidad,
IdTipoEntidad,
LimiteCredito,
UserNameEntidad,
PassworEntidad,
RolUserEntidad,
Comentario,
Statuss,
NoEliminable,
FechaRegistro
FROM Entidades
ORDER BY  IdEntidad ASC
END
GO


CREATE PROCEDURE SpEntidadesSiguiente
@IdEntidad AS INT
AS
IF(SELECT COUNT(IdEntidad) FROM Entidades WHERE IdEntidad > @IdEntidad) > 0
BEGIN
SELECT TOP 1 
IdEntidad,
Descripcion,
Direccion,
Localidad,
TipoEntidad,
TipoDocumento,
NumeroDocumento,
Teléfonos,
URLPaginaWeb,
URLFacebook,
URLInstagram,
URLTwitter,
URLTikTok,
IdGrupoEntidad,
IdTipoEntidad,
LimiteCredito,
UserNameEntidad,
PassworEntidad,
RolUserEntidad,
Comentario,
Statuss,
NoEliminable,
FechaRegistro
FROM Entidades
WHERE IdEntidad > @IdEntidad
ORDER BY  IdEntidad ASC
END
ELSE
BEGIN
SELECT TOP 1 
IdEntidad,
Descripcion,
Direccion,
Localidad,
TipoEntidad,
TipoDocumento,
NumeroDocumento,
Teléfonos,
URLPaginaWeb,
URLFacebook,
URLInstagram,
URLTwitter,
URLTikTok,
IdGrupoEntidad,
IdTipoEntidad,
LimiteCredito,
UserNameEntidad,
PassworEntidad,
RolUserEntidad,
Comentario,
Statuss,
NoEliminable,
FechaRegistro
FROM Entidades
ORDER BY  IdEntidad DESC
END
GO

