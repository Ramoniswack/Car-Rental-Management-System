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

ALTER TABLE tbllogin ADD LastLoginDate DATETIME
alter table tbllogin add LoginCount Int Default 0




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











<<<<<<< HEAD
-- previously
=======

>>>>>>> 34a9dec18eb717259f191a27cdb9ce2653e796b0
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

<<<<<<< HEAD
Alter table tblcars
 Drop column active;

 ALTER TABLE tblcars
ADD [Year] INT;

ALTER TABLE tblcars
ADD Availability BIT NOT NULL DEFAULT 1;

   ALTER TABLE tblcars
DROP COLUMN Active;

truncate table tblcars
delete from tblcars

ALTER TABLE tblcars
ADD RegNumber NVARCHAR(20) NULL;

ALTER TABLE tblcars
DROP COLUMN Availability;

SELECT
    def.name
FROM
    sys.default_constraints def
    INNER JOIN sys.columns col ON def.parent_object_id = col.object_id AND def.parent_column_id = col.column_id
WHERE
    col.name = 'Availability'
    AND object_name(def.parent_object_id) = 'tblcars';
	ALTER TABLE tblcars
DROP CONSTRAINT DF__tblcars__Availab__17036CC0;

ALTER TABLE tblcars
DROP COLUMN Availability;

ALTER TABLE tblcars
DROP COLUMN Year;

ALTER TABLE tblcars
DROP COLUMN qty;

ALTER TABLE tblcars
ADD Available NVARCHAR(3) NOT NULL DEFAULT 'Yes';


UPDATE tblcars
SET Available = 'Yes';


select *from tblcars
-- Add a unique constraint to regnumber in tblcars
ALTER TABLE tblcars
ADD CONSTRAINT UQ_tblcars_regnumber UNIQUE (regnumber);


ALTER TABLE tblcars
ADD LastMaintenanceDate DATE,
    TotalKilometers INT DEFAULT 0,
    LastMaintenanceKilometers INT DEFAULT 0;

truncate table tblcars










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

truncate table tblcarrentals1

delete from tblcarrentals1





<<<<<<< HEAD


create table tblcarrentals2
(
 RentalID INT IDENTITY(1,1) PRIMARY KEY,
    CusID INT FOREIGN KEY REFERENCES tblcustomers(CusID),
	CustomerName nvarchar(50),
    CarID INT FOREIGN KEY REFERENCES tblcars(CariD),
	CarName nvarchar(50),
    PickupLocation NVARCHAR(200) NOT NULL,
    RentDate DATE NOT NULL,
    ReturnDate DATE NOT NULL,
    Charges DECIMAL(10, 2) NOT NULL
);
select *from tblcarrentals2



CREATE TABLE tblCarRentals3
(
    RentalID INT IDENTITY(1,1) PRIMARY KEY,
    CarID INT NOT NULL,
    RegNumber NVARCHAR(50) NOT NULL,
    CusID INT NOT NULL,
    CusName NVARCHAR(50) NOT NULL,
    PickupLocation NVARCHAR(200) NOT NULL,
    RentDate DATE NOT NULL,
    ReturnDate DATE NOT NULL,
    Charges DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (CarID) REFERENCES tblcars(CarID),
    FOREIGN KEY (CusID) REFERENCES tblcustomers(CusID)
);



select *from tblcarrentals3
ALTER TABLE tblCarRentals3 ADD IsCancelled BIT DEFAULT 0

ALTER TABLE tblCarRentals3
ADD LoggedInUser NVARCHAR(50),
    CreatedDate DATETIME;














CREATE TABLE tblcancel (
    CancelID INT PRIMARY KEY IDENTITY(1,1),
    RentalID INT,  
    CarID INT,
    RegNumber Nvarchar(50),
    CusID Int,
    CusName Nvarchar(100),
    PickupLocation Nvarchar(100),
    RentDate DATE,
    ReturnDate DATE,
    Charges DECIMAL(10, 2),
    CreatedDate DATETIME,
    CancelledDate DATETIME DEFAULT GETDATE(),
    CancelledBy Nvarchar(50),
    Remarks Nvarchar(200),
    FOREIGN KEY (RentalID) REFERENCES tblcarrentals3(RentalID),
    FOREIGN KEY (CarID) REFERENCES tblcars(CarID),
    FOREIGN KEY (CusID) REFERENCES tblcustomers(cusid)
);



CREATE TABLE tblcheckouts (
    CheckoutID INT PRIMARY KEY IDENTITY(1,1),
    RentalID INT,
    CarID INT,
    RegNumber VARCHAR(50),
    CusID VARCHAR(50),
    CusName VARCHAR(100),
    RentDate DATE,
    ReturnDate DATE,
    ActualReturnDate DATE,
    Charges DECIMAL(10,2),
    DelayDays INT,
    Fine DECIMAL(10,2),
    TotalCharges DECIMAL(10,2),
    LoggedInUser VARCHAR(50),
    CreatedDate DATETIME,
    FOREIGN KEY (RentalID) REFERENCES tblcarrentals3(RentalID),
    FOREIGN KEY (CarID) REFERENCES tblcars(CarID)
);
ALTER TABLE tblcheckouts
ADD FineDescription NVARCHAR(200)




select *From tblcancel
select *From tblcarrentals3
select *from tblcars
SELECT *fROM TBLCUSTOMERS
select *from tblcheckouts
select *from tbllogin
select *from tblcars



=======
0000000.00
>>>>>>> 34a9dec18eb717259f191a27cdb9ce2653e796b0
