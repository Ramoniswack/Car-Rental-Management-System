create table tbllogin
(
Uid int primary key identity (1,1),
username nvarchar(50),
password nvarchar(50),
)
insert into tbllogin(username,password) values ('admin','admin1')
insert into tbllogin(username,password,usertype,contact) values ('ad','ad2','Admin','999')


select *From tbllogin



ALTER TABLE tbllogin
ADD usertype nvarchar(50)
ALTER TABLE tbllogin
ADD Contact nvarchar(50)




create table tblcustomers
(
Cusid int primary key identity (1,1),
Customername nvarchar(50),
Contact nvarchar(50),
Address nvarchar(50)
)
select *from tblcustomers
truncate table tblcustomers

ALTER TABLE tblcustomers
ADD LicenseID nvarchar(50)












create table tblcars
(
Carid int primary key identity (1,1),
Carname nvarchar(50),
Model nvarchar(50),
Color nvarchar(50)
)
select *From tblcars

ALTER TABLE tblcars
ADD Active BIT NOT NULL DEFAULT 1;

Alter table tblcars
add QTY nvarchar(20);






CREATE TABLE tblCarRentals (
    RentalID INT IDENTITY(1,1) PRIMARY KEY,
    CusID INT FOREIGN KEY REFERENCES tblcustomers(CusID),
    CarID INT FOREIGN KEY REFERENCES tblcars(CarID),
    PickupLocation NVARCHAR(200) NOT NULL,
    RentDate DATE NOT NULL,
    ReturnDate DATE NOT NULL,
    Charges DECIMAL(10, 2) NOT NULL
);

select *from tblCarRentals

create table tblcarrentals1
(
 RentalID INT IDENTITY(1,1) PRIMARY KEY,
    CusID INT FOREIGN KEY REFERENCES tblcustomers(CusID),
	CustomerName nvarchar(50),
    CarID INT FOREIGN KEY REFERENCES tblcars(CarID),
	CarName nvarchar(50),
    PickupLocation NVARCHAR(200) NOT NULL,
    RentDate DATE NOT NULL,
    ReturnDate DATE NOT NULL,
    Charges DECIMAL(10, 2) NOT NULL
);
select *from tblcarrentals1





0000000.00
