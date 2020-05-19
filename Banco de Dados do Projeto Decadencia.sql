create database Filme;

create table usuario (
codigousuario int not null primary key auto_increment,
 nome varchar(15) not null, 
 email varchar(50) not null,
 senha varchar(15) not null); 
 
 insert into usuario(nome, email, senha) values('murilofurlaneto','furlanetomurilo@gmail.com','abc123');
 
create table filmes (
codigofilme int not null primary key auto_increment,
nome varchar(40) not null,
imagem varchar(50) not null,
genero varchar (20) not null,
diretor varchar (50) not null,
sinopse varchar (50) not null,
faixaetaria varchar(20) not null,
duracao varchar(20) not null,
anolanca varchar(20) not null);
