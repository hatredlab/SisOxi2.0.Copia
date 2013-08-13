CREATE PROCEDURE spr_ReporteEnfermedadesPorRangoEdades
AS
declare @TotalIH int;
SELECT @TotalIH=HistoriaClinica.idHistoriaClinica from HistoriaClinica
Select E.nombre,'Total'=@TotalIH,
'Paciente'=Count(HC.idHistoriaClinica),
'Porcentaje'=CONVERT(varchar,(Count(HC.idHistoriaClinica)* 100 / (Select Count(*) From HistoriaClinica)))+'%',
'EdadMin'=MIN(Hc.edad),
'EdadMax'=MAX(hc.edad),
'Promedio'=AVG(HC.edad)
from 
Enfermedad E inner join ImpresionDiagnostica ID
	on E.idEnfermedad = ID.idEnfermedad and E.tipo = 'Enfermedad Principal'
			 inner join HistoriaClinica HC
	on HC.idHistoriaClinica = ID.idHistoriaClinica
GROUP BY E.nombre
GO

create PROCEDURE spr_ReporteEnfermedadesPorRangoEdadesII
AS
declare @TotalIH int;
SELECT @TotalIH=HistoriaClinica.idHistoriaClinica from HistoriaClinica
Select E.nombre,'Total'=@TotalIH,
'0-10'=SUM(CASE WHEN HC.edad between 0 and 10 THEN 1 ELSE 0 END),
'11-20'=SUM(CASE WHEN HC.edad between 11 and 20 THEN 1 ELSE 0 END),
'21-30'=SUM(CASE WHEN HC.edad between 21 and 30 THEN 1 ELSE 0 END),
'31-40'=SUM(CASE WHEN HC.edad between 31 and 40 THEN 1 ELSE 0 END),
'41-50'=SUM(CASE WHEN HC.edad between 41 and 50 THEN 1 ELSE 0 END),
'51-60'=SUM(CASE WHEN HC.edad between 51 and 60 THEN 1 ELSE 0 END),
'61-70'=SUM(CASE WHEN HC.edad between 61 and 70 THEN 1 ELSE 0 END),
'71-80'=SUM(CASE WHEN HC.edad between 71 and 80 THEN 1 ELSE 0 END),
'81+'=SUM(CASE WHEN HC.edad >=81 THEN 1 ELSE 0 END)
from 
Enfermedad E inner join ImpresionDiagnostica ID
	on E.idEnfermedad = ID.idEnfermedad and E.tipo = 'Enfermedad Principal'
			 inner join HistoriaClinica HC
	on HC.idHistoriaClinica = ID.idHistoriaClinica
GROUP BY E.nombre
GO


create PROCEDURE spr_ReporteEnfermedadesPorSexo
AS
declare @TotalIH int;
SELECT @TotalIH=HistoriaClinica.idHistoriaClinica from HistoriaClinica
Select E.nombre,
'Total'=@TotalIH,
'Paciente'=Count(HC.idHistoriaClinica),
'Porcentaje'=CONVERT(varchar,(Count(HC.idHistoriaClinica)* 100 / (Select Count(*) From HistoriaClinica)))+'%',
'Femenino'=SUM(CASE WHEN HC.sexo = 'Femenino' THEN 1 ELSE 0 END),			
'Masculino'=SUM(CASE WHEN HC.sexo = 'Masculino' THEN 1 ELSE 0 END)
			
from 
Enfermedad E inner join ImpresionDiagnostica ID
	on E.idEnfermedad = ID.idEnfermedad and E.tipo = 'Enfermedad Principal'
			 inner join HistoriaClinica HC
	on HC.idHistoriaClinica = ID.idHistoriaClinica
GROUP BY E.nombre



CREATE PROCEDURE spr_ReporteEnfermedadesTratamientoCamaraHiperbarica
AS
declare @TotalIH int;
SELECT @TotalIH=HistoriaClinica.idHistoriaClinica from HistoriaClinica
Select E.nombre,
'Paciente'=Count(HC.idHistoriaClinica),
'TratamientoCompleto'=SUM(CASE WHEN T.estadoTratamiento = 'Completo' THEN 1 ELSE 0 END),	
'TratamientoIncompleto'=SUM(CASE WHEN T.estadoTratamiento = 'Incompleto' THEN 1 ELSE 0 END),
'NroSesionesMin'=Min(T.nroSesiones),
'NroSesionesMax'=MAX(T.nroSesiones),
'PromedioNroSesiones'=AVG(T.nroSesiones)
from 
ImpresionDiagnostica ID inner join Enfermedad E
	on E.idEnfermedad = ID.idEnfermedad and E.tipo = 'Enfermedad Principal'
			 inner join HistoriaClinica HC
	on HC.idHistoriaClinica = ID.idHistoriaClinica
			 inner join Tratamiento T
	on T.idImpresionDiagnostica = ID.idImpresionDiagnostica
		Where T.tipoTratamiento = 'Camara Hiperbárica'
		
