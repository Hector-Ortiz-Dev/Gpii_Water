


use gpi_water;

select id, nombre from StatusUsuario;
select * from Usuario;
select id, usuario, contraseña, nombre, apellido_p, apellido_m, f_nacimiento, genero, f_alta, intento, recordar, fk_status from Usuario;

insert into StatusUsuario(nombre)values ('ACTIVO');
insert into StatusUsuario(nombre)values ('BANEADO');
insert into StatusUsuario(nombre)values ('BAJA');

insert into Usuario (usuario, contraseña, nombre, apellido_p, apellido_m, f_nacimiento, genero) 
values ('alan1625', 'alan1625', 'ALAN', 'GONZALEZ', 'LEOS', '03-08-1998', 'MASCULINO');
insert into Usuario (usuario, contraseña, nombre, apellido_p, apellido_m, f_nacimiento, genero) 
values ('hector1625', 'hector1625', 'HECTOR JAVIER', 'ORTIZ', 'MUNIZ', '10-25-1997', 'MASCULINO');
insert into Usuario (usuario, contraseña, nombre, apellido_p, apellido_m, f_nacimiento, genero) 
values ('admin', 'admin', 'JOSE DE JESUS', 'ORTIZ', 'MARQUEZ', '09-27-2000', 'MASCULINO');

select * from Administrador;
select * from Empleado;
select * from Cliente;

insert into Administrador(tipo, fk_usuario) values('ADMINISTRADOR', 1002);
insert into Empleado(domicilio, fk_usuario) values('APODACA N.L, CP. 16640, COL. HUINALA, DESIERTO SAHARA #400', 1001);
insert into Cliente(email, curp, rfc, fk_usuario) values('alangl.lmad@hotmail.com', 'GOLA980308HNLNSL09', 'GOLA980308HNL', 1000);

exec sp_login @user = 'admin', @pass = 'admin', @tipo_user = 'ADMINISTRADOR';
exec sp_login @user = 'hector1625', @pass = 'hector1625', @tipo_user = 'EMPLEADO';
exec sp_login @user = 'alan1625', @pass = 'alan1625', @tipo_user = 'CLIENTE';

select * from Usuario;

select id, IIF(per_moral = 0, 'NO', 'SI') as per_moral from Cliente 

select * from Usuario inner join Administrador on Administrador.fk_usuario = Usuario.id;
select * from Usuario inner join Empleado on Empleado.fk_usuario = Usuario.id;
select * from Usuario inner join Cliente on Cliente.fk_usuario = Usuario.id;
SELECT * FROM USUARIO;
select * from Empleado;

exec sp_gestion_empleado 
@Opc='ELIMINAR', 
@id=1004, @user='tfortz', @pass='tfortz', 
@nombre='DANIEL', @apellido_p='LOPEZ', @apellido_m='ALMARAZ', 
@f_nacimiento='06-23-2000', @genero='MASCULINO', @domicilio='GUADALUPE NL, COL. VILLA ESPAÑOLA, CASTILLA #1625, CP. 67118';

exec sp_gestion_cliente
@Opc = 'ELIMINAR',
@id = 1006, @user = 'webo', @pass = 'webo',
@nombre = 'MELANIE JANETH', @apellido_p = 'LOREDO', @apellido_m = 'GARCIA',
@f_nacimiento = '03-08-2000', @genero = 'FEMENINO', @email = 'webo@hotmail.com',
@curp = 'MELR124578HNLNSL09', @per_moral = 0, @institucion = NULL, @rfc = 'MELR124578HNL';

exec sp_alta_cliente_contrato
@user = 'pelona', @pass = 'pelona',
@nombre = 'LESLIE ANAID', @apellido_p = 'ROSAS', @apellido_m = 'REYNA',
@f_nacimiento = '06-10-2001', @genero = 'FEMENINO', @email = 'pelona@hotmail.com',
@curp = 'RORL010610MNLSYSA4', @per_moral = 0, @institucion = NULL, @rfc = 'RORL010610MNL',
@medidor = 12345, @tipo = 'DOMESTICO', @categoria = 'A',
@municipio = 'APODACA', @cod_postal = 66608, @colonia = 'LOS CASTAÑOS', @calle = 'ASORES', @num_ext = 1625;

