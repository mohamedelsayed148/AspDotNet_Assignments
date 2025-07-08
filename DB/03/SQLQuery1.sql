create database ITIDB 

create table Students (
Id int Primary key Identity(1,1),
Fname varchar(20) not null,
Lname varchar(20) not null,
Age int,
Address varchar(100),
Dept_id int				-- references Departement(id)


)

create table Departements (
Id int Primary key Identity(10,10),
Name varchar(20) not null,
HiringDate varchar(100),
Manager_id int not null unique		-- references Instructors(id)

)

create table Instructors (
Id int Primary key Identity(1,1),
Name varchar(20) not null,
Address varchar(100),
Bonus int,
salary decimal not null,
HourRate decimal,
Dept_id int	references Departements(id)


)

create table Courses (
Id int primary key identity (1,1),
Name varchar(30) not null,
Duration int not null,
Description varchar(100),
Top_Id int

)

create table Topic (
Id int Primary key identity(1,1),
Name varchar(20) not null

)