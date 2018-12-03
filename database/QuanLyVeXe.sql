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
	id_ghe varchar(10),
	dong int,
	cot int,
	tang int, 
	so_ghe int,  
	Xe_XeID varchar(10),
	constraint ghe_pk
	PRIMARY KEY (id_ghe)
)	

create table Ve
(
	id_ve varchar(10),
	ghe_id_ghe varchar(10),
	chuyen_id_chuyen varchar(10),
	tinhtrang int,
	giatien money,
	khachhang_id_khachhang varchar(10),
	ngayxuatve datetime,
	ghichu nvarchar(40),
	constraint ve_ghe_pk
	PRIMARY KEY (id_ve)
)	
create table KhachHang
(
	id_khachhang varchar(10) ,
	hoten nvarchar(4000),
	dienthoai varchar(4000),
	email varchar(4000),
	loai int
	constraint khachhang_pk
	PRIMARY KEY (id_khachhang)
)
create table Tai_Xe
(
	id_taixe varchar(10),
	tentaixe nvarchar(100),
	banglai Nvarchar(100),
	constraint taixe_pk
	PRIMARY KEY (id_taixe)
)
create table Tram_trung_gian
(
	tuyen_id_tuyen varchar(10),
	tram_id_tram varchar(10),
	thu_tu int,
	constraint tram_trung_gian_pk
	PRIMARY KEY (tuyen_id_tuyen,tram_id_tram)
)
create table Tuyen 
(
	id_tuyen varchar(10),  
	khoang_cach float,
	thoigianchay int,
	tram_id_tram1 varchar(10),
	tram_id_tram varchar(10)
	constraint tuyen_pk
	PRIMARY KEY (id_tuyen)
)

create table Tram
(
	id_tram varchar(10),
	ten_tram nvarchar(4000),
	dia_diem nvarchar(4000),
	constraint tram_pk
	PRIMARY KEY (id_tram)
)

create table LoaiXe
(
	id_loaixe varchar(10),
	tenloai nvarchar(4000)
	constraint loaixe_pk
	PRIMARY KEY (id_loaixe)
)
create table Xe
(
	xe_id varchar(10), 
	ten_xe nvarchar(4000),
	so_dang_ky varchar(4000),
	loaixe_id_loaixe varchar(10),
	constraint xe_pk
	PRIMARY KEY (xe_id)
)

create table Chuyen 
(
	id_chuyen varchar(10),
	tuyen_id_tuyen varchar(10),
	giokhoihanh datetime,
	ghichu nvarchar(4000),
	xe_xeid varchar(10),
	tai_xe_id_taixe varchar(10),
	constraint chuyen_pk
	PRIMARY KEY (id_chuyen)
)

create table GiaVe
(	
	stt int,
	id_tuyen_id varchar(10),
	gia_ve float
	constraint giave_pk
	PRIMARY KEY (stt,id_tuyen_id)
)

create table DanhSachNguoiDat
(
	stt int,	
	id_ve_id varchar(10),
	hoten nvarchar(100),
	sdt varchar(15),
	constraint dsnd_pk
	PRIMARY KEY (stt,id_ve_id)
)
--khoa ngoai 
ALTER TABLE DanhSachNguoiDat
ADD 
CONSTRAINT dsnd_Ve_fk
FOREIGN KEY(id_ve_id)
REFERENCES Ve

ALTER TABLE GiaVe
ADD 
CONSTRAINT gia_tuyen_fk
FOREIGN KEY(id_tuyen_id)
REFERENCES Tuyen

ALTER TABLE Ve
ADD 
CONSTRAINT ve_chuyen_fk
FOREIGN KEY(chuyen_id_chuyen)
REFERENCES Chuyen,
CONSTRAINT ve_khachhang_fk
FOREIGN KEY(khachhang_id_khachhang)
REFERENCES KhachHang,
CONSTRAINT ve_ghe_fk
FOREIGN KEY(ghe_id_ghe)
REFERENCES Ghe

ALTER TABLE Ghe
ADD 
CONSTRAINT ghe1_xe_fk
FOREIGN KEY(Xe_XeID)
REFERENCES Xe