exec sp_alta_cliente_contrato
@user = 'chiflada', @pass = 'chiflada',
@nombre = 'SAMANTHA AYLIN', @apellido_p = 'HERNANDEZ', @apellido_m = 'LUNA',
@f_nacimiento = '08-24-1999', @genero = 'FEMENINO', @email = 'chiflada@hotmail.com',
@curp = 'HELS990824MNLRNM07', @per_moral = 0, @institucion = NULL, @rfc = 'HELS990824MNL',
@medidor = 77625, @tipo = 'DOMESTICO', @categoria = 'A',
@municipio = 'SAN NICOLAS', @cod_postal = 66470, @colonia = 'RESIDENCIAL LOS MORALES', @calle = 'PASEO LOS MORALES', @num_ext = 128;

exec sp_gestion_contrato
@Opc = 'ELIMINAR',
@num_ref = 1003, @medidor = 77779, @tipo = 'DOMESTICO', @categoria = 'C',
@municipio = 'GUADALUPE', @cod_postal = 67118, @colonia = 'VILLA ESPAÑOLA', 
@calle = 'CASTILLA', @num_ext = 1627 ,@id_cliente = 10000;

select * from Usuario;
select * from Cliente;
select * from Contrato;

update c
	set c.activo = 1
from Contrato c
where c.num_ref = 1003 or c.num_ref = 1005;

update u
set u.fk_status = 1
from Usuario u
where u.id = 1004;

SELECT * FROM Empleado;
exec sp_get_empleados @buscar = '';
exec sp_get_clientes @buscar = '';
exec sp_get_clientes_cb @buscar = '';
exec sp_get_contratos @id_cliente = '';

update e
set domicilio = 'SANTA CATARINA NL, CP. 66368, COL. RINCON DE LAS PALMAS, RINCON DE LA SIERRA #436'
from Empleado e where id = 10002;

declare @id_cliente int = (select id from Cliente where email = 'pelona@hotmail.com' and curp = 'RORL010610MNLSYSA4' and rfc = 'RORL010610MNL');
insert into Contrato(medidor, tipo, categoria, municipio, cod_postal, colonia, calle, num_ext, fk_cliente)
values(@medidor, @tipo, @categoria, @municipio, @cod_postal, @colonia, @calle, @num_ext, @id_cliente);

SELECT * FROM Cliente;
SELECT * FROM Contrato;



select 
us.id, us.usuario, us.nombre + ' ' + us.apellido_p + ' ' + us.apellido_m as 'nombre_completo', 
su.nombre as 'status',
cl.curp, cl.rfc,
con.municipio + ', ' + cast(con.cod_postal as varchar(20)) + ', ' + con.colonia + ',' + con.calle + ' #' + cast(con.num_ext as varchar(10))  as 'domicilio'
	from Contrato con inner join Cliente cl
	on cl.id = con.fk_cliente
	inner join Usuario us
	on us.id = cl.fk_usuario
	inner join StatusUsuario su
	on su.id = us.fk_status;

exec sp_get_zonas;

exec sp_get_baneos @buscar = '', @filtro = 'SELECCIONAR';

exec sp_desbanear @id = 1001;

exec sp_get_curps;
exec sp_get_usuarios;
exec sp_get_rfcs;
exec sp_get_medidores;

