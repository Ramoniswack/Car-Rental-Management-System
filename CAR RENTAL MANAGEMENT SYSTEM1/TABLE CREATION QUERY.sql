create table Users(
id int primary key identity (1,1),
usertype nvarchar(50) not null,
Fullname  nvarchar(50) not null,
Passwordd nvarchar(1000) not null,
Contact Bigint,
Email nvarchar(50)
);
drop table Users


select *from Users
