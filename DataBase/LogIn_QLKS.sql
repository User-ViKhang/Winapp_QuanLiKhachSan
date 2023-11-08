create proc	proc_login @user nvarchar(50), @pass nvarchar(50), @quyen int
as
begin
	select * from TBL_TAIKHOAN where sTaiKhoan = @user and sMatKhau = @pass and FK_iMaQuyen = @quyen
end
drop proc proc_login