insert into Zona(municipio, zona) values ('MONTERREY', 1);
insert into Zona(municipio, zona) values ('GUADALUPE', 1);
insert into Zona(municipio, zona) values ('JUAREZ', 1);
insert into Zona(municipio, zona) values ('SAN NICOLAS', 2);
insert into Zona(municipio, zona) values ('ESCOBEDO', 2);
insert into Zona(municipio, zona) values ('APODACA', 2);
insert into Zona(municipio, zona) values ('SAN PEDRO', 3);
insert into Zona(municipio, zona) values ('SANTA CATARINA', 3);
insert into Zona(municipio, zona) values ('GARCIA', 3);

select * from Contrato;

select distinct zona from Zona;


exec sp_gestion_tarifa @Opc = 'AGREGAR', 
@id = 0, @zona = 1, @año = 2020, @mes = 11,
@cuota = 99, @tipo = 'DOMESTICO',
@basico = 15, @intermedio = 30, @excedente = 80;

exec sp_gestion_tarifa @Opc = 'ELIMINAR', 
@id = 1, @zona = 1, @año = 2022, @mes = 1,
@cuota = 100.50, @tipo = 'DOMESTICO',
@basico = 50, @intermedio = 100, @excedente = 200;

SELECT * FROM Tarifa;
exec sp_gestion_consumo @Opc = 'AGREGAR',
@id = 0, @consumo = 66,
@mes = 12, @año = 2020, @fk_num_ref = 1004;

exec sp_gestion_consumo @Opc = 'ELIMINAR',
@id = 1, @consumo = 200,
@mes = 1, @año = 2022, @fk_num_ref = 1004;

select * from Consumo;

exec sp_get_tarifas @año = '';
exec sp_get_consumos @año = '', @num_ref = '1004';

exec sp_get_tarifas_valid @zona = 1, @mes = 1, @año = 2021, @tipo = 'DOMESTICO';
exec sp_get_consumos_valid @mes = 1, @año = 2021;

--'15 - ' + DATENAME (MONTH, DATEADD(MONTH, MONTH(mes) - 2, '1900-01-01')) as anterior,
--'15 - ' + DATENAME (MONTH, DATEADD(MONTH, MONTH(mes) - 1, '1900-01-01')) as actual

--SELECT
--LAG( ProductSubcategoryID ) OVER( PARTITION BY ProductCategoryID ORDER BY ProductSubCategoryID ) as lag1,
--ProductSubCategoryID,
--LAG( ProductSubcategoryID , 2 ) OVER( PARTITION BY ProductCategoryID ORDER BY ProductSubCategoryID ) as lag2,
--ProductSubCategoryID,
--LAG( ProductSubcategoryID , 2, 100 ) OVER( PARTITION BY ProductCategoryID ORDER BY ProductSubCategoryID ) as lag3,
-- * FROM Production.ProductSubcategory

--REPORTE DE CONSUMOS
select * from Consumo;
select 
	cons.año, 
	cons.mes, 
	cont.medidor, 
	lag(cons.consumo, 1, 0) over (order by year(mes)) as anterior,
	cons.consumo as actual
from Consumo cons
inner join Contrato cont
on cont.num_ref = cons.fk_num_ref
where cons.año = 2021;


select 
	cons.año, 
	cons.mes, 
	cont.medidor, 
	lag(cons.consumo, 1, 0) over (partition by cons.fk_num_ref order by year(cont.medidor), año, mes) as anterior,
	cons.consumo as actual
from Consumo cons
inner join Contrato cont
on cont.num_ref = cons.fk_num_ref
where cons.año = 2021;

select * from Tarifa;
select año, mes, zona, cuota, tipo, basico, intermedio, excedente 
from Tarifa
where año = 2021
order by año, mes;

--REPORTE DE TARIFAS -- MAL
select 
	cons.año, 
	cons.mes, 
	cont.medidor, 
	z.zona,
	cont.tipo,
	dbo.fn_get_cuota(z.zona, cons.mes, cons.año, cont.tipo) as cuota_fija,
	dbo.fn_get_basico(z.zona, cons.mes, cons.año, cont.tipo) as basico,
	dbo.fn_get_intermedio(z.zona, cons.mes, cons.año, cont.tipo) as intermedio,
	dbo.fn_get_excedente(z.zona, cons.mes, cons.año, cont.tipo) as excedente
