CREATE DATABASE Inventory_Project
go

use Inventory_Project
go

Create table Customers
	(
		CustomerID int primary key IDENTITY,
		CustomerName varchar(40) not null,
		PhoneNumber int,
		DoB date, 
		Gender Varchar (10),
		Address varchar (100),
		email Varchar (40)not null
	)
Go
insert into Customers values
('Salim Sheikh', 01912200321, '02/01/1994', 'Male', '26, A, Lalbagh, Dhaka', 'salimbd@gmail.com'),
('Roman Sheikh', 01612200321, '04/10/1994', 'Male', '26, A, Mohammadpur, Dhaka', 'romansheikh3@gmail.com'),
('Jaman Sheikh', 01812200321, '07/12/1994', 'Male', '26, A, Hajarabagh, Dhaka', 'jamanbd@gmail.com'),
('Sahkil Sheikh', 01712200321, '03/09/1994','Male','26, A, Jhigatola, Dhaka', 'shakilbd@gmail.com')
Go
CREATE TABLE SupplierType 
(
SupplierTypeID INT PRIMARY KEY IDENTITY,
SupplierTypeNAME VARCHAR
)
GO

Create table Suppliers
	(
		SupplierID int primary key IDENTITY,
		SupplierName varchar(40) not null,
		SupplierPhone varchar(40)not null,
		SupplierType int REFERENCES SupplierType(SupplierTypeID),
		SupplierAddress varchar(50)
	)
Go


create table Category 
(
		categoryid int primary key identity,
		categoryName Varchar(30) not Null
)
go

Create table Product
	(
		Productid int primary key IDENTITY,
		Category int references category(categoryid),
		ProductName varchar(40)not null,
		PurchasePrice money not null,
		SalesPrice Money,
		Supplierid int references Suppliers(Supplierid),
		Images varbinary (max)
	)
Go

Create table Sales_Details
	(
		Customerid int references Customers(Customerid),
		Productid int references Product (productid),
		primary key (Customerid, productid)
	)
Go

create table Stock 
(
StockID int primary key identity not null,
Quantity decimal(18,2),
PurchaesPrice decimal(18,2),
SalesPrice decimal(18,2)
)
go

 create table LoginUser 
 (
 UserID INT primary key references Customers(customerid),
 UserName varchar(20) unique Not Null,
 Password varchar(10) not null
 )
 go


insert into Category values
('Electrinic'),
('FirstFood'),
('Beverage'),
('Grochery'),
('Drinks')
Go


insert into Suppliers values
('Uniliver','01912200321', 'Gulshan'),
('ACI','01812200321', 'Motijheel'),
('Pran RFL Group','01812200321', 'Baridhara')
Go



insert into Product(Category, ProductName, PurchasePrice, SalesPrice, Supplierid) values (1, 'Means Watch', 250.00, 400.00,1)
go







insert into Sales_Details values
(1,1)
Go


select * from Sales_Details
Select * from Product
Select * from Suppliers
Select * from Customers
go

create proc sp_loginverify 
(
@username varchar(30),
@password varchar (30)
)
as
begin
select '#' from LoginUser where UserName = @username and Password = @password
end
go



insert into LoginUser(UserID, UserName, Password) values 
(1,'admin', 'admin'),
(2,'UserName', 'Passwords')
go

select * from Product
go
select * from LoginUser
go
select * from SupplierType
go
Select * from Product
Go
SELECT * FROM Suppliers
GO
Select * From Category
go
Select * from Customers
Go