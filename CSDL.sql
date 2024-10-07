create database QLKS
go
use QLKS
go
create table nguoidung
(
	tendangnhap varchar(50) primary key,
	matkhau varchar(50),
	quyen int,
	tinhtrang int
)
go
create table nhanvien
(
	manv varchar(50) primary key,
	tennv nvarchar(100),
	ngaysinh smalldatetime,
	gioitinh nvarchar(3),
	diachi nvarchar(4000),
	sdt varchar(10),
	calamviec int,
	tinhtrang int,
	luongcoban decimal(18, 0),
	hesoluong float,
	tendangnhap varchar(50) not null,
	constraint fk_nv_nd foreign key (tendangnhap) references nguoidung(tendangnhap)
)
go
create table luong
(
	mapluong varchar(50) primary key,
	manv varchar(50),
	ngaytinhluong smalldatetime not null,
	songaynghi int,
	thuongthem decimal(18, 0),
	constraint fk_l_nv foreign key (manv) references nhanvien(manv) on delete set null
)
go
create table donvicungcap
(
	madv varchar(50) primary key,
	tendv nvarchar(100),
	sdt varchar(10),
	diachi nvarchar(4000)
)
go
create table loaiphong
(
	maloai varchar(50) primary key,
	tenloai nvarchar(100),
	gia decimal(18, 0)
)
go
create table phong
(
	maphong varchar(50) primary key,
	tenphong nvarchar(100) not null,
	tinhtrang int,
	maloai varchar(50) not null,
	constraint fk_p_lp foreign key (maloai) references loaiphong(maloai)
)
go
create table khachhang
(
	makh varchar(50) primary key,
	hoten nvarchar(100),
	cmnd varchar(50)
)
go
create table dichvu
(
	madv varchar(50) primary key,
	tendv nvarchar(100),
	dvt nvarchar(100),
	gia decimal(18, 0),
	soluong int
)
go
create table thietbi
(
	matb varchar(50) primary key,
	tentb nvarchar(100),
	dvt nvarchar(100),
	gia decimal(18,0)
)
go
create table tttp
(
	maphieu varchar(50) primary key,
	maphong varchar(50) not null,
	matb varchar(50) not null,
	soluong int,
	constraint fk_tt_lp foreign key (maphong) references phong(maphong),
	constraint fk_tttp_tt foreign key (matb) references thietbi(matb)
)
go
create table phieudatphong
(
	maphieu varchar(50) primary key,
	makh varchar(50) not null,
	ngayden smalldatetime,
	maphong varchar(50) not null,
	constraint fk_pdp_kh foreign key (makh) references khachhang(makh),
	constraint fk_pdp_p foreign key (maphong) references phong(maphong)
)
go
create table hoadon
(
	sohd varchar(50) primary key,
	makh varchar(50) not null,
	ngayden smalldatetime,
	ngaydi smalldatetime,
	maphong varchar(50) not null,
	manv varchar(50),
	constraint fk_hd_kh foreign key (makh) references khachhang(makh),
	constraint fk_hd_p foreign key (maphong) references phong(maphong),
	constraint fk_hd_nv foreign key (manv) references nhanvien(manv) on delete set null
)
go
create table cthd 
(
	sohd varchar(50) not null,
	madv varchar(50) not null,
	soluong int,
	constraint fk_cthd_hd foreign key (sohd) references hoadon(sohd),
	constraint fk_cthd_dv foreign key (madv) references dichvu(madv),
	constraint pk_cthd primary key (sohd,madv)
)
go
create table hoadonnhap
(
	sohd varchar(50) primary key,
	madv varchar(50),
	ngaynhap smalldatetime,
	constraint fk_hdn_dvcc foreign key (madv) references donvicungcap(madv) on delete set null
)
go
create table cthdnhap
(
	sohd varchar(50) not null,
	madv varchar(50) not null,
	gia decimal(18, 0),
	soluong int,
	constraint fk_cthdn_hdn foreign key (sohd) references hoadonnhap(sohd),
	constraint fk_cthdn_dv foreign key (madv) references dichvu(madv),
	constraint pk_cthdn primary key (sohd,madv)
)
go
create table thongke
(
	ten nvarchar(1000),
	giatri Decimal(18, 0),
	kieu varchar(50)
)
go
set dateformat dmy
--0 la OFFLINE
--1 la ONLINE
--1 la ADMIN
--0 la NHANVIEN
insert into nguoidung values('admin','uhWMkRMIwpxKrGRZ3XeR0g==',1,0)
insert into nguoidung values('admin1','uhWMkRMIwpxKrGRZ3XeR0g==',1,0)
insert into nguoidung values('nv001','uLx9MWsjL8NmHpowjYfq/w==',0,0)
go
insert into nhanvien values('nv001',N'Phạm Phú Huy','08/07/2000','Nam',N'Tam Kỳ, Quảng Nam','0967035017',1,0,5000000,2,'nv001')
go
insert into loaiphong values('lp001',N'VIP đơn',500000)
insert into loaiphong values('lp002',N'VIP đôi',700000)
insert into loaiphong values('lp003',N'Thường đơn',300000)
insert into loaiphong values('lp004',N'Thường đôi',400000)
go
--0 la da thue
--1 la trong
--2 la da dat
insert into phong values('ph001','1.1',1,'lp003')
insert into phong values('ph002','1.2',1,'lp003')
insert into phong values('ph003','1.3',1,'lp002')
insert into phong values('ph004','1.4',1,'lp004')
insert into phong values('ph005','1.5',1,'lp004')
insert into phong values('ph006','2.1',1,'lp003')
insert into phong values('ph007','2.2',1,'lp004')
insert into phong values('ph008','2.3',1,'lp002')
insert into phong values('ph009','2.4',1,'lp003')
insert into phong values('ph010','2.5',1,'lp004')
insert into phong values('ph011','3.1',1,'lp003')
insert into phong values('ph012','3.2',1,'lp003')
insert into phong values('ph013','3.3',1,'lp002')
insert into phong values('ph014','3.4',1,'lp003')
insert into phong values('ph015','3.5',1,'lp004')
insert into phong values('ph016','4.1',1,'lp004')
insert into phong values('ph017','4.2',1,'lp004')
insert into phong values('ph018','4.3',1,'lp003')
insert into phong values('ph019','4.4',1,'lp003')
insert into phong values('ph020','4.5',1,'lp003')
insert into phong values('ph021','5.1',1,'lp004')
insert into phong values('ph022','5.2',1,'lp002')
insert into phong values('ph023','5.3',1,'lp004')
insert into phong values('ph024','5.4',1,'lp004')
insert into phong values('ph025','5.5',1,'lp003')
go
insert into dichvu values('dv001',N'Bò húc',N'Lon',15000,200)
insert into dichvu values('dv002',N'Sting',N'Lon',12000,200)
insert into dichvu values('dv003',N'Pepsi',N'Lon',10000,200)
insert into dichvu values('dv004',N'Coca',N'Lon',10000,200)
go
insert into thietbi values('tb001',N'Tivi',N'Cái',35000000)
insert into thietbi values('tb002',N'Giường',N'Cái',25000000)
go
insert into khachhang values('kh001',N'Nguyễn thị thảo','206317889')
insert into khachhang values('kh002',N'Nguyễn thị lệ giang','206417889')
insert into khachhang values('kh003',N'Nguyễn thị cần','206217885')
insert into khachhang values('kh004',N'Nguyễn thị tâm','206647879')
insert into khachhang values('kh005',N'Nguyễn thị hến','206357899')
go
insert into donvicungcap values('dv001',N'Nước giải khát Việt Khánh','0953267934',N'Tam kỳ, Quảng Nam')
insert into donvicungcap values('dv002',N'Công ty TNHH Hạnh Vy Thảo','0235381252',N'Tam kỳ, Quảng Nam')
insert into donvicungcap values('dv003',N'Công ty TNHH Hoa Ba','0235389506',N'Tam kỳ, Quảng Nam')
go
insert into thongke values(N'Khoản thu', 0, 'dtkcngay')
insert into thongke values(N'Khoản chi', 0, 'dtkcngay')
insert into thongke values(N'Doanh thu', 0, 'dtkcngay1')
insert into thongke values(N'Khoản thu', 0, 'dtnam')
insert into thongke values(N'Khoản chi', 0, 'dtnam')
insert into thongke values(N'Doanh thu', 0, 'dtnam1')
insert into thongke values(N'Khoản thu', 0, 'dtthang')
insert into thongke values(N'Khoản chi', 0, 'dtthang')
insert into thongke values(N'Doanh thu', 0, 'dtthang1')
insert into thongke values(N'Nhập dịch vụ', 0, 'tienravaokcngay')
insert into thongke values(N'Lương nhân viên', 0, 'tienravaokcngay')
insert into thongke values(N'Thuê phòng', 0, 'tienravaokcngay')
insert into thongke values(N'Nhập dịch vụu', 0, 'tienravaonam')
insert into thongke values(N'Lương nhân viên', 0, 'tienravaonam')
insert into thongke values(N'Thuê phòng', 0, 'tienravaonam')
insert into thongke values(N'Nhập dịch vụ', 0, 'tienravaothang')
insert into thongke values(N'Lương nhân viên', 0, 'tienravaothang')
insert into thongke values(N'Thuê phòng', 0, 'tienravaothang')
go
--quan ly he thong
create proc dangnhap(@tendn varchar(50))
as begin
	update nguoidung set tinhtrang = '1' where tendangnhap=@tendn
