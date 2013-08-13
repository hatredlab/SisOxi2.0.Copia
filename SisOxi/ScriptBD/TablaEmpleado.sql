/* Script T-SQL Generado por LayerHelper by Hatred */

-----------------------------------------------------            
--PROCEDIMIENTOS ALMACENADOS PARA LA TABLA Empleado--
-----------------------------------------------------


--Descripcion : Procedimiento Almacenado para Insertar sobre la tabla Empleado
--Fecha de Creacion : domingo, 14 de abril de 2013
CREATE PROCEDURE spr_AgregarEmpleado
(
    
            @nombres varchar(100),
            @apellidos varchar(100),
            @direccionDomiciliaria varchar(200),
            @fono varchar(20),
            @clave varchar(20),
            @cargo varchar(50),
            @dni varchar(11)
)
AS
INSERT INTO Empleado 
(nombres,apellidos,direccionDomiciliaria,fono,clave,cargo,dni)
VALUES
(@nombres,@apellidos,@direccionDomiciliaria,@fono,@clave,@cargo,@dni)

--Descripcion : Procedimiento Almacenado para Actualizar sobre la tabla Empleado
--Autor : 
--Fecha de Creacion : domingo, 14 de abril de 2013
CREATE PROCEDURE spr_ModificarEmpleado
(
    
            @idEmpleado int,
            @nombres varchar(100),
            @apellidos varchar(100),
            @direccionDomiciliaria varchar(200),
            @fono varchar(20),
            @clave varchar(20),
            @cargo varchar(50),
            @dni varchar(11)
)
AS
UPDATE Empleado 
SET
nombres = @nombres,
apellidos = @apellidos,
direccionDomiciliaria = @direccionDomiciliaria,
fono = @fono,
clave = @clave,
cargo = @cargo,
dni = @dni

WHERE idEmpleado = @idEmpleado;

--Descripcion : Procedimiento Almacenado para Seleccionar Toda la informacion de la tabla Empleado
--Fecha de Creacion : domingo, 14 de abril de 2013
CREATE PROCEDURE spr_BuscarEmpleado
(
	@apellidos varchar(100)
)
AS
SELECT Empleado.*,'nombrefull'=Empleado.nombres+' '+Empleado.apellidos FROM Empleado 
WHERE empleado.apellidos  like @apellidos + '%'



--Descripcion : Procedimiento Almacenado para Seleccionar Toda la informacion de la tabla Enfermedad
--Fecha de Creacion : sábado, 13 de abril de 2013

