use master
go
if DB_ID ('QuanLyVeXe') is not null
drop database QuanLyVeXe
go
create database QuanLyVeXe
go
use QuanLyVeXe
go

create table Ghe
(
	id_ghe int,
	dong int,
	cot int,
	tang int, 
	so_ghe int,  
	Xe_XeID int,
	constraint ghe_pk
	PRIMARY KEY (id_ghe)
)	

create table Ve
(
	id_ve int,
	ghe_id_ghe int,
	chuyen_id_chuyen int,
	tinhtrang int,
	giatien smallmoney,
	khachhang_id_khachhang int,
	ngayxuatve datetime,
	ghichu varchar(40),
	constraint ve_ghe_pk
	PRIMARY KEY (id_ve)
)	
create table KhachHang
(
	id_khachhang int ,
	hoten nvarchar(4000),
	dienthoai varchar(4000),
	email varchar(4000),
	loai int
	constraint khachhang_pk
	PRIMARY KEY (id_khachhang)
)
create table Tai_Xe
(
	id_taixe int,
	tentaixe nvarchar(100),
	banglai varchar(100),
	constraint taixe_pk
	PRIMARY KEY (id_taixe)
)
create table Tram_trung_gian
(
	tuyen_id_tuyen int,
	tram_id_tram int,
	thu_tu int,
	constraint tram_trung_gian_pk
	PRIMARY KEY (tuyen_id_tuyen,tram_id_tram)
)
create table Tuyen 
(
	id_tuyen int,
	khoang_cach float,
	thoigianchay int,
	tram_id_tram1 int,
	tram_id_tram int
	constraint tuyen_pk
	PRIMARY KEY (id_tuyen)
)

create table Tram
(
	id_tram int,
	ten_tram nvarchar(4000),
	dia_diem nvarchar(4000),
	constraint tram_pk
	PRIMARY KEY (id_tram)
)

create table LoaiXe
(
	id_loaixe int,
	tenloai nvarchar(4000)
	constraint loaixe_pk
	PRIMARY KEY (id_loaixe)
)
create table Xe
(
	xe_id int, 
	ten_xe nvarchar(4000),
	so_dang_ky varchar(4000),
	loaixe_id_loaixe int,
	constraint xe_pk
	PRIMARY KEY (xe_id)
)

create table Chuyen 
(
	id_chuyen int,
	tuyen_id_tuyen int,
	giokhoihanh datetime,
	ghichu nvarchar(4000),
	xe_xeid int,
	tai_xe_id_taixe int,
	constraint chuyen_pk
	PRIMARY KEY (id_chuyen)
)
--khoa ngoai 
ALTER TABLE Ve
ADD 
CONSTRAINT ve_ghe_fk
FOREIGN KEY(ghe_id_ghe)
REFERENCES Ghe,
CONSTRAINT ve_chuyen_fk
FOREIGN KEY(chuyen_id_chuyen)
REFERENCES Chuyen,
CONSTRAINT ve_khachhang1_fk
FOREIGN KEY(khachhang_id_khachhang)
REFERENCES KhachHang

ALTER TABLE Ghe
ADD 
CONSTRAINT ghe_xe_fk
FOREIGN KEY(Xe_XeID)
REFERENCES Xe

ALTER TABLE Xe
ADD 
CONSTRAINT xe_loaixe_fk
FOREIGN KEY(loaixe_id_loaixe)
REFERENCES LoaiXe

ALTER TABLE Chuyen
ADD 
CONSTRAINT chuyen_taixe_fk
FOREIGN KEY(tai_xe_id_taixe)
REFERENCES Tai_Xe,
CONSTRAINT chuyen_tuyen_fk
FOREIGN KEY(tuyen_id_tuyen)
REFERENCES Tuyen,
CONSTRAINT ve_khachhang_fk
FOREIGN KEY(xe_xeid)
REFERENCES Xe

ALTER TABLE Tuyen
ADD 
CONSTRAINT tuyen_tram_fk
FOREIGN KEY(tram_id_tram)
REFERENCES Tram,
CONSTRAINT chuyen_tram2_fk
FOREIGN KEY(tram_id_tram1)
REFERENCES Tram

ALTER TABLE Tram_trung_gian
ADD 
CONSTRAINT ttg_tuyen_fk
FOREIGN KEY(tuyen_id_tuyen)
REFERENCES Tuyen,
CONSTRAINT ttg_tram_fk
FOREIGN KEY(tram_id_tram)
REFERENCES Tram
