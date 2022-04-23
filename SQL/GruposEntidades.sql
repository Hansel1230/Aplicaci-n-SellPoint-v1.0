set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE SpGruposEntidadesInsertar
@IdGrupoEntidad AS INT,
@Descripcion AS VARCHAR(120),
@Comentario AS NTEXT,
@Statuss AS VARCHAR(10),
@NoEliminable AS BIT,
@FechaRegistro AS DATE
AS
BEGIN
INSERT INTO GruposEntidades (Descripcion,Comentario,Statuss,NoEliminable,FechaRegistro)
SET @IdGrupoEntidad = @@IDENTITY
VALUES (@Descripcion,@Comentario,@Statuss,@NoEliminable,@FechaRegistro)
END
GO

CREATE PROCEDURE SpGruposEntidadesActualizar
@IdGrupoEntidad AS INT,
@Descripcion AS VARCHAR(120),
@Comentario AS NTEXT,
@Statuss AS VARCHAR(10),
@NoEliminable AS BIT,
@FechaRegistro AS DATE
AS
BEGIN
UPDATE GruposEntidades
SET Descripcion = @Descripcion,
Comentario = @Comentario,
Statuss = @Statuss,
NoEliminable = @NoEliminable,
FechaRegistro = @FechaRegistro
WHERE IdGrupoEntidad = @IdGrupoEntidad
END
GO

CREATE PROCEDURE SpGruposEntidadesEliminar
@IdGrupoEntidad AS INT
AS
BEGIN
DELETE FROM GruposEntidades
WHERE IdGrupoEntidad = @IdGrupoEntidad
END
GO

CREATE PROCEDURE SpGruposEntidadesListar
AS
BEGIN
SELECT IdGrupoEntidad,
Descripcion,
Comentario,
Statuss,
NoEliminable,
FechaRegistro
FROM GruposEntidades
END
GO

CREATE PROCEDURE SpGruposEntidadesObtener
@IdGrupoEntidad AS INT
AS
BEGIN
SELECT TOP 1 
IdGrupoEntidad,
Descripcion,
Comentario,
Statuss,
NoEliminable,
FechaRegistro
FROM GruposEntidades
WHERE IdGrupoEntidad = @IdGrupoEntidad
END
GO

CREATE PROCEDURE SpGruposEntidadesPrimero
AS
BEGIN
SELECT TOP 1 
IdGrupoEntidad,
Descripcion,
Comentario,
Statuss,
NoEliminable,
FechaRegistro
FROM GruposEntidades
ORDER BY  IdGrupoEntidad ASC
END
GO

CREATE PROCEDURE SpGruposEntidadesUltimo
AS
BEGIN
SELECT TOP 1 
IdGrupoEntidad,
Descripcion,
Comentario,
Statuss,
NoEliminable,
FechaRegistro
FROM GruposEntidades
ORDER BY  IdGrupoEntidad DESC
END
GO

CREATE PROCEDURE SpGruposEntidadesAnterior
@IdGrupoEntidad AS INT
AS
IF(SELECT COUNT(IdGrupoEntidad) FROM GruposEntidades WHERE IdGrupoEntidad < @IdGrupoEntidad) > 0
BEGIN
SELECT TOP 1 
IdGrupoEntidad,
Descripcion,
Comentario,
Statuss,
NoEliminable,
FechaRegistro
FROM GruposEntidades
WHERE IdGrupoEntidad < @IdGrupoEntidad
ORDER BY  IdGrupoEntidad DESC
END
ELSE
BEGIN
SELECT TOP 1 
IdGrupoEntidad,
Descripcion,
Comentario,
Statuss,
NoEliminable,
FechaRegistro
FROM GruposEntidades
ORDER BY  IdGrupoEntidad ASC
END
GO


CREATE PROCEDURE SpGruposEntidadesSiguiente
@IdGrupoEntidad AS INT
AS
IF(SELECT COUNT(IdGrupoEntidad) FROM GruposEntidades WHERE IdGrupoEntidad > @IdGrupoEntidad) > 0
BEGIN
SELECT TOP 1 
IdGrupoEntidad,
Descripcion,
Comentario,
Statuss,
NoEliminable,
FechaRegistro
FROM GruposEntidades
WHERE IdGrupoEntidad > @IdGrupoEntidad
ORDER BY  IdGrupoEntidad ASC
END
ELSE
BEGIN
SELECT TOP 1 
IdGrupoEntidad,
Descripcion,
Comentario,
Statuss,
NoEliminable,
FechaRegistro
FROM GruposEntidades
ORDER BY  IdGrupoEntidad DESC
END
GO

