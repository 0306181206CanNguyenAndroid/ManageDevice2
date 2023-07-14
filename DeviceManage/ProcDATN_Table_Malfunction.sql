create proc [dbo].[Malfuntion_Insert]
(
@Id int,
@CreatedDate datetime,
@CreatedUserId int,
@IsDeleted bit,
@Status int,
@DeviceId int,
@Solution nvarchar(250),
@Note nvarchar(250),
@Severity int
)

as
begin
	insert into [D_Malfunction]([DeviceId],[Note],[CreatedUserId],[CreatedDate],[Status],[Severity],[IsDeleted])
				Values(@DeviceId,@Note,@CreatedUserId, @CreatedDate,@Status,@Severity,@IsDeleted)
	Select Max(Id) from [D_Malfunction]
end

create proc [dbo].[Malfuntion_Update](
@Id int,
@CreatedDate datetime,
@CreatedUserId int,
@IsDeleted bit,
@Status int,
@DeviceId int,
@Solution nvarchar(250),
@Note nvarchar(250),
@Severity int
)
as
begin

Update D_Malfunction
Set [Note] = @Note,[DeviceId] = @DeviceId, CreatedDate = @CreatedDate,CreatedUserId = @CreatedUserId
, Severity = @Severity,IsDeleted = @IsDeleted,[Status] = @Status
Where Id = @Id


end

create proc [dbo].[Malfunction_SelectAllWhereDynamic]
(
@id int = null,
@createdDate datetime = null,
@createdUserId int = null,
@isDeleted bit = null,
@status int = null,
@deviceId int = null,
@solution nvarchar(250) = null,
@note nvarchar(250) = null,
@severity int = null
)
as 
	begin
	Select* from [D_Malfunction]
	where (@id is null or [Id] = @id) and
	(@createdDate is null or [createdDate] = @createdDate) and
	(@createdUserId is null or [createdUserId] = @createdUserId) and
	(@status is null or [status] = @status) and
	(@isDeleted is null or [isDeleted] = @isDeleted) and
	(@deviceId is null or [deviceId] = @deviceId) and
	(@note is null or [note] = @note) and
	(@solution is null or [Solution] = @solution) and
	(@severity is null or [Severity] = @severity) 
	order by [CreatedDate]
	end
go