create database Books
go 
use Books 
go

create table TacGia
(
	MaTacGia nchar(9) primary key not null,
	TenTacGia nvarchar(50) not null,
	DiaChiTG nvarchar(50) not null,
	TieuSu nvarchar(50) not null,
	DienThoaiTG char(10) not null,
	EmailTG varchar(30) not null,
)

create table NhaXuatBan
(
	MaNhaXuatBan nchar(9) primary key not null,
	TenNhaXuatBan nvarchar(50) not null,
	DiaChiNXB nvarchar(50) not null,
	DienThoaiNXB nvarchar(50) not null,
	EmailNXB varchar(30) not null,
)
create table TheLoai
(
	MaTheLoai nchar(9) primary key not null,
	TenTheLoai nvarchar(50) not null,
	DienGiaiTL nvarchar(50),

)

create table Sach
(
	MaSach nchar(9) primary key not null,
	TenSach nvarchar(30) not null,
	GiaBia int not null,
	NamXuatBan date not null,
	BiaTruoc image,
	BiaSau image,
)

create table TrangMau
(
	MaTrangMau nchar(9) primary key not null,
	MaSach char(9) not null,
	LienKet image,

)
create table DonHang
(
	MaDonHang nchar(9) primary key not null,
	NgayDatHang date not null,
	NgayGiaoHang date not null,
	TrangThaiDH nvarchar(15) not null,
)
create table Gia
(
	MaGia nchar(9) primary key not null,
	NgayBatDau date not null,
	NgayKetThuc date not null,
	Gia int not null,
	TrangThaiGia nvarchar(15) not null,
)
create table KhachHang
(
	MaKhachHang nchar(9) primary key not null,
	HoTenKH nvarchar(50) not null,
	DiaChi nvarchar(50) not null,
	DienThoaiKH char(10) not null,
	EmailKH nvarchar(30) not null,

)
create table NhanVien
(
	MaNhanVien nchar(9) primary key not null,
	HoTenNV nvarchar(50) not null,
	TenDangNhap nchar(15) not null,
	MatKhau nchar(30) not null,
	DiaChiNV nvarchar(50) not null,
	DienThoaiNV char(10) not null,
	EmailNV nvarchar(30) not null,
)

create table Quyen
(
	MaQuyen nchar(9) primary key not null,
	TenQuyen nvarchar(50) not null,
	DienGiaiQuyen nchar(10) not null,
)


create table Sach_TacGia
(
	MaSach nchar(9) not null,
	MaTacGia nchar(9) not null,
	primary key (MaSach, MaTacGia),
)

create table Sach_TheLoai
(
	MaSach nchar(9) not null,
	MaTacGia nchar(9) not null,
	primary key (MaSach,MaTacGia),
)
create table Sach_DonHang_KhachHang
(
	MaSach nchar(9) not null,
	MaDonHang nchar(9) not null,
	MaKhachHang nchar(9) not null,
	primary key (MaSach, MaDonHang, MaKhachHang),
	Gia int not null,
	SoLuong int not null,
)
create table NhanVien_Quyen
(
	MaNhanVien nchar(9) not null,
	MaQuyen nchar(9) not null,
)


alter table DonHang
add constraint df_TrangThaiDH
default 'Đang cập nhật' for TrangThaiDH

--dqeqw
ALTER TABLE Sach ADD CONSTRAINT CHK_GiaPositive CHECK (GiaBia > 0);

ALTER TABLE TacGia ADD CONSTRAINT UQ_TenTacGia UNIQUE (TenTacGia);

SELECT Sach.TenSach, TacGia.TenTacGia
FROM Sach
INNER JOIN Sach_TacGia ON Sach.MaSach = Sach_TacGia.MaSach
INNER JOIN TacGia ON Sach_TacGia.MaTacGia = TacGia.MaTacGia
WHERE Sach.NamXuatBan >= '  ' AND TacGia.TieuSu LIKE '  '
ORDER BY Sach.NamXuatBan DESC;

SELECT TheLoai.TenTheLoai, COUNT(*) AS TongSoSach
FROM Sach
INNER JOIN Sach_TheLoai ON Sach.MaSach = Sach_TheLoai.MaSach
INNER JOIN TheLoai ON Sach_TheLoai.MaTheLoai = TheLoai.MaTheLoai
WHERE Sach.NamXuatBan >= '2022-01-01'
GROUP BY TheLoai.TenTheLoai
HAVING COUNT(*) > 5;


