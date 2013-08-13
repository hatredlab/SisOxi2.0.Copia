--------------------------------------------------------            
--PROCEDIMIENTOS ALMACENADOS PARA LA TABLA Tratamiento--
--------------------------------------------------------


--Descripcion : Procedimiento Almacenado para Insertar sobre la tabla Tratamiento
--Fecha de Creacion : miércoles, 10 de abril de 2013
create PROCEDURE spr_AgregarTratamientoCamaraHiperbarica
(
    
            @nroSesiones int,
            @estadoTratamiento varchar(20),
            @observacionesTratamiento text,
            @promedioOxigeno decimal(8,2),
			@idImpresionDiagnostica int,
            @tipoTratamiento varchar(100),
            @fechaInicioTratamiento datetime,
            @estadoPaciente varchar(20)
)
AS
INSERT INTO Tratamiento 
(nroSesiones,estadoTratamiento,observacionesTratamiento,promedioOxigeno,idImpresionDiagnostica,tipoTratamiento,fechaInicioTratamiento,estadoPaciente)
VALUES
(@nroSesiones,@estadoTratamiento,@observacionesTratamiento,@promedioOxigeno,@idImpresionDiagnostica,@tipoTratamiento,@fechaInicioTratamiento,@estadoPaciente)
select @@Identity

--Descripcion : Procedimiento Almacenado para Actualizar sobre la tabla Tratamiento
--Autor : 
--Fecha de Creacion : miércoles, 10 de abril de 2013
CREATE PROCEDURE spr_ModificarTratamientoCamaraHiperbarica
(
    
            @idTratamiento int,
            @nroSesiones int,
            @estadoTratamiento varchar(20),
            @observacionesTratamiento text,
            @promedioOxigeno decimal(8,2),
			@idImpresionDiagnostica int,
            @tipoTratamiento varchar(100),
            @fechaInicioTratamiento datetime,
            @estadoPaciente varchar(20)
)
AS
UPDATE Tratamiento 
SET
nroSesiones = @nroSesiones,
estadoTratamiento = @estadoTratamiento,
observacionesTratamiento = @observacionesTratamiento,
promedioOxigeno = @promedioOxigeno,
idImpresionDiagnostica = @idImpresionDiagnostica,
estadoPaciente = @estadoPaciente,
tipoTratamiento = @tipoTratamiento,
fechaInicioTratamiento = @fechaInicioTratamiento

WHERE idTratamiento = @idTratamiento;



--Descripcion : Procedimiento Almacenado para Insertar sobre la tabla Tratamiento
--Fecha de Creacion : miércoles, 10 de abril de 2013
CREATE PROCEDURE spr_AgregarTratamientoAlterno
(
    
            @estadoTratamiento varchar(20),
            @observacionesTratamiento text,
            @idHistoriaClinica int,
            @tipoTratamiento varchar(100),
            @fechaInicioTratamiento datetime
)
AS
INSERT INTO Tratamiento 
(estadoTratamiento,observacionesTratamiento,idHistoriaClinica,tipoTratamiento,fechaInicioTratamiento)
VALUES
(@estadoTratamiento,@observacionesTratamiento,@idHistoriaClinica,@tipoTratamiento,@fechaInicioTratamiento)
--Descripcion : Procedimiento Almacenado para Actualizar sobre la tabla Tratamiento
--Autor : 
--Fecha de Creacion : miércoles, 10 de abril de 2013
CREATE PROCEDURE spr_ModificarTratamientoAlterno
(
    
            @idTratamiento int,
            @estadoTratamiento varchar(20),
            @observacionesTratamiento text,
            @idHistoriaClinica int,
            @tipoTratamiento varchar(100),
            @fechaInicioTratamiento datetime
)
AS
UPDATE Tratamiento 
SET

estadoTratamiento = @estadoTratamiento,
observacionesTratamiento = @observacionesTratamiento,
idHistoriaClinica = @idHistoriaClinica,
tipoTratamiento = @tipoTratamiento,
fechaInicioTratamiento = @fechaInicioTratamiento

WHERE idTratamiento = @idTratamiento;

select * from Enfermedad

--Descripcion : Procedimiento Almacenado para Seleccionar Toda la informacion de la tabla Tratamiento
--Fecha de Creacion : miércoles, 10 de abril de 2013
CREATE PROCEDURE spr_BuscarTratamientoPorID
(
	@idTratamiento int
)
AS
SELECT * FROM Tratamiento WHERE idTratamiento = @idTratamiento

CREATE PROCEDURE spr_BuscarTratamientoPorIDHistoriaClinica
(
	@idHistoriaClinica int
)
AS
SELECT * FROM Tratamiento WHERE idHistoriaClinica = @idHistoriaClinica