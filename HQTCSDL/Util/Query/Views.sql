Create view view_DonHangKhachDaMua
As
	Select Don_Hang.Ma_KH ,Ho+' '+Ten As TenKH, SDT, Email, Duong + ', '+Thanh_Pho +', '+Tinh as Dia_Chi, Ma_Don_Hang, Ma_Nhan_Vien
	from KinhDoanh.Khach_Hang, KinhDoanh.Don_Hang
	where KinhDoanh.Khach_Hang.Ma_KH = KinhDoanh.Don_Hang.Ma_KH

Go
CREATE VIEW view_TongTienMotDon
AS
	Select Ma_Don_Hang, sum(So_Luong*Gia_Ca*Mien_Giam) As TienMotDon from KinhDoanh.Chi_Tiet_Don_Hang
	Group by Ma_Don_Hang

go
drop view view_ThongTinGiaoHang
go
Create view view_ThongTinGiaoHang
AS
	Select 
	KH.Ma_KH, KH.Ten, 
	DH.Ma_Don_Hang, DH.Trang_Thai_Giao_Hang, 
	DH.Ngay_Dat_Hang, DH.Ngay_Yeu_Cau_Giao_Hang,
	DH.Ngay_Van_Chuyen, NV.Ma_Nhan_Vien, NV.Ten,
	SP.Ten_San_Pham, SP.Gia_SP
	from 
	KinhDoanh.Don_Hang as DH, 
	KinhDoanh.Khach_Hang as KH,
	KinhDoanh.Chi_Tiet_Don_Hang as CT,
	SanPhamBan.San_Pham as SP,
	KinhDoanh.Nhan_Vien as NV
	where DH.Ma_Don_Hang = CT.Ma_Don_Hang and
		DH.Ma_KH = KH.Ma_KH and
		CT.Ma_SP = SP.Ma_San_Pham