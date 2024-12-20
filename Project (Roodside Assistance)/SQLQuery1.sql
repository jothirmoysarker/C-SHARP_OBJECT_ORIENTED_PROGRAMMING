create database Roadside_Assistance1

create table Oilorder1(
bid int NOT NULL IDENTITY(1,1) primary key,
bBrand varchar(250) not null,
bType varchar(250) not null,
bAmount varchar(250) not null,
bDelivery varchar(250) not null,
bLocation varchar(250) not null,
bupdatedorder varchar(250) not null,


)

select * from Oilorder1

Create table Tow_truck(

Tid int NOT NULL IDENTITY(1,1) primary key,
Tlocation varchar(250) not null,
Ttype varchar(250) not null,
Tnumber varchar(250) not null,
Temail varchar(250) not null,
TupdatedOrder varchar(250) not null,

)

select * from Tow_truck

create table Registration(

Uid int NOT NULL IDENTITY(1,1) primary key,
Username varchar(250) not null,
Uemail varchar(250) not null,
Upassword varchar(250) not null,
CUpassword varchar(250) not null,


)


select * from Registration
