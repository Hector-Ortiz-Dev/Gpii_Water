use gpi_water;

drop proc sp_login;
create procedure sp_login(@user varchar(30), @pass varchar(30), @tipo_user varchar(20))
as
begin
	if @tipo_user = 'ADMINISTRADOR'
	begin
		select u.id, u.usuario, u.recordar, u.intento, a.tipo, s.nombre as 'status'
			from Usuario u
			inner join Administrador a
			on u.id = a.fk_usuario
			inner join StatusUsuario s
			on s.id = u.fk_status
		where u.usuario = @user and u.contraseña = @pass;
	end

	else if @tipo_user = 'EMPLEADO'
	begin
		select u.id, u.usuario, u.recordar, u.intento, 'EMPLEADO' as tipo, s.nombre as 'status'
			from Usuario u
			inner join Empleado e
			on u.id = e.fk_usuario
			inner join StatusUsuario s
			on s.id = u.fk_status
		where u.usuario = @user and u.contraseña = @pass;
	end

	else if @tipo_user = 'CLIENTE'
	begin
		select u.id, u.usuario, u.recordar, u.intento, 'CLIENTE' as tipo, s.nombre as 'status'
			from Usuario u
			inner join Cliente c
			on u.id = c.fk_usuario
			inner join StatusUsuario s
			on s.id = u.fk_status
		where u.usuario = @user and u.contraseña = @pass;
	end
end
go
create procedure sp_login(@user varchar(30), @pass varchar(30), @tipo_user varchar(20))
as
begin
	--Si el usuario con la contraseña no existen...
	if not exists(select id from Usuario where usuario = @user and contraseña = @pass)
	begin
		--Aumenta intentos
		update Usuario set intento += 1 where usuario = @user;
		--Si los intentos llegan a 3 o mayor...
		if exists(select intento from Usuario where intento >= 3 and usuario = @user)
		begin
			--El usuario se banea
			update Usuario set fk_status = 2, intento = 0 where usuario = @user;
		end
	end

	else
	begin
		--Intentos se regresa a 0 si existe usuario y contraseña
		update Usuario set intento = 0 where usuario = @user;

		--Condiciones para traer a los usuarios, si son ADMINISTRADOR, EMPLEADO o CLIENTE
		if @tipo_user = 'ADMINISTRADOR'
		begin
			update Usuario set fk_status = 1, intento = 0 where usuario = @user;
			
			select u.id, u.usuario, u.recordar, u.intento, a.tipo, s.nombre as 'status'
				from Usuario u
				inner join Administrador a
				on u.id = a.fk_usuario
				inner join StatusUsuario s
				on s.id = u.fk_status
			where u.usuario = @user and u.contraseña = @pass;
		end

		else if @tipo_user = 'EMPLEADO'
		begin
			select u.id, u.usuario, u.recordar, u.intento, 'EMPLEADO' as tipo, s.nombre as 'status'
				from Usuario u
				inner join Empleado e
				on u.id = e.fk_usuario
				inner join StatusUsuario s
				on s.id = u.fk_status
			where u.usuario = @user and u.contraseña = @pass;
		end

		else if @tipo_user = 'CLIENTE'
		begin
			select u.id, u.usuario, u.recordar, u.intento, 'CLIENTE' as tipo, s.nombre as 'status'
				from Usuario u
				inner join Cliente c
				on u.id = c.fk_usuario
				inner join StatusUsuario s
				on s.id = u.fk_status
			where u.usuario = @user and u.contraseña = @pass;
		end
	end
end
go

drop proc sp_intentos;
create procedure sp_intentos(@user varchar(30))
as
begin
	update Usuario set intento += 1 where usuario = @user;

	if exists(select intento from Usuario where intento >= 3 and usuario = @user)
	begin
		update Usuario set fk_status = 2, intento = 0 where usuario = @user;

		select u.id, u.usuario, s.nombre as 'status'
				from Usuario u
				inner join StatusUsuario s
				on s.id = u.fk_status
			where u.usuario = @user;
	end
end
go

create procedure sp_logued(@user varchar(30))
as
begin
	update Usuario set intento = 0 where usuario = @user;
