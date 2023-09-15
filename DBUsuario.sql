USE MASTER
DROP DATABASE DBUsuario

CREATE DATABASE DBUsuario

USE DBUsuario

CREATE TABLE Roles (
    ID INT NOT NULL IDENTITY PRIMARY KEY,
    Nombre NVARCHAR(50) UNIQUE,
    Descripcion NVARCHAR(255),
    Habilitado BIT,
    Estado BIT NULL
);

CREATE TABLE Usuarios (
    ID INT NOT NULL IDENTITY PRIMARY KEY,
    NombreDeUsuario NVARCHAR(50) UNIQUE,
    Email NVARCHAR(255),
    Nombre NVARCHAR(50),
    Apellido NVARCHAR(50),
    Estado BIT NULL
);

CREATE TABLE UsuariosRoles (
	PRIMARY KEY (IDUsuario, IDRol),
	IDUsuario INT FOREIGN KEY REFERENCES Usuarios(ID),
	IDRol INT FOREIGN KEY REFERENCES Roles(ID)
);

--#REGION (ROLES)

--SPs de Roles
GO
CREATE PROCEDURE SP_RECUPERARROLES
AS BEGIN
    SELECT * FROM Roles WHERE Estado IS NULL
END;

GO
CREATE PROCEDURE SP_AGREGARROL 
    @Nombre NVARCHAR(50), 
    @Descripcion NVARCHAR(255), 
    @Habilitado BIT
AS 
BEGIN
    DECLARE @ID INT
    SET @ID = (SELECT ID FROM Roles WHERE Nombre = @Nombre)
    IF (@ID IS NULL)
    BEGIN
        INSERT INTO Roles (Nombre, Descripcion, Habilitado, Estado)
        VALUES (@Nombre, @Descripcion, @Habilitado, NULL)
    END
    ELSE
    BEGIN
        UPDATE Roles
        SET Descripcion = @Descripcion, Habilitado = @Habilitado, Estado = NULL
        WHERE Nombre = @Nombre
    END
END;


GO
CREATE PROCEDURE SP_MODIFICARROL 
    @Nombre NVARCHAR(50), 
    @Descripcion NVARCHAR(255), 
    @Habilitado BIT
AS BEGIN
     UPDATE Roles
        SET Descripcion = @Descripcion, Habilitado = @Habilitado
        WHERE Nombre = @Nombre
END;


GO
CREATE PROCEDURE SP_ELIMINARROL 
    @Nombre NVARCHAR(50)
AS 
BEGIN
    UPDATE Roles
    SET Estado = 1
    WHERE Nombre = @Nombre
END;
--#ENDREGION



--#REGION (USUARIOS)

--SPs de USUARIOS 
GO
CREATE PROCEDURE SP_RECUPERARUSUARIOS
AS BEGIN
    SELECT * FROM Usuarios WHERE Estado IS NULL
END;


GO
CREATE PROCEDURE SP_AGREGARUSUARIO 
    @NombreDeUsuario NVARCHAR(50), 
    @Email NVARCHAR(255), 
    @Nombre NVARCHAR(50), 
    @Apellido NVARCHAR(50)
AS 
BEGIN
    DECLARE @ID INT
    SET @ID = (SELECT ID FROM Usuarios WHERE NombreDeUsuario = @NombreDeUsuario)
    IF (@ID IS NULL)
    BEGIN
        INSERT INTO Usuarios (NombreDeUsuario, Email, Nombre, Apellido, Estado)
        VALUES (@NombreDeUsuario, @Email, @Nombre, @Apellido, NULL)
    END
    ELSE
    BEGIN
        UPDATE Usuarios
        SET Email = @Email, Nombre = @Nombre, Apellido = @Apellido, Estado = NULL
        WHERE NombreDeUsuario = @NombreDeUsuario
    END
END;


GO
CREATE PROCEDURE SP_ELIMINARUSUARIO 
    @NombreDeUsuario NVARCHAR(50)
AS 
BEGIN
    UPDATE Usuarios
    SET Estado = 1
    WHERE NombreDeUsuario = @NombreDeUsuario
    DELETE FROM UsuariosRoles WHERE IDUsuario = (SELECT ID FROM Usuarios WHERE NombreDeUsuario = @NombreDeUsuario)
