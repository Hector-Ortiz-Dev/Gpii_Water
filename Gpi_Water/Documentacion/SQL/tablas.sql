create database gpi_water;

use gpi_water;

create table StatusUsuario(
	id int identity(1, 1),
	nombre varchar(30) not null

	primary key(id)
);
drop table StatusUsuario;

create table Usuario(
	id int identity(1000, 1) not null,
	usuario varchar(30) unique not null,
	contraseña varchar(30) not null,
	nombre varchar(30) not null,
	apellido_p varchar(30) not null,
	apellido_m varchar(30) not null,
	f_nacimiento date not null,
	genero varchar(30) not null,

	--f_alta date default getdate(),
	f_alta_mod datetime default getdate(),
	intento int default 0,
	recordar bit default 0, --0 : falso, 1 : verdadero

	fk_status int default 1,

	primary key(id),
	foreign key(fk_status) references StatusUsuario(id)
);
drop table Usuario;

--alter table Usuario add f_alta_mod datetime default getdate();

create table Administrador(
	id int identity(10000, 1),
	tipo varchar(20) not null,

	fk_usuario int not null

	primary key(id),
	foreign key(fk_usuario) references Usuario(id)
);
drop table Administrador;

create table Empleado(
	id int identity(10000, 1),
	domicilio varchar(150) not null,

	fk_usuario int not null

	primary key(id),
	foreign key(fk_usuario) references Usuario(id)
);
drop table Empleado;

create table Cliente(
	id int identity(10000, 1),
	email varchar(30) unique not null,
	curp varchar(18) unique not null,--GOLA980308HNLNSL08 //cliente
	per_moral bit default 0, --0 : falso, 1 : verdadero
	institucion varchar(50),
	rfc varchar(13) unique not null,--GOLA980308HNLNSL08 //cliente

	fk_usuario int not null

	primary key(id),
	foreign key(fk_usuario) references Usuario(id)
);
drop table Cliente;

create table Contrato(
	num_ref int identity(1000,1),
	medidor int unique not null,
	tipo varchar(30) not null,
	categoria varchar(1) not null,
	--municipio varchar(30) not null,
	cod_postal int not null,
	colonia varchar(50) not null,
	calle varchar(50) not null,
	num_ext int not null,
	activo bit default 1,

	fk_cliente int not null,
	fk_municipio varchar(30) not null,

	primary key(num_ref),
	foreign key(fk_cliente) references Cliente(id),
	foreign key(fk_municipio) references Zona(municipio)
);
drop table Contrato;

alter table Contrato drop column fk_municipio;
select * from Contrato;
alter table Contrato add fk_ciudad int not null default 1;
--ALTER TABLE Contrato ALTER COLUMN fk_municipio int NOT NULL;
--alter table Contrato add foreign key(fk_municipio) references Municipio(id);
--select * from Municipio;
select con.num_ref, con.calle, con.num_ext, mun.municipio, zon.zona
from Contrato con
inner join Municipio mun on con.fk_ciudad = mun.id
inner join Zona_v2 zon on mun.fk_zona = zon.id;

create table Zona(
	--id int identity(1,1),
	municipio varchar(30) unique not null,
	zona int not null,

	primary key(municipio)
);
drop table Zona;

create table Tarifa(
	id int identity(1,1),
	zona int not null,
	año int not null,
	mes int not null,
	cuota money not null,
	tipo varchar(20) not null,
	basico float not null,
	intermedio float not null,
	excedente float not null,

	primary key(id)
);
drop table Tarifa;
alter table Tarifa drop column tipo;
select * from Tarifa;

create table Consumo(
	id int identity(1,1),
	consumo int not null,
	mes int not null,
	año int not null,

	fk_num_ref int not null,

	primary key(id),
	foreign key(fk_num_ref) references Contrato(num_ref)
);

drop table Recibo;
create table Recibo
(
	id int identity(1,1),
	mes int not null,
	año int not null,
	total_pago money,
	pagado money default 0,

	fk_contrato int not null,
	fk_tarifa int not null,
	fk_consumo int not null,

	primary key(id),
	foreign key(fk_contrato) references Contrato(num_ref),
	foreign key(fk_tarifa) references Tarifa(id),
	foreign key(fk_consumo) references Consumo(id)
)

create table Zona_v2(
	id int identity(1, 1),
	zona varchar(20) unique not null,

	primary key(id)
);

create table Municipio(
	id int identity(1, 1),
	municipio varchar(20) not null,

	fk_zona int not null,

	primary key(id),
	foreign key(fk_zona) references Zona_v2(id)
);

declare @zona varchar(20) = (select zona from Zona_v2 where id = 2);
declare @zona int = (select id from Zona_v2 where zona = 'SUR');
select @zona as zona_nombre;