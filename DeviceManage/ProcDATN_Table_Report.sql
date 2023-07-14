


create proc Report_Insert(

@CreatedDate datetime,
@CreatedUserId int,
@IsDeleted bit,
@Status int,
@DeviceId int,
@Note nvarchar(250),
@Title nvarchar(100)
)
as
begin

Insert Into D_Report([Title],[DeviceId],CreatedDate,CreatedUserId,IsDeleted,[Status])
		values (@Title,@DeviceId,@CreatedDate,@CreatedUserId,@IsDeleted,@Status)
Select Max(Id) from D_Report
end

create proc Report_Update(
@Id int,
@CreatedDate datetime,
@CreatedUserId int,
@IsDeleted bit,
@Status int,
@DeviceId int,
@Note nvarchar(250),
@Title nvarchar(100)
)
as
begin

Update D_Report
Set [Title] = @Title,[DeviceId] = @DeviceId, CreatedDate = @CreatedDate,CreatedUserId = @CreatedUserId
,IsDeleted = @IsDeleted,[Status] = @Status
Where Id = @Id

end