end
go
create proc laythongtin(@taikhoan varchar(50))
as begin
	select matkhau, quyen, tinhtrang from nguoidung where tendangnhap = @taikhoan
end
go
create proc doimk(@taikhoan varchar(50),@matkhau varchar(50))
as begin
	update nguoidung set matkhau = @matkhau where tendangnhap = @taikhoan
end
go
create proc dangxuat(@tendn varchar(50))
as begin
	update nguoidung set tinhtrang = '0' where tendangnhap=@tendn
end
go
create proc laytrangthainv(@tendangnhap varchar(50))
as begin
	select nhanvien.tinhtrang
	from nhanvien join nguoidung on nguoidung.tendangnhap = nhanvien.manv
	where nhanvien.manv = @tendangnhap
end
go
--quan ly nhan vien
--1 la ca sang
--2 la ca chieu
--3 la ca toi
--0 la con lam
--1 la nghi viec
create proc taomanv
as begin
	select top 1 nhanvien.manv
	from nhanvien
	order by nhanvien.manv desc
end
go
create proc themnv(@manv varchar(50),@tennv nvarchar(100),@ngaysinh smalldatetime,@gioitinh nvarchar(3),@diachi nvarchar(4000),@sdt varchar(10),@calamviec int,@matkhau varchar(50),@luongcb decimal(18,0),@hsl float)
as begin
	set dateformat dmy
	insert into nguoidung values(@manv,@matkhau,0,0)
	insert into nhanvien values(@manv,@tennv,@ngaysinh,@gioitinh,@diachi,@sdt,@calamviec,'0',@luongcb,@hsl,@manv)
end
go
create proc loadbangnv(@manv varchar(50))
as begin
	select tennv [Tên nhân viên],ngaysinh [Ngày sinh],gioitinh [Giới tính],diachi [Địa chỉ],sdt [Số điện thoại],case when calamviec=1 then N'Ca sáng' else case when calamviec=2 then N'Ca chiều' else N'Ca tối' end end [Ca],luongcoban [Lương cơ bản],hesoluong [Hệ số lương],case when nhanvien.tinhtrang=0 then N'Còn làm' else N'Đã nghỉ việc' end [Tình trạng]
	from nhanvien
	where manv = @manv
end
go
create proc capnhapnv(@manv varchar(50),@tennv nvarchar(100),@ngaysinh smalldatetime,@gioitinh nvarchar(3),@diachi nvarchar(4000),@sdt varchar(10),@calamviec int,@luongcb decimal(18,0),@hsl float, @tt int)
as begin
	set dateformat dmy
	update nhanvien set tennv = @tennv, ngaysinh = @ngaysinh, gioitinh = @gioitinh, diachi = @diachi, sdt = @sdt, calamviec = @calamviec,luongcoban =@luongcb,hesoluong = @hsl, tinhtrang = @tt where manv = @manv
end
go
create proc xoanv(@manv varchar(50))
as begin
	delete nhanvien where manv = @manv
end
go
create proc tknv(@tennv nvarchar(100))
as begin
	declare @hoten nvarchar(100)
	set @hoten = '%' + @tennv + '%'
	select nhanvien.manv [Mã nhân viên],tennv [Tên nhân viên],ngaysinh [Ngày sinh],gioitinh [Giới tính],diachi [Địa chỉ],sdt [Số điện thoại],case when calamviec=1 then N'Ca sáng' else case when calamviec=2 then N'Ca chiều' else N'Ca tối' end end [Ca],luongcoban [Lương cơ bản],hesoluong [Hệ số lương],case when nhanvien.tinhtrang=0 then N'Còn làm' else N'Đã nghỉ việc' end [Tình trạng],nhanvien.tendangnhap [Tên đăng nhập],matkhau [Mật khẩu]
	from nhanvien join nguoidung on nguoidung.tendangnhap=nhanvien.tendangnhap
	where tennv like @hoten
	order by nhanvien.tinhtrang asc
end
go
create trigger tgxoanv on nhanvien instead of delete
as begin
	declare @manv varchar(50)
	declare @sl int
	select @manv = manv from deleted
	select @sl = COUNT(manv) from luong where manv = @manv
	while @sl > 0
	begin
		delete luong where manv = @manv
		select @sl = COUNT(manv) from luong where manv = @manv
	end
	delete nhanvien where manv = @manv
	delete nguoidung where tendangnhap = @manv
end
go
--luong
create function laysongaytrongthang(@thang int) returns int
as begin
	declare @kq int
	set @kq =
	case
		when @thang = 1 then 31
		when @thang = 2 then 28
		when @thang = 3 then 31
		when @thang = 4 then 30
		when @thang = 5 then 31
		when @thang = 6 then 30
		when @thang = 7 then 31
		when @thang = 8 then 31
		when @thang = 9 then 30
		when @thang = 10 then 31
		when @thang = 11 then 30
		else 31
	end
	return @kq
end
go
create proc bangtinhluong
as begin
	select nhanvien.manv [Mã nhân viên], tennv [Tên nhân viên]
	from nhanvien
	where tinhtrang = 0
end
go
create proc bangtinhluong2
as begin
	select nhanvien.manv [Mã nhân viên], tennv [Tên nhân viên]
	from nhanvien
	where tinhtrang = 0
	and manv not in (
	select manv
	from luong 
	where MONTH(ngaytinhluong)=MONTH(getdate())
		and year(ngaytinhluong)=year(getdate()))
end
go
create proc tinhluong
as begin
	select *
	from luong
	where MONTH(ngaytinhluong)=MONTH(getdate())
	and year(ngaytinhluong)=year(getdate())
end
go
create proc taomaphieuluong
as begin
	select top 1 mapluong
	from luong
	order by mapluong desc
end
go
create proc themluong(@mapluong varchar(50),@manv varchar(50), @songaynghi int, @thuongthem decimal(18,0))
as begin
	set dateformat dmy
	insert into luong values(@mapluong,@manv,GETDATE(),@songaynghi,@thuongthem)
end
go
create function laythangnam(@ngay smalldatetime) returns nvarchar(100)
as begin
	declare @thang nvarchar(100)
	set @thang = cast(MONTH(@ngay) as nvarchar)
	set @thang = cast(@thang as nvarchar) + '/' + cast(YEAR(@ngay) as nvarchar)
	return @thang
end
go
create proc tkluong(@tennv nvarchar(100))
as begin
	declare @hoten nvarchar(100)
	set @hoten = '%' + @tennv + '%'
	select nhanvien.manv [Mã nhân viên], tennv [Tên nhân viên], dbo.laythangnam(ngaytinhluong) [Tháng], songaynghi [Số ngày nghỉ], thuongthem [Thưởng thêm], (nhanvien.luongcoban*nhanvien.hesoluong) - ((nhanvien.luongcoban*nhanvien.hesoluong)/(dbo.laysongaytrongthang(MONTH(ngaytinhluong))) * luong.songaynghi) + luong.thuongthem [Lương]
	from nhanvien join luong on luong.manv = nhanvien.manv
	where tennv like @hoten
end
go
create proc tkluong2(@tennv nvarchar(100))
as begin
	declare @hoten nvarchar(100)
	set @hoten = '%' + @tennv + '%'
	select luong.*
	from nhanvien join luong on luong.manv = nhanvien.manv
	where tennv like @hoten
end
go
create proc xoaluong
as begin
	delete luong where MONTH(ngaytinhluong) = MONTH(getdate()) and YEAR(ngaytinhluong) = YEAR(getdate())
end
go
create proc loadluongcn(@maphieu varchar(50))
as begin
	select luong.manv, YEAR(ngaytinhluong), MONTH(ngaytinhluong),songaynghi,thuongthem, nhanvien.tennv
	from nhanvien join luong on luong.manv = nhanvien.manv 
	where mapluong = @maphieu
end
go
create proc capnhapluong(@mapluong varchar(50),@songaynghi int, @thuongthem decimal(18,0))
as begin
	set dateformat dmy
	update luong set ngaytinhluong = GETDATE(), songaynghi = @songaynghi, thuongthem = @thuongthem where mapluong = @mapluong
end
go
--quan ly don vi cung cap
create proc taomadonvi
as begin
	select top 1 madv
	from donvicungcap
	order by madv desc
