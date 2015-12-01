create database empresa;
go
use empresa;
go

create table tipo_de_pessoa(
	codigo varchar(3),
	descricao varchar(100),
	sigla varchar(3),
	primary key(codigo)
);

select * from tipo_de_pessoa; 