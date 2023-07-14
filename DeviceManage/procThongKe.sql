	create proc LayThietBiTheoPhong(
	@RoomId int =null
	)
	as
	begin
	select RoomId , DeviceName, Info,DeviceTypeId, DeviceTypeName,RoomName,NgayMua,COUNT([DeviceId]) as [SL] from
	(
		select tbl_room.DeviceId, tbl_room.RoomId, deviceInfo.DeviceName, deviceInfo.Info,deviceInfo.DeviceTypeId, deviceType.DeviceTypeName,tbl_room.RoomName,tbl_shipment.NgayMua from 
		(
			SELECT d.Id, d.[Name] as DeviceName,
				---Cột chứa Tất cả Thông tin Cấu hình Thiết bị---
				(   
					SELECT dt.[Info] +';' AS [text()]
						FROM 
						(
						----Gom thông tin cấu hình thành 1 cột (tên cấu hỉnh + giá trị)----
							Select ddt.DeviceId as 'Id', CONCAT_WS(': ',ddt.NameSpecs,ddt.[Description]) as 'Info'
							from [dbo].[D_DeviceDetail] ddt, [dbo].[D_DeviceType_Specs] dtp
							where Isnull(ddt.IsDeleted,0) = 0
							Group By ddt.DeviceId, CONCAT_WS(': ',ddt.NameSpecs,ddt.[Description])
						) as dt
					WHERE dt.Id=d.ID
					ORDER BY dt.Id
					FOR XML PATH('')
				) [Info], 
				---End Thông tin Cấu hình Thiết bị---
				d.DeviceTypeId
				FROM D_Device d
		) as deviceInfo join 
		--Lấy Tên loại thiết bị
		( select Id, [Name] as [DeviceTypeName] from [dbo].D_Device_Type dvt) as deviceType
		on deviceInfo.DeviceTypeId = deviceType.Id
		join
		--Lấy tên phòng
		(
		select DeviceId,RoomId,[Name] as [RoomName] from [dbo].[D_DeviceRegistration] drs, [dbo].[D_Room] r
		where drs.RoomId = r.Id
		) as tbl_room
		on tbl_room.DeviceId = deviceInfo.Id
		left join
		--Lấy Ngày Mua
		(
		select [DeviceId], Convert(Date,ship.CreatedDate,103) as [NgayMua] from [dbo].[D_Shipment] ship, [dbo].[D_Shipment_Detail] shipDetail
		where ship.Id = shipDetail.ShipmentId
		) as tbl_shipment
		on deviceInfo.Id = tbl_shipment.DeviceId
	) as tbThongKeThietBiTheoPhong
	--Where (Tham số id phòng = Room Id) 
	where RoomId=@RoomId or @RoomId is null
	group by RoomId, DeviceName, Info,DeviceTypeId, DeviceTypeName,RoomName,NgayMua
	end

	go

	create proc [LayThietBiTheoTrangThai](@Status int ,@deviceTypeId int = null)
	as 
	begin
		SET NOCOUNT ON;
		
		select * from(
		select [DeviceName],[Info], DeviceTypeName,[RoomName], ErrorName, ErrorDescription, Remediation,[Status]  from 
		(
		Select Detail.DeviceId as [Id], Detail.DeviceTypeId, Detail.DeviceName, Detail.[Info], Detail.[Status]--Count(Detail.DeviceId) as 'SL', Sum(Detail.Price) as 'TotalPrice'
		From
		(
			SELECT d.[Name] as DeviceName,
			---Cột chứa Tất cả Thông tin Cấu hình Thiết bị---
			(   
				SELECT dt.[Info] +';' AS [text()]
					FROM 
					(
					----Gom thông tin cấu hình thành 1 cột (tên cấu hỉnh + giá trị)----
						Select ddt.DeviceId as 'Id', CONCAT_WS(': ',ddt.NameSpecs,ddt.[Description]) as 'Info'
						from [dbo].[D_DeviceDetail] ddt
						where Isnull(ddt.IsDeleted,0) = 0
						Group By ddt.DeviceId, CONCAT_WS(': ',ddt.NameSpecs,ddt.[Description])
					) as dt
				WHERE dt.Id=d.ID and (@deviceTypeId is null or d.DeviceTypeId = @deviceTypeId)
				ORDER BY dt.Id
				FOR XML PATH('')
			) [Info], 
			---End Thông tin Cấu hình Thiết bị---
			d.DeviceTypeId,d.Id as DeviceId,d.Price,d.[Status],d.[IsDeleted]
			FROM D_Device d
		) as Detail
		where Isnull(Detail.IsDeleted,0)=0
		) as DeviceInfo
		join 
		(
			Select [Id], [Name] as [DeviceTypeName] from [D_Device_Type]
		) as [Type]
		on DeviceInfo.DeviceTypeId = [Type].Id
		join
		(
			Select r.Id as [RoomId],[Name] as [RoomName], [DeviceId] from [D_Room] r, [D_DeviceRegistration] rg
			where r.Id = rg.RoomId
		) as [Room]
		on DeviceInfo.Id = [Room].DeviceId
		left join
		(
			Select fix.DeviceId, err.[ErrorCode] as [ErrorName], err.[Description] as [ErrorDescription], err.Solution as [Remediation] 
			from [D_DeviceError] err, [D_Malfunction] fix
			where err.Id = fix.ErrorId
		) as error
		on error.DeviceId = DeviceInfo.Id
		) as [ThongKe]
		where ThongKe.[Status]=@Status
		
		
end
	go


	
create proc [dbo].[User_SelectByPrimaryKey](@Id int)
as
begin 
select*from [System_User]
where Id = @Id
end
go