end
go
create proc themdonvi(@madonvi varchar(50),@tendonvi nvarchar(100),@sdt varchar(10),@diachi nvarchar(4000))
as begin
	set dateformat dmy
	insert into donvicungcap values(@madonvi,@tendonvi,@sdt,@diachi)
end
go
create proc tkdonvi(@tendv nvarchar(100))
as begin
	declare @hoten nvarchar(100)
	set @hoten = '%' + @tendv + '%'
	select madv, tendv [Tên đơn vị], sdt [Số điện thoại], diachi [Địa chỉ]
	from donvicungcap
	where tendv like @hoten
end
go
create proc suadonvi(@madonvi varchar(50),@tendonvi nvarchar(100),@sdt varchar(10),@diachi nvarchar(4000))
as begin
	set dateformat dmy
	update donvicungcap set tendv = @tendonvi, sdt = @sdt, diachi = @diachi where madv = @madonvi
end
go
create proc xoadonvi(@madonvi varchar(50))
as begin
	delete donvicungcap where madv = @madonvi
end
go
create proc loaddonvi(@madv varchar(50))
as begin
	select * from donvicungcap where madv = @madv
end
go
--nhap dich vu
create proc loaddvcc
as begin
	select * from donvicungcap
end
go
create proc taosohdnhap
as begin
	select top 1 sohd
	from hoadonnhap
	order by sohd desc
end
go
create proc taohoadonnhap(@sohd varchar(50), @madv varchar(50))
as begin
	set dateformat dmy
	insert into hoadonnhap values(@sohd,@madv,GETDATE())
end
go
create proc huyhoadonnhap(@sohd varchar(50))
as begin
	delete hoadonnhap where sohd = @sohd
end
go
create proc loaddichvu
as begin
	select * from dichvu
end
go
create proc nhapdichvu(@sohd varchar(50), @madv varchar(50), @gia decimal(18, 0), @sl int)
as begin
	insert into cthdnhap values(@sohd,@madv,@gia,@sl)
end
go
create trigger tg_nhapdichvu on cthdnhap instead of insert
as begin
	declare @sl1 int
	declare @sl2 int
	declare @ma varchar(50)
	declare @sohd varchar(50)
	declare @gia decimal(18,0)
	select @ma = madv from inserted
	select @sohd = sohd from inserted
	select @gia = gia from inserted
	select @sl1 = soluong from dichvu where madv = @ma
	select @sl2 = soluong from inserted
	update dichvu set soluong = @sl1 + @sl2 where madv = @ma
	insert into cthdnhap values(@sohd,@ma,@gia,@sl2)
end
go
create function laytendvcc (@ma varchar(50)) returns nvarchar(100)
as begin
	declare @ten nvarchar(100)
	declare @sl int
	select @sl = count(tendv) from donvicungcap where madv = @ma
	if @sl > 0
		select @ten = tendv from donvicungcap where madv = @ma
	else
		set @ten = ''
	return @ten
end
go
create function laytendv (@ma varchar(50)) returns nvarchar(100)
as begin
	declare @ten nvarchar(100)
	select @ten = tendv from dichvu where madv = @ma
	return @ten
end
go
create proc xemhoadonnhap (@sohd varchar(50))
as begin
	select hoadonnhap.sohd, dbo.laytendvcc(hoadonnhap.madv), hoadonnhap.ngaynhap, dbo.laytendv(cthdnhap.madv), cthdnhap.gia, cthdnhap.soluong
	from hoadonnhap join cthdnhap on hoadonnhap.sohd = cthdnhap.sohd
	where hoadonnhap.sohd = @sohd
end
go
create proc timkiemhdnhap(@key nvarchar(100))
as begin
	set @key = '%' + @key + '%'
	select hoadonnhap.sohd, dbo.laytendvcc(hoadonnhap.madv),ngaynhap
	from hoadonnhap
	where dbo.laytendvcc(hoadonnhap.madv) like @key 
end
go
--load phong
--lp000 la all
create proc loadphong(@loaiphong varchar(50))
as begin
	if @loaiphong != 'lp000'
			select * from phong where maloai = @loaiphong
		else
			select * from phong
end
go
create proc loadloaiphong
as begin
	select * from loaiphong
end
go
--quan ly loai phong
create proc tkloaiphong(@ten nvarchar(100))
as begin
	declare @hoten nvarchar(100)
	set @hoten = '%' + @ten + '%'
	select maloai [Mã loại],tenloai [Tên loại],gia [Giá]
	from loaiphong
	where tenloai like @hoten
end
go
create proc themloaiphong(@ma varchar(50),@tenloai nvarchar(50),@gia decimal(18,0))
as begin
	insert into loaiphong values(@ma,@tenloai,@gia)
end
go
create proc capnhaploaiphong(@ma varchar(50),@tenloai nvarchar(100),@gia decimal(18,0))
as begin
	update loaiphong set tenloai = @tenloai, gia = @gia where maloai = @ma
end
go
create proc xoaloaiphong(@ma varchar(50))
as begin
	delete loaiphong where maloai = @ma
end
go
create trigger tgxoaloaiphong on loaiphong instead of delete
as begin
	declare @ma varchar(50)
	declare @sl int
	select @ma = maloai from deleted
	select @sl = COUNT(maloai) from phong where maloai = @ma
	while @sl > 0
	begin
		delete phong where maloai = @ma
		select @sl = COUNT(maloai) from phong where maloai = @ma
	end
	delete loaiphong where maloai = @ma
end
go
create proc taomaloaiphong
as begin
	select top 1 maloai
	from loaiphong
	order by maloai desc
end
go
create proc loadloaiphongsua(@madv varchar(50))
as begin
	select * from loaiphong where maloai = @madv
end
go
--quan ly phong
create proc tkphong(@ten nvarchar(100))
as begin
	declare @hoten nvarchar(100)
	set @hoten = '%' + @ten + '%'
	select maphong,tenphong [Phòng], tenloai [Loại]
	from phong join loaiphong on loaiphong.maloai=phong.maloai
	where tenphong like @hoten
	order by phong.maloai asc
end
go
create proc themphong(@ma varchar(50),@ten nvarchar(100), @loai varchar(50))
as begin
	insert into phong values(@ma,@ten,1,@loai)
end
go
create proc taomaphong
as begin
	select top 1 maphong
	from phong
	order by maphong desc
end
go
create proc loadphongsua(@ma varchar(50))
as begin
	select phong.*,loaiphong.tenloai
	from phong join loaiphong on loaiphong.maloai=phong.maloai
	where maphong = @ma
end
go
create proc capnhapphong(@ma varchar(50),@so nvarchar(100), @loai varchar(50))
as begin
	update phong set tenphong = @so, maloai = @loai where maphong = @ma
end
go
create proc xoaphong(@ma varchar(50))
as begin
	delete phong where maphong = @ma
end
go
create trigger tgxoaphong on phong instead of delete
as begin
	declare @ma varchar(50)
	declare @sl int
	select @ma = maphong from deleted
	select @sl = COUNT(maphong) from tttp where maphong = @ma
	while @sl > 0
	begin
		delete tttp where maphong = @ma
		select @sl = COUNT(maphong) from tttp where maphong = @ma
	end
	select @sl = COUNT(maphong) from phieudatphong where maphong = @ma
	while @sl > 0
	begin
		delete phieudatphong where maphong = @ma
		select @sl = COUNT(maphong) from phieudatphong where maphong = @ma
	end
	select @sl = COUNT(maphong) from hoadon where maphong = @ma
	while @sl > 0
	begin
		delete hoadon where maphong = @ma
		select @sl = COUNT(maphong) from hoadon where maphong = @ma
	end
	delete phong where maphong = @ma
end
go
create proc loadtbtp(@map varchar(50))
as begin
	select matb [Thiết bị], soluong [Số lượng]
	from tttp
	where maphong = @map
end
go
create proc ktphong(@map varchar(50))
as begin
	select * 
	from phong
	where maphong = @map
end
go
create proc taomasxtb
as begin
	select top 1 maphieu
	from tttp
	order by maphieu desc
end
go
create proc sapxeptb(@maphieu varchar(50),@maphong varchar(50),@matb varchar(50),@soluong int)
as begin
	insert into tttp values(@maphieu,@maphong,@matb,@soluong)
end
go
create proc xoaalltb(@maphong varchar(50))
as begin
	delete tttp where maphong = @maphong
end
go
--quản lý thiết bị
create proc tktb(@ten nvarchar(100))
as begin
	declare @hoten nvarchar(100)
	set @hoten = '%' + @ten + '%'
	select matb [Mã thiết bị], tentb [Tên thiết bị],dvt [Đơn vị tính],gia [Giá]
	from thietbi
	where tentb like @hoten
end
go
create proc themtb(@matb varchar(50),@tentb nvarchar(100),@dvt nvarchar(100),@gia decimal(18,0))
as begin
	insert into thietbi values(@matb,@tentb,@dvt,@gia)
