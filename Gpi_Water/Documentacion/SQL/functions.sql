drop function fn_id_nombre_cliente;

create function fn_id_nombre_cliente(@id int) returns varchar(80)
as
begin
	declare @nombre_completo varchar(80)

	--select @nombre_completo = (cast(id as varchar(10)) + ' - '  + nombre + ' ' + apellido_p + ' ' + apellido_m) from Usuario where id = @id;
	select @nombre_completo = (' ' + cast(c.id as varchar(10)) + ' - '  + u.nombre + ' ' + u.apellido_p + ' ' + u.apellido_m) 
	from Usuario u
	inner join Cliente c
	on u.id = c.fk_usuario
	where u.id = @id;

	return @nombre_completo
end
go



create function fn_get_cuota(@zona int, @mes int, @año int, @tipo varchar(20)) returns money
as
begin
	declare @cuota money

	--select @nombre_completo = (cast(id as varchar(10)) + ' - '  + nombre + ' ' + apellido_p + ' ' + apellido_m) from Usuario where id = @id;
	select @cuota = (cuota)
	from Tarifa
	where zona = @zona
	and mes = @mes
	and año = @año
	and tipo = @tipo;

	return @cuota
end
go

create function fn_get_basico(@zona int, @mes int, @año int, @tipo varchar(20)) returns money
as
begin
	declare @basico money

	select @basico = (basico)
	from Tarifa
	where zona = @zona
	and mes = @mes
	and año = @año
	and tipo = @tipo;

	return @basico
end
go

create function fn_get_intermedio(@zona int, @mes int, @año int, @tipo varchar(20)) returns money
as
begin
	declare @intermedio money

	select @intermedio = (intermedio)
	from Tarifa
	where zona = @zona
	and mes = @mes
	and año = @año
	and tipo = @tipo;

	return @intermedio
end
go

create function fn_get_excedente(@zona int, @mes int, @año int, @tipo varchar(20)) returns money
as
begin
	declare @excedente money

	select @excedente = (excedente)
	from Tarifa
	where zona = @zona
	and mes = @mes
	and año = @año
	and tipo = @tipo;

	return @excedente
end
go

create function fn_get_tipo(@zona int, @mes int, @año int, @tipo varchar(20)) returns money
as
begin
	declare @excedente money

	select @excedente = (excedente)
	from Tarifa
	where zona = @zona
	and mes = @mes
	and año = @año
	and tipo = @tipo;

	return @excedente
end
go

drop function fn_id_contrato_cliente
create function fn_id_contrato_cliente(@id int) returns varchar(80)
as
begin
	declare @nombre_completo varchar(80)

	--select @nombre_completo = (cast(id as varchar(10)) + ' - '  + nombre + ' ' + apellido_p + ' ' + apellido_m) from Usuario where id = @id;
	select @nombre_completo = (' ' + cast(con.num_ref as varchar(10)) + ' - '  + u.nombre + ' ' + u.apellido_p + ' ' + u.apellido_m + '') 
	from Usuario u
	inner join Cliente c
	on u.id = c.fk_usuario
	inner join Contrato con
	on c.id = con.fk_cliente
	where con.num_ref = @id;

	return @nombre_completo
end
go

select id, dbo.fn_id_nombre_completo(id) as 'nombre_completo' from Usuario;

create function fn_id_nombre_completo_prueba() returns varchar(80)
as
begin
	declare @nombre_completo varchar(80)

	select @nombre_completo = (cast(id as varchar(10)) + ' - '  + nombre + ' ' + apellido_p + ' ' + apellido_m) from Usuario;

	--return @nombre_completo
end
go

select  id, dbo.fn_id_nombre_completo_prueba() as 'nombre_completo' from Usuario;
select  * from Usuario;