Use PoolDB;
GO
CREATE PROCEDURE SP_GetPersonInfoById
		@PersonID INT
AS
BEGIN
	SELECT * FROM People WHERE PersonID = @PersonID 
END;

-------------------------------------------------
GO
CREATE PROCEDURE SP_GetPersonInfoByNationalNo
			@NationalNo NVARCHAR(20)
AS
BEGIN
	SELECT * FROM People WHERE NationalNo = @NationalNo 
END;
------------------------------------------------
GO
CREATE PROCEDURE SP_AddNewPerson
			@NationalNo NVARCHAR(20),
			@FirstName NVARCHAR(20),
			@SecondName NVARCHAR(20),
			@ThirdName NVARCHAR(20) = null,
			@LastName NVARCHAR(20),
			@DateOfBirth DATETIME,
			@Gender tinyint,
			@Address NVARCHAR(500),
			@Phone NVARCHAR(20),
			@Email NVARCHAR(50),
			@ImagePath NVARCHAR(250),
			@NewPersonID INT OUTPUT --like by ref
AS
BEGIN
			INSERT INTO People (NationalNo,FirstName,SecondName,ThirdName,LastName,DateOfBirth,Gender,Address,Phone,Email,ImagePath)
            VALUES (@NationalNo,@FirstName,@SecondName,@ThirdName,@LastName,@DateOfBirth,@Gender,@Address,@Phone,@Email,@ImagePath);
         
			SET @NewPersonID = CAST(SCOPE_IDENTITY() AS INT);
END;
----------------------------------------------------------
GO
CREATE PROCEDURE SP_UpdatePerson
			@PersonID INT,
			@NationalNo NVARCHAR(20),
			@FirstName NVARCHAR(20),
			@SecondName NVARCHAR(20),
			@ThirdName NVARCHAR(20) = null,
			@LastName NVARCHAR(20),
			@DateOfBirth DATETIME,
			@Gender tinyint,
			@Address NVARCHAR(500),
			@Phone NVARCHAR(20),
			@Email NVARCHAR(50),
			@ImagePath NVARCHAR(250)
AS
BEGIN
			UPDATE People
                              SET NationalNo = @NationalNo, 
                                 FirstName = @FirstName,
                                 SecondName = @SecondName,
                                 ThirdName = @ThirdName, 
                                 LastName = @LastName, 
                                 DateOfBirth = @DateOfBirth, 
                                 Gender = @Gender,
                                 Address = @Address, 
                                 Phone = @Phone, 
                                 Email = @Email, 
                                 ImagePath = @ImagePath
                            WHERE PersonID =@PersonID 
END;

------------------------
GO
CREATE PROCEDURE SP_GetAllPeople
AS
BEGIN
    SELECT * FROM People
END
-------------------------------------------------------
GO
CREATE PROCEDURE SP_DeletePerson
    @PersonID INT
AS
BEGIN
    DELETE FROM People WHERE PersonID = @PersonID
END
----------------------------
GO
CREATE PROCEDURE SP_CheckPersonExistsByPersonID
		@PersonID INT
AS
BEGIN
	IF EXISTS(SELECT * FROM People WHERE PersonID =@PersonID)
		return 1;
	ELSE
		return 0;
END
-------------------------------
GO
CREATE PROCEDURE SP_CheckPersonExistsByNationalNo
		@NationalNo NVARCHAR(20)
AS
BEGIN
	IF EXISTS(SELECT * FROM People WHERE NationalNo =@NationalNo)
		return 1;
	ELSE
		return 0;
END
