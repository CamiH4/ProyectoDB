--DDL 
/*Crear bd*/
create database DBPrueba26;
go

use DBPrueba26
go

create table Ciudad (
	idCiudad INT PRIMARY KEY identity (1, 1),
	nombre nvarchar(50) NOT NULL,
	estado bit default 1
);
go

create table Persona(
	idPersona int Primary key identity (1, 1)
	, primerNombre nvarchar(50) NOT NULL
	, segundoNombre nvarchar(50)
	, primerApellido nvarchar(50) NOt NULL
	, segundoApellido nvarchar(50) 
	, fechaNac dateTime not null
	, sexo bit default 1 not null
	, telefono nvarchar(8) not null
	, email nvarchar(100) not null
	,idCiudad int  not null
	, direccion nvarchar(100) not null
	, estado bit default 'true'
);
go

--DML
/*Create or insert a record*/
Insert into Ciudad(nombre) values (N'Masaya'), (N'Managua'), (N'Granada'), (N'Jinotepe'), (N'León'),(N'Jinotega');

--Show records 

/*
Trad way:
"Select * from Ciudad"*/

--Agile way of working (Is done when the queries are larger):

--View records
SELECT        Ciudad.*
FROM            Ciudad
go 

--Edit records
Update Ciudad set nombre = N'Leon', estado = 'True' where idCiudad = 5
go
--Update Ciudad set nombre = N'Leon'

--Delete records
Delete from Ciudad where idCiudad = 5

--Insert records in "Persona"
insert into Persona(primerNombre, primerApellido,fechaNac, idCiudad) values
('Joel', 'Salazar', '2004-09-19' , 1)

insert into Persona(primerNombre, primerApellido,fechaNac, idCiudad) values
('Giselle', 'Ortega', '2004-11-15',1),
('Roberto', 'Cruz', '2004-12-09',2),
('Manuel', 'Fonseca', '2004-10-10',2),
('Lidia', 'Cuadra', '2004-08-19',3),
('Alejandro', 'Salazar', '2004-07-15',3),
('Adriana', 'Ramos', '2004-06-13',4),
('Elizabeth', 'Osorio', '2004-05-29',4),
('Jonathan', 'Orozco', '2004-04-01',6),
('Cecilia', 'Zamora', '2004-03-12',6)

SELECT        Persona.*
FROM            Persona

/* Show in a column the first name, surname,  
and in the other column the age of the person*/

SELECT        primerNombre + N' ' + primerApellido as N'Nombre completo', 
				Year(GETDATE()) - Year(fechaNac) as N'Edad'
FROM            Persona

--Shows the actual date and time 
print(GETDATE())

----Shows the actual date and year
print(YEAR(GETDATE()))

--Shows the numbre of the month
print(MONTH(getDate()))

--Shows the actual date
print DAY(GETDATE())

--Shows the date in britanic date
print Convert(NVARCHAR(10), GetDate(), 103)


--Shows the date in yy-mm-dd
print Convert(NVARCHAR(10), GetDate(), 102)