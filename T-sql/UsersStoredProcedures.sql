Use PoolDB;
GO
CREATE PROCEDURE SP_GetUserInfoByUserID 
		@UserID INT
AS
BEGIN
	SELECT * FROM Users WHERE UserID = @UserID
END;
-------------------------------

GO
CREATE PROCEDURE SP_GetUserInfoUserNameAndPassword
		@UserName NVARCHAR(50),
		@Password NVARCHAR(255)

AS
BEGIN
	SELECT * FROM Users WHERE UserName=@UserName AND Password=@Password 
END;

-----------------------------------------
GO
CREATE PROCEDURE SP_AddNewUser
		@PersonID INT,
		@UserName NVARCHAR(50),
		@Password NVARCHAR(255),
		@IsActive BIT,
		@NewUserID INT OUTPUT

AS
BEGIN
	INSERT INTO Users
                           (PersonID
                           ,UserName
                           ,Password
                           ,IsActive)
                     VALUES
                      (@PersonID,@UserName,@Password,@IsActive) 
                      SET @NewUserID = CAST(SCOPE_IDENTITY() AS INT)
END;

---------------------
GO
CREATE PROCEDURE SP_UpdateUser
		@UserID int,
		@PersonID INT,
		@UserName NVARCHAR(50),
		@IsActive  BIT
AS
BEGIN
	UPDATE Users
                   SET 
						PersonID = @PersonID, 
                        UserName = @UserName,
                        
                        IsActive = @IsActive
                   WHERE 
				   UserID =@UserID
END;
--------------------------------------

GO
CREATE PROCEDURE SP_GetAllUsers
AS
BEGIN
SELECT Users.UserID, Users.PersonID, FullName =People.FirstName +' '+ People.SecondName+' '+ ISNULL( People.ThirdName,'')+' '+ People.LastName, Users.UserName, Users.IsActive
                           FROM     People INNER JOIN
                            Users ON People.PersonID = Users.PersonID
END;
--------------------------------


GO
CREATE PROCEDURE SP_DeleteUser
	@UserID INT
AS
BEGIN
	DELETE Users WHERE UserID=@UserID
END;
----------------------------

GO
CREATE PROCEDURE SP_IsUserExistByUserID
	@UserID INT
AS
BEGIN
	IF EXISTS (SELECT 1 FROM USERS WHERE UserID =@UserID)
	RETURN 1
	ELSE
	RETURN 0
END;

GO
CREATE PROCEDURE SP_IsUserExistByUserName
	@UserName NVARCHAR(50)
AS
BEGIN
	IF EXISTS (SELECT 1 FROM USERS WHERE UserName =@UserName)
		RETURN 1
	ELSE
		RETURN 0
END;

GO
CREATE PROCEDURE SP_IsUserExistForPersonID
	@PersonID INT
AS
BEGIN
	IF EXISTS (SELECT 1 FROM USERS WHERE PersonID =@PersonID)
		RETURN 1
	ELSE
		RETURN 0
END;

GO
CREATE PROCEDURE SP_ChangePassword
		@UserID INT,
		@NewPassword nvarchar(255)
AS
BEGIN
	UPDATE Users
                     SET  
                        Password = @NewPassword
                   WHERE UserID =@UserID 
END;

