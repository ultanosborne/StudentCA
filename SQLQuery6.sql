CREATE PROCEDURE PWCheck @username NVARCHAR(20)
AS
SELECT * FROM Logins
WHERE Username = @username