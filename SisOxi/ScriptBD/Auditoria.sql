CREATE PROCEDURE spr_AgregarAuditoria
(
    
            @idEmpleado int,
            @idRegistro int,
            @tipo varchar(50),
            @tabla varchar(50),
            @fecha datetime
)
AS
INSERT INTO Auditoria 
(idEmpleado,idRegistro,tipo,tabla,fecha)
VALUES
(@idEmpleado,@idRegistro,@tipo,@tabla,@fecha)