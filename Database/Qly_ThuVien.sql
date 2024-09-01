
Create Database Qly_ThuVien
	Go
	Use Qly_ThuVien
	Go

	Create table ThuVien (
		madocgia int not null,
		tendocgia nvarchar (50) null,
		ngaysinh datetime,
		tienno float
	)

	Insert into ThuVien Values ( '1', 'Huy', 17/01/2003, '15000')