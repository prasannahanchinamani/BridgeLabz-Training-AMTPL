SELECT name FROM sys.databases;
create database empdb;
CREATE DATABASE empdb;
GO

USE empdb;
GO

CREATE TABLE Employee (
    Id INT PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    Dept VARCHAR(100) NOT NULL
);
GO

SELECT * FROM Employee;