end
go

create procedure sp_recordar_pass(@user varchar(30), @pass varchar(30), @tipo_user varchar(20), @recordar bit)
as
begin
	--Condicionales
	if @tipo_user = 'ADMINISTRADOR'
	begin
		update u
		set u.recordar = @recordar
		from Usuario u
		inner join Administrador a
			on u.id = a.fk_usuario
		where u.usuario = @user and u.contraseña = @pass;
	end

	if @tipo_user = 'EMPLEADO'
	begin
		update u
		set u.recordar = @recordar
		from Usuario u
		inner join Empleado e
			on u.id = e.fk_usuario
		where u.usuario = @user and u.contraseña = @pass;
	end

	if @tipo_user = 'CLIENTE'
	begin
		update u
		set u.recordar = @recordar
		from Usuario u
		inner join Cliente c
			on u.id = c.fk_usuario
		where u.usuario = @user and u.contraseña = @pass;
	end
end
go

create procedure sp_get_pass(@user varchar(30))
as
begin
	select contraseña from Usuario where usuario = @user and recordar = 1;
end
go

create procedure sp_gestion_empleado
(
	@Opc varchar(20),
	@id int,
	@user varchar(30),
	@pass varchar(30),
	@nombre varchar(30),
	@apellido_p varchar(30),
	@apellido_m varchar(30),
	@f_nacimiento date,
	@genero varchar(30),
	@domicilio varchar(150)
)
as
begin
	if @Opc = 'AGREGAR'
	begin
		insert into Usuario(usuario, contraseña, nombre, apellido_p, apellido_m, f_nacimiento, genero) 
		values (@user, @pass, @nombre, @apellido_p, @apellido_m, @f_nacimiento, @genero);

		declare @id_usuario int = (select id from Usuario where usuario = @user and contraseña = @pass);

		insert into Empleado(domicilio, fk_usuario)
		values(@domicilio, @id_usuario);
	end

	else if @Opc = 'MODIFICAR'
	begin
		update u
		set u.usuario = @user,
		u.nombre = @nombre,
		u.apellido_p = @apellido_p,
		u.apellido_m = @apellido_m,
		u.f_nacimiento = @f_nacimiento,
		u.genero = @genero
		from Usuario u
		where u.id = @id;

		update e
		set e.domicilio = @domicilio
		from Empleado e
		where e.fk_usuario = @id;
	end

	else if @Opc = 'ELIMINAR'
	begin
		delete from Empleado where fk_usuario = @id;
		--delete from Usuario where id = @id;
	end
end
go

create procedure sp_gestion_cliente
(
	@Opc varchar(20),
	@id int,
	@user varchar(30),
	@pass varchar(30),
	@nombre varchar(30),
	@apellido_p varchar(30),
	@apellido_m varchar(30),
	@f_nacimiento date,
	@genero varchar(30),
	@email varchar(30), --
	@curp varchar(18), --
	@per_moral bit, --
	@institucion varchar(50), --
	@rfc varchar(13) --
)
as
begin
	if @Opc = 'AGREGAR'
	begin
		insert into Usuario(usuario, contraseña, nombre, apellido_p, apellido_m, f_nacimiento, genero) 
		values (@user, @pass, @nombre, @apellido_p, @apellido_m, @f_nacimiento, @genero);

		declare @id_usuario int = (select id from Usuario where usuario = @user and contraseña = @pass);

		if @per_moral = 0
		begin
			insert into Cliente(email, curp, rfc, fk_usuario) 
			values(@email, @curp, @rfc, @id_usuario);
		end

		else
		begin
			insert into Cliente(email, curp, per_moral, institucion, rfc, fk_usuario) 
			values(@email, @curp, @per_moral, @institucion, @rfc, @id_usuario);
		end
	end

	else if @Opc = 'MODIFICAR'
	begin
		update u
		set u.usuario = @user,
		u.nombre = @nombre,
		u.apellido_p = @apellido_p,
		u.apellido_m = @apellido_m,
		u.f_nacimiento = @f_nacimiento,
		u.genero = @genero
		from Usuario u
		where u.id = @id;

		if @per_moral = 0
		begin
			update c
			set c.email = @email,
			c.curp = @curp,
			c.per_moral = 0,
			c.institucion = NULL,
			c.rfc = @rfc
			from Cliente c
			where c.fk_usuario = @id;
		end

		else
		begin
			update c
			set c.email = @email,
			c.curp = @curp,
			c.per_moral = 1,
			c.institucion = @institucion,
			c.rfc = @rfc
			from Cliente c
			where c.fk_usuario = @id;
		end
	end

	else if @Opc = 'ELIMINAR'
	begin
		delete from Cliente where fk_usuario = @id;
		--delete from Usuario where id = @id;
	end
