﻿CREATE PROCEDURE DeleteStudent @SID INT
AS
DELETE FROM Students 
WHERE StudentNumber = @SID