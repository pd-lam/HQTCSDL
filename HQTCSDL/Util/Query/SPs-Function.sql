use BikeStore
	-- Find Employee Detail at Store by id --
Go
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'sp_FindAllEmployee')
DROP PROCEDURE sp_FindAllEmployee;

Go
Create Procedure sp_FindAllEmployee
As
	Select * From KinhDoanh.Nhan_Vien
Go

Go
Exec sp_FindAllEmployee;

Go
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'sp_FindEmployeeByName')
DROP PROCEDURE sp_FindEmployeeByName;

Go
Create Procedure sp_FindEmployeeByName @Name varchar(255)
As
	Select * From KinhDoanh.Nhan_Vien as NV
	Where NV.Ten like '%' + @Name + '%'
Go

Go
Exec sp_FindEmployeeByName @Name = "Genna";

-- Find ALL Bill By EmployeeId --
Go
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'sp_FindBillEmployee')
DROP PROCEDURE sp_FindBillEmployee;

Go
Create Procedure sp_FindBillEmployee @IdEmployee int
As
	Select
	KH.Ma_KH, KH.Ten, 
	DH.Ma_Don_Hang, DH.Trang_Thai_Giao_Hang, 
	DH.Ngay_Dat_Hang, DH.Ngay_Yeu_Cau_Giao_Hang, 
	DH.Ngay_Van_Chuyen, NV.Ma_Nhan_Vien, NV.Ten,
	SP.Ten_San_Pham, SP.Gia_SP
	From 
	KinhDoanh.Don_Hang as DH, 
	KinhDoanh.Khach_Hang as KH, 
	KinhDoanh.Chi_Tiet_Don_Hang as CTDH,
	SanPhamBan.San_Pham as SP,
	KinhDoanh.Nhan_Vien as NV
	Where 
	CTDH.Ma_Don_Hang = DH.Ma_Don_Hang
	and CTDH.Ma_SP = SP.Ma_San_Pham 
	and NV.Ma_Nhan_Vien = @IdEmployee 
	and NV.Ma_Nhan_Vien = DH.Ma_Nhan_Vien
Go

Go
Exec sp_FindBillEmployee @IdEmployee = 2