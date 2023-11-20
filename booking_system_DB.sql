--drop edunovawp2;

----use master;

--create database booking_system;

--use booking_system;

--drop table gost;

--create table gost (
--ime varchar (50)not null,
--prezime varchar (50)not null,
--oib int not null primary key identity(1,1),
--grupa int not null
--);

--create table grupa (
--id int not null primary key identity(1,1),
--rezervacija int not null
--);

--create table rezervacija (
--id int not null primary key identity(1,1),
--cijena decimal (18,2) not null,
--datum_od datetime not null,
--datum_do datetime not null
--);

--create table cjenik (
--id int not null primary key identity(1,1),
--datum datetime not null,
--cijena decimal (18,2) not null,
--rezervirano bit not null
--);

--alter table gost add foreign key (grupa) references grupa(id);
--alter table grupa add foreign key (rezervacija) references rezervacija(id);