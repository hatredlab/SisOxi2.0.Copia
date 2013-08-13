----------------------------------------------------------            
--PROCEDIMIENTOS ALMACENADOS PARA LA TABLA DatosClinicos--
----------------------------------------------------------


--Descripcion : Procedimiento Almacenado para Insertar sobre la tabla DatosClinicos
--Fecha de Creacion : miércoles, 10 de abril de 2013
CREATE PROCEDURE spr_AgregarDatosClinicos
(
    
            @enfermedadActual text,
            @antecedenteFamiliares text,
            @antecedentesPatologicos text,
            @FC varchar(50),
            @T varchar(50),
            @PA varchar(50),
            @peso varchar(50),
            @talla varchar(50),
            @observacionesFisicas text,
            @examenesDeLaboratorio text,
            @idHistoriaClinica int
)
AS
INSERT INTO DatosClinicos 
(enfermedadActual,antecedenteFamiliares,antecedentesPatologicos,FC,T,PA,peso,talla,observacionesFisicas,examenesDeLaboratorio,idHistoriaClinica)
VALUES
(@enfermedadActual,@antecedenteFamiliares,@antecedentesPatologicos,@FC,@T,@PA,@peso,@talla,@observacionesFisicas,@examenesDeLaboratorio,@idHistoriaClinica)
SELECT @@IDENTITY

--Descripcion : Procedimiento Almacenado para Actualizar sobre la tabla DatosClinicos
--Autor : 
--Fecha de Creacion : miércoles, 10 de abril de 2013
CREATE PROCEDURE spr_ModificarDatosClinicos
(
    
            @idDatosClinicos int,
            @enfermedadActual text,
            @antecedenteFamiliares text,
            @antecedentesPatologicos text,
            @FC varchar(50),
            @T varchar(50),
            @PA varchar(50),
            @peso varchar(50),
            @talla varchar(50),
            @observacionesFisicas text,
            @examenesDeLaboratorio text,
            @idHistoriaClinica int
)
AS
UPDATE DatosClinicos 
SET
enfermedadActual = @enfermedadActual,
antecedenteFamiliares = @antecedenteFamiliares,
antecedentesPatologicos = @antecedentesPatologicos,
FC = @FC,
T = @T,
PA = @PA,
peso = @peso,
talla = @talla,
observacionesFisicas = @observacionesFisicas,
examenesDeLaboratorio = @examenesDeLaboratorio,
idHistoriaClinica = @idHistoriaClinica

WHERE idDatosClinicos = @idDatosClinicos;

--Descripcion : Procedimiento Almacenado para Seleccionar Toda la informacion de la tabla DatosClinicos
--Fecha de Creacion : miércoles, 10 de abril de 2013
CREATE PROCEDURE spr_SeleccionarDatosClinicos
AS
SELECT * FROM DatosClinicos