end
go

create procedure sp_get_empleados
(
	@buscar varchar(80)
)
as
begin
	if @buscar = ''
	begin
		select u.id, u.usuario, u.nombre, u.apellido_p, u.apellido_m, u.f_nacimiento, u.genero, u.f_alta_mod,
		e.id as id_e, e.domicilio, 
		st.nombre as 'status'
		from Usuario u 
		inner join Empleado e 
		on u.id = e.fk_usuario
		inner join StatusUsuario st
		on st.id = u.fk_status
		where st.nombre != 'BANEADO'
		order by st.nombre asc;
	end

	else 
	begin
		select u.id, u.usuario, u.nombre, u.apellido_p, u.apellido_m, u.f_nacimiento, u.genero, u.f_alta_mod,
		e.id as id_e, e.domicilio, 
		st.nombre as 'status'
		from Usuario u 
		inner join Empleado e 
		on u.id = e.fk_usuario
		inner join StatusUsuario st
		on st.id = u.fk_status
		where u.id like '%' + @buscar + '%'
			or u.usuario like '%' + @buscar + '%'
			or u.nombre + ' ' + u.apellido_p + ' ' + u.apellido_m like '%' + @buscar + '%'
			and st.nombre != 'BANEADO'
		order by st.nombre asc;
	end
end
go

create procedure sp_get_clientes
(
	@buscar varchar(80)
)
as
begin
	if @buscar = ''
	begin
		select u.id, u.usuario, u.nombre, u.apellido_p, u.apellido_m, u.f_nacimiento, u.genero, u.f_alta_mod,
		c.email, c.curp, c.rfc, c.per_moral, c.institucion, c.id as id_c, 
		st.nombre as 'status'
		from Usuario u 
			inner join Cliente c 
			on c.fk_usuario = u.id
			inner join StatusUsuario st
			on st.id = u.fk_status
		where st.nombre != 'BANEADO'
		order by st.nombre asc;
	end

	else
	begin
		select u.id, u.usuario, u.nombre, u.apellido_p, u.apellido_m, u.f_nacimiento, u.genero, u.f_alta_mod,
		c.email, c.curp, c.rfc, c.per_moral, c.institucion, c.id as id_c, 
		st.nombre as 'status'
		from Usuario u 
		inner join Cliente c 
		on c.fk_usuario = u.id
		inner join StatusUsuario st
		on st.id = u.fk_status
		where u.id like '%' + @buscar + '%'
			or u.usuario like '%' + @buscar + '%'
			or u.nombre + ' ' + u.apellido_p + ' ' + u.apellido_m like '%' + @buscar + '%'
			and st.nombre != 'BANEADO'
		order by st.nombre asc;
	end
end
go

create procedure sp_get_cliente_single
(
	@id_cliente int
)
as
begin
	select 
		cl.id, 
		cl.email, 
		cl.curp, 
		cl.rfc, 
		us.usuario,
		us.nombre + ' ' + us.apellido_p + ' ' + us.apellido_m as nombre
	from Cliente cl 
	inner join Usuario us on cl.fk_usuario = us.id
	inner join StatusUsuario st on us.fk_status = st.id
	where cl.id = @id_cliente;
end
go

