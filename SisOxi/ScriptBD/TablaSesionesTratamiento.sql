----------------------------------------------------------------            
--PROCEDIMIENTOS ALMACENADOS PARA LA TABLA SesionesTratamiento--
----------------------------------------------------------------


--Descripcion : Procedimiento Almacenado para Insertar sobre la tabla SesionesTratamiento
--Fecha de Creacion : miércoles, 10 de abril de 2013
CREATE PROCEDURE spr_AgregarSesionesTratamiento
(
    
            @fechaSesion datetime,
            @consumoOxigeno decimal(8,2),
            @notasTender text,
            @idTratamiento int,
            @idEmpleado int,
            @idHistoriaClinica int,
			@protocolo varchar(10)
)
AS
INSERT INTO SesionesTratamiento 
(fechaSesion,consumoOxigeno,notasTender,idTratamiento,idEmpleado,idHistoriaClinica,protocolo)
VALUES
(@fechaSesion,@consumoOxigeno,@notasTender,@idTratamiento,@idEmpleado,@idHistoriaClinica,@protocolo)
GO
--Descripcion : Procedimiento Almacenado para Actualizar sobre la tabla SesionesTratamiento
--Autor : 
--Fecha de Creacion : miércoles, 10 de abril de 2013
CREATE PROCEDURE spr_ModificarSesionesTratamiento
(
    
            @idSesionTratamiento int,
            @fechaSesion datetime,
            @consumoOxigeno decimal(8,2),
            @notasTender text,
            @idTratamiento int,
            @idEmpleado int,
            @idHistoriaClinica int,
			@protocolo varchar(10)
)
AS
UPDATE SesionesTratamiento 
SET

fechaSesion = @fechaSesion,
consumoOxigeno = @consumoOxigeno,
notasTender = @notasTender,
idTratamiento = @idTratamiento,
idEmpleado = @idEmpleado,
idHistoriaClinica = @idHistoriaClinica,
protocolo = @protocolo

WHERE idSesionTratamiento = @idSesionTratamiento;
GO
--Descripcion : Procedimiento Almacenado para Seleccionar Toda la informacion de la tabla SesionesTratamiento
--Fecha de Creacion : miércoles, 10 de abril de 2013
CREATE PROCEDURE spr_SeleccionarSesionesPorTratamiento
(
	@idTratamiento int
)
AS
SELECT s.idSesionTratamiento,'nro'=ROW_NUMBER() over (order by s.idSesionTratamiento), s.fechaSesion,s.consumoOxigeno,s.protocolo,
s.idEmpleado,s.idTratamiento,s.idHistoriaClinica,s.notasTender ,'nombrefull'=e.nombres+ ' '+e.apellidos
 FROM SesionesTratamiento s inner join Empleado e on s.idEmpleado = e.idEmpleado
WHERE s.idTratamiento = @idTratamiento
GO


CREATE TRIGGER TR_ObtenerPromedioConsumoOxigeno
on SesionesTratamiento
for insert
as
declare @idTratamiento int;
declare @consumoOxigeno decimal(8,2);
declare @total decimal(8,2);
declare @contador int;
set @total = 0;
set @contador = 0;
begin try
begin transaction PromedioConsumo

select @idTratamiento=inserted.idTratamiento from inserted
		declare SesionesT cursor for
		select s.consumoOxigeno from SesionesTratamiento s where s.idTratamiento = @idTratamiento
		open SesionesT
		fetch SesionesT into @consumoOxigeno
		while(@@FETCH_STATUS=0)
		begin
			set @total = @total + @consumoOxigeno;
			set @contador = @contador +1;
			fetch SesionesT into @consumoOxigeno
		end
		update Tratamiento
		set
			promedioOxigeno = @total/@contador
		where Tratamiento.idTratamiento = @idTratamiento;
commit transaction PromedioConsumo
end try
begin catch
	rollback transaction PromedioConsumo
end catch


ALTER TRIGGER TR_ObtenerPromedioConsumoOxigenoUpdate
on SesionesTratamiento
for update
as
declare @idTratamiento int;
declare @consumoOxigeno decimal(8,2);
declare @total decimal(8,2);
declare @contador int;
set @total = 0;
set @contador = 0;
begin try
begin transaction PromedioConsumo

select @idTratamiento=inserted.idTratamiento from inserted
		declare SesionesT cursor for
		select s.consumoOxigeno from SesionesTratamiento s where s.idTratamiento = @idTratamiento
		open SesionesT
		fetch SesionesT into @consumoOxigeno
		while(@@FETCH_STATUS=0)
		begin
			set @total = @total + @consumoOxigeno;
			set @contador = @contador +1;
			fetch SesionesT into @consumoOxigeno
		end
		update Tratamiento
		set
			promedioOxigeno = @total/@contador
		where Tratamiento.idTratamiento = @idTratamiento;
commit transaction PromedioConsumo
end try
begin catch
	rollback transaction PromedioConsumo
end catch


select * from SesionesTratamiento