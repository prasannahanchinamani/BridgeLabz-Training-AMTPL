use ADVANCEOP;
CREATE TABLE Persons (
    PersonID INT PRIMARY KEY IDENTITY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Email VARCHAR(100)
);
INSERT INTO Persons (FirstName, LastName, Email)
VALUES ('Prasanna', 'Hayes', 'prasanna@email.com');

UPDATE Person
SET LastName = 'Kumar'
WHERE PersonID = 1;


BEGIN TRANSACTION;
UPDATE Persons
SET LastName = 'Frost'
WHERE PersonID = 2;
DELETE FROM Persons
WHERE PersonID = 3;
COMMIT;


CREATE VIEW vw_PersonEmails
AS
SELECT PersonID, FirstName, Email
FROM Persons;
select * from vw_PersonEmails;


CREATE PROCEDURE sp_GetPersonByID @ID INT
AS
BEGIN
SELECT * FROM Persons WHERE PersonID = @ID;
END;
select * from Persons where PersonID=1;



CREATE TRIGGER tr_InsertPerson
ON Persons
FOR INSERT
AS
BEGIN
PRINT 'Row inserted into Person';
END;

insert into persons values('muttu','kagal','xyz@gmail.com');

--cursors
DECLARE @personId INT;
DECLARE cursorBasedOnId CURSOR FOR
    SELECT PersonID FROM Persons;
OPEN cursorBasedOnId;
FETCH NEXT FROM cursorBasedOnId INTO @personId;
WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT 'row ' + CAST(@personId AS VARCHAR(3));
    FETCH NEXT FROM cursorBasedOnId INTO @personId;
END;
CLOSE cursorBasedOnId;
DEALLOCATE cursorBasedOnId;

select * from AGEGT_20;