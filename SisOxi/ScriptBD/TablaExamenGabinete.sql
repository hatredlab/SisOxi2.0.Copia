-----------------------------------------------------------            
--PROCEDIMIENTOS ALMACENADOS PARA LA TABLA ExamenGabinete--
-----------------------------------------------------------


--Descripcion : Procedimiento Almacenado para Insertar sobre la tabla ExamenGabinete
--Fecha de Creacion : miércoles, 10 de abril de 2013
CREATE PROCEDURE spr_AgregarExamenGabinete
(
    
           
            @observaciones text,
            @idHistoriaClinica int,
            @idTipoExamen int,
            @fecha datetime
)
AS
INSERT INTO ExamenGabinete 
(observaciones,idHistoriaClinica,idTipoExamen,fecha)
VALUES
(@observaciones,@idHistoriaClinica,@idTipoExamen,@fecha)


--Descripcion : Procedimiento Almacenado para Actualizar sobre la tabla ExamenGabinete
--Autor : 
--Fecha de Creacion : miércoles, 10 de abril de 2013
CREATE PROCEDURE spr_ModificarExamenGabinete
(
    
            @idExamenGabinete int,
            @observaciones text,
            @idHistoriaClinica int,
            @idTipoExamen int,
            @fecha datetime
)
AS
UPDATE ExamenGabinete 
SET

observaciones = @observaciones,
idHistoriaClinica = @idHistoriaClinica,
idTipoExamen = @idTipoExamen,
fecha = @fecha

WHERE idExamenGabinete = @idExamenGabinete ;

--Descripcion : Procedimiento Almacenado para Seleccionar Toda la informacion de la tabla ExamenGabinete
--Fecha de Creacion : miércoles, 10 de abril de 2013
create PROCEDURE spr_SeleccionarExamenGabinete
AS
SELECT * FROM ExamenGabinete



create PROCEDURE spr_BuscarExamen
AS
SELECT * FROM ExamenGabinete

--Descripcion : Procedimiento Almacenado para Seleccionar Toda la informacion de la tabla Enfermedad
--Fecha de Creacion : sábado, 13 de abril de 2013

create PROCEDURE spr_BuscarExamenPorID
(
	@idExamenGabinete int
)
AS
SELECT * FROM ExamenGabinete where idExamenGabinete = @idExamenGabinete


CREATE PROCEDURE spr_BuscarExamenDeGabinetePorIDHistoriaClinica
(
	@idHistoriaClinica int
)
AS
SELECT ExamenGabinete.*,TipoExamen.nombre 
FROM ExamenGabinete inner join TipoExamen
on ExamenGabinete.idTipoExamen = TipoExamen.idTipoExamen
WHERE idHistoriaClinica = @idHistoriaClinica;

SELECT ExamenGabinete.*,TipoExamen.nombre 
FROM ExamenGabinete inner join TipoExamen
on ExamenGabinete.idTipoExamen = TipoExamen.idTipoExamen
WHERE idHistoriaClinica = 1;