end
go
create proc taomatb
as begin
	select top 1 matb
	from thietbi
	order by matb desc
end
go
create proc xoatb(@matb varchar(50))
as begin
	delete thietbi where matb = @matb
end
go
create trigger tgxoatb on thietbi instead of delete
as begin
	declare @ma varchar(50)
	declare @sl int
	select @ma = matb from deleted
	select @sl = COUNT(maphong) from tttp where matb = @ma
	while @sl > 0
	begin
		delete tttp where matb = @ma
		select @sl = COUNT(maphong) from tttp where matb = @ma
	end
	delete thietbi where matb = @ma
end
go
create proc taobangcntb(@ma varchar(50))
as begin
	select tentb [Tên thiết bị],dvt [Đơn vị tính],gia [Giá]
	from thietbi
	where matb = @ma
end
go
create proc suatb(@matb varchar(50),@tentb nvarchar(100),@dvt nvarchar(100),@gia decimal(18,0))
as begin
	update thietbi set tentb = @tentb, dvt = @dvt, gia = @gia where matb=@matb
end
go
--quan ly dich vu
create proc tkdichvu(@ten nvarchar(100))
as begin
	declare @hoten nvarchar(100)
	set @hoten = '%' + @ten + '%'
	select madv [Mã dịch vụ], tendv [Tên dịch vụ],dvt [Đơn vị tính],gia [Giá],soluong [Số lượng]
	from dichvu
	where tendv like @hoten
end
go
create proc themdichvu(@madv varchar(50),@tendv nvarchar(100),@dvt nvarchar(100),@gia decimal(18,0))
as begin
	insert into dichvu values(@madv,@tendv,@dvt,@gia,0)
end
go
create proc taomadichvu
as begin
	select top 1 madv
	from dichvu
	order by madv desc
end
go
create proc xoadichvu(@matb varchar(50))
as begin
	delete dichvu where madv = @matb
end
go
create trigger tgxoadichvu on dichvu instead of delete
as begin
	declare @ma varchar(50)
	declare @sl int
	select @ma = madv from deleted
	select @sl = COUNT(madv) from cthd where madv = @ma
	while @sl > 0
	begin
		delete cthd where madv = @ma
		select @sl = COUNT(madv) from cthd where madv = @ma
	end
	select @sl = COUNT(madv) from cthdnhap where madv = @ma
	while @sl > 0
	begin
		delete cthdnhap where madv = @ma
		select @sl = COUNT(madv) from cthdnhap where madv = @ma
	end
	delete dichvu where madv = @ma
end
go
create proc taobangcndichvu(@ma varchar(50))
as begin
	select *
	from dichvu
	where madv = @ma
end
go
create proc suadichvu(@madv varchar(50),@tendv nvarchar(100),@dvt nvarchar(100),@gia decimal(18,0))
as begin
	update dichvu set tendv = @tendv, dvt = @dvt, gia = @gia where madv=@madv
end
go
--quan ly khach hang
create proc tkkhachhang(@ten nvarchar(100))
as begin
	declare @hoten nvarchar(100)
	set @hoten = '%' + @ten + '%'
	select makh [Mã dịch vụ], hoten [Tên khách hàng],cmnd [CMND]
	from khachhang
	where hoten like @hoten
end
go
create proc themkhachhang(@makh varchar(50),@tenkh nvarchar(100),@cmnd varchar(50))
as begin
	insert into khachhang values(@makh,@tenkh,@cmnd)
end
go
create proc taomakhachhang
as begin
	select top 1 makh
	from khachhang
	order by makh desc
end
go
create proc xoakhachhang(@matb varchar(50))
as begin
	delete khachhang where makh = @matb
end
go
create trigger tgxoakhachhang on khachhang instead of delete
as begin
	declare @ma varchar(50)
	declare @sl int
	select @ma = makh from deleted
	select @sl = COUNT(makh) from phieudatphong where makh = @ma
	while @sl > 0
	begin
		delete phieudatphong where makh = @ma
		select @sl = COUNT(makh) from phieudatphong where makh = @ma
	end
	select @sl = COUNT(makh) from hoadon where makh = @ma
	while @sl > 0
	begin
		delete hoadon where makh = @ma
		select @sl = COUNT(makh) from hoadon where makh = @ma
	end
	delete khachhang where makh = @ma
end
go
create proc taobangcnkhachhang(@ma varchar(50))
as begin
	select *
	from khachhang
	where makh = @ma
end
go
create proc suakhachhang(@makh varchar(50),@tenkh nvarchar(100),@cmnd varchar(50))
as begin
	update khachhang set hoten = @tenkh, cmnd = @cmnd where makh=@makh
end
go
--phu nhan vien
create proc loadtbtp2(@map varchar(50))
as begin
	select tentb [Thiết bị], thietbi.gia [Đơn giá], soluong [Số lượng], thietbi.gia*tttp.soluong [Thành tiền]
	from tttp join thietbi on thietbi.matb = tttp.matb
	where maphong = @map
end
go
--dat phong
create proc loadkhdat
as begin
	select makh, hoten
	from khachhang
end
go
create proc datphongkc(@maphieu varchar(50), @makh varchar(50), @ngayden smalldatetime, @maphong varchar(50))
as begin
	insert into phieudatphong values (@maphieu, @makh, @ngayden, @maphong)
	update phong set tinhtrang = 2 where maphong = @maphong
end
go
create proc datphongkm(@maphieu varchar(50), @makh varchar(50), @tenkh nvarchar(100), @cmnd varchar(10), @ngayden smalldatetime, @maphong varchar(50))
as begin
	insert into khachhang values(@makh, @tenkh, @cmnd)
	insert into phieudatphong values (@maphieu, @makh, @ngayden, @maphong)
	update phong set tinhtrang = 2 where maphong = @maphong
end
go
create proc taomaphieu
as begin
	select top 1 maphieu
	from phieudatphong
	order by maphieu desc
end
go
create proc kiemtraphong(@maphong varchar(50))
as begin
	select * from phong where maphong = @maphong
end
go
--thue phong
create proc loadkhthue
as begin
	select makh, hoten
	from khachhang
end
go
create proc thuephongkc(@sohd varchar(50), @makh varchar(50), @maphong varchar(50), @manv varchar(50))
as begin
	insert into hoadon values (@sohd, @makh, GETDATE(), null, @maphong, @manv)
	update phong set tinhtrang = 0 where maphong = @maphong
end
go
create proc thuephongkm(@sohd varchar(50), @makh varchar(50), @tenkh nvarchar(100), @cmnd varchar(10), @maphong varchar(50), @manv varchar(50))
as begin
	insert into khachhang values(@makh, @tenkh, @cmnd)
	insert into hoadon values (@sohd, @makh, GETDATE(), null, @maphong, @manv)
	update phong set tinhtrang = 0 where maphong = @maphong
end
go
create proc chuyen(@sohd varchar(50), @sophong varchar(50), @manv varchar(50))
as begin
	--lay info
	declare @maph varchar(50)
	declare @makh varchar(50)
	declare @ngayden smalldatetime
	select @maph = maphieu, @makh = makh, @ngayden = ngayden
	from phieudatphong
	where maphong = @sophong
	--them
	insert into hoadon values(@sohd, @makh, GETDATE(), null, @sophong, @manv)
	delete phieudatphong where maphieu = @maph
	update phong set tinhtrang = 0 where maphong = @sophong
end
go
create proc taosohd
as begin
	select top 1 sohd
	from hoadon
	order by sohd desc
end
go
--phieu dat phong
create function laytenkh(@makh varchar(50)) returns nvarchar(100)
as begin
	declare @Ten nvarchar(100)
	select @Ten = hoten
	from khachhang
	where makh = @makh
	return @Ten
end
go
create function laytenphong(@makh varchar(50)) returns nvarchar(100)
as begin
	declare @Ten nvarchar(100)
	select @Ten = tenphong
	from phong
	where maphong = @makh
	return @Ten
end
go
create proc tkphieudatphong(@tenkh nvarchar(100))
as begin
	set @tenkh = '%' + @tenkh + '%'
	select maphieu [Số phiếu], dbo.laytenkh(makh) [Khách hàng], ngayden [Ngày đến], dbo.laytenphong(maphong) [Phòng]
	from phieudatphong
	where dbo.laytenkh(makh) like @tenkh
end
go
create proc loadphieu (@sophieu varchar(50))
as begin
	select maphieu, dbo.laytenkh(makh), ngayden, dbo.laytenphong(maphong)
	from phieudatphong
	where maphieu = @sophieu
end
go
create proc suaphieu (@sophieu varchar(50), @ngayden smalldatetime)
as begin
	update phieudatphong set ngayden = @ngayden where maphieu = @sophieu
end
go
create proc xoaphieu (@sophieu varchar(50))
as begin
	declare @maphong varchar(50)
	select @maphong = maphong
	from phieudatphong
	where maphieu = @sophieu
	delete phieudatphong where maphieu = @sophieu
	update phong set tinhtrang = 1 where maphong = @maphong
