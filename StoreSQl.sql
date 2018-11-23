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
create proc sp_XoaKhachHang @idKH varchar(10)
as
begin 
	if(not exists (select * from KhachHang where id_khachhang = @idKH))
		return 0
	else 
	begin
			ALTER TABLE Ve NOCHECK CONSTRAINT ve_khachhang_fk
			DELETE FROM KhachHang
			WHERE id_khachhang = @idKH
			ALTER TABLE Ve CHECK CONSTRAINT ve_khachhang_fk
			return 1
	end

end 
go

create proc sp_SuaKhachHang
	@idKH varchar(10), @hoten nvarchar(4000), @dienthoai varchar(4000), @email varchar(4000),@loai int
as
begin 
	if(not exists (select * from KhachHang where id_khachhang = @idKH))
		return 0
	else
		begin 
			update KhachHang
			set id_khachhang = @idKH,
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
	@idChuyen varchar(10), @idtuyen varchar(10),@gioKH datetime,@ghichu nvarchar(4000),@idxe varchar(10),@idtaixe varchar(10)
as
begin 
	insert into Chuyen(id_chuyen,tuyen_id_tuyen,giokhoihanh,ghichu,xe_xeid,tai_xe_id_taixe)
	values(@idChuyen,@idtuyen,@gioKH,@ghichu,@idxe,@idtaixe)
	return 1
end 
go

create proc sp_XoaChuyenXe @idchuyen varchar(10)
as
begin 
	if(not exists (select * from Chuyen where id_chuyen = @idchuyen))
		return 0
	else 
	begin
			ALTER TABLE Ve NOCHECK CONSTRAINT ve_chuyen_fk
			DELETE FROM Chuyen
			WHERE id_chuyen = @idchuyen
			ALTER TABLE Ve CHECK CONSTRAINT ve_chuyen_fk
			return 1
	end
end 
go

create proc sp_SuaChuyenXe
	@idChuyen varchar(10), @idtuyen varchar(10),@gioKH datetime,@ghichu nvarchar(4000),@idxe varchar(10),@idtaixe varchar(10)
as
begin 
	if(not exists (select * from Chuyen where id_chuyen = @idchuyen))
		return 0
	else
		begin 
			update Chuyen
			set id_chuyen = @idChuyen,
				@idtuyen = @idtuyen,
				giokhoihanh = @gioKH,
				ghichu = @ghichu,
				xe_xeid = @idxe,
				tai_xe_id_taixe = @idtaixe
			return 1
		end
end
go