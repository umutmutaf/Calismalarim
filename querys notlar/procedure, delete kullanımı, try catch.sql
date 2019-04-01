create proc spSilme2
@CategoryID int, @hata nvarchar(300) output
as
begin try
	delete from Categories
	where CategoryID=@CategoryID
	set @hata=@CategoryID
end try

begin catch
	set @hata=ERROR_MESSAGE()
end catch

declare @mesaj nvarchar(300)
exec spSilme2 1, @mesaj output
select @mesaj