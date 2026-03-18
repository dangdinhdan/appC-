IF NOT EXISTS (SELECT 1 FROM sys.Databases WHERE name = 'QLSV')
    EXEC('CREATE DATABASE QLSV');
use QLSV;
go
create table tbl_LopQL(
	MaLop VARCHAR(50) primary key,
	TenLop VarChar(100) not null,
	create_at datetime2 default SYSDatetime(),
	update_at datetime2,
	delete_at Datetime2,
	isDelete bit
)
Create table tbl_SinhVien(
	MaSV int identity primary key,
	TenSV NVarChar(200) not null,
	NgaySinh Date not null,
	MaLop VARCHAR(50),
	GioiTinh varchar(50),
	Email Varchar(50),
	CONSTRAINT FK_DatPhong_KhachHang foreign key (MaLop) references tbl_LopQL(MaLop),
	create_at datetime2 default SYSDatetime(),
	update_at datetime2,
	delete_at Datetime2,
	isDelete bit
)
INSERT INTO tbl_LopQL (MaLop, TenLop, isDelete)
VALUES
('CNTT1', 'Cong nghe thong tin 1', 0),
('CNTT2', 'Cong nghe thong tin 2', 0),
('QTKD1', 'Quan tri kinh doanh 1', 0),
('KT1', 'Ke toan 1', 0),
('DL1', 'Du lich 1', 0);

INSERT INTO tbl_SinhVien (TenSV, NgaySinh, MaLop, GioiTinh, Email, isDelete)
VALUES
('Nguyen Van An', '2002-03-15', 'CNTT1', 'Nam', 'an@gmail.com', 0),
('Tran Thi Binh', '2001-11-20', 'CNTT1', 'Nu', 'binh@gmail.com', 0),
('Le Van Cuong', '2002-07-10', 'CNTT2', 'Nam', 'cuong@gmail.com', 0),
('Pham Thi Dung', '2003-01-05', 'CNTT2', 'Nu', 'dung@gmail.com', 0),
('Hoang Van Duc', '2002-09-12', 'QTKD1', 'Nam', 'duc@gmail.com', 0),
('Dang Thi Hoa', '2001-04-22', 'KT1', 'Nu', 'hoa@gmail.com', 0),
('Bui Van Khanh', '2003-05-18', 'DL1', 'Nam', 'khanh@gmail.com', 0),
('Ngo Thi Lan', '2002-12-30', 'CNTT1', 'Nu', 'lan@gmail.com', 0),
('Phan Van Minh', '2001-06-14', 'KT1', 'Nam', 'minh@gmail.com', 0),
('Vu Thi Nga', '2003-08-25', 'DL1', 'Nu', 'nga@gmail.com', 0);