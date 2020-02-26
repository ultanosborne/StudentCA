SELECT * FROM Students


GO
CREATE PROCEDURE AddStudent @SID INT, @FName VARCHAR(20),
@LName VARCHAR(20),@Email VARCHAR(50),@Phone VARCHAR(20),
@AL1 VARCHAR(50), @AL2 VARCHAR(50),@City VARCHAR(20), 
@Country VARCHAR(50), @GLevel BIT, @Course VARCHAR(20)
AS
INSERT INTO Employee VALUES( @SID, @FName,@LName,@Email,@Phone, @AL1, @AL2, @City, @Country, @GLevel, @Course);
GO