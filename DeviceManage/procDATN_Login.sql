

go
create proc [dbo].[GetStatusByUserId](
@UserId int
)
as
begin
	select Status from [System_User]
	where Id=@UserId and ISNULL(IsDeleted,0)=0
end
go
create proc [dbo].[GetInfoByUserId](
@UserId int
)
as
begin
	select Id,[UserName], [Name] from [System_User]
	where Id=@UserId and ISNULL(IsDeleted,0)=0
end
go
create proc [dbo].[CheckUserId](
@UserId int
)
as 
begin
	select * from [System_Decentralization]
	where UserId=@UserId and ISNULL(IsDeleted,0)=0
end


go
create proc User_SelectAll
as
begin
	select * from [System_User]
	where ISNULL(IsDeleted,0)=0
end


go 
create proc Insert_Decentralization(
	@TeacherId int null,
	@UserId int null,
	@CreatedDate datetime null,
	@CreatedUserId int null,
	@IsDelete bit null
)as 
begin
	Set Nocount on
	declare @Id int;
	Insert into [System_Decentralization](UserId,TeacherId,CreatedDate,CreatedUserId,IsDeleted)
	values(@UserId,@TeacherId,@CreatedDate,@CreatedUserId,@IsDelete)
	set @Id=SCOPE_IDENTITY()
	return @Id
end

go 
create proc Update_Decentralization(
	@Id int null,
	@TeacherId int null,
	@UserId int null,
	@CreatedDate datetime null,
	@CreatedUserId int null,
	@IsDelete bit null
)
as
begin 
	set Nocount on
	update [System_Decentralization]
	set TeacherId=@TeacherId,UserId=@UserId,CreatedDate=@CreatedDate,CreatedUserId=@CreatedUserId,IsDeleted=@IsDelete
	WHERE @Id=Id
	SET @Id =SCOPE_IDENTITY()
	return @Id
end





create proc Brand_SelectById(@Id int)
as 
begin
	Select* from [D_Brand]
	where Id = @Id
end
go

----------------------------------------------sửa proc ngày 14/7-----------------------
go 
create proc UpdateUserNameAndPass(
@UserId int null,
@UserName varchar(50) null,
@Pass varchar(100) null,
--@Name nvarchar(100) null,
--Image nvarchar(200) null,
--AccessRightsGroup int null,
@CreatedDate DateTime null,
@CreatedUserId int null,
@IsDeleted bit null,
@Status int null)

as
begin
	SET NOCOUNT ON;
	update [System_User]
	set UserName=@UserName,Pass=@Pass,CreatedDate=@CreatedDate,CreatedUserId=@CreatedUserId,IsDeleted=@IsDeleted,[Status]=@Status
	where Id=@UserId
	set @UserId = SCOPE_IDENTITY()
	return @UserId
end

go
create proc [dbo].[GetUserByUserName_Pass](
@UserName varchar(50),
@Pass varchar(100)
)
as
begin
	select * from [System_User]
	where UserName=@UserName and Pass=@Pass and ISNULL(IsDeleted,0)=0
end
go
CREATE PROCEDURE SearchUser
    @Name NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT u.Id, u.TeacherId, t.FullName, t.Gender, t.Phone, t.Birth, u.UserName, u.Pass, u.[Status] 
    FROM [System_User] u
    INNER JOIN S_Teacher t ON u.TeacherId = t.Id
    WHERE (u.UserName LIKE '%' + @Name + '%' OR u.[Name] LIKE '%' + @Name + '%')
        AND u.[IsDeleted] = 0
END