end
go
create proc laysohd(@sophong varchar(50))
as begin
	select sohd
	from hoadon
	where ngaydi is null
	and maphong = @sophong
end
go
create proc loadbanggiadv
as begin
	select tendv [Tên dịch vụ], dvt [Đơn vị tính], gia [Giá], soluong [Số lượng]
	from dichvu
end
go
create proc loaddvdagoi(@sohd varchar(50))
as begin
	select tendv [Tên dịch vụ], gia [Giá], cthd.soluong [Số lượng], cthd.soluong * gia [Thành tiền]
	from dichvu join cthd on cthd.madv = dichvu.madv
	where sohd = @sohd
end
go
create proc loaddsdv
as begin
	select *
	from dichvu
end
go
create proc goidv(@sohd varchar(50), @madv varchar(50), @soluong int)
as begin
	insert into cthd values(@sohd, @madv, @soluong)
end
go
create proc capnhapdvhd(@sohd varchar(50), @madv varchar(50), @soluong int)
as begin
	update cthd set soluong = @soluong where sohd = @sohd and madv = @madv
end
go
create proc xoadvhd(@sohd varchar(50), @madv varchar(50))
as begin
	delete cthd where sohd = @sohd and madv = @madv
end
go
create trigger tgthemdvhd on cthd after insert
as begin
	declare @slhd int
	select @slhd = soluong from inserted
	declare @madvhd varchar(50)
	select @madvhd = madv from inserted
	declare @slmh int
	select @slmh = soluong from dichvu where madv = @madvhd
	update dichvu set soluong = @slmh - @slhd where madv = @madvhd
end
go
create trigger tgcapnhapdvhd on cthd instead of update
as begin
	declare @slhd int
	select @slhd = soluong from inserted
	declare @madvhd varchar(50)
	select @madvhd = madv from inserted
	declare @sohd varchar(50)
	select @sohd = sohd from inserted

	declare @slmh int
	select @slmh = soluong from dichvu where madv = @madvhd

	declare @sl int
	select @sl = soluong from cthd where madv = @madvhd and sohd = @sohd

	update dichvu set soluong = @slmh + @sl - @slhd where madv = @madvhd
	update cthd set soluong = @slhd where madv = @madvhd and sohd = @sohd
end
go
create trigger tgxoadvhd on cthd instead of delete
as begin
	declare @slhd int
	select @slhd = soluong from deleted
	declare @madvhd varchar(50)
	select @madvhd = madv from deleted
	declare @sohd varchar(50)
	select @sohd = sohd from deleted

	declare @slmh int
	select @slmh = soluong from dichvu where madv = @madvhd

	update dichvu set soluong = @slmh + @slhd where madv = @madvhd
	delete cthd where madv = @madvhd and sohd = @sohd
end
go
create proc kiemtratontaidv(@sohd varchar(50), @madv varchar(50))
as begin
	select *
	from cthd
	where sohd = @sohd and madv = @madv
end
go
create proc laysldv(@madv varchar(50))
as begin
	select soluong
	from dichvu
	where madv = @madv
end
go
create proc laysldvhd(@sohd varchar(50), @madv varchar(50))
as begin
	select soluong
	from cthd
	where madv = @madv and sohd = @sohd
end
go
create proc kiemtrasohd(@sohd varchar(50))
as begin
	select *
	from hoadon
	where sohd = @sohd
	and ngaydi is null
end
go
create proc kiemtrasohdtt(@sohd varchar(50))
as begin
	select *
	from hoadon
	where sohd = @sohd
	and ngaydi is not null
end
go
create proc huyhoadon(@sohd varchar(50))
as begin
	delete hoadon where sohd = @sohd
end
go
create trigger tgxoahd on hoadon instead of delete
as begin
	declare @sohd varchar(50)
	select @sohd = sohd from deleted
	declare @maphong varchar(50)
	select @maphong = maphong from deleted
	declare @sl int
	select @sl = count(sohd) from cthd where sohd = @sohd
	while @sl > 0
	begin
		delete cthd where sohd = @sohd
		select @sl = count(sohd) from cthd where sohd = @sohd
	end
	delete hoadon where sohd = @sohd
	update phong set tinhtrang = 1 where maphong = @maphong
end
go
create function laytennv(@manv varchar(50)) returns nvarchar(100)
as begin
	declare @kq nvarchar(100)
	select @kq = tennv from nhanvien where manv = @manv
	return @kq
end
go
create proc thanhtoan(@sohd varchar(50))
as begin
	update hoadon set ngaydi = GETDATE() where sohd = @sohd
	declare @Maphong varchar(50)
	select @Maphong = maphong from hoadon where sohd = @sohd
	update phong set tinhtrang = 1 where maphong = @Maphong
end
go
create proc hoadonkodv(@sohd varchar(50))
as begin
	select hoadon.sohd, dbo.laytenkh(hoadon.makh), ngayden, ngaydi, dbo.laytenphong(hoadon.maphong), dbo.laytennv(hoadon.manv), case when DATEDIFF(d, ngayden, ngaydi) = 0 then 1 else DATEDIFF(d, ngayden, ngaydi) end, loaiphong.gia
	from hoadon join phong on hoadon.maphong = phong.maphong join loaiphong on loaiphong.maloai = phong.maloai
	where sohd = @sohd
end
go
create proc hoadoncodv(@sohd varchar(50))
as begin
	select hoadon.sohd, dbo.laytenkh(hoadon.makh), ngayden, ngaydi, dbo.laytenphong(hoadon.maphong), dbo.laytennv(hoadon.manv), case when DATEDIFF(d, ngayden, ngaydi) = 0 then 1 else DATEDIFF(d, ngayden, ngaydi) end, loaiphong.gia, dichvu.tendv, dichvu.gia, cthd.soluong 
	from hoadon join phong on hoadon.maphong = phong.maphong join loaiphong on loaiphong.maloai = phong.maloai join cthd on cthd.sohd = hoadon.sohd join dichvu on dichvu.madv = cthd.madv
	where hoadon.sohd = @sohd
end
go
create proc kiemtrasohdcthd(@sohd varchar(50))
as begin
	select *
	from cthd
	where sohd = @sohd
end
go
create proc tkhoadonthue(@key nvarchar(100))
as begin
	set @key = '%' + @key + '%'
	select sohd [Số hóa đơn], dbo.laytenkh(makh) [Khách hàng], ngayden [Ngày đến], ngaydi [Ngày đi], dbo.laytenphong(maphong) [Phòng], dbo.laytennv(manv) [Nhân viên]
	from hoadon
	where dbo.laytenkh(makh) like @key
	and ngaydi is not null
end
go
create function khoanchi(@ngaybd smalldatetime, @ngaykt smalldatetime) returns Decimal(18, 0)
as begin
	declare @kq Decimal(18, 0)
	declare @sl int
	select @sl = count(cthdnhap.gia)
	from hoadonnhap join cthdnhap on cthdnhap.sohd = hoadonnhap.sohd
	where convert(varchar(100), hoadonnhap.ngaynhap, 103) between convert(varchar(100), @ngaybd, 103) and convert(varchar(100), @ngaykt, 103)
	--where hoadonnhap.ngaynhap >= @ngaybd and hoadonnhap.ngaynhap <= @ngaykt
	if @sl = 0
		set @kq = 0
	else
		begin
			select @kq = sum(cthdnhap.gia * cthdnhap.soluong)
			from hoadonnhap join cthdnhap on cthdnhap.sohd = hoadonnhap.sohd
			where convert(varchar(100), hoadonnhap.ngaynhap, 103) between convert(varchar(100), @ngaybd, 103) and convert(varchar(100), @ngaykt, 103)
			--where hoadonnhap.ngaynhap >= @ngaybd and hoadonnhap.ngaynhap <= @ngaykt
		end
	return @kq
end
go
create function chiluong(@ngaybd smalldatetime, @ngaykt smalldatetime) returns Decimal(18, 0)
as begin
	declare @kq Decimal(18, 0)
	declare @sl int
	select @sl = COUNT(luong.songaynghi)
	from luong join nhanvien on nhanvien.manv = luong.manv
	where MONTH(luong.ngaytinhluong) >= MONTH(@ngaybd) and MONTH(luong.ngaytinhluong) <= MONTH(@ngaykt)
	if @sl = 0
		set @kq = 0
	else
		begin
			select @kq = sum((nhanvien.luongcoban*nhanvien.hesoluong) - ((nhanvien.luongcoban*nhanvien.hesoluong)/(dbo.laysongaytrongthang(MONTH(ngaytinhluong))) * luong.songaynghi) + luong.thuongthem)
			from luong join nhanvien on nhanvien.manv = luong.manv
			where MONTH(luong.ngaytinhluong) >= MONTH(@ngaybd) and MONTH(luong.ngaytinhluong) <= MONTH(@ngaykt)
		end
	return @kq
