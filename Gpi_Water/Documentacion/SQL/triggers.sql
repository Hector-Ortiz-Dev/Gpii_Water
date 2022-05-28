use gpi_water;

drop trigger tr_baja_empleado;
create trigger tr_baja_empleado
on Empleado
instead of delete
as
begin
	update u
		set u.fk_status = 3
	from Usuario u
	inner join deleted d
	on u.id = d.fk_usuario
	inner join Empleado e
	on e.fk_usuario = d.fk_usuario
	where u.id = d.fk_usuario;
end
go

drop trigger tr_baja_cliente;
create trigger tr_baja_cliente
on Cliente
instead of delete
as 
begin
	update u
		set u.fk_status = 3
	from Usuario u
	inner join deleted d
	on u.id = d.fk_usuario
	inner join Cliente c
	on c.fk_usuario = d.fk_usuario
	where u.id = d.fk_usuario;
end
go

create trigger tr_baja_contrato
on Contrato
instead of delete
as
begin
	update c
		set c.activo = 0
	from Contrato c
	inner join deleted d
	on c.num_ref = d.num_ref
	where c.num_ref = d.num_ref;
end
go

SELECT * FROM sys.triggers