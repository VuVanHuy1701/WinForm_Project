
USE MASTER
GO 
IF EXISTS(SELECT NAME FROM SYSDATABASES WHERE NAME ='QLY_Pos')
BEGIN 
DROP DATABASE QLY_Pos
END 
GO 
CREATE DATABASE QLY_Pos
GO
USE QLY_Pos
GO

---thanh toán ,, dihcj vụ, dôanh thu, 


---Tạo bảng tài khoản 
	Create table TaiKhoan (
		
		ID			varchar(20) Primary key Not Null,
		UserName	varchar(20)		Not Null,
		Pass		varchar (10)	Not Null,

		Name		nvarchar (50)	Not Null,
		Phone		char (10)		Not Null,
		Email		varchar (50)	Not Null,
		CCCD		char(20)		Null
	)
	Go

---Thêm dữ liệu cho bảng TaiKhoan
Insert into TaiKhoan Values ('admin', 'Admin', 'Admin', 'Admin', '0123456789', 'Admin@gmail.com', '0123456789')
Go



---Tạo bảng thể loại
	Create table TheLoai (
		MaTheloai	nchar (10) Primary Key	Not Null, 
		TenTheLoai	nvarchar (50)			Not Null
	)
	GO

---Thêm dữ liệu cho bảng TheLoai
/*
11 - 14: Mặt hàng nước
21 - 22: Mặt hàngg bánh
*/
Insert into TheLoai Values ('11', N'Cà Phê' )
Insert into TheLoai Values ('12', N'Nước Ép' )
Insert into TheLoai Values ('13', N'Đá Xay' )
Insert into TheLoai Values ('14', N'Sinh Tố' )

Insert into TheLoai Values ('21', N'Bánh Ngọt' )
Insert into TheLoai Values ('22', N'Bánh Mặn')

Select * From TheLoai


---Tạo bảng mặt hàng
	Create table MatHang (
		MaMatHang	varchar (10) Primary Key	Not Null,
		TenMon		nvarchar (50)			Not Null,
		MaTheLoai	nchar (10)				Not Null,
		HinhAnh		varchar (max)			Null,
		Gia			float					Not Null,
		Constraint Fk_TheLoai Foreign key(MaTheLoai) References TheLoai(MaTheLoai)
	)
	Go

---Thêm dữ liệu cho bảng MatHang 
---Mặt hàng nước
Insert into MatHang Values ('N-1', N'Cà Phê Đen', '11', '', '15000' )
Insert into MatHang Values ('N-2', N'Cà Phê Sữa', '11', '', '17000' )

Insert into MatHang Values ('N-3', N'Nước Ép Cam', '12',  '', '25000' )
Insert into MatHang Values ('N-4', N'Nước Ép Dưa Hấu', '12',  '', '25000' )

Insert into MatHang Values ('N-5', N'MatCha Đá Xay', '13',  '', '30000' )
Insert into MatHang Values ('N-6', N'Socola Đá Xay', '13',  '', '30000' )

Insert into MatHang Values ('N-7', N'Sinh Tố Dâu', '14',  '', '30000' )
Insert into MatHang Values ('N-8', N'Sinh Tố Đào', '14',  '', '30000' )

---Mặt hàng bánh
Insert into MatHang Values ('B-1', N'Cupcake', '21',  '','45000' )
Insert into MatHang Values ('B-2', N'Dorayaki', '21',  '','45000' )

Insert into MatHang Values ('B-3', N'Salted Egg Sponge Cake Large', '22',  '','45000' )
Insert into MatHang Values ('B-4', N'Croissant', '22',  '','45000' )

Select * From MatHang

---Tạo bảng thanh toán
	Create table ThanhToan(	
	MaThanhToan		char (10) Primary Key	Not	Null,
	PhuongThuc		nvarchar (50)			Null
	)
Go
Insert into ThanhToan values ('1', N'Tiền Mặt' ) 
Insert into ThanhToan values ('2', N'Chuyển Khoản' ) 

---Tạo bảng hóa đơn 
	Create table HoaDon (
	
		MaHoaDon		int Identity(1,1) Primary Key,
		MaMatHang		varchar (10)		Null,
		TenMatHang		nvarchar (50)		Null,
		Gia				float				Null,
		Ngay			Datetime			Null,
		Constraint Fk_MatHang Foreign Key(MaMatHang) References MatHang(MaMatHang)
	)
Go
Insert into HoaDon values ('N-1', N'Cà Phê', '15000', '8/25/2023')

---Tạo bảng khuyến mãi
	Create table KhuyenMai(
	MaKM			varchar (10)		Not Null,
	TenKM			nvarchar (10)		Null,
	GiaTri			float				Not Null,
	)
Go
Insert into KhuyenMai Values ('SN-1', N'Sinh Nhật', '10000' )
Insert into KhuyenMai Values ('CB-1', N'Combo', '15000' )

Select * From KhuyenMai

---Tạo bảng doanh thu
	Create table DoanhThu(
	TongDT			float				Null,
	TienMat			float				Null,
	ChuyenKhoan		float				Null
	)
Go

	Create table  Oder(
	TenMon		nvarchar (50)			Null,
	Gia			float					Null,
	SoLuong		nchar	(20)			Null
	)
GO


