create login mylogin with password = 'mylogin', check_policy = off
sp_changedbowner mylogin


create database ThanhToan
use ThanhToan

drop table Phong
drop table KhachHang

create table Phong(
	MaPhong int primary key identity(1,1),
	TenPhong nvarchar(100) not null);

create table KhachHang(
	SoHD int primary key identity(1,1),
	TenKH nvarchar(50) not null,
	SoCMND nvarchar(10) not null,
	SoTienTT money not null,
	NgayTT date not null,
	Phong int not null,
	constraint FK_MaPhong foreign key (Phong)
		references Phong(MaPhong) on delete cascade on update cascade
);

delete from KhachHang

insert into Phong values
(N'A1'),
(N'A2'),
(N'A3'),
(N'A4'),
(N'A5');

insert into KhachHang values
(N'Minhify', N'12345678', 20000, N'2024-5-22', 1),
(N'My', N'987654321', 40000, N'2024-8-11', 2),
(N'Seoul', N'135792468', 60000, N'2024-3-2', 3),
(N'Mee', N'246813579', 50000, N'2024-4-1', 4),
(N'Chloe', N'012398765', 10000, N'2024-2-21', 5);


select * from KhachHang