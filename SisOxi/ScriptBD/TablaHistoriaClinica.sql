/* Script T-SQL Generado por LayerHelper by Hatred */

------------------------------------------------------------            
--PROCEDIMIENTOS ALMACENADOS PARA LA TABLA HistoriaClinica--
------------------------------------------------------------


--Descripcion : Procedimiento Almacenado para Insertar sobre la tabla HistoriaClinica
--Fecha de Creacion : lunes, 8 de abril de 2013
create PROCEDURE spr_AgregarHistoriaClinica
(
    
            @nombres varchar(100),
            @apellidoPaterno varchar(100),
            @codigoHistoriaClinica varchar(20),
            @apellidoMaterno varchar(100),
            @documentoIdentidad varchar(20),
            @estadoCivil varchar(20),
            @edad int,
            @sexo varchar(20),
            @profesion varchar(50),
            @fechaNacimiento datetime,
            @lugarNacimiento varchar(50),
            @provincia varchar(50),
            @ocupacion varchar(50),
            @centroTrabajo varchar(100),
            @direccionDomiciliaria varchar(100),
            @fono varchar(20),
            @diistritoDomicilio varchar(50),
            @provinciaDomicilio varchar(50),
            @nombreContacto varchar(50),
            @parentescoContacto varchar(20),
            @domicilioContacto varchar(100),
            @fonoContacto varchar(50),
            @grupoEtnico varchar(100),
            @nacionalidad varchar(50),
            @departamentoDomicilio varchar(100),
            @apellidosContacto varchar(100)
)
AS
INSERT INTO HistoriaClinica 
(nombres,apellidoPaterno,codigoHistoriaClinica,apellidoMaterno,documentoIdentidad,estadoCivil,edad,sexo,profesion,fechaNacimiento,lugarNacimiento,provincia,ocupacion,centroTrabajo,direccionDomiciliaria,fono,diistritoDomicilio,provinciaDomicilio,nombreContacto,parentescoContacto,domicilioContacto,fonoContacto,grupoEtnico,nacionalidad,departamentoDomicilio,apellidosContacto)
VALUES
(@nombres,@apellidoPaterno,@codigoHistoriaClinica,@apellidoMaterno,@documentoIdentidad,@estadoCivil,@edad,@sexo,@profesion,@fechaNacimiento,@lugarNacimiento,@provincia,@ocupacion,@centroTrabajo,@direccionDomiciliaria,@fono,@diistritoDomicilio,@provinciaDomicilio,@nombreContacto,@parentescoContacto,@domicilioContacto,@fonoContacto,@grupoEtnico,@nacionalidad,@departamentoDomicilio,@apellidosContacto)
SELECT @@IDENTITY

--Descripcion : Procedimiento Almacenado para Actualizar sobre la tabla HistoriaClinica
--Autor : 
--Fecha de Creacion : lunes, 8 de abril de 2013
CREATE PROCEDURE spr_ModificarHistoriaClinica
(
    
            @idHistoriaClinica int,
            @nombres varchar(100),
            @apellidoPaterno varchar(100),
            @codigoHistoriaClinica varchar(20),
            @apellidoMaterno varchar(100),
            @documentoIdentidad varchar(20),
            @estadoCivil varchar(20),
            @edad int,
            @sexo varchar(20),
            @profesion varchar(50),
            @fechaNacimiento datetime,
            @lugarNacimiento varchar(50),
            @provincia varchar(50),
            @ocupacion varchar(50),
            @centroTrabajo varchar(100),
            @direccionDomiciliaria varchar(100),
            @fono varchar(20),
            @diistritoDomicilio varchar(50),
            @provinciaDomicilio varchar(50),
            @nombreContacto varchar(50),
            @parentescoContacto varchar(20),
            @domicilioContacto varchar(100),
            @fonoContacto varchar(50),
            @grupoEtnico varchar(100),
            @nacionalidad varchar(50),
            @departamentoDomicilio varchar(100),
            @apellidosContacto varchar(100)
)
AS
UPDATE HistoriaClinica 
SET
nombres = @nombres,
apellidoPaterno = @apellidoPaterno,
codigoHistoriaClinica = @codigoHistoriaClinica,
apellidoMaterno = @apellidoMaterno,
documentoIdentidad = @documentoIdentidad,
estadoCivil = @estadoCivil,
edad = @edad,
sexo = @sexo,
profesion = @profesion,
fechaNacimiento = @fechaNacimiento,
lugarNacimiento = @lugarNacimiento,
provincia = @provincia,
ocupacion = @ocupacion,
centroTrabajo = @centroTrabajo,
direccionDomiciliaria = @direccionDomiciliaria,
fono = @fono,
diistritoDomicilio = @diistritoDomicilio,
provinciaDomicilio = @provinciaDomicilio,
nombreContacto = @nombreContacto,
parentescoContacto = @parentescoContacto,
domicilioContacto = @domicilioContacto,
fonoContacto = @fonoContacto,
grupoEtnico = @grupoEtnico,
nacionalidad = @nacionalidad,
departamentoDomicilio = @departamentoDomicilio,
apellidosContacto = @apellidosContacto

WHERE idHistoriaClinica = @idHistoriaClinica;



--Descripcion : Procedimiento Almacenado para Seleccionar Toda la informacion de la tabla HistoriaClinica
--Fecha de Creacion : lunes, 8 de abril de 2013
CREATE PROCEDURE spr_BuscarHistoriaClinica
(
	@busqueda varchar(50)
)
AS
SELECT HistoriaClinica.* , DatosClinicos.* 
FROM HistoriaClinica inner join
DatosClinicos on HistoriaClinica.idHistoriaClinica = DatosClinicos.idHistoriaClinica
WHERE HistoriaClinica.nombres like @busqueda + '%' or
	  HistoriaClinica.apellidoPaterno like @busqueda + '%'



--Descripcion : Trigger para generar automaticamente el codigo al insertar registro
--con el formato <incial apellido><numero> ejemplo : O-0001
--Fecha de Creacion : lunes, 8 de abril de 2013

create trigger tr_InsertarCodigoHistoriaClinica
on HistoriaClinica
for insert
as 
declare @codigo int;
declare @cantidad int;
declare @apellido varchar(100);
begin try
begin transaction InsertarPaciente
	select @apellido=SUBSTRING(apellidoPaterno,1,1),@codigo=idHistoriaClinica from inserted;
	select @cantidad=COUNT(*) from HistoriaClinica where apellidoPaterno like @apellido+'%';
	
		
		update HistoriaClinica
		set
			codigoHistoriaClinica = @apellido+'-' + replace(str(@cantidad, 5), ' ', '0')
		where idHistoriaClinica = @codigo;
	
		
commit transaction InsertarPaciente
end try
begin catch
rollback transaction InsertarPaciente
end catch



CREATE PROCEDURE spr_BuscarHistoriaClinicaPorID
(
	@idHistoriaClinica int
)
AS
SELECT HistoriaClinica.* , DatosClinicos.* 
FROM HistoriaClinica inner join
DatosClinicos on HistoriaClinica.idHistoriaClinica = DatosClinicos.idHistoriaClinica
WHERE HistoriaClinica.idHistoriaClinica = @idHistoriaClinica