drop proc sp_get_clientes_cb;
create procedure sp_get_clientes_cb
(
	@buscar varchar(80)
)
as
begin
	--select dbo.fn_id_nombre_completo(1000) as 'nombre_completo' from Usuario where id = 1000;
	if @buscar = ''
	begin
		select c.id, dbo.fn_id_nombre_cliente(u.id) as nombre , st.nombre as 'status'
		from Usuario u 
			inner join Cliente c 
			on c.fk_usuario = u.id
			inner join StatusUsuario st
			on st.id = u.fk_status
		where st.nombre != 'BAJA'
		order by u.id asc;
	end

	else
	begin
		--declare @id_usuario int = (select id from Usuario where id like '%' + @buscar + '%' or  nombre + ' ' + apellido_p + ' ' + apellido_m like '%' + @buscar + '%');
		--dbo.fn_id_nombre_completo(id)
		select c.id, dbo.fn_id_nombre_cliente(u.id) as nombre, st.nombre as 'status'
		from Usuario u 
		inner join Cliente c 
		on c.fk_usuario = u.id
		inner join StatusUsuario st
		on st.id = u.fk_status
		where u.id like '%' + @buscar + '%'
			or u.usuario like '%' + @buscar + '%'
			or u.nombre + ' ' + u.apellido_p + ' ' + u.apellido_m like '%' + @buscar + '%'
			and st.nombre != 'BAJA'
		order by u.id asc;
	end
end
go

drop proc sp_alta_cliente_contrato;
create procedure sp_alta_cliente_contrato
(
	--Usuario
	@user varchar(30),
	@pass varchar(30),
	@nombre varchar(30),
	@apellido_p varchar(30),
	@apellido_m varchar(30),
	@f_nacimiento date,
	@genero varchar(30),
	--Cliente
	@email varchar(30),
	@curp varchar(18),
	@per_moral bit,
	@institucion varchar(50),
	@rfc varchar(13),
	--Contrato
	@medidor int,
	@tipo varchar(30),
	@categoria varchar(1),
	@municipio varchar(30),
	@cod_postal int,
	@colonia varchar(50),
	@calle varchar(50),
	@num_ext int
)
as 
begin
	--Creamos el usuario en usuario
	insert into Usuario(usuario, contraseña, nombre, apellido_p, apellido_m, f_nacimiento, genero) 
	values (@user, @pass, @nombre, @apellido_p, @apellido_m, @f_nacimiento, @genero);

	--Obtenemos el id del usuario creado
	declare @id_usuario int = (select id from Usuario where usuario = @user and contraseña = @pass);

	--Si es persona fisica...
	if @per_moral = 0
	begin
		insert into Cliente(email, curp, rfc, fk_usuario) 
		values(@email, @curp, @rfc, @id_usuario);
	end
	--si es persona moral...
	else
	begin
		insert into Cliente(email, curp, per_moral, institucion, rfc, fk_usuario) 
		values(@email, @curp, @per_moral, @institucion, @rfc, @id_usuario);
	end
	
	declare @id_cliente int = (select id from Cliente where email = @email and curp = @curp and rfc = @rfc);
	insert into Contrato(medidor, tipo, categoria, fk_municipio, cod_postal, colonia, calle, num_ext, fk_cliente)
	values(@medidor, @tipo, @categoria, @municipio, @cod_postal, @colonia, @calle, @num_ext, @id_cliente);
end
go

drop proc sp_gestion_contrato;
create procedure sp_gestion_contrato
(
	@Opc varchar(20),
	@num_ref int,
	@medidor int,
	@tipo varchar(30),
	@categoria varchar(1),
	@municipio varchar(30),
	@cod_postal int,
	@colonia varchar(50),
	@calle varchar(50),
	@num_ext int,
	@id_cliente int
)
as
begin
	if @Opc = 'AGREGAR'
	begin
		insert into Contrato(medidor, tipo, categoria, fk_municipio, cod_postal, colonia, calle, num_ext, fk_cliente)
		values(@medidor, @tipo, @categoria, @municipio, @cod_postal, @colonia, @calle, @num_ext, @id_cliente);
	end

	else if @Opc = 'MODIFICAR'
	begin
		update c
		set c.medidor = @medidor,
		c.tipo = @tipo,
		c.categoria = @categoria,
		c.fk_municipio = @municipio,
		c.cod_postal = @cod_postal,
		c.colonia = @colonia,
		c.calle = @calle,
		c.num_ext = @num_ext
		from Contrato c
		where c.num_ref = @num_ref;
	end

	else if @Opc = 'ELIMINAR'
	begin
		delete from Contrato where num_ref = @num_ref;
	end
