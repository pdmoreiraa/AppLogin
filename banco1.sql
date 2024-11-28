
create database LoginCore;
use LoginCore;

create table Cliente (
Id int auto_increment primary key,
Nome varchar(50) NOT NULL,
Nascimento DateTime not null,
Sexo char(1),
CPF Varchar(11) not null,
Telefone varchar(14) not null,
Email varchar(50) not null,
Senha varchar(8) not null,
ConfirmacaoSenha varchar(8) not null,
Situacao char(1) not null
);

create table Colaborador (
Id int  auto_increment primary key,
Nome varchar(50) not null,
Email varchar(50) not null,
Senha varchar(8) not null,
Tipo varchar(8) not null
);

insert into Cliente 
values (1, 'Pedro Moreira', '2007-06-18 00:00:00', 'M', 12345678910, 11999999999, 'ph@123.com', 'pd345678', 'pd345678', 'A');