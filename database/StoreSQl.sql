--Load khach hang 

create proc sp_LoadKhachHang
as
begin 
	select* from KhachHang
end
go
create proc sp_LoadIDKhachHang
as
begin 
	select kh.id_khachhang from KhachHang kh
end

go
create proc sp_IDKhachHang
as
begin 
	select id_khachhang from KhachHang
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
create proc sp_LoadIDChuyenXe 
as
begin 
	select id_chuyen from Chuyen
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

alter proc sp_SuaChuyenXe
@id_chuyen varchar(10), @tuyen_id_tuyen varchar(10),@giokhoihanh datetime,@xe_xeid varchar(10),@ghichu nvarchar(4000),@tai_xe_id_taixe varchar(10)
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

create proc sp_IDTaiXe 
as
begin 
	select id_taixe from Tai_Xe
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


-- TRẠM
create proc sp_LoadTram 
as
begin 
	select* from Tram
end
go

create proc sp_LoadIDTram 
as
begin 
	select id_tram from Tram
end
go
-- Thêm trạm
create proc sp_ThemTram 
	@id_tram varchar(10),@ten_tram nvarchar(4000),@dia_diem nvarchar(4000)
as
begin 
	insert into Tram(id_tram,ten_tram,dia_diem)
	values(@id_tram,@ten_tram,@dia_diem)
	return 1
end 
go

create proc sp_XoaTram
 @id_tram varchar(10)
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
create proc sp_GetIDTuyen
@GhiChu nvarchar(4000)
as
begin
	Select distinct tuyen_id_tuyen From Chuyen Where ghichu = @GhiChu
end
go
create proc sp_GetIDChuyen
@GhiChu nvarchar(4000)
as
begin
	Select distinct id_chuyen From Chuyen Where ghichu = @GhiChu
end
go

-- Xe
create proc sp_LoadXe
as
begin
	Select * From Xe
end
go

create proc sp_IDXe
as
begin
	Select xe_id From Xe
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

create proc sp_LoadLoaiXe
as
	Select id_loaixe From LoaiXe
go
----Tuyen Xe
create proc sp_LoadTuyenXe
as
	Select * From Tuyen

go

create proc sp_IDTuyen
as
	Select id_tuyen From Tuyen

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
go
----Gia Ve

create proc sp_LoadGiaVe
as
	Select * From GiaVe
go
create proc sp_XoaGiaVe
@STT int ,@ID varchar(10) 
as
begin
	if(not exists (select * from GiaVe where stt = @STT and id_tuyen_id = @ID))
			return 0
	else
	Delete From GiaVe
	Where stt = @STT and id_tuyen_id = @ID
	
end
go
create proc sp_ThemGiaVe
@id_ve int , @id_tuyen_id varchar(10) , @gia_ve float
as
begin 
	Insert into GiaVe
	Values( @id_ve , @id_tuyen_id , @gia_ve)
end
go
alter proc sp_SuaGiaVe
@id_ve int , @id_tuyen_id varchar(10) , @gia_ve float
as
begin 
	if(not exists (select * from GiaVe where stt = @id_ve and id_tuyen_id = @id_tuyen_id))
			return 0
	else
	Update GiaVe
	Set gia_ve = @gia_ve
	Where stt =@id_ve and id_tuyen_id = @id_tuyen_id
end
go
create proc sp_LoadIDGiaVe
as
begin
	Select stt , id_tuyen_id From GiaVe
end
go
create proc sp_GetGiaVe
@ID varchar(10) 
as
begin
	Select gia_ve From GiaVe Where id_tuyen_id = @ID
end
--exec sp_GetGiaVe 'T01'
go
create proc sp_AddNguoiDat
@id_ve varchar(10) , @stt int , @ten_khach_hang nvarchar(50) , @so_dt varchar(15) , @ghe_id_ghe varchar(10) , @chuyen_id_chuyen varchar(10) , @tinhtrang int , @giatien float , @ngayxuatve datetime , @ghichu nvarchar(40)
as
begin
	
	insert into DanhSachNguoiDat
	values(@id_ve, @stt ,@ten_khach_hang ,@so_dt ,@ghe_id_ghe ,@chuyen_id_chuyen, @tinhtrang, @giatien, @ngayxuatve ,@ghichu )