end
go
create function tongtiendv(@sohd varchar(50)) returns Decimal(18, 0)
as begin
	declare @kq Decimal(18, 0)
	declare @sl int
	select @sl = count(cthd.madv)
	from dichvu join cthd on cthd.madv = dichvu.madv
	where cthd.sohd = @sohd
	if @sl = 0
		set @kq = 0
	else
		begin
			select @kq = sum(cthd.soluong * dichvu.gia)
			from dichvu join cthd on cthd.madv = dichvu.madv
			where cthd.sohd = @sohd
		end
	return @kq
end
go
create function tongtienhd(@sohd varchar(50)) returns Decimal(18, 0)
as begin
	declare @kq Decimal(18, 0)
	select @kq = loaiphong.gia * case when DATEDIFF(d, ngayden, ngaydi) = 0 then 1 else DATEDIFF(d, ngayden, ngaydi) end
	from hoadon join phong on hoadon.maphong = phong.maphong join loaiphong on loaiphong.maloai = phong.maloai
	where hoadon.sohd = @sohd
	return @kq
end
go
create function khoanthu(@ngaybd smalldatetime, @ngaykt smalldatetime) returns Decimal(18, 0)
as begin
	declare @kq Decimal(18, 0)
	declare @sl int
	select @sl = COUNT(hoadon.sohd)
	from hoadon
	where convert(varchar(100), hoadon.ngayden, 103) between convert(varchar(100), @ngaybd, 103) and convert(varchar(100), @ngaykt, 103) and ngaydi is not null
	if @sl = 0
		set @kq = 0
	else
		begin
			select @kq = sum(dbo.tongtienhd(hoadon.sohd) + dbo.tongtiendv(hoadon.sohd))
			from hoadon
			where convert(varchar(100), hoadon.ngayden, 103) between convert(varchar(100), @ngaybd, 103) and convert(varchar(100), @ngaykt, 103) and ngaydi is not null
		end
	return @kq
end
go
create proc thongkedoanhthu(@ngaybd smalldatetime, @ngaykt smalldatetime)
as begin
	update thongke set giatri = dbo.khoanthu(@ngaybd, @ngaykt) where ten = N'Khoản thu' and kieu = 'dtkcngay'
	update thongke set giatri = dbo.khoanchi(@ngaybd, @ngaykt) + dbo.chiluong(@ngaybd, @ngaykt) where ten = N'Khoản chi' and kieu = 'dtkcngay'
	update thongke set giatri = dbo.khoanthu(@ngaybd, @ngaykt) - (dbo.khoanchi(@ngaybd, @ngaykt) + dbo.chiluong(@ngaybd, @ngaykt)) where ten = N'Doanh thu' and kieu = 'dtkcngay1'
	select * from thongke where kieu = 'dtkcngay'
end
go
create proc thongkedoanhthuhd(@ngaybd smalldatetime, @ngaykt smalldatetime)
as begin
	update thongke set giatri = dbo.khoanthu(@ngaybd, @ngaykt) where ten = N'Khoản thu' and kieu = 'dtkcngay1'
	select * from thongke where kieu = 'dtkcngay1'
end
go
create proc thongkedoanhthuall(@ngaybd smalldatetime, @ngaykt smalldatetime)
as begin
	update thongke set giatri = dbo.khoanthu(@ngaybd, @ngaykt) where ten = N'Khoản thu' and kieu = 'dtkcngay'
	update thongke set giatri = dbo.khoanchi(@ngaybd, @ngaykt) + dbo.chiluong(@ngaybd, @ngaykt) where ten = N'Khoản chi' and kieu = 'dtkcngay'
	update thongke set giatri = dbo.khoanthu(@ngaybd, @ngaykt) - (dbo.khoanchi(@ngaybd, @ngaykt) + dbo.chiluong(@ngaybd, @ngaykt)) where ten = N'Doanh thu' and kieu = 'dtkcngay1'
	select * from thongke where kieu like '%dtkcngay%'
end
go
--nam
create function khoanchinam(@nam int) returns Decimal(18, 0)
as begin
	declare @kq Decimal(18, 0)
	declare @sl int
	select @sl = count(cthdnhap.gia)
	from hoadonnhap join cthdnhap on cthdnhap.sohd = hoadonnhap.sohd
	where year(hoadonnhap.ngaynhap) = @nam
	if @sl = 0
		set @kq = 0
	else
		begin
			select @kq = sum(cthdnhap.gia * cthdnhap.soluong)
			from hoadonnhap join cthdnhap on cthdnhap.sohd = hoadonnhap.sohd
			where year(hoadonnhap.ngaynhap) = @nam
		end
	return @kq
end
go
create function chiluongnam(@nam int) returns Decimal(18, 0)
as begin
	declare @kq Decimal(18, 0)
	declare @sl int
	select @sl = COUNT(luong.songaynghi)
	from luong join nhanvien on nhanvien.manv = luong.manv
	where year(luong.ngaytinhluong) = @nam
	if @sl = 0
		set @kq = 0
	else
		begin
			select @kq = sum((nhanvien.luongcoban*nhanvien.hesoluong) - ((nhanvien.luongcoban*nhanvien.hesoluong)/(dbo.laysongaytrongthang(MONTH(ngaytinhluong))) * luong.songaynghi) + luong.thuongthem)
			from luong join nhanvien on nhanvien.manv = luong.manv
			where year(luong.ngaytinhluong) = @nam
		end
	return @kq
end
go
create function khoanthunam(@nam int) returns Decimal(18, 0)
as begin
	declare @kq Decimal(18, 0)
	declare @sl int
	select @sl = COUNT(hoadon.sohd)
	from hoadon
	where year(hoadon.ngayden) = @nam and ngaydi is not null
	if @sl = 0
		set @kq = 0
	else
		begin
			select @kq = sum(dbo.tongtienhd(hoadon.sohd) + dbo.tongtiendv(hoadon.sohd))
			from hoadon
			where year(hoadon.ngayden) = @nam and ngaydi is not null
		end
	return @kq
end
go
create proc thongkedoanhthunam(@nam int)
as begin
	update thongke set giatri = dbo.khoanthunam(@nam) where ten = N'Khoản thu' and kieu = 'dtnam'
	update thongke set giatri = dbo.khoanchinam(@nam) + dbo.chiluongnam(@nam) where ten = N'Khoản chi' and kieu = 'dtnam'
	update thongke set giatri = dbo.khoanthunam(@nam) - (dbo.khoanchinam(@nam) + dbo.chiluongnam(@nam)) where ten = N'Doanh thu' and kieu = 'dtnam1'
	select * from thongke where kieu = 'dtnam'
end
go
create proc thongkedoanhthuhdnam(@nam int)
as begin
	update thongke set giatri = dbo.khoanthunam(@nam) where ten = N'Khoản thu' and kieu = 'dtnam1'
	select * from thongke where kieu = 'dtnam1'
end
go
create proc thongkedoanhthuallnam(@nam int)
as begin
	update thongke set giatri = dbo.khoanthunam(@nam) where ten = N'Khoản thu' and kieu = 'dtnam'
	update thongke set giatri = dbo.khoanchinam(@nam) + dbo.chiluongnam(@nam) where ten = N'Khoản chi' and kieu = 'dtnam'
	update thongke set giatri = dbo.khoanthunam(@nam) - (dbo.khoanchinam(@nam) + dbo.chiluongnam(@nam)) where ten = N'Doanh thu' and kieu = 'dtnam1'
	select * from thongke where kieu like '%dtnam%'
end
go
--thang
create function khoanchithang(@thang int, @nam int) returns Decimal(18, 0)
as begin
	declare @kq Decimal(18, 0)
	declare @sl int
	select @sl = count(cthdnhap.gia)
	from hoadonnhap join cthdnhap on cthdnhap.sohd = hoadonnhap.sohd
	where year(hoadonnhap.ngaynhap) = @nam
	and month(hoadonnhap.ngaynhap) = @thang
	if @sl = 0
		set @kq = 0
	else
		begin
			select @kq = sum(cthdnhap.gia * cthdnhap.soluong)
			from hoadonnhap join cthdnhap on cthdnhap.sohd = hoadonnhap.sohd
			where year(hoadonnhap.ngaynhap) = @nam
			and month(hoadonnhap.ngaynhap) = @thang
		end
	return @kq
end
go
create function chiluongthang(@thang int, @nam int) returns Decimal(18, 0)
as begin
	declare @kq Decimal(18, 0)
	declare @sl int
	select @sl = COUNT(luong.songaynghi)
	from luong join nhanvien on nhanvien.manv = luong.manv
	where year(luong.ngaytinhluong) = @nam
	and month(luong.ngaytinhluong) = @thang
	if @sl = 0
		set @kq = 0
	else
		begin
			select @kq = sum((nhanvien.luongcoban*nhanvien.hesoluong) - ((nhanvien.luongcoban*nhanvien.hesoluong)/(dbo.laysongaytrongthang(MONTH(ngaytinhluong))) * luong.songaynghi) + luong.thuongthem)
			from luong join nhanvien on nhanvien.manv = luong.manv
			where year(luong.ngaytinhluong) = @nam
			and month(luong.ngaytinhluong) = @thang
		end
	return @kq
