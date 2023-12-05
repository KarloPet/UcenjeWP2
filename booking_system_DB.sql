use master;

drop database booking_system;

create database booking_system;

use booking_system;

create table gost (
	id int not null primary key identity(1,1),
	ime varchar (50)not null,
	prezime varchar (50)not null,
	oib varchar (11)not null,
	grupa int not null
);

create table grupa (
	id int not null primary key identity(1,1),
	rezervacija int not null
);

create table rezervacija (
	id int not null primary key identity(1,1),
	cijena decimal (18,2) not null,
	datum_od datetime not null,
	datum_do datetime not null
);

create table cjenik (
	id int not null primary key identity(1,1),
	datum datetime not null,
	cijena decimal (18,2) not null,
	rezervirano bit not null
);

alter table gost add foreign key (grupa) references grupa(id);
alter table grupa add foreign key (rezervacija) references rezervacija(id);

insert into grupa (rezervacija) values
	('001'),
	('002'),
	('003');

insert into gost (Ime, Prezime, oib, grupa) values
	('Marko','Marković','41455400679','001'),
	('Petar','Perić','66164136372','002'),
	('Ana','Horvat','06636100164','003');

insert into rezervacija (cijena, datum_od, datum_do) values
	('256.56','2023-06-25','2023-07-02'),
	('256.56','2023-06-25','2023-07-02'),
	('256.56','2023-06-25','2023-07-02');

insert into cjenik (datum, cijena, rezervirano) values
	('2023-07-02','256.56','1'),
	('2023-07-05','180.58','1'),
	('2023-07-15','150.00','0');

select a.ime, a.prezime, b.rezervacija
from gost a inner join grupa b
on a.grupa = b.id;