from Consumo cons
inner join Contrato cont
on cont.num_ref = cons.fk_num_ref
inner join Zona z
on cont.fk_municipio = z.municipio
where dbo.fn_get_cuota(z.zona, cons.mes, cons.año, cont.tipo) is not null
and año = 2020
order by año, mes;

select * from Consumo;


select * from Consumo;

truncate table Consumo;

exec sp_get_consumos @año = '', @num_ref = '1004';
exec sp_get_cliente_contrato_cb @buscar = '';
exec sp_reporte_consumos @año = '';
exec sp_reporte_tarifas @año = '';




--declare @sub_basico float = (select dbo.fn_get_basico(z.zona, cons.mes, cons.año, cont.tipo) from Consumo cons
--inner join Contrato cont
--on cont.num_ref = cons.fk_num_ref
--inner join Zona z
--on cont.fk_municipio = z.municipio);

--declare @sub_intermedio float = (select dbo.fn_get_intermedio(z.zona, cons.mes, cons.año, cont.tipo) from Consumo cons
--inner join Contrato cont
--on cont.num_ref = cons.fk_num_ref
--inner join Zona z
--on cont.fk_municipio = z.municipio);

--declare @sub_excedente float = (select dbo.fn_get_excedente(z.zona, cons.mes, cons.año, cont.tipo) from Consumo cons
--inner join Contrato cont
--on cont.num_ref = cons.fk_num_ref
--inner join Zona z
--on cont.fk_municipio = z.municipio);


declare @cons_basico money;
declare @cons_intermedio money;
declare @cons_excedente money;
set @cons_basico = (select iif(cons.consumo <= 200, cons.consumo, 200) as total from Consumo);
set @cons_intermedio = (select iif(cons.consumo > 200 and cons.consumo <= 350, cons.consumo - 200, 0) as total from Consumo cons where id = 1);
set @cons_excedente = (select iif(cons.consumo > 350, cons.consumo - 350, 0) as total from Consumo cons where id = 1);
--select @cons_basico, @cons_intermedio, @cons_excedente;


--select @sub_basico, @sub_intermedio, @sub_excedente;
--REPORTE HISTORICO
select 
cons.año, --
cons.mes, --
cons.consumo, --
rec.fk_contrato, --
(
	(iif(cons.consumo <= 200, cons.consumo, 200) * tar.basico) + 
	(iif(cons.consumo > 200 and cons.consumo <= 350, cons.consumo - 200, 0) * tar.intermedio) + 
	(iif(cons.consumo > 350, cons.consumo - 350, 0) * tar.excedente) + 
	tar.cuota
) as total, --
rec.pagado as cant_pagada,
rec.total_pago - rec.pagado as pendiente_pago
from Recibo rec
inner join Consumo cons on rec.fk_consumo = cons.id
inner join Tarifa tar on rec.fk_tarifa = tar.id
inner join Contrato cont on rec.fk_contrato = cont.num_ref
order by cons.fk_num_ref, año, mes;

--REPORTE GENERAL
select 
	cons.año,
	cons.mes,
	z.zona,
	cont.tipo,
	rec.pagado,
	rec.total_pago - rec.pagado as pendiente_pago
from Recibo rec
inner join Consumo cons on rec.fk_consumo = cons.id
inner join Tarifa tar on rec.fk_tarifa = tar.id
inner join Contrato cont on rec.fk_contrato = cont.num_ref
inner join Zona z on cont.fk_municipio = z.municipio
order by cons.fk_num_ref, cons.año, cons.mes;

select * from Consumo;
select * from Contrato;
select * from Tarifa;
select * from Recibo;

insert into Recibo(mes, año, total_pago, pagado, fk_contrato, fk_tarifa, fk_consumo)
values(1, 2021, 4350.5, 4000, 1004, 2, 1)

