create database EMP_MGM1;

USE EMP_MGM1;
GO

SELECT * FROM dbo.EMP_Detials1;

create table register_tbl1
(
 ID int identity(1,1) PRIMARY KEY,
 User_Name varchar(50),
 Password varchar(50),
 CPassword varchar(50),
 Email varchar(50),
 Mobile_Num varchar(20)
 );
create procedure sp_register1
 (
 @User_Name varchar(50),
 @Password varchar(50),
 @CPassword varchar(50),
 @Email varchar(50),
 @Mobile_Num varchar(20)
 )
 as begin
 insert into register_tbl1
 values (@User_Name,@Password,@CPassword,@Email,@Mobile_Num)
 end

 Create procedure sp_login1
 (
  @User_Name varchar(50),
  @CPassword varchar(50) 
)
as begin
select * from register_tbl1 
where User_Name=@User_Name and CPassword=@CPassword 
end

Create procedure sp_forgot
(
  @User_Name varchar(50)
)
as begin
select * from register_tbl1 
where User_Name=@User_Name 
end

IF OBJECT_ID('dbo.EMP_Details1', 'U') IS NOT NULL
DROP TABLE dbo.EMP_Detials1;
GO

CREATE TABLE dbo.EMP_Detials1
(
    EMP_ID INT PRIMARY KEY,
    EMP_Name VARCHAR(50),
    EMP_Salary VARCHAR(100),
    EMP_Dept VARCHAR(50),
    EMP_Role VARCHAR(50)
);
GO

CREATE PROCEDURE sp_EMP_register1
(
    @EMP_ID INT,
    @EMP_Name VARCHAR(50),
    @EMP_Salary VARCHAR(100),
    @EMP_Dept VARCHAR(50),
    @EMP_Role VARCHAR(50)
)
AS
BEGIN
    INSERT INTO dbo.EMP_Detials1
    VALUES
    (
        @EMP_ID,
        @EMP_Name,
        @EMP_Salary,
        @EMP_Dept,
        @EMP_Role
    )
END
GO

CREATE PROCEDURE sp_Fetch1
AS
BEGIN
    SELECT * FROM dbo.EMP_Detials1
END
GO

CREATE OR ALTER PROCEDURE sp_Delete
(
    @EMP_ID INT
)
AS
BEGIN
    DELETE FROM dbo.EMP_Detials1
    WHERE EMP_ID=@EMP_ID;
END
GO

CREATE PROCEDURE sp_Search1
(
    @SearchData VARCHAR(50)
)
AS
BEGIN
    SELECT *
    FROM dbo.EMP_Detials1
    WHERE EMP_Name LIKE '%' + @SearchData + '%'
END
GO

CREATE OR ALTER PROCEDURE sp_Update
(
    @EMP_ID INT,
    @EMP_Name VARCHAR(50),
    @EMP_Salary VARCHAR(100),
    @EMP_Dept VARCHAR(50),
    @EMP_Role VARCHAR(50)
)
AS
BEGIN
    UPDATE dbo.EMP_Detials1
    SET
        EMP_Name=@EMP_Name,
        EMP_Salary=@EMP_Salary,
        EMP_Dept=@EMP_Dept,
        EMP_Role=@EMP_Role
    WHERE EMP_ID=@EMP_ID;
END
GO

 create procedure sp_Create
 (
 @User_Name varchar(50),
 @Password varchar(50),
 @CPassword varchar(50)
 )
 as begin 
 update register_tbl1 
 set 
  Password = @Password,
  CPassword = @CPassword
 where User_Name=@User_Name
 end

 SELECT * FROM EMP_Detials1;

  SELECT * FROM register_tbl1;
