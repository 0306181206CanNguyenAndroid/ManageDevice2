create proc checkBrand_Device(@BrandId int 
)
as
begin
	select top 1 Id from [D_Device]
	where  BrandId=@BrandId and ISNULL(IsDeleted,0)=0
end

 go
 create proc checkBrand_Device_Detail(@BrandId int 
)
as
begin
	select top 1 Id from [D_DeviceDetail]
	where  BrandId=@BrandId and ISNULL(IsDeleted,0)=0
end

go
create proc checkBrand_Shipment(@BrandId int 
)
as
begin
	select top 1 Id from [D_Shipment]
	where  BrandId=@BrandId and ISNULL(IsDeleted,0)=0
end