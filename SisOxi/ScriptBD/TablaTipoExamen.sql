-------------------------------------------------------            
--PROCEDIMIENTOS ALMACENADOS PARA LA TABLA TipoExamen--
-------------------------------------------------------


--Descripcion : Procedimiento Almacenado para Insertar sobre la tabla TipoExamen
--Fecha de Creacion : miércoles, 10 de abril de 2013
CREATE PROCEDURE spr_AgregarTipoExamen
(
    
           
            @nombre varchar(200),
            @descripcion text
)
AS
INSERT INTO TipoExamen 
(nombre,descripcion)
VALUES
(@nombre,@descripcion)

--Descripcion : Procedimiento Almacenado para Actualizar sobre la tabla TipoExamen
--Autor : 
--Fecha de Creacion : miércoles, 10 de abril de 2013
CREATE PROCEDURE spr_ModificarTipoExamen
(
    
            @idTipoExamen int,
            @nombre varchar(200),
            @descripcion text
)
AS
UPDATE TipoExamen 
SET

nombre = @nombre,
descripcion = @descripcion

WHERE idTipoExamen = @idTipoExamen;

--Descripcion : Procedimiento Almacenado para Seleccionar Toda la informacion de la tabla TipoExamen
--Fecha de Creacion : miércoles, 10 de abril de 2013



CREATE PROCEDURE spr_BuscarTipoExamen
AS
SELECT * FROM TipoExamen

--Descripcion : Procedimiento Almacenado para Seleccionar Toda la informacion de la tabla Enfermedad
--Fecha de Creacion : sábado, 13 de abril de 2013

CREATE PROCEDURE spr_BuscarTipoExamenPorID
(
	@idTipoExamen int
)
AS
SELECT * FROM TipoExamen where idTipoExamen = @idTipoExamen