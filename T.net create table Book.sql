-- ----------------------------- create table

create table book
(
Id int primary key IDENTITY(1,1),
Name varchar(50),
Page int,
publish date,
Auther_Id int 
);



create table Auther
(
Id int primary key IDENTITY(1,1),
Name varchar(50),
);

-- ---------------------------------------------------
insert into Auther values('Ahmad');

insert into book values('C#',220,GETDATE());