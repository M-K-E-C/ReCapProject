create table Cars(
 Id int not null,
ModelYear int ,
DailyPrice decimal ,
Description varchar(50),
BrandId int,
ColorId int
);

create table Brands(
BrandId int,
BrandName varchar(50)
);

create table Colors(
ColorId int not null,
ColorName varchar(50)
);

insert into Cars
values (1,2017,12500,'1.5 dizel manuel',1,1)

insert into Cars
values (2,2008,85000,'1.4 dizel manuel',2,2)

insert into Brands 
values(1,'Ford')

insert into Brands 
values(2,'Seat')

insert into Colors
values (1,'Beyaz')

insert into Colors
values (2,'Siyah')