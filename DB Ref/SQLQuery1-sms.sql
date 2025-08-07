CREATE DATABASE sms_data;

CREATE TABLE Cources(
	CourceID int PRIMARY KEY NOT NULL IDENTITY(1,1),
	NAME nvarchar(60) NOT NULL,
	LecturerName nvarchar(100) NULL,
);

CREATE TABLE Students(
	StudentID nvarchar(50) PRIMARY KEY NOT NULL,
	Name nvarchar(100) NOT NULL,
	City nvarchar(50) NOT NULL,
	CourceID int NOT NULL,
	FOREIGN KEY (CourceID) REFERENCES Cources(CourceID) 
);