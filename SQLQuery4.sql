create table Brands(
BrandId int primary key not null,
BrandName varchar(255),
);


create table Colors (
ColorId int primary key not null,
ColorName varchar(255),
);


create table Cars (
CarId int primary key not null,
CarName varchar(255),
DailyPrice decimal,
ModelYear int,
Description varchar(255),
BrandId int foreign key references Brands(BrandId),
ColorId int foreign key references Colors(ColorId),
);

create Table Users(
UserId int primary key not null,
FirstName varchar(255),
LastName varchar(255),
Email varchar(255),
Password varchar(255),
);

create table Customers(
CustomerId int primary key not null,
UserId int foreign key references Users(UserId),
CompanyName varchar(255),
);

create table Rentals(
RentalId int primary key not null,
CarId int foreign key references Cars(CarId),
CustomerId int foreign key references Customers(CustomerId),
RentDate Date,
ReturnDate Date,
);



insert into Cars 
values (1,'Tourneo Courier',150,2017,'1.5 TDI-Manuel',1,1);

insert into Cars 
values (2,'Cordoba',135,2008,'1.4 TDI-Manuel',2,2);

insert into Brands
values (1,'Ford');

insert into Brands
values (2,'Seat');

insert into Colors
values (1,'Beyaz');

insert into Colors
values (2,'Siyah');