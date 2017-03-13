use Parcial2Db;

create table Retenciones(
RetencionesId int identity (1,1) primary key,
Descripcion varchar (30),
Valor varchar(30)
);

create table TiposEmails(
TipoId int identity (1,1) primary key,
Descripcion varchar (30)
);