select 
año,
mes,
consumo,
fk_num_ref,
iif(cons.consumo <= 200, cons.consumo, 200) as total,
iif(cons.consumo > 200 and cons.consumo <= 350, cons.consumo - 200, 0) as cant_pagada,
iif(cons.consumo > 350, cons.consumo - 350, 0) as pendiente_pago
from Consumo cons
inner join Contrato cont
on cons.fk_num_ref = cont.num_ref;

IIF(per_moral = 0, 'NO', 'SI')

select 5*2 as total

exec sp_reporte_historico @año = '', @num_ref ='1004'
exec sp_reporte_general @año = '2021', @mes = '1', @tipo = 'DOMESTICO';

--Registrar recibo
exec sp_get_consumos @año = '2021', @num_ref = '1004'; --quiza no, en definitiva no
exec sp_get_contrato_single @num_ref = 1004; --Este si
exec sp_get_tarifas_valid @zona = 1, @mes = 1, @año = 2021, @tipo = 'DOMESTICO'; --Este si
exec sp_get_cliente_single @id_cliente = 10000; --tambien

select 
	re.id, 
	re.año, 
	re.mes,
	cont.medidor,
	re.total_pago, 
	re.pagado
from Usuario us 
inner join Cliente cl on us.id = cl.fk_usuario
inner join Contrato cont on cl.id = cont.fk_cliente
inner join Recibo re on re.fk_contrato = cont.num_ref
where us.id = 1000;

select * from Contrato;
--Calculo de total del recibo
--REPORTE HISTORICO
select 
(
	(iif(cons.consumo <= 200, cons.consumo, 200) * tar.basico) + 
	(iif(cons.consumo > 200 and cons.consumo <= 350, cons.consumo - 200, 0) * tar.intermedio) + 
	(iif(cons.consumo > 350, cons.consumo - 350, 0) * tar.excedente) + 
	tar.cuota
) as total
from Recibo rec
inner join Consumo cons on rec.fk_consumo = cons.id
inner join Tarifa tar on rec.fk_tarifa = tar.id
inner join Contrato cont on rec.fk_contrato = cont.num_ref
order by cons.fk_num_ref, cons.año, cons.mes;

select num_ref, medidor, tipo from Contrato;

select * from Consumo;

select * from Empleado;
select * from Cliente;

select * from Zona_v2;
exec sp_gestion_zona @Opc = 'MODIFICAR', @id = 1, @nombre = 'METROPOLITANA';
exec sp_gestion_zona @Opc = 'AGREGAR', @id = 0, @nombre = 'NORTE';
exec sp_gestion_zona @Opc = 'AGREGAR', @id = 0, @nombre = 'SUR';
exec sp_gestion_zona @Opc = 'AGREGAR', @id = 0, @nombre = 'ZONA 3';
exec sp_gestion_zona @Opc = 'AGREGAR', @id = 0, @nombre = 'ZONA 4';
exec sp_gestion_zona @Opc = 'AGREGAR', @id = 0, @nombre = 'ZONA 5';
exec sp_gestion_zona @Opc = 'AGREGAR', @id = 0, @nombre = 'ZONA 6';
exec sp_gestion_zona @Opc = 'AGREGAR', @id = 0, @nombre = 'ZONA EME';
exec sp_gestion_zona @Opc = 'AGREGAR', @id = 0, @nombre = 'ZONA GENERAL';
exec sp_gestion_zona @Opc = 'AGREGAR', @id = 0, @nombre = 'ZONA H';
exec sp_gestion_zona @Opc = 'AGREGAR', @id = 0, @nombre = 'ZONA LOS';
exec sp_gestion_zona @Opc = 'AGREGAR', @id = 0, @nombre = 'ZONA PE';

