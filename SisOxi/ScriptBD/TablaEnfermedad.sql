/* Script T-SQL Generado por LayerHelper by Hatred */

-------------------------------------------------------            
--PROCEDIMIENTOS ALMACENADOS PARA LA TABLA Enfermedad--
-------------------------------------------------------


--Descripcion : Procedimiento Almacenado para Insertar sobre la tabla Enfermedad
--Fecha de Creacion : sábado, 13 de abril de 2013
CREATE PROCEDURE spr_AgregarEnfermedad
(
			
            @nombre varchar(200),
            @descripcion varchar(200),
            @tipo varchar(100)
)
AS
INSERT INTO Enfermedad 
(nombre,descripcion,tipo)
VALUES
(@nombre,@descripcion,@tipo)
go
--Descripcion : Procedimiento Almacenado para Actualizar sobre la tabla Enfermedad
--Autor : 
--Fecha de Creacion : sábado, 13 de abril de 2013
CREATE PROCEDURE spr_ModificarEnfermedad
(
    
            @idEnfermedad int,
            @nombre varchar(200),
            @descripcion varchar(200),
            @tipo varchar(100)
)
AS
UPDATE Enfermedad 
SET
nombre = @nombre,
descripcion = @descripcion,
tipo = @tipo
WHERE idEnfermedad = @idEnfermedad;
go
--Descripcion : Procedimiento Almacenado para Seleccionar Toda la informacion de la tabla Enfermedad
--Fecha de Creacion : sábado, 13 de abril de 2013
CREATE PROCEDURE spr_BuscarEnfermedad
AS
SELECT * FROM Enfermedad where Enfermedad.tipo = 'Enfermedad Principal'
go

CREATE PROCEDURE spr_BuscarEnfermedadAsociada
AS
SELECT * FROM Enfermedad where Enfermedad.tipo = 'Enfermedad Asociada'
go
--Descripcion : Procedimiento Almacenado para Seleccionar Toda la informacion de la tabla Enfermedad
--Fecha de Creacion : sábado, 13 de abril de 2013
CREATE PROCEDURE spr_BuscarEnfermedadPorID
(
	@idEnfermedad int
)
AS
SELECT * FROM Enfermedad where idEnfermedad = @idEnfermedad
GO

ALTER PROCEDURE spr_BuscarEnfermedadHistoria
(
	@enfermedad as TBEnfermedad readonly
)
AS
SELECT * FROM Enfermedad WHERE Enfermedad.nombre NOT IN (select nombre from @enfermedad) and Enfermedad.tipo = 'Enfermedad Principal'
go

CREATE PROCEDURE spr_BuscarEnfermedadHistoriaAsociada
(
	@enfermedad as TBEnfermedad readonly
)
AS
SELECT * FROM Enfermedad WHERE Enfermedad.nombre NOT IN (select nombre from @enfermedad) and Enfermedad.tipo = 'Enfermedad Asociada'




CREATE procedure spr_ReporteEnfermedadAsociada
(
@idenfermedad int
)
as
SELECT 
'nombrecompleto'=H.nombres+' '+H.apellidoPaterno+' '+H.apellidoMaterno, 
H.apellidoPaterno, 
E.nombre
FROM  Enfermedad AS E INNER JOIN ImpresionDiagnostica AS IA 
ON E.idEnfermedad = IA.idEnfermedad AND E.tipo = 'Enfermedad Asociada' 
AND IA.idImpresionDiagnostica IN
(SELECT idImpresionDiagnostica
FROM ImpresionDiagnostica AS I
WHERE(idImpresionDiagnosticaAlterna IN
(SELECT idImpresionDiagnostica
FROM ImpresionDiagnostica AS IIA
WHERE(idEnfermedad = @idenfermedad)))) INNER JOIN
HistoriaClinica AS H ON H.idHistoriaClinica = IA.idHistoriaClinica