end
go
create function khoanthuthang(@thang int, @nam int) returns Decimal(18, 0)
as begin
	declare @kq Decimal(18, 0)
	declare @sl int
	select @sl = COUNT(hoadon.sohd)
	from hoadon
	where year(hoadon.ngayden) = @nam 
	and month(hoadon.ngayden) = @thang
	and ngaydi is not null
	if @sl = 0
		set @kq = 0
	else
		begin
			select @kq = sum(dbo.tongtienhd(hoadon.sohd) + dbo.tongtiendv(hoadon.sohd))
			from hoadon
			where year(hoadon.ngayden) = @nam
			and month(hoadon.ngayden) = @thang
			and ngaydi is not null
		end
	return @kq
end
go
create proc thongkedoanhthuthang(@thang int, @nam int)
as begin
	update thongke set giatri = dbo.khoanthuthang(@thang, @nam) where ten = N'Khoản thu' and kieu = 'dtthang'
	update thongke set giatri = dbo.khoanchithang(@thang, @nam) + dbo.chiluongthang(@thang, @nam) where ten = N'Khoản chi' and kieu = 'dtthang'
	update thongke set giatri = dbo.khoanthuthang(@thang, @nam) - (dbo.khoanchithang(@thang, @nam) + dbo.chiluongthang(@thang, @nam)) where ten = N'Doanh thu' and kieu = 'dtthang1'
	select * from thongke where kieu = 'dtthang'
end
go
create proc thongkedoanhthuhdthang(@thang int, @nam int)
as begin
	update thongke set giatri = dbo.khoanthuthang(@thang, @nam) where ten = N'Khoản thu' and kieu = 'dtthang1'
	select * from thongke where kieu = 'dtthang1'
end
go
create proc thongkedoanhthuallthang(@thang int, @nam int)
as begin
	update thongke set giatri = dbo.khoanthuthang(@thang, @nam) where ten = N'Khoản thu' and kieu = 'dtthang'
	update thongke set giatri = dbo.khoanchithang(@thang, @nam) + dbo.chiluongthang(@thang, @nam) where ten = N'Khoản chi' and kieu = 'dtthang'
	update thongke set giatri = dbo.khoanthuthang(@thang, @nam) - (dbo.khoanchithang(@thang, @nam) + dbo.chiluongthang(@thang, @nam)) where ten = N'Doanh thu' and kieu = 'dtthang1'
	select * from thongke where kieu like '%dtthang%'
end
go
create function laysolanthuephongnam(@loai varchar(50), @nam int) returns int
as begin
	declare @kq int
	declare @sl int
	select @sl = count(tenphong)
	from hoadon join phong on hoadon.maphong = phong.maphong join loaiphong on loaiphong.maloai = phong.maloai
	where loaiphong.maloai = @loai
	and year(ngayden) = @nam
	and hoadon.ngaydi is not null
	if @sl = 0
		set @kq = 0
	else
		select @kq = count(hoadon.sohd)
		from hoadon join phong on hoadon.maphong = phong.maphong join loaiphong on loaiphong.maloai = phong.maloai
		where loaiphong.maloai = @loai
		and year(ngayden) = @nam
		and hoadon.ngaydi is not null
	return @kq
end
go
create function laydoanhthunam(@loai varchar(50), @nam int) returns Decimal(18, 0)
as begin
	declare @kq Decimal(18, 0)
	declare @sl int
	select @sl = count(tenphong)
	from hoadon join phong on hoadon.maphong = phong.maphong join loaiphong on loaiphong.maloai = phong.maloai
	where loaiphong.maloai = @loai
	and year(ngayden) = @nam
	if @sl = 0
		set @kq = 0
	else
		select @kq = sum(dbo.tongtienhd(hoadon.sohd) + dbo.tongtiendv(hoadon.sohd))
		from hoadon join phong on hoadon.maphong = phong.maphong join loaiphong on loaiphong.maloai = phong.maloai
		where loaiphong.maloai = @loai
		and year(ngayden) = @nam
	return @kq
end
go
create proc thongkesolanthuenam(@nam int)
as begin
	select loaiphong.tenloai, dbo.laysolanthuephongnam(maloai, @nam), dbo.laydoanhthunam(maloai, @nam)
	from loaiphong
end
go
create function laysolanthuephongthang(@loai varchar(50), @thang int, @nam int) returns int
as begin
	declare @kq int
	declare @sl int
	select @sl = count(tenphong)
	from hoadon join phong on hoadon.maphong = phong.maphong join loaiphong on loaiphong.maloai = phong.maloai
	where loaiphong.maloai = @loai
	and year(ngayden) = @nam
	and month(ngayden) = @thang
	and hoadon.ngaydi is not null
	if @sl = 0
		set @kq = 0
	else
		select @kq = count(hoadon.sohd)
		from hoadon join phong on hoadon.maphong = phong.maphong join loaiphong on loaiphong.maloai = phong.maloai
		where loaiphong.maloai = @loai
		and year(ngayden) = @nam
		and month(ngayden) = @thang
		and hoadon.ngaydi is not null
	return @kq
end
go
create function laydoanhthuthang(@loai varchar(50), @thang int, @nam int) returns Decimal(18, 0)
as begin
	declare @kq Decimal(18, 0)
	declare @sl int
	select @sl = count(tenphong)
	from hoadon join phong on hoadon.maphong = phong.maphong join loaiphong on loaiphong.maloai = phong.maloai
	where loaiphong.maloai = @loai
	and year(ngayden) = @nam
	and month(ngayden) = @thang
	if @sl = 0
		set @kq = 0
	else
		select @kq = sum(dbo.tongtienhd(hoadon.sohd) + dbo.tongtiendv(hoadon.sohd))
		from hoadon join phong on hoadon.maphong = phong.maphong join loaiphong on loaiphong.maloai = phong.maloai
		where loaiphong.maloai = @loai
		and year(ngayden) = @nam
		and month(ngayden) = @thang
	return @kq
end
go
create proc thongkesolanthuethang(@thang int, @nam int)
as begin
	select loaiphong.tenloai, dbo.laysolanthuephongthang(maloai, @thang, @nam), dbo.laydoanhthuthang(maloai, @thang, @nam)
	from loaiphong
end
go
create function laysolanthuephongkcngay(@loai varchar(50), @ngaybd smalldatetime, @ngaykt smalldatetime) returns int
as begin
	declare @kq int
	declare @sl int
	select @sl = count(tenphong)
	from hoadon join phong on hoadon.maphong = phong.maphong join loaiphong on loaiphong.maloai = phong.maloai
	where loaiphong.maloai = @loai
	and convert(nvarchar, hoadon.ngayden, 103) between convert(nvarchar, @ngaybd, 103) and convert(nvarchar, @ngaykt, 103)
	and hoadon.ngaydi is not null
	if @sl = 0
		set @kq = 0
	else
		select @kq = count(hoadon.sohd)
		from hoadon join phong on hoadon.maphong = phong.maphong join loaiphong on loaiphong.maloai = phong.maloai
		where loaiphong.maloai = @loai
		and convert(nvarchar, hoadon.ngayden, 103) between convert(nvarchar, @ngaybd, 103) and convert(nvarchar, @ngaykt, 103)
		and hoadon.ngaydi is not null
	return @kq
end
go
create function laydoanhthukcngay(@loai varchar(50), @ngaybd smalldatetime, @ngaykt smalldatetime) returns Decimal(18, 0)
as begin
	declare @kq Decimal(18, 0)
	declare @sl int
	select @sl = count(tenphong)
	from hoadon join phong on hoadon.maphong = phong.maphong join loaiphong on loaiphong.maloai = phong.maloai
	where loaiphong.maloai = @loai
	and convert(nvarchar, hoadon.ngayden, 103) between convert(nvarchar, @ngaybd, 103) and convert(nvarchar, @ngaykt, 103)
	if @sl = 0
		set @kq = 0
	else
		select @kq = sum(dbo.tongtienhd(hoadon.sohd) + dbo.tongtiendv(hoadon.sohd))
		from hoadon join phong on hoadon.maphong = phong.maphong join loaiphong on loaiphong.maloai = phong.maloai
		where loaiphong.maloai = @loai
		and convert(nvarchar, hoadon.ngayden, 103) between convert(nvarchar, @ngaybd, 103) and convert(nvarchar, @ngaykt, 103)
	return @kq
end
go
create proc thongkesolanthuekcngay(@ngaybd smalldatetime, @ngaykt smalldatetime)
as begin
	select loaiphong.tenloai, dbo.laysolanthuephongkcngay(maloai, @ngaybd, @ngaykt), dbo.laydoanhthukcngay(maloai, @ngaybd, @ngaykt)
	from loaiphong
