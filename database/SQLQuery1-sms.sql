CREATE DATABASE sms_data;

CREATE TABLE Cources(
	ID int PRIMARY KEY NOT NULL IDENTITY(1,1),
	Name nvarchar(MAX) NOT NULL,
	LecturerName nvarchar(MAX) NULL,
);

CREATE TABLE Students(
	ID int PRIMARY KEY NOT NULL,
	Name nvarchar(MAX) NOT NULL,
	City nvarchar(MAX) NOT NULL,
	CourceID int NOT NULL,
	FOREIGN KEY (CourceID) REFERENCES Cources(ID) 
);

SELECT * FROM Students;

SELECT * FROM Cources;

SELECT ID AS 'Student ID',Name,City FROM Students WHERE City='Kandy';

UPDATE Students SET City='Galle' WHERE ID='4';

SELECT * FROM Students WHERE ID=4;

SELECT st.ID as 'Student ID',st.Name,st.City,co.Name as 'Cource Name' FROM Students st JOIN Cources co ON st.CourceID=co.ID;