end
go

DROP PROC sp_get_baneos;
create procedure sp_get_baneos
(
	@buscar varchar(50),
	@filtro varchar(30)
)
as
begin
	if @buscar = ''
	begin
		if @filtro = 'SELECCIONAR'
		begin
			select u.id, u.usuario, u.nombre, u.apellido_p, u.apellido_m, st.nombre as 'status' 
			from Usuario u
				inner join StatusUsuario st
				on u.fk_status = st.id
			where st.nombre = 'BANEADO';
		end

		else if @filtro = 'EMPLEADOS'
		begin
			select u.id, u.usuario, u.nombre, u.apellido_p, u.apellido_m, st.nombre as 'status' 
			from Usuario u
				inner join StatusUsuario st
				on u.fk_status = st.id
				inner join Empleado e
				on e.fk_usuario = u.id
			where st.nombre = 'BANEADO';
		end

		else if @filtro = 'CLIENTES'
		begin
			select u.id, u.usuario, u.nombre, u.apellido_p, u.apellido_m, st.nombre as 'status' 
			from Usuario u
				inner join StatusUsuario st
				on u.fk_status = st.id
				inner join Cliente c
				on c.fk_usuario = u.id
			where st.nombre = 'BANEADO';
		end
	end
		
	else
	begin
		if @filtro = 'SELECCIONAR'
		begin
			select u.id, u.usuario, u.nombre, u.apellido_p, u.apellido_m, st.nombre as 'status' 
			from Usuario u
				inner join StatusUsuario st
				on u.fk_status = st.id
			where st.nombre = 'BANEADO'
				and (u.id like '%' + @buscar + '%'
				or u.nombre + ' ' + u.apellido_p + ' ' + u.apellido_m like '%' + @buscar + '%'
				or u.usuario like '%' + @buscar + '%');
		end

		else if @filtro = 'EMPLEADOS'
		begin
			select u.id, u.usuario, u.nombre, u.apellido_p, u.apellido_m, st.nombre as 'status' 
			from Usuario u
				inner join StatusUsuario st
				on u.fk_status = st.id
				inner join Empleado e
				on e.fk_usuario = u.id
			where st.nombre = 'BANEADO'
				and (u.id like '%' + @buscar + '%'
				or u.nombre + ' ' + u.apellido_p + ' ' + u.apellido_m like '%' + @buscar + '%'
				or u.usuario like '%' + @buscar + '%');
		end

		else if @filtro = 'CLIENTES'
		begin
			select u.id, u.usuario, u.nombre, u.apellido_p, u.apellido_m, st.nombre as 'status' 
			from Usuario u
				inner join StatusUsuario st
				on u.fk_status = st.id
				inner join Cliente c
				on c.fk_usuario = u.id
			where st.nombre = 'BANEADO'
				and (u.id like '%' + @buscar + '%'
				or u.nombre + ' ' + u.apellido_p + ' ' + u.apellido_m like '%' + @buscar + '%'
				or u.usuario like '%' + @buscar + '%');
		end
	end
end
go

create procedure sp_desbanear
(
	@id int
)
as
begin
	update u
		set u.fk_status = 1
	from Usuario u
	where u.id = @id;
end
go

drop proc sp_get_contratos;
create procedure sp_get_contratos
(
	@id_cliente varchar(10)
)
as
begin
	if @id_cliente = ''
	begin
		select num_ref, medidor, tipo, categoria, fk_municipio, cod_postal, colonia, calle, num_ext, IIF(activo = 0, 'BAJA', 'ALTA') as activo, fk_cliente 
		from Contrato;
	end

	else
	begin
		select num_ref, medidor, tipo, categoria, fk_municipio, cod_postal, colonia, calle, num_ext, IIF(activo = 0, 'BAJA', 'ALTA') as activo, fk_cliente 
		from Contrato where fk_cliente like '%' + @id_cliente + '%';
	end

