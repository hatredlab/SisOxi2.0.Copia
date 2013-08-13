-----------------------------------------------------------------            
--PROCEDIMIENTOS ALMACENADOS PARA LA TABLA ImpresionDiagnostica--
-----------------------------------------------------------------


--Descripcion : Procedimiento Almacenado para Insertar sobre la tabla ImpresionDiagnostica
--Fecha de Creacion : miércoles, 10 de abril de 2013
CREATE PROCEDURE spr_AgregarImpresionDiagnostica
(
    
            @observaciones text,
            @idEnfermedad int,
            @idHistoriaClinica int,
            @idImpresionDIagnosticaAlterna int
)
AS
INSERT INTO ImpresionDiagnostica 
(observaciones,idEnfermedad,idHistoriaClinica,idImpresionDiagnosticaAlterna)
VALUES
(@observaciones,@idEnfermedad,@idHistoriaClinica,@idImpresionDIagnosticaAlterna)
SELECT @@identity
GO
--Descripcion : Procedimiento Almacenado para Actualizar sobre la tabla ImpresionDiagnostica
--Autor : 
--Fecha de Creacion : miércoles, 10 de abril de 2013
CREATE PROCEDURE spr_ModificarImpresionDiagnostica
(
    
            @idImpresionDiagnostica int,
            @observaciones text,
            @idEnfermedad int,
            @idHistoriaClinica int,
            @idImpresionDIagnosticaAlterna int
)
AS
UPDATE ImpresionDiagnostica 
SET

observaciones = @observaciones,
idEnfermedad = @idEnfermedad,
idHistoriaClinica = @idHistoriaClinica,
idImpresionDiagnosticaAlterna = @idImpresionDIagnosticaAlterna
WHERE idImpresionDiagnostica = @idImpresionDiagnostica ;

--Descripcion : Procedimiento Almacenado para Seleccionar Toda la informacion de la tabla ImpresionDiagnostica
--Fecha de Creacion : miércoles, 10 de abril de 2013
CREATE PROCEDURE spr_BuscarImpresionDiagnosticaPorIDHistoriaClinica
(
	@idHistoriaClinica int
)
AS
SELECT ImpresionDiagnostica.*,Enfermedad.nombre 
FROM ImpresionDiagnostica inner join Enfermedad
on ImpresionDiagnostica.idEnfermedad = Enfermedad.idEnfermedad
WHERE idHistoriaClinica = @idHistoriaClinica and tipo='Enfermedad Principal';
go

CREATE PROCEDURE spr_BuscarImpresionDiagnosticaPorIDImpresionDiagnosticaAlterna
(
	@idImpresionDiagnosticaAlterna int
)
AS
SELECT ImpresionDiagnostica.*,Enfermedad.nombre 
FROM ImpresionDiagnostica inner join Enfermedad
on ImpresionDiagnostica.idEnfermedad = Enfermedad.idEnfermedad
WHERE idImpresionDiagnosticaAlterna = @idImpresionDiagnosticaAlterna;
go

CREATE PROCEDURE spr_EliminarImpresionDiagnosticaAlterna
(
	@idImpresionDiagnosticaAlterna int
)
AS
delete from ImpresionDiagnostica where ImpresionDiagnostica.idImpresionDiagnostica = @idImpresionDiagnosticaAlterna;
go


