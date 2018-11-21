if DB_ID('QLNhaXe') is null
	create database QLNhaXe;
go

use QLNhaXe;
go
if object_id('Chuyen') is not null
  drop table Chuyen;
 go
 if object_id('Ve') is not null
  drop table Ve;
 go
 if object_id('Ghe') is not null
  drop table Ghe;
 go
 if object_id('Xe') is not null
  drop table Xe;
 go
 if object_id('LoaiXe') is not null
  drop table LoaiXe;
 go
 if object_id('Tuyen') is not null
  drop table Tuyen;
 go
 if object_id('Tai_Xe') is not null
  drop table Tai_Xe;
 go
 if object_id('Tram') is not null
  drop table Tram;
 go
 if object_id('Tram_Trung_Gian') is not null
  drop table Tram_Trung_Gian;
 go
 if object_id('KhachHang') is not null
  drop table KhachHang;
 go
 if OBJECT_ID('fk_Chuyen_Tai_Xe', 'f') is not null
	alter table Chuyen drop constraint fk_Chuyen_Tai_Xe;
go
 if OBJECT_ID('fk_Chuyen_Tuyen', 'f') is not null
	alter table Chuyen drop constraint fk_Chuyen_Tuyen;
go
if OBJECT_ID('fk_Chuyen_Xe', 'f') is not null
	alter table Chuyen drop constraint fk_Chuyen_Xe;
go
if OBJECT_ID('fk_Tuyen_Tram', 'f') is not null
	alter table Tuyen drop constraint fk_Tuyen_Tram;
go
if OBJECT_ID('fk_Tram_Trung_Gian_Tuyen', 'f') is not null
	alter table Tram_Trung_Gian drop constraint fk_Tram_Trung_Gian_Tuyen;
go
if OBJECT_ID('fk_fk_Tram_Trung_Gian_Tram', 'f') is not null
	alter table Tram_Trung_Gian drop constraint fk_Tram_Trung_Gian_Tram;
go
if OBJECT_ID('fk_Ve_Ghe', 'f') is not null
	alter table Ve drop constraint fk_Ve_Ghe;
go
if OBJECT_ID(' fk_Ve_Chuyen', 'f') is not null
	alter table Ve drop constraint  fk_Ve_Chuyen;
go
if OBJECT_ID('fk_Ve_KhachHang', 'f') is not null
	alter table Ve drop constraint fk_Ve_KhachHang;
go
if OBJECT_ID(' fk_Xe_LoaiXe', 'f') is not null
	alter table Xe drop constraint  fk_Xe_LoaiXe;
go
if OBJECT_ID(' fk_Ghe_Xe', 'f') is not null
	alter table Ghe drop constraint  fk_Ghe_Xe;
go

 create table Chuyen(
  ID_Chuyen int primary key,
  Tuyen_ID_Tuyen int not null,
  Gio_Khoi_Hanh date not null,
  Ghi_Chu varchar(40) not null,
  Xe_XeID int not null,
  Tai_xe_ID_TaiXe int not null

 );

 create table Xe(
 XeID int primary key,
 TenXe varchar(4000) not null,
 So_dang_ky varchar(4000) not null,
 LoaiXe_ID_LoaiXe  int not null
 
 );

 create table Tuyen(
 ID_Tuyen int primary key,
 KhoangCach    float not null,
 ThoiGianChay  int not null,
 Tram_ID_Tram1 int not null,
 Tran_ID_Tram int not null
 );
 create table Tram_Trung_Gian(
 Tuyen_ID_Tuyen int primary key,
 Tram_ID_Tram int not null,
 Thu_Tu int  not null
 );

 create table Tram(
 ID_Tram int primary key,
 TenTram varchar(4000) not null,
 Dia_Diem varchar(4000) not null
 );
 create table LoaiXe(
 ID_LoaiXe int primary key,
 TenLoai  varchar(4000) not null
 );

 create table Ghe(
 ID_Ghe int primary key,
 Dong int not null,
 Cot1 int not null,
 Tang int not null,
 So_Ghe int not null,
 Xe_XeID int not null
 );


 create table Ve(
 ID_Ve int primary key,
 Ghe_ID_Ghe int not null,
 Chuyen_ID_Chuyen int not null,
 TinhTrang int not null,
 GiaTien float not null,
 NgayXuatVe date not null, 
 GhiChu varchar(4000) not null
 );

 create table KhachHang(
 KhachHang_ID_KhachHang int primary key,
 HoTen varchar(4000) not null,
 DienThoai varchar(4000) not null,
 Email varchar(4000) not null,
 Loai int not null
 );


 create table Tai_Xe(
 ID_TaiXe int primary key,
 TenTaiXe varchar(4000) not null,
 BangLai varchar(4000) not null
 );

 alter table Chuyen add constraint fk_Chuyen_Tai_Xe
foreign key (Tai_Xe_ID_TaiXe) references Tai_Xe(ID_TaiXe);

alter table Chuyen add constraint fk_Chuyen_Tuyen
foreign key (Tuyen_ID_Tuyen) references Tuyen(ID_Tuyen);

alter table Chuyen add constraint fk_Chuyen_Xe
foreign key (Xe_XeID) references Xe(XeID);

alter table Tuyen add constraint fk_Tuyen_Tram
foreign key (Tram_ID_Tram) references Tram(ID_Tram);

alter table Tuyen add constraint fk2_Tuyen_Tram
foreign key (Tram_ID_Tram1) references Tram(ID_Tram);

alter table Tram_Trung_Gian add constraint fk_Tram_Trung_Gian_Tuyen
foreign key (Tuyen_ID_Tuyen) references Tuyen(ID_Tuyen);

alter table Tram_Trung_Gian add constraint fk_Tram_Trung_Gian_Tram
foreign key (Tram_ID_Tram) references Tram(ID_Tram);


alter table Ve add constraint fk_Ve_Ghe
foreign key (Ghe_ID_Ghe) references Ghe(ID_Ghe);


alter table Ve add constraint fk_Ve_Chuyen
foreign key (Chuyen_ID_Chuyen) references Chuyen(ID_Chuyen);

alter table Ve add constraint fk_Ve_KhachHang
foreign key (KhachHang_ID_KhachHang) references KhachHang(ID_KhachHang);

alter table Xe add constraint fk_Xe_LoaiXe
foreign key (LoaiXe_ID_LoaiXe) references LoaiXe(ID_LoaiXe);

alter table Ghe add constraint fk_Ghe_Xe
foreign key (Xe_IDXe) references Xe(XeID);






