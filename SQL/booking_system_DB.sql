﻿use master;

drop database booking_system;

create database booking_system;

use booking_system;

create table gost (
	id int not null primary key identity(1,1),
	ime varchar (50)not null,
	prezime varchar (50)not null,
	oib varchar (11)not null
);

create table gost_rezervacija (
	gost int not null,
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
);

alter table gost_rezervacija add foreign key (gost) references gost(id);
alter table gost_rezervacija add foreign key (rezervacija) references rezervacija(id);


insert into gost (Ime, Prezime, oib) values
	('Marko','Marković','41455400679'),
	('Petar','Perić','66164136372'),
	('Ana','Horvat','06636100164');

insert into rezervacija (cijena, datum_od, datum_do) values
	('256.56','2023-06-25','2023-07-02'),
	('256.56','2023-06-25','2023-07-02'),
	('256.56','2023-06-25','2023-07-02');

insert into cjenik (datum, cijena) values
	('2023-07-02','256.56'),
	('2023-07-05','180.58'),
	('2023-07-15','150.00');

insert into gost_rezervacija (gost, rezervacija) values
	('1','1'),
	('2','2'),
	('3','3'),
	('3','1');

	select * from rezervacija;
	select * from gost;
	select * from cjenik;
	select * from gost_rezervacija;