GROUP BY E.nombre
GO
select * from Tratamiento
select * from ImpresionDiagnostica
select * from SesionesTratamiento

select SS.idTratamiento, MAX(SS.nro),SS.protocolo from (select s.idTratamiento,COUNT(s.protocolo) nro,s.protocolo from SesionesTratamiento s
group by s.idTratamiento,s.protocolo) SS group by SS.idTratamiento

select s.idTratamiento,s.protocolo from
(
	select SS.idTratamiento,COUNT(SS.protocolo) nro,SS.protocolo,
	row_number() over (partition by SS.idTratamiento order by COUNT(SS.protocolo) desc) RowNumber
	
	from SesionesTratamiento SS group by SS.idTratamiento,SS.protocolo
) s
Where RowNumber = 1



select s.idTratamiento,
	(Select TOP 1 COUNT (*) from SesionesTratamiento SI where SI.idTratamiento = s.idTratamiento
	group by SI.protocolo ) , s.protocolo from SesionesTratamiento s
group by s.idTratamiento,s.protocolo

-- FINAL --
select 'nombre'=H.nombres+' '+H.apellidoPaterno+' '+H.apellidoMaterno,H.grupoEtnico
		,T.nroSesiones,SE.protocolo

from HistoriaClinica H 
	inner join ImpresionDiagnostica I
	on H.idHistoriaClinica = I.idHistoriaClinica and I.idEnfermedad = 1
	inner join Tratamiento T
	on I.idImpresionDiagnostica = T.idImpresionDiagnostica and T.tipoTratamiento = 'Camara Hiperbárica'
	inner join (select s.idTratamiento,s.protocolo from
	(
	select SS.idTratamiento,COUNT(SS.protocolo) nro,SS.protocolo,
	row_number() over (partition by SS.idTratamiento order by COUNT(SS.protocolo) desc) RowNumber 
	from SesionesTratamiento SS group by SS.idTratamiento,SS.protocolo
	) s Where RowNumber = 1) SE
	on T.idTratamiento = SE.idTratamiento

---

--TRIAL

exec spr_ReporteResumenTratamientoCamara 1
CREATE PROCEDURE spr_ReporteResumenTratamientoCamara
(
	@idEnfermedad int
)
as
select  H.nombres+' '+H.apellidoPaterno+' '+H.apellidoMaterno as nombres,H.edad,H.grupoEtnico,
		SE.protocolo,COUNT(ST.idSesionTratamiento) as NroSesiones,T.nroSesiones,T.estadoPaciente

from HistoriaClinica H 
	inner join ImpresionDiagnostica I
	on H.idHistoriaClinica = I.idHistoriaClinica and I.idEnfermedad = @idEnfermedad
	inner join Tratamiento T
	on I.idImpresionDiagnostica = T.idImpresionDiagnostica and T.tipoTratamiento = 'Camara Hiperbárica'
	inner join (select s.idTratamiento,s.protocolo from
	(
	select SS.idTratamiento,COUNT(SS.protocolo) nro,SS.protocolo,
	row_number() over (partition by SS.idTratamiento order by COUNT(SS.protocolo) desc) RowNumber 
	from SesionesTratamiento SS group by SS.idTratamiento,SS.protocolo
	) s Where RowNumber = 1) SE
	on T.idTratamiento = SE.idTratamiento
	inner join SesionesTratamiento ST
	on T.idTratamiento = ST.idTratamiento
	group by H.nombres,H.apellidoPaterno,H.apellidoMaterno,T.nroSesiones,Se.protocolo,H.grupoEtnico,T.nroSesiones,H.edad,T.estadoPaciente
	select * from Tratamiento
select * from ImpresionDiagnostica where idEnfermedad = 1
select * from SesionesTratamiento where idTratamiento = 3 or idTratamiento = 4

--
select H.nombres	
from HistoriaClinica H 
	inner join ImpresionDiagnostica I
	on H.idHistoriaClinica = I.idHistoriaClinica and I.idEnfermedad = 1
	inner join Tratamiento T
	on I.idImpresionDiagnostica = T.idImpresionDiagnostica and T.tipoTratamiento = 'Camara Hiperbárica'
	select * from Tratamiento
	



exec spr_ReportePorSexo
GO
exec spr_ReporteEnfermedadesPorSexo
GO


select * from Tratamiento

Select T.*
from 
Enfermedad E inner join ImpresionDiagnostica ID
	on E.idEnfermedad = ID.idEnfermedad
			 inner join HistoriaClinica HC
	on HC.idHistoriaClinica = ID.idHistoriaClinica
			 inner join Tratamiento T
	on HC.idHistoriaClinica = T.idHistoriaClinica
	
	
select t.* from Tratamiento t inner join HistoriaClinica h 
on t.idHistoriaClinica = h.idHistoriaClinica
Where T.tipoTratamiento = 'Camara Hiperbarica'
		
		
		
GROUP BY E.nombre
GO