end
go
alter function f_MaVeMoi ()
returns varchar(10)
as
begin
	Declare c cursor for
	Select id_ve 
	From DanhSachNguoiDat
	Declare @MaVe varchar(10)
	Open c
	fetch next from c into @MaVe 
	Declare @tempMV varchar(10) = @MaVe
	while @@FETCH_STATUS = 0
	begin
		Declare @i int 
		set @i = convert(int , substring(@MaVe,2,2))
		set @i += 1
		Declare @MA varchar(5)
		if(@i < 10)
			set @MA = '0' + cast(@i as varchar(10))
		else
			set @MA = cast(@i as varchar(10))
		set @tempMV = 'V' + @MA
		fetch next from c into @MaVe 
	end
	Close c
	Deallocate c
	if(@tempMV is null)
		Set @tempMV = 'V01'
	return @tempMV
end
go
create function f_VeMoi ()
returns varchar(10)
as
begin
	Declare c cursor for
	Select id_ve 
	From Ve
	Declare @MaVe varchar(10)
	Open c
	fetch next from c into @MaVe 
	Declare @tempMV varchar(10) = @MaVe
	while @@FETCH_STATUS = 0
	begin
		Declare @i int 
		set @i = convert(int , substring(@MaVe,2,2))
		set @i += 1
		Declare @MA varchar(5)
		if(@i < 10)
			set @MA = '0' + cast(@i as varchar(10))
		else
			set @MA = cast(@i as varchar(10))
		set @tempMV = 'V' + @MA
		fetch next from c into @MaVe 
	end
	Close c
	Deallocate c
	if(@tempMV is null)
		Set @tempMV = 'V01'
	return @tempMV
end
go
create proc sp_MaVeMoi
as
	Select dbo.f_MaVeMoi()
go
create proc sp_VeMoi
as
	Select dbo.f_VeMoi()
go

--exec sp_MaVeMoi

create proc sp_LoadNguoiDat
as
	Select * From DanhSachNguoiDat
go
--exec sp_LoadNguoiDat
create proc sp_LoadIDVe
as
begin
	Select id_ve
	From Ve
end
go
alter proc sp_ThemVe
@id_ve varchar(10) , @ghe_id_ghe varchar(10) , @chuyen_id_chuyen varchar(10), @tinhtrang int , @giatien money ,@khachhang_id_khachhang varchar(10) , @ngayxuatve datetime , @ghichu nvarchar(40)
as
begin 
	if(exists( select * from Ve where id_ve = @id_ve))
	begin
		return 0
	end
	ALTER TABLE Ve NOCHECK CONSTRAINT ve_ghe_fk
	insert into Ve
	values (@id_ve , @ghe_id_ghe , @chuyen_id_chuyen , @tinhtrang ,@giatien ,@khachhang_id_khachhang ,@ngayxuatve ,@ghichu)
	ALTER TABLE Ve CHECK CONSTRAINT ve_ghe_fk
end
go
alter proc sp_DELNguoiDat
@id_ve varchar(10) , @stt int
as
begin
	if(not exists( select * from DanhSachNguoiDat where id_ve = @id_ve and stt = @stt))
	begin
		return 0
	end
	Delete from DanhSachNguoiDat
	Where id_ve = @id_ve and stt = @stt
END
GO 
CREATE PROC sp_CheckUser
@ID varchar(50), @Pass VARCHAR(50)
AS
BEGIN
	SELECT COUNT(*) AS KiemTra FROM dbo.Users WHERE UserName = @ID AND Password = @Pass

END
GO
--SELECT * FROM  dbo.Users

--------------
alter proc sp_FindKH
@hoten varchar(10)
as
	Select id_khachhang , hoten 
	From KhachHang 
	Where hoten like '%'+@hoten+'%'
exec sp_FindKH 'Nguy'