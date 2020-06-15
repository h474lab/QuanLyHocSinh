create trigger TRIGGER_UPDATE_DIEMTB on BANGDIEMMON
for update, insert, delete
as
begin
	declare @MABANGDIEMMH decimal(10), @DIEMTB float, @COUNT int

	select @MABANGDIEMMH=MaBangDiemMH from deleted

	select @DIEMTB=sum(DIEM.DiemSo*LOAIKT.HeSo), @COUNT=sum(case when DIEM.DiemSo is not null then HeSo else 0 end)
	from DIEM inner join LOAIKT on DIEM.MaLoaiKT=LOAIKT.MaLoaiKT
	where DIEM.MaBangDiemMH=@MABANGDIEMMH

	update BANGDIEMMON
	set DiemTBMon=@DIEMTB/@COUNT
	where MaBangDiemMH=@MABANGDIEMMH

	select @MABANGDIEMMH=MaBangDiemMH from inserted

	select @DIEMTB=sum(DIEM.DiemSo*LOAIKT.HeSo), @COUNT=sum(case when DIEM.DiemSo is not null then HeSo else 0 end)
	from DIEM inner join LOAIKT on DIEM.MaLoaiKT=LOAIKT.MaLoaiKT
	where DIEM.MaBangDiemMH=@MABANGDIEMMH

	update BANGDIEMMON
	set DiemTBMon=@DIEMTB/@COUNT
	where MaBangDiemMH=@MABANGDIEMMH
end