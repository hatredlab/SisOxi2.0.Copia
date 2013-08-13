create PROCEDURE ConsultaHistoriaClinicaConTratamiento 
@RAZA varchar(100),
@NACIONALIDAD VARCHAR(50),
@PROFESION VARCHAR(50),
@SEXO VARCHAR(20),
@EDADINICIAL INT,
@EDADFINAL INT,
@ENFERMEDAD VARCHAR(200),
@TRATAMIENTO VARCHAR(100)
	
AS
SELECT codigoHistoriaClinica, (nombres + ' ' + apellidoPaterno + '' + apellidoMaterno) as NOMBRE,
documentoIdentidad,e.nombre, t.tipoTratamiento, fono, direccionDomiciliaria,(nombreContacto
+ ''+apellidosContacto) as NOMBRECONTACTO,parentescoContacto,fonoContacto

froM HistoriaClinica hc
inner join ImpresionDiagnostica id on 
id.idHistoriaClinica = hc.idHistoriaClinica 
inner join Enfermedad e on 
id.idEnfermedad = e.idEnfermedad
inner join Tratamiento t on t.idHistoriaClinica = hc.idHistoriaClinica

WHERE 
	t.tipoTratamiento= @TRATAMIENTO and
	(@RAZA = '' OR grupoEtnico LIKE '%' + @RAZA + '%') AND
	(@NACIONALIDAD = '' OR nacionalidad LIKE '%' + @NACIONALIDAD + '%') and
	(@PROFESION = '' OR profesion LIKE '%' + @PROFESION + '%') AND
	(@SEXO = '' OR sexo LIKE '%' + @SEXO + '%') AND
	(@EDADINICIAL = '' OR edad LIKE '%' + @EDADINICIAL + '%') and
	(@ENFERMEDAD = '' OR e.nombre LIKE '%' + @ENFERMEDAD + '%') and
	(@EDADINICIAL = ''AND @EDADFINAL = '' OR edad between @EDADINICIAL and @EDADFINAL  + @EDADINICIAL  + '%' + @EDADFINAL + '%')
	 