end
go

create procedure sp_reactiva_contrato
(
	@num_ref int
)
as
begin
	update c
		set c.activo = 1
	from Contrato c
	where c.num_ref = @num_ref;
end
go

drop proc sp_get_zonas;
create procedure sp_get_zonas
as 
begin
	select municipio, zona from Zona order by municipio asc;
end
go

create procedure sp_get_usuarios
as 
begin
	select usuario from Usuario;
end
go

create procedure sp_get_curps
as 
begin
	select curp from Cliente;
end
go

create procedure sp_get_rfcs
as 
begin
	select rfc from Cliente;
end
go

create procedure sp_get_medidores
as
begin
	select medidor from Contrato;
end
go

create procedure sp_gestion_tarifa
(
	@Opc varchar(20),
	@id int,
	@zona int,
	@año int,
	@mes int,
	@cuota money,
	@tipo varchar(20),
	@basico float,
	@intermedio float,
	@excedente float
)
as
begin
	if @Opc = 'AGREGAR'
	begin
		insert into Tarifa(zona, año, mes, cuota, tipo, basico, intermedio, excedente)
		values(@zona, @año, @mes, @cuota, @tipo, @basico, @intermedio, @excedente);
	end

	else if @Opc = 'MODIFICAR'
	begin
		update t
			set t.zona = @zona,
			t.año = @año,
			t.mes = @mes,
			t.cuota = @cuota,
			t.tipo = @tipo,
			t.basico = @basico,
			t.intermedio = @intermedio,
			t.excedente = @excedente
		from Tarifa t
		where t.id = @id;
	end

	else if @Opc = 'ELIMINAR'
	begin
		delete from Tarifa where id = @id;
	end
end
go

create procedure sp_gestion_consumo
(
	@Opc varchar(20),
	@id int,
	@consumo int,
	@mes int,
	@año int,
	@fk_num_ref int
)
as
begin
	if @Opc = 'AGREGAR'
	begin
		insert into Consumo(consumo, mes, año, fk_num_ref)
		values(@consumo, @mes, @año, @fk_num_ref);
	end

	else if @Opc = 'MODIFICAR'
	begin
		update c
			set c.consumo = @consumo,
			c.mes = @mes,
			c.año = @año
		from Consumo c
		where c.id = @id;
	end

	else if @Opc = 'ELIMINAR'
	begin
		delete from Consumo where id = @id;
	end
end
go

drop proc sp_get_tarifas;
create procedure sp_get_tarifas
(
	@año varchar(10)
)
as
begin
	if @año = ''
	begin
		select id, zona, mes, año, tipo, cuota, basico, intermedio, excedente 
		from Tarifa order by año asc, mes asc;
	end

	else
	begin
		select id, zona, mes, año, tipo, cuota, basico, intermedio, excedente 
		from Tarifa where año like '%' + @año + '%'
		order by año asc, mes asc;
	end
end
go

drop proc sp_get_consumos;
create procedure sp_get_consumos
(
	@año varchar(10),
	@num_ref varchar(10)
)
as 
begin
	if @año = ''
	begin
		select id, consumo, mes, año, fk_num_ref 
		from Consumo 
		where fk_num_ref like '%' + @num_ref + '%'
		order by año asc, mes asc;
	end

	else
	begin
		select id, consumo, mes, año, fk_num_ref 
		from Consumo 
		where año like '%' + @año + '%'
		and fk_num_ref like '%' + @num_ref + '%'
		order by año asc, mes asc;
	end
end

create procedure sp_get_tarifas_valid
(
	@zona int,
	@mes int,
	@año int,
	@tipo varchar(20)
)
as
begin
	select id, zona, mes, año, tipo, cuota, basico, intermedio, excedente
	from Tarifa
	where zona = @zona and mes = @mes and año = @año and tipo = @tipo;
end
go