ALTER TABLE Xe
ADD 
CONSTRAINT xe_loaixe_fk
FOREIGN KEY(loaixe_id_loaixe)
REFERENCES LoaiXe

ALTER TABLE Chuyen
ADD 
CONSTRAINT chuyen_tuyen_fk
FOREIGN KEY(tuyen_id_tuyen)
REFERENCES Tuyen,
CONSTRAINT chuyen_taixe_fk
FOREIGN KEY(tai_xe_id_taixe)
REFERENCES Tai_Xe,
CONSTRAINT chuyen_xe_fk
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



insert Tai_Xe
values 
('TX01',N'Nguyễn Mai Thi',N'bằng A2'),
('TX02',N'Nguyễn Thanh Phong',N'bằng A2'),
('TX03',N'Nguyễn Thị Thìn',N'bằng A2'),
('TX04',N'Trần Thị Bích Phương',N'bằng A2'),
('TX05',N'Nguyễn Thị Mỹ Tiên',N'bằng A2'),
('TX06',N'Nguyễn Văn Đức',N'bằng A2'),
('TX07',N'Nguyễn Văn Độ',N'bằng A2'),
('TX08',N'Trần Hưng Mạnh',N'bằng A2'),
('TX09',N'Nguyễn Văn An',N'bằng A2'),
('TX10',N'Nguyễn Văn Nga',N'bằng A2')

insert Xe
values 
('X01',N'BA THI','S01','LX01'),
('X02',N'HAI PHONG','S02','LX02'),
('X03',N'BẢY TÀU ','S03','LX03'),
('X04',N'PHƯƠNG TRANG','S04','LX01'),
('X05',N'SÁU ĐÀI','S05','LX02'),
('X06',N'SÁU','S06','LX03'),
('X07',N'BẢY TỴ','S07','LX01'),
('X08',N'BẢY TÈO','77-D1','LX02'),
('X09',N'THANH PHONG','77-D2','LX03'),
('X10',N'THÀNH LONG','77-D4','LX01')

INSERT LoaiXe
VALUES
('LX01',N'30 CHỖ'),
('LX02',N'45 CHỖ'),
('LX03',N'GIƯỜNG NẰM')

INSERT Ghe
VALUES
('G01',1,1,1,30,'X01'),
('G02',2,1,1,30,'X01'),
('G03',4,1,1,30,'X01'),
('G04',5,1,1,30,'X02'),
('G05',6,1,1,30,'X02'),
('G06',1,2,3,30,'X03'),
('G07',2,2,3,30,'X03'),
('G08',3,2,3,30,'X04'),
('G09',4,1,2,30,'X04'),
('G10',7,1,2,30,'X04'),
('G11',8,1,1,30,'X05'),
('G12',1,5,1,30,'X06'),
('G13',2,5,1,30,'X06'),
('G14',3,5,1,30,'X06'),
('G15',4,5,2,30,'X07'),
('G16',5,5,2,30,'X10')

INSERT Ve
VALUES
('V01','G01','C01',1,200.0,'KH01','2018/11/30',N'KHÔNG ĐƯỢC LÀM RÁCH VÉ'),
('V02','G02','C02',1,200.0,'KH02','2018/11/30',N'KHÔNG ĐƯỢC LÀM RÁCH VÉ'),
('V03','G03','C03',1,200.0,'KH03','2018/11/30',N'KHÔNG ĐƯỢC LÀM RÁCH VÉ'), 
('V04','G04','C04',1,300.0,'KH04','2018/12/01',N'KHÔNG ĐƯỢC LÀM RÁCH VÉ'),
('V05','G05','C05',0,300.0,'KH05','2018/12/01',N'KHÔNG ĐƯỢC LÀM RÁCH VÉ')