end
go
create function layluongthang(@manv varchar(50), @thang int, @nam int) returns Decimal(18, 0)
as begin
	declare @kq Decimal(18, 0)
	declare @sl int
	select @sl = count(nhanvien.manv)
	from nhanvien join luong on luong.manv = nhanvien.manv
	where nhanvien.manv = @manv
	and year(luong.ngaytinhluong) = @nam
	and month(luong.ngaytinhluong) = @thang
	if @sl = 0
		set @kq = 0
	else
		select @kq = sum((nhanvien.luongcoban*nhanvien.hesoluong) - ((nhanvien.luongcoban*nhanvien.hesoluong)/(dbo.laysongaytrongthang(MONTH(ngaytinhluong))) * luong.songaynghi) + luong.thuongthem)
		from nhanvien join luong on luong.manv = nhanvien.manv
		where nhanvien.manv = @manv
		and year(luong.ngaytinhluong) = @nam
		and month(luong.ngaytinhluong) = @thang
	return @kq
end
go
create function laysongaynghithang(@manv varchar(50), @thang int, @nam int) returns int
as begin
	declare @kq int
	declare @sl int
	select @sl = count(nhanvien.manv)
	from nhanvien join luong on luong.manv = nhanvien.manv
	where nhanvien.manv = @manv
	and year(luong.ngaytinhluong) = @nam
	and month(luong.ngaytinhluong) = @thang
	if @sl = 0
		set @kq = 0
	else
		select @kq = sum(luong.songaynghi)
		from nhanvien join luong on luong.manv = nhanvien.manv
		where nhanvien.manv = @manv
		and year(luong.ngaytinhluong) = @nam
		and month(luong.ngaytinhluong) = @thang
	return @kq
end
go
create function laythuongthemthang(@manv varchar(50), @thang int, @nam int) returns Decimal(18, 0)
as begin
	declare @kq Decimal(18, 0)
	declare @sl int
	select @sl = count(nhanvien.manv)
	from nhanvien join luong on luong.manv = nhanvien.manv
	where nhanvien.manv = @manv
	and year(luong.ngaytinhluong) = @nam
	and month(luong.ngaytinhluong) = @thang
	if @sl = 0
		set @kq = 0
	else
		select @kq = sum(luong.thuongthem)
		from nhanvien join luong on luong.manv = nhanvien.manv
		where nhanvien.manv = @manv
		and year(luong.ngaytinhluong) = @nam
		and month(luong.ngaytinhluong) = @thang
	return @kq
end
go
create proc thongkeluongthang(@thang int, @nam int)
as begin
	select tennv, dbo.laysongaynghithang(manv, @thang, @nam), dbo.laythuongthemthang(manv, @thang, @nam), dbo.layluongthang(manv, @thang, @nam)
	from nhanvien
end
go
create function layluongnam(@manv varchar(50), @nam int) returns Decimal(18, 0)
as begin
	declare @kq Decimal(18, 0)
	declare @sl int
	select @sl = count(nhanvien.manv)
	from nhanvien join luong on luong.manv = nhanvien.manv
	where nhanvien.manv = @manv
	and year(luong.ngaytinhluong) = @nam
	if @sl = 0
		set @kq = 0
	else
		select @kq = sum((nhanvien.luongcoban*nhanvien.hesoluong) - ((nhanvien.luongcoban*nhanvien.hesoluong)/(dbo.laysongaytrongthang(MONTH(ngaytinhluong))) * luong.songaynghi) + luong.thuongthem)
		from nhanvien join luong on luong.manv = nhanvien.manv
		where nhanvien.manv = @manv
		and year(luong.ngaytinhluong) = @nam
	return @kq
end
go
create function laysongaynghinam(@manv varchar(50), @nam int) returns int
as begin
	declare @kq int
	declare @sl int
	select @sl = count(nhanvien.manv)
	from nhanvien join luong on luong.manv = nhanvien.manv
	where nhanvien.manv = @manv
	and year(luong.ngaytinhluong) = @nam
	if @sl = 0
		set @kq = 0
	else
		select @kq = sum(luong.songaynghi)
		from nhanvien join luong on luong.manv = nhanvien.manv
		where nhanvien.manv = @manv
		and year(luong.ngaytinhluong) = @nam
	return @kq
end
go
create function laythuongthemnam(@manv varchar(50), @nam int) returns Decimal(18, 0)
as begin
	declare @kq Decimal(18, 0)
	declare @sl int
	select @sl = count(nhanvien.manv)
	from nhanvien join luong on luong.manv = nhanvien.manv
	where nhanvien.manv = @manv
	and year(luong.ngaytinhluong) = @nam
	if @sl = 0
		set @kq = 0
	else
		select @kq = sum(luong.thuongthem)
		from nhanvien join luong on luong.manv = nhanvien.manv
		where nhanvien.manv = @manv
		and year(luong.ngaytinhluong) = @nam
	return @kq
end
go
create proc thongkeluongnam(@nam int)
as begin
	select tennv, dbo.laysongaynghinam(manv, @nam), dbo.laythuongthemnam(manv, @nam), dbo.layluongnam(manv, @nam)
	from nhanvien
end
go
create proc thongkehdthuenam(@nam int)
as begin
	select sohd [Số hóa đơn], dbo.laytenkh(makh) [Khách hàng], ngayden [Ngày đến], case when ngaydi is null  then N'Chưa trả phòng' else convert(nvarchar, ngaydi, 103) end [Ngày đi], dbo.laytenphong(maphong) [Phòng], dbo.laytennv(manv) [Nhân viên]
	from hoadon
	where year(ngayden) = @nam
end
go
create proc thongkehdthuethang(@thang int, @nam int)
as begin
	select sohd [Số hóa đơn], dbo.laytenkh(makh) [Khách hàng], ngayden [Ngày đến], case when ngaydi is null  then N'Chưa trả phòng' else convert(nvarchar, ngaydi, 103) end [Ngày đi], dbo.laytenphong(maphong) [Phòng], dbo.laytennv(manv) [Nhân viên]
	from hoadon
	where year(ngayden) = @nam
	and month(ngayden) = @thang
end
go
create proc thongkehdthuekcngay(@ngaybd smalldatetime, @ngaykt smalldatetime)
as begin
	select sohd [Số hóa đơn], dbo.laytenkh(makh) [Khách hàng], ngayden [Ngày đến], case when ngaydi is null  then N'Chưa trả phòng' else convert(nvarchar, ngaydi, 103) end [Ngày đi], dbo.laytenphong(maphong) [Phòng], dbo.laytennv(manv) [Nhân viên]
	from hoadon
	where convert(nvarchar, hoadon.ngayden, 103) between convert(nvarchar, @ngaybd, 103) and convert(nvarchar, @ngaykt, 103)
end
go
create function cvmoney(@value Decimal(18, 0), @type int) returns Decimal(18, 0)
as begin
	declare @kq Decimal(18, 0)
	if @type = 1
		set @kq = 0 - @value
	else
		set @kq = @value
	return @kq
end
go
create proc thongketienravaothang(@thang int, @nam int)
as begin
	update thongke set giatri = dbo.khoanthuthang(@thang, @nam) where ten = N'Thuê phòng' and kieu = 'tienravaothang'
	update thongke set giatri = dbo.khoanchithang(@thang, @nam) where ten = N'Nhập dịch vụ' and kieu = 'tienravaothang'
	update thongke set giatri = dbo.chiluongthang(@thang, @nam) where ten = N'Lương nhân viên' and kieu = 'tienravaothang'
	select * from thongke where kieu = 'tienravaothang'
end
go
create proc thongketienravaonam(@nam int)
as begin
	update thongke set giatri = dbo.khoanthunam(@nam) where ten = N'Thuê phòng' and kieu = 'tienravaonam'
	update thongke set giatri = dbo.khoanchinam(@nam) where ten = N'Nhập dịch vụ' and kieu = 'tienravaonam'
	update thongke set giatri = dbo.chiluongnam(@nam) where ten = N'Lương nhân viên' and kieu = 'tienravaonam'
	select * from thongke where kieu = 'tienravaonam'
end
go
create proc thongketienravaokcngay(@ngaybd smalldatetime, @ngaykt smalldatetime)
as begin
	update thongke set giatri = dbo.khoanthu(@ngaybd, @ngaykt) where ten = N'Thuê phòng' and kieu = 'tienravaokcngay'
	update thongke set giatri = dbo.khoanchi(@ngaybd, @ngaykt) where ten = N'Nhập dịch vụ' and kieu = 'tienravaokcngay'
	update thongke set giatri = dbo.chiluong(@ngaybd, @ngaykt) where ten = N'Lương nhân viên' and kieu = 'tienravaokcngay'
	select * from thongke where kieu = 'tienravaokcngay'
end
go