create procedure sp_get_consumos_valid
(
	@mes int,
	@año int
)
as
begin
	select id, consumo, mes, año, fk_num_ref 
	from Consumo
	where mes = @mes and año = @año;
end
go

drop proc sp_get_cliente_contrato_cb;
create procedure sp_get_cliente_contrato_cb
(
	@buscar varchar(80)
)
as
begin
	--select dbo.fn_id_nombre_completo(1000) as 'nombre_completo' from Usuario where id = 1000;
	if @buscar = ''
	begin
		select cont.num_ref,
			dbo.fn_id_contrato_cliente(cont.num_ref) as nombre, st.nombre as 'status'
		from Contrato cont
		inner join Cliente cl
		on cont.fk_cliente = cl.id
		inner join Usuario us
		on cl.fk_usuario = us.id
		inner join StatusUsuario st
		on st.id = us.fk_status
		where st.nombre != 'BAJA'
		order by cont.num_ref asc;
	end

	else
	begin
		select cont.num_ref,
			dbo.fn_id_contrato_cliente(cont.num_ref) as nombre, st.nombre as 'status'
		from Contrato cont
		inner join Cliente cl
		on cont.fk_cliente = cl.id
		inner join Usuario us
		on cl.fk_usuario = us.id
		inner join StatusUsuario st
		on st.id = us.fk_status
		where cont.num_ref like '%' + @buscar + '%'
			or us.usuario like '%' + @buscar + '%'
			or us.nombre + ' ' + us.apellido_p + ' ' + us.apellido_m like '%' + @buscar + '%'
			and st.nombre != 'BAJA'
		order by cont.num_ref asc;	
	end
end
go

drop proc sp_get_contrato_single
create procedure sp_get_contrato_single
(
	@num_ref int
)
as
begin
	select num_ref, medidor, tipo, categoria, cod_postal, colonia, calle, num_ext, fk_cliente, fk_municipio from Contrato where num_ref = @num_ref;
end
go

drop proc sp_reporte_consumos;
create procedure sp_reporte_consumos
(
	@año varchar(10)
)
as
begin
	if @año = '' or @año = 'TODOS'
	begin
		select 
			cons.año, 
			cons.mes, 
			cont.medidor, 
			lag(cons.consumo, 1, 0) over (partition by cons.fk_num_ref order by year(cont.medidor), año, mes) as anterior,
			cons.consumo as actual
		from Consumo cons
		inner join Contrato cont
		on cont.num_ref = cons.fk_num_ref;
	end

	else
	begin
		select 
			cons.año, 
			cons.mes, 
			cont.medidor, 
			lag(cons.consumo, 1, 0) over (partition by cons.fk_num_ref order by year(cont.medidor), año, mes) as anterior,
			cons.consumo as actual
		from Consumo cons
		inner join Contrato cont
		on cont.num_ref = cons.fk_num_ref
		where cons.año like '%' + @año + '%';
	end
end
go

drop proc sp_reporte_historico
create procedure sp_reporte_historico
(
	@año varchar(10),
	@num_ref varchar(10)
)
as
begin
	if @año = '' or @año = 'TODOS'
	begin
		select 
			cons.año, --
			cons.mes, --
			cons.consumo, --
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
		where rec.fk_contrato like '%' + @num_ref + '%'
		order by cons.fk_num_ref, año, mes;
	end

	else
	begin
		select 
			cons.año, --
			cons.mes, --
			cons.consumo, --
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
		where rec.fk_contrato like '%' + @num_ref + '%' and rec.año like '%' + @año + '%'
		order by cons.fk_num_ref, año, mes;
	end

end
go

create procedure sp_reporte_general
(
	@año varchar(10),
	@mes varchar(10),
	@tipo varchar(20)
)
as
begin
	if @año = '' or @año = 'TODOS'
	begin
		if @mes = '' or @mes = 'TODOS'
		begin
			if @tipo = '' or @tipo = 'TODOS'
			begin
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
			end

			else
			begin
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
				where cont.tipo like '%' + @tipo + '%'
				order by cons.fk_num_ref, cons.año, cons.mes;
			end
		end

		else 
		begin
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
			where (cons.mes like '%' + @mes + '%') and (cont.tipo like '%' + @tipo + '%')
			order by cons.fk_num_ref, cons.año, cons.mes;
		end
	end

	else
	begin
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
		where (cons.año like '%' + @año + '%') and (cons.mes like '%' + @mes + '%') and (cont.tipo like '%' + @tipo + '%')
		order by cons.fk_num_ref, cons.año, cons.mes;
	end
