	
	Create Database Qly_VatTu
	Go
	Use Qly_VatTu	
	Go

Create table tblMatHang (
	
	MaVTu nchar(5) Not Null, 
	TenVTu nvarchar(30) Null, 
	DonVi nvarchar(10) Null, 
	DonGia float Null
)
Go

Create table tblNhaCC (
	
	MaNhaCC nchar(5), 
	TenNhaCC nvarchar(50), 
	DiaChi nvarchar(200), 
	MaSoThue nvarchar(15), 
	TaiKhoan nvarchar(15), 
	DienThoai nvarchar(11)

)
Go

Create table tblHangNhap (
	
	MaSP nchar(5), 
	MaNhaCC nchar(5), 
	SoLuong int, 
	DonGia float,
	SoHD nvarchar(10), 
	NgayGH Date
)
Go