exec sp_gestion_municipio @Opc = 'AGREGAR', @id = 0, @municipio = 'ANAHUAC', @zona = 'NORTE';
exec sp_gestion_municipio @Opc = 'AGREGAR', @id = 0, @municipio = 'APODACA', @zona = 'METROPOLITANA';
exec sp_gestion_municipio @Opc = 'AGREGAR', @id = 0, @municipio = 'CIENEGA DE FLORES', @zona = 'NORTE';
exec sp_gestion_municipio @Opc = 'AGREGAR', @id = 0, @municipio = 'DOCTOR ARROYO', @zona = 'SUR';
exec sp_gestion_municipio @Opc = 'AGREGAR', @id = 0, @municipio = 'GARCIA', @zona = 'METROPOLITANA';
exec sp_gestion_municipio @Opc = 'AGREGAR', @id = 0, @municipio = 'GENERAL ESCOBEDO', @zona = 'METROPOLITANA';
exec sp_gestion_municipio @Opc = 'AGREGAR', @id = 0, @municipio = 'GUADALUPE', @zona = 'METROPOLITANA';
exec sp_gestion_municipio @Opc = 'AGREGAR', @id = 0, @municipio = 'HUALAHUISES', @zona = 'SUR';
exec sp_gestion_municipio @Opc = 'AGREGAR', @id = 0, @municipio = 'LINARES', @zona = 'SUR';
exec sp_gestion_municipio @Opc = 'AGREGAR', @id = 0, @municipio = 'MONTEMORELOS', @zona = 'SUR';
exec sp_gestion_municipio @Opc = 'AGREGAR', @id = 0, @municipio = 'MONTERREY', @zona = 'METROPOLITANA';
exec sp_gestion_municipio @Opc = 'AGREGAR', @id = 0, @municipio = 'SABINAS HIDALGO', @zona = 'NORTE';
exec sp_gestion_municipio @Opc = 'AGREGAR', @id = 0, @municipio = 'SALINAS VICTORIA', @zona = 'NORTE';
exec sp_gestion_municipio @Opc = 'AGREGAR', @id = 0, @municipio = 'SAN NICOLAS DE LOS GARZA', @zona = 'METROPOLITANA';
exec sp_gestion_municipio @Opc = 'AGREGAR', @id = 0, @municipio = 'SAN PEDRO GARZA GARCIA', @zona = 'METROPOLITANA';
exec sp_gestion_municipio @Opc = 'AGREGAR', @id = 0, @municipio = 'SANTA CATARINA', @zona = 'METROPOLITANA';
exec sp_gestion_municipio @Opc = 'AGREGAR', @id = 0, @municipio = 'SANTIAGO', @zona = 'METROPOLITANA';
exec sp_gestion_municipio @Opc = 'AGREGAR', @id = 0, @municipio = 'VALLECILLO', @zona = 'ZONA 6';
exec sp_gestion_municipio @Opc = 'AGREGAR', @id = 0, @municipio = 'VILLALDAMA', @zona = 'ZONA 6';
exec sp_get_municipios;
exec sp_get_zonas_v2;


--funcionales 
select * from Tarifa;

exec sp_gestion_tarifa @Opc = 'AGREGAR', 
@id = 0, @zona = 1, @año = 2020, @mes = 6,
@cuota = 30,
@basico = 20, @intermedio = 45, @excedente = 60;

exec sp_get_tarifas @año = '';
exec sp_get_tarifas_valid @zona = 'METROPOLITANA', @mes = 11, @año = 2020;
exec sp_reporte_tarifas @año = '2021';
exec sp_reporte_historico @año = '', @num_ref ='1004'

exec sp_reporte_general @año = '2021', @mes = '1', @tipo = 'DOMESTICO';

select tar.id, tar.zona, tar.mes, tar.año, tar.cuota, tar.basico, tar.intermedio, tar.excedente
from Tarifa tar left join Zona_v2 zon on tar.zona = zon.id
where zon.zona = 'METROPOLITANA' and mes = 6 and año = 2021;

select * from Contrato;
	