END;


GO
CREATE PROCEDURE SP_MODIFICARUSUARIO 
    @NombreDeUsuario NVARCHAR(50), 
    @Email NVARCHAR(255), 
    @Nombre NVARCHAR(50), 
    @Apellido NVARCHAR(50)
AS 
BEGIN
    UPDATE Usuarios
    SET Email = @Email, Nombre = @Nombre, Apellido = @Apellido
    WHERE NombreDeUsuario = @NombreDeUsuario
    DELETE FROM UsuariosRoles WHERE IDUsuario = (SELECT ID FROM Usuarios WHERE NombreDeUsuario = @NombreDeUsuario)
END;

--#ENDREGION



--#REGION (USUARIOROL)

--SPs de USUARIOROL

GO
CREATE PROCEDURE SP_AGREGARROLAUSUARIO @NombredeUsuario nvarchar (25), @NombreRol nvarchar (25)
AS BEGIN
INSERT INTO UsuariosRoles VALUES ((SELECT ID FROM USUARIOS WHERE NombreDeUsuario = @NombredeUsuario),(SELECT ID FROM ROLES WHERE NOMBRE = @NombreRol))
END;


GO
CREATE PROCEDURE SP_RECUPERARROLESPORUSUARIO @NombredeUsuario nvarchar (25)
AS BEGIN
SELECT Roles.Nombre as Nombre FROM Roles
INNER JOIN
    UsuariosRoles ON IDRol = Roles.ID
INNER JOIN
    Usuarios ON Usuarios.ID = UsuariosRoles.IDUsuario
WHERE
    Usuarios.NombreDeUsuario = @NombredeUsuario
END;




--#ENDREGION



--#REGION (PRUEBAS)
SELECT * FROM Roles

-- Llamar a las SP de Roles
EXEC SP_RECUPERARROLES

EXEC SP_AGREGARROL 'Rol1', 'Descripción1', 1
EXEC SP_AGREGARROL 'Rol2', 'Descripción2', 1
EXEC SP_AGREGARROL 'Rol3', 'Descripción3', 0

EXEC SP_MODIFICARROL 'Rol1', 'Nueva Descripción', 0

EXEC SP_RECUPERARROLES

EXEC SP_ELIMINARROL 'Rol3'

-- Llamar a las SP de Usuarios
EXEC SP_RECUPERARUSUARIOS

EXEC SP_AGREGARUSUARIO 'Usuario1', 'usuario1@email.com', 'Nombre1', 'Apellido1'
EXEC SP_AGREGARUSUARIO 'Usuario2', 'usuario2@email.com', 'Nombre2', 'Apellido2'
EXEC SP_AGREGARUSUARIO 'Usuario3', 'usuario3@email.com', 'Nombre3', 'Apellido3'

EXEC SP_MODIFICARUSUARIO 'Usuario1', 'usuario1_modificado@email.com', 'Nombre1_modificado', 'Apellido1_modificado'

EXEC SP_RECUPERARUSUARIOS

SELECT * FROM UsuariosRoles


EXEC SP_ELIMINARUSUARIO 'Usuario1'

-- Llamar a las SP de UsuarioRol
EXEC SP_AGREGARROLAUSUARIO 'Usuario1', 'Rol1'
EXEC SP_AGREGARROLAUSUARIO 'Usuario1', 'Rol2'
EXEC SP_AGREGARROLAUSUARIO 'Usuario2', 'Rol3'

EXEC SP_RECUPERARROLESPORUSUARIO 'Usuario1'

EXEC SP_RECUPERARROLESPORUSUARIO 'Usuario2'

EXEC SP_ELIMINARRELACION 'Usuario1'



DROP PROCEDURE SP_RECUPERARROLES
DROP PROCEDURE SP_RECUPERARUSUARIOS
DROP PROCEDURE SP_RECUPERARROLESPORUSUARIO
DROP PROCEDURE SP_ELIMINARUSUARIO 
DROP PROCEDURE SP_MODIFICARUSUARIO 