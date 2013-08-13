create Procedure dbo.spr_LogeoSistema
(
@NOMBREUSUARIO	varchar(15),
@CLAVEUSUARIO	varchar(15)
)
as
select * from Empleado where dni=@NOMBREUSUARIO AND clave =@CLAVEUSUARIO