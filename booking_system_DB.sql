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
grupa int not null,
datum_do datetime not null
);

create table cjenik (
id int not null primary key identity(1,1),
datum datetime not null,
cijena decimal (18,2) not null,
rezervirano bit not null
);

alter table gost add foreign key (grupa) references grupa(id);
alter table rezervacija add foreign key (grupa) references grupa(id);


insert into grupa (rezervacija) values
('001'),
('002'),
('003');

insert into gost (Ime, Prezime, oib, grupa) values
('Ana','Androš','76642855863','003'),
('Karlo','Peterfaj','76642855863','002'),
('Ana','Peterfaj','76642855863','001');

select * from rezervacija;
insert into rezervacija (cijena, datum_od, grupa, datum_do) values
('256.56','2023-06-25','001','2023-07-02'),
('256.56','2023-06-25','002','2023-07-02'),
('256.56','2023-06-25','003','2023-07-02');

