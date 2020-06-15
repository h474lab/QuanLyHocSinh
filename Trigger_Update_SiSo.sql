create trigger trg_update_siso on QUATRINH
for update, insert, delete
as
begin
	declare @MALOP decimal(10)
	select @MALOP=MaLop from inserted
	update DANHSACHLOP
	set SiSo=(select count(*) from QUATRINH where DANHSACHLOP.MaLop=QUATRINH.MaLop)
	select @MALOP=MaLop from deleted
	update DANHSACHLOP
	set SiSo=(select count(*) from QUATRINH where DANHSACHLOP.MaLop=QUATRINH.MaLop)
end