end
go

drop proc sp_reporte_tarifas;
create procedure sp_reporte_tarifas
(
	@año varchar(10)
)
as
begin
	if @año = '' or @año = 'TODOS'
	begin
		select 
			año, mes, zona, cuota, tipo, basico, intermedio, excedente 
		from Tarifa
		order by año, mes;
	end

	else
	begin
		select 
			año, mes, zona, cuota, tipo, basico, intermedio, excedente 
		from Tarifa
		where año like '%' + @año + '%'
		order by año, mes;
	end
end
go

create procedure sp_genera_recibo
(
	@mes int,
	@año int,
	@total_pago money,
	@num_ref int,--
	@id_tarifa int,
	@id_consumo int --
)
as
begin
	if not exists(select mes, año, total_pago, fk_contrato, fk_tarifa, fk_consumo from Recibo where fk_contrato = @num_ref and fk_tarifa = @id_tarifa and fk_consumo = @id_consumo)
	begin
		insert into Recibo(mes, año, total_pago, fk_contrato, fk_tarifa, fk_consumo)
		values(@mes, @año, @total_pago, @num_ref, @id_tarifa, @id_consumo)
	end
end

create procedure sp_gestion_zona
(
	@Opc varchar(20),
	@id int,
	@nombre varchar(20)
)
as
	if @Opc = 'AGREGAR'
	begin
		insert into Zona_v2(zona) values(@nombre);
	end

	else
	begin
		update Zona_v2
			set zona = @nombre
		where id = @id
	end
go

create procedure sp_gestion_municipio
(
	@Opc varchar(20),
	@id int,
	@municipio varchar(20),
	@zona varchar(20)
)
as
	declare @id_zona int = (select id from Zona_v2 where zona = @zona);
	
	if @Opc = 'AGREGAR'
	begin
		insert into Municipio(municipio, fk_zona) values(@municipio, @id_zona);
	end

	else
	begin
		update Municipio
			set municipio = @municipio,
			fk_zona = @id_zona
		where id = @id
	end
go

create procedure sp_get_municipios
as
	select m.id, m.municipio, z.zona
	from Municipio m
	inner join Zona_v2 z on z.id = m.fk_zona; 
go

create procedure sp_get_zonas_v2
as
	select id, zona from Zona_v2;
go

create procedure sp_get_recibos
(
	@id_usuario int
)
as
begin
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
	where us.id = @id_usuario;
end
go

create procedure sp_reporte_historico_cliente
(
	@id_usuario int
)
as
begin
	select 
		re.año, 
		re.mes, 
		con.consumo, 
		re.total_pago, 
		re.pagado, 
		(re.total_pago - re.pagado) as pendiente_pago
	from Usuario us 
	inner join Cliente cl on us.id = cl.fk_usuario
	inner join Contrato cont on cl.id = cont.fk_cliente
	inner join Recibo re on re.fk_contrato = cont.num_ref
	inner join Consumo con on re.fk_consumo = con.id
	where us.id = @id_usuario
	order by con.fk_num_ref, año, mes;
end
go

create procedure sp_pagar_recibo
(
	@id_recibo int,
	@pagado money
)
as
begin
	update Recibo
		set pagado = @pagado
	where id = @id_recibo;
end


--NO NECESARIOS -------------------------------------------------------------
create procedure sp_intentos(@user varchar(30))
as
begin
	update Usuario set intento += 1 where usuario = @user;
	if exists(select intento from Usuario where intento >= 3 and usuario = @user)
	begin
		update Usuario set fk_status = 2, intento = 0 where usuario = @user;

	end
end
go

create procedure sp_logued(@user varchar(30))
as
begin
	update Usuario set intento = 0 where usuario = @user;
end
go