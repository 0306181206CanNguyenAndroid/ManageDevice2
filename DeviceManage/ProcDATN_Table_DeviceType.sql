create proc DeviceType_SelectDeviceTypeHasSpecs (@isDeleted bit = null)
as
	begin
		Select * from [dbo].[D_Device_Type]
		where (isnull([IsDeleted],0)=@isDeleted or @isDeleted is null) and [Id] in (select distinct [DeviceTypeId] from [dbo].[D_DeviceType_Specs] where isnull([IsDeleted],0)=0)
	end
go