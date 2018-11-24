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
alter proc sp_XoaKhachHang @id_khachhang varchar(10)
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
			set hoten = @hoten,
				dienthoai = @dienthoai,
				email = @email,
				loai = @loai
			where  id_khachhang = @id_khachhang
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
			set tuyen_id_tuyen = @tuyen_id_tuyen,
				giokhoihanh = @giokhoihanh,
				ghichu = @ghichu,
				xe_xeid = @xe_xeid,
				tai_xe_id_taixe = @tai_xe_id_taixe
			where  id_chuyen = @id_chuyen
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

alter proc sp_ThemTaiXe 
	@id_taixe varchar(10), @tentaixe nvarchar(100),@banglai nvarchar(100)
as
begin 
	insert into Tai_Xe(id_taixe,tentaixe,banglai)
	values(@id_taixe,@tentaixe,@banglai)
	return 1
end 
go

alter proc sp_XoaTaiXe @id_taixe varchar(10)
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

alter proc sp_SuaTaiXe
	@id_taixe varchar(10), @tentaixe nvarchar(100),@banglai nvarchar(100)
as
begin 
	if(not exists (select * from Tai_Xe where id_taixe = @id_taixe))
		return 0
	else
		begin 
			update Tai_Xe
			set tentaixe = @tentaixe,
				banglai = @banglai	
			where id_taixe = @id_taixe
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
			set ten_tram = @ten_tram,
				dia_diem = @dia_diem	
			where id_tram = @id_tram		
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
go

create proc sp_LoadXe
as
begin
	Select * From Xe
end
go

create proc ThemXe 
@xe_id varchar(10) , @ten_xe nvarchar(4000) , @so_dang_ky varchar(4000)
as
begin
		Insert into Xe(xe_id,ten_xe,so_dang_ky)
		Values(@xe_id , @ten_xe , @so_dang_ky )
end
go

alter proc sp_ThemXe
@xe_id varchar(10) , @ten_xe nvarchar(4000) , @so_dang_ky varchar(4000) , @loaixe_id_loaixe varchar(10)
as
begin 
		Exec ThemXe @xe_id , @ten_xe , @so_dang_ky
		ALTER TABLE Xe NOCHECK CONSTRAINT xe_loaixe_fk
		Update Xe
		Set loaixe_id_loaixe = @loaixe_id_loaixe
		where xe_id = @xe_id	
		ALTER TABLE Xe CHECK CONSTRAINT xe_loaixe_fk
end
go

create proc sp_XoaXe
@xe_id varchar(10)
as
begin
		ALTER TABLE Ghe NOCHECK CONSTRAINT Ghe1_Xe_fk
		ALTER TABLE Chuyen NOCHECK CONSTRAINT Chuyen_Xe_fk
		DELETE FROM Xe
		WHERE xe_id = @xe_id
		ALTER TABLE Ghe CHECK CONSTRAINT Ghe1_Xe_fk
		ALTER TABLE Chuyen CHECK CONSTRAINT Chuyen_Xe_fk
end
go

create proc sp_SuaXe 
@xe_id varchar(10) , @ten_xe nvarchar(4000) , @so_dang_ky varchar(4000) ,  @loaixe_id_loaixe varchar(10)
as
begin 
		if(not exists (select * from Xe where xe_id = @xe_id))
				return 0
		else
		begin 
			update Xe
			set ten_xe = @ten_xe,
				so_dang_ky = @so_dang_ky,
				loaixe_id_loaixe =  @loaixe_id_loaixe
			where xe_id = @xe_id
			return 1
		end
end
go

create proc sp_LoadTuyenXe
as
	Select * From Tuyen

go

alter proc sp_XoaTuyenXe
@id_tuyen varchar(10)
as
begin
	ALTER TABLE Chuyen NOCHECK CONSTRAINT chuyen_tuyen_fk
	ALTER TABLE Tram_trung_gian NOCHECK CONSTRAINT ttg_tuyen_fk
	Delete From Tuyen
	Where id_tuyen = @id_tuyen
	ALTER TABLE Chuyen CHECK CONSTRAINT chuyen_tuyen_fk
	ALTER TABLE Tram_trung_gian CHECK CONSTRAINT ttg_tuyen_fk
end
go

alter proc sp_ThemTuyenXe
@id_tuyen varchar(10) , @khoang_cach float , @thoigianchay int , @tram_id_tram1 varchar(10) , @tram_id_tram varchar(10)
as
begin
	ALTER TABLE Tuyen NOCHECK CONSTRAINT tuyen_tram_fk
	ALTER TABLE Tuyen NOCHECK CONSTRAINT chuyen_tram2_fk
	Insert into Tuyen
	values (@id_tuyen , @khoang_cach , @thoigianchay ,@tram_id_tram1 , @tram_id_tram)
	ALTER TABLE Tuyen CHECK CONSTRAINT tuyen_tram_fk
	ALTER TABLE Tuyen CHECK CONSTRAINT chuyen_tram2_fk
end
go

alter proc sp_SuaTuyenXe
@id_tuyen varchar(10) , @khoang_cach float , @thoigianchay int , @tram_id_tram varchar(10) , @tram_id_tram1 varchar(10)
as 
begin
	 if(not exists (select * from Tuyen where id_tuyen = @id_tuyen))
				return 0
		else
		begin 
			ALTER TABLE Tuyen NOCHECK CONSTRAINT tuyen_tram_fk
			ALTER TABLE Tuyen NOCHECK CONSTRAINT chuyen_tram2_fk
			update Tuyen
			set khoang_cach = @khoang_cach,
				thoigianchay = @thoigianchay,
				tram_id_tram =  @tram_id_tram,
				tram_id_tram1 = @tram_id_tram1
			where id_tuyen = @id_tuyen
			ALTER TABLE Tuyen CHECK CONSTRAINT tuyen_tram_fk
			ALTER TABLE Tuyen CHECK CONSTRAINT chuyen_tram2_fk
			return 1
		end
end