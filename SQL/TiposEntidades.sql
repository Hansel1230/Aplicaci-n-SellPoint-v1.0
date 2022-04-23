set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE SpTiposEntidadesInsertar
@IdTipoEntidad AS INT,
@Descripcion AS VARCHAR(120),
@IdGrupoEntidad AS INT,
@Comentario AS NTEXT,
@Statuss AS VARCHAR(10),
@NoEliminable AS BIT,
@FechaRegistro AS DATE
AS
BEGIN
INSERT INTO TiposEntidades (Descripcion,IdGrupoEntidad,Comentario,Statuss,NoEliminable,FechaRegistro)
SET @IdTipoEntidad = @@IDENTITY
VALUES (@Descripcion,@IdGrupoEntidad,@Comentario,@Statuss,@NoEliminable,@FechaRegistro)
END
GO

CREATE PROCEDURE SpTiposEntidadesActualizar
@IdTipoEntidad AS INT,
@Descripcion AS VARCHAR(120),
@IdGrupoEntidad AS INT,
@Comentario AS NTEXT,
@Statuss AS VARCHAR(10),
@NoEliminable AS BIT,
@FechaRegistro AS DATE
AS
BEGIN
UPDATE TiposEntidades
SET Descripcion = @Descripcion,
IdGrupoEntidad = @IdGrupoEntidad,
Comentario = @Comentario,
Statuss = @Statuss,
NoEliminable = @NoEliminable,
FechaRegistro = @FechaRegistro
WHERE IdTipoEntidad = @IdTipoEntidad
END
GO

CREATE PROCEDURE SpTiposEntidadesEliminar
@IdTipoEntidad AS INT
AS
BEGIN
DELETE FROM TiposEntidades
WHERE IdTipoEntidad = @IdTipoEntidad
END
GO

CREATE PROCEDURE SpTiposEntidadesListar
AS
BEGIN
SELECT IdTipoEntidad,
Descripcion,
IdGrupoEntidad,
Comentario,
Statuss,
NoEliminable,
FechaRegistro
FROM TiposEntidades
END
GO

CREATE PROCEDURE SpTiposEntidadesObtener
@IdTipoEntidad AS INT
AS
BEGIN
SELECT TOP 1 
IdTipoEntidad,
Descripcion,
IdGrupoEntidad,
Comentario,
Statuss,
NoEliminable,
FechaRegistro
FROM TiposEntidades
WHERE IdTipoEntidad = @IdTipoEntidad
END
GO

CREATE PROCEDURE SpTiposEntidadesPrimero
AS
BEGIN
SELECT TOP 1 
IdTipoEntidad,
Descripcion,
IdGrupoEntidad,
Comentario,
Statuss,
NoEliminable,
FechaRegistro
FROM TiposEntidades
ORDER BY  IdTipoEntidad ASC
END
GO

CREATE PROCEDURE SpTiposEntidadesUltimo
AS
BEGIN
SELECT TOP 1 
IdTipoEntidad,
Descripcion,
IdGrupoEntidad,
Comentario,
Statuss,
NoEliminable,
FechaRegistro
FROM TiposEntidades
ORDER BY  IdTipoEntidad DESC
END
GO

CREATE PROCEDURE SpTiposEntidadesAnterior
@IdTipoEntidad AS INT
AS
IF(SELECT COUNT(IdTipoEntidad) FROM TiposEntidades WHERE IdTipoEntidad < @IdTipoEntidad) > 0
BEGIN
SELECT TOP 1 
IdTipoEntidad,
Descripcion,
IdGrupoEntidad,
Comentario,
Statuss,
NoEliminable,
FechaRegistro
FROM TiposEntidades
WHERE IdTipoEntidad < @IdTipoEntidad
ORDER BY  IdTipoEntidad DESC
END
ELSE
BEGIN
SELECT TOP 1 
IdTipoEntidad,
Descripcion,
IdGrupoEntidad,
Comentario,
Statuss,
NoEliminable,
FechaRegistro
FROM TiposEntidades
ORDER BY  IdTipoEntidad ASC
END
GO


CREATE PROCEDURE SpTiposEntidadesSiguiente
@IdTipoEntidad AS INT
AS
IF(SELECT COUNT(IdTipoEntidad) FROM TiposEntidades WHERE IdTipoEntidad > @IdTipoEntidad) > 0
BEGIN
SELECT TOP 1 
IdTipoEntidad,
Descripcion,
IdGrupoEntidad,
Comentario,
Statuss,
NoEliminable,
FechaRegistro
FROM TiposEntidades
WHERE IdTipoEntidad > @IdTipoEntidad
ORDER BY  IdTipoEntidad ASC
END
ELSE
BEGIN
SELECT TOP 1 
IdTipoEntidad,
Descripcion,
IdGrupoEntidad,
Comentario,
Statuss,
NoEliminable,
FechaRegistro
FROM TiposEntidades
ORDER BY  IdTipoEntidad DESC
END
GO