insert KhachHang
values
('KH01',N'Trần Thị Bích Phương','0783478386','ttbp@gmail.com',1),
('KH02',N'Nguyễn Thị Thìn',N'0784562123','nnt@gmail.com',1),
('KH03',N'Nguyễn Thị Tuyết Thảo',N'078365789','nttt@gmail.com',1),
('KH04',N'Trần Thị Bích Hân','0783474315','ttbhan@gmail.com',1),
('KH05',N'Nguyễn Thị Thu Hồng',N'078390880','ntthong@gmail.com',1),
('KH06',N'Nguyễn Thị Kim Yến',N'078654888','ntkyen@gmail.com',1),
('KH07',N'Trần Trung Nguyên',N'0783478386','ttnguyen@gmail.com',1),
('KH08',N'Trần Nguyễn Hoàng Khôi',N'0783478386','tnhkhoi@gmail.com',1)

insert Tuyen
values
('T01',678.8,14,'TR01','TR02'),
('T02',678.8,14,'TR02','TR01'),
('T03',100.9,3,'TR03','TR04'),
('T04',100.9,3,'TR04','TR03'),
('T05',801.5,20,'TR05','TR06'),
('T06',801.5,20,'TR06','TR05')

insert Chuyen
values
('C01','T01','08:00',N'TPHCM -QUY NHƠN ','X01','TX01'),
('C02','T01','10:00',N'TPHCM -QUY NHƠN ','X02','TX02'),
('C03','T01','17:00',N'TPHCM -QUY NHƠN ','X03','TX03'),
('C04','T02','08:00',N'QUY NHƠN - TPHCM','X04','TX04'),
('C05','T02','10:00',N'QUY NHƠN - TPHCM ','X05','TX05'),
('C06','T02','19:00',N'QUY NHƠN - TPHCM ','X06','TX06'),
('C07','T03','08:00',N'TPHCM -VŨNG TÀU ','X07','TX07'),
('C08','T03','10:00',N'TPHCM -VŨNG TÀU ','X08','TX08'),
('C09','T03','20:00',N'TPHCM -VŨNG TÀU ','X09','TX09'),
('C10','T04','08:00',N'VŨNG TÀU -TPHCM ','X10','TX10'),
('C11','T04','10:00',N'VŨNG TÀU -TPHCM','X01','TX01'),
('C12','T04','20:00',N'VŨNG TÀU -TPHCM','X07','TX07'),
('C13','T05','08:00',N'TPHCM -ĐÀ NẴNG ','X01','TX01'),
('C14','T05','10:00',N'TPHCM -ĐÀ NẴNG ','X02','TX02'),
('C15','T05','20:00',N'TPHCM -ĐÀ NẴNG ','X03','TX03'),
('C16','T06','08:00',N'ĐÀ NẴNG-TPHCM ','X04','TX04'),
('C17','T06','17:00',N'ĐÀ NẴNG-TPHCM ','X05','TX05'),
('C18','T06','20:00',N'ĐÀ NẴNG-TPHCM ','X06','TX06')

INSERT Tram
VALUES
('TR01',N'TPHCM- QUY NHƠN',N'1 Bạch Đằng ,tphcm'),
('TR02',N'QuyNhon- tphcm',N'bến xe quy nhơn, bình định'),
('TR03',N'TPHCM- VŨNG TÀU',N'1 Bạch Đằng ,tphcm'),
('TR04',N'Vũng Tàu - tphcm',N'Bến xe vũng  tàu'),
('TR05',N'TPHCM - ĐÀ NẴNG',N'Bến xe miền đông ,tphcm'),
('TR06',N'Đà Nẵng- tphcm',N'Bến xe bạch đằng')

INSERT Tram_trung_gian
values
('T01','TR01',1),
('T02','TR02',2),
('T03','TR03',3),
('T04','TR04',4),
('T05','TR05',5)

insert GiaVe
values
(1,'T01',200.0),
(2,'T02',200.0),
(3,'T03',300.0),
(4,'T04',300.0),
(5,'T05',350.0),
(6,'T06',350.0)

insert DanhSachNguoiDat
values
(1,'V01',N'Nguyễn Trần Hoài Anh','0128515675'),
(2,'V02',N'Trần Quang Phú','0918463363'),
(3,'V03',N'Dương Câm Linh','0963125521'),
(4,'V04',N'Nguyễn Quang Công','0971345678'),
(5,'V05',N'Thái Thiện Thành','0128515675')

select* from DanhSachNguoiDat


