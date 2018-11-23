--Load khach hang 

create proc sp_LoadKhachHang
as
begin 
	select* from KhachHang
end
go

create proc sp_ThemKhachHang 
	@id_khachhang varchar(10), @hoten nvarchar(4000), @dienthoai varchar(4000), @email varchar(4000),@loai int
as
begin 
	insert into KhachHang(id_khachhang,hoten,dienthoai,email,loai)
	values(@id_khachhang,@hoten,@dienthoai,@email,@loai)
	return 1
end 
go
-- xoa khach hang 
create proc sp_XoaKhachHang @id_khachhang varchar(10)
as
begin 
	if(not exists (select * from KhachHang where id_khachhang = @id_khachhang))
		return 0
	else 
	begin
			ALTER TABLE Ve NOCHECK CONSTRAINT ve_khachhang_fk
			DELETE FROM KhachHang
			WHERE id_khachhang = @id_khachhang
			ALTER TABLE Ve CHECK CONSTRAINT ve_khachhang_fk
			return 1
	end

end 
go

create proc sp_SuaKhachHang
	@id_khachhang varchar(10), @hoten nvarchar(4000), @dienthoai varchar(4000), @email varchar(4000),@loai int
as
begin 
	if(not exists (select * from KhachHang where id_khachhang = @id_khachhang))
		return 0
	else
		begin 
			update KhachHang
			set id_khachhang = @id_khachhang,
				hoten = @hoten,
				dienthoai = @dienthoai,
				email = @email,
				loai = @loai
			return 1
		end
end
go
--load chuyến xe 
create proc sp_LoadChuyenXe 
as
begin 
	select* from Chuyen
end
go

create proc sp_ThemChuyenXe 
	@id_chuyen varchar(10), @tuyen_id_tuyen varchar(10),@giokhoihanh datetime,@ghichu nvarchar(4000),@xe_xeid varchar(10),@tai_xe_id_taixe varchar(10)
as
begin 
	insert into Chuyen(id_chuyen,tuyen_id_tuyen,giokhoihanh,ghichu,xe_xeid,tai_xe_id_taixe)
	values(@id_chuyen,@tuyen_id_tuyen,@giokhoihanh,@ghichu,@xe_xeid,@tai_xe_id_taixe)
	return 1
end 
go

create proc sp_XoaChuyenXe @id_chuyen varchar(10)
as
begin 
	if(not exists (select * from Chuyen where id_chuyen = @id_chuyen))
		return 0
	else 
	begin
			ALTER TABLE Ve NOCHECK CONSTRAINT ve_chuyen_fk
			DELETE FROM Chuyen
			WHERE id_chuyen = @id_chuyen
			ALTER TABLE Ve CHECK CONSTRAINT ve_chuyen_fk
			return 1
	end
end 
go

create proc sp_SuaChuyenXe
	@id_chuyen varchar(10), @tuyen_id_tuyen varchar(10),@giokhoihanh datetime,@ghichu nvarchar(4000),@xe_xeid varchar(10),@tai_xe_id_taixe varchar(10)
as
begin 
	if(not exists (select * from Chuyen where id_chuyen = @id_chuyen))
		return 0
	else
		begin 
			update Chuyen
			set id_chuyen = @id_chuyen,
				tuyen_id_tuyen = @tuyen_id_tuyen,
				giokhoihanh = @giokhoihanh,
				ghichu = @ghichu,
				xe_xeid = @xe_xeid,
				tai_xe_id_taixe = @tai_xe_id_taixe
			return 1
		end
end
go

--tài xê
create proc sp_LoadTaiXe 
as
begin 
	select* from Tai_Xe
end
go

create proc sp_ThemTaiXe 
	@id_taixe varchar(10), @tentaixe nvarchar(100),@banglai nvarchar(100)
as
begin 
	insert into Tai_Xe(id_taixe,tentaixe,banglai)
	values(@id_taixe,@tentaixe,@banglai)
	return 1
end 
go

create proc sp_XoaTaiXe @id_taixe varchar(10)
as
begin 
	if(not exists (select * from Tai_Xe where id_taixe = @id_taixe))
		return 0
	else 
	begin
			ALTER TABLE Chuyen NOCHECK CONSTRAINT chuyen_taixe_fk
			DELETE FROM Tai_Xe
			WHERE id_taixe = @id_taixe
			ALTER TABLE Chuyen CHECK CONSTRAINT chuyen_taixe_fk
			return 1
	end
end 
go

create proc sp_SuaTaiXe
	@id_taixe varchar(10), @tentaixe nvarchar(100),@banglai nvarchar(100)
as
begin 
	if(not exists (select * from Tai_Xe where id_taixe = @id_taixe))
		return 0
	else
		begin 
			update Tai_Xe
			set id_taixe = @id_taixe,
				tentaixe = @tentaixe,
				banglai = @banglai			
			return 1
		end
end
go

--GHẾ

create proc sp_LoadTram 
as
begin 
	select* from Tram
end
go

create proc sp_ThemTram 
	@id_tram varchar(10),@ten_tram nvarchar(4000),@dia_diem nvarchar(4000)
as
begin 
	insert into Tram(id_tram,ten_tram,dia_diem)
	values(@id_tram,@ten_tram,@dia_diem)
	return 1
end 
go

create proc sp_XoaTram @id_tram varchar(10)
as
begin 
	if(not exists (select * from Tram where id_tram = @id_tram))
		return 0
	else 
	begin
			ALTER TABLE Tuyen NOCHECK CONSTRAINT tuyen_tram_fk
			DELETE FROM Tram
			WHERE id_tram = @id_tram
			ALTER TABLE Tuyen CHECK CONSTRAINT tuyen_tram_fk

			ALTER TABLE Tuyen NOCHECK CONSTRAINT chuyen_tram2_fk
			DELETE FROM Tram
			WHERE id_tram = @id_tram
			ALTER TABLE Tuyen CHECK CONSTRAINT tuyen_tram_fk

			ALTER TABLE Tram_trung_gian NOCHECK CONSTRAINT chuyen_tram2_fk
			DELETE FROM Tram
			WHERE id_tram = @id_tram
			ALTER TABLE Tram_trung_gian CHECK CONSTRAINT chuyen_tram2_fk

			return 1
	end
end 
go

create proc sp_SuaTram
	@id_tram varchar(10),@ten_tram nvarchar(4000),@dia_diem nvarchar(4000)
as
begin 
	if(not exists (select * from Tram where id_tram = @id_tram))
		return 0
	else
		begin 
			update Tram
			set id_tram = @id_tram,
				ten_tram = @ten_tram,
				dia_diem = @dia_diem			
			return 1
		end
end
go

create proc sp_LayTenLoaiXe
as
begin
	Select tenloai  From LoaiXe
end
go
create proc sp_LoadGhiChuChuyenXe
as
begin
	Select distinct ghichu From Chuyen
end



