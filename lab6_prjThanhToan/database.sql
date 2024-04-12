create login mylogin with password = 'mylogin', check_policy = off
sp_changedbowner mylogin


create database ThanhToan
use ThanhToan

create table Phong(
	MaPhong int primary key,
	TenPhong nvarchar(100) not null);

create table KhachHang(
	SoHD int primary key,
	TenKH nvarchar(50) not null,
	SoCMND int not null,
	NgayTT date not null,
	Phong int not null,
	constraint FK_MaPhong foreign key (Phong)
		references Phong(MaPhong) on delete cascade on update cascade
);