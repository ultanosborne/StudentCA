CREATE PROCEDURE EditStudent @SID INT, @Email VARCHAR(50), @Phone VARCHAR(20),
@AL1 VARCHAR(50), @AL2 VARCHAR(50),@City VARCHAR(20), 
@Country VARCHAR(50), @GLevel BIT
AS
UPDATE Students 
SET Email = @Email,
Phone = @Phone, 
AddressLine1 = @AL1, 
AddressLine2 = @AL2, 
City = @City, 
Country = @Country, 
GradLevel = @GLevel
WHERE StudentNumber = @SID
