create proc spHarfSay2
@say int=4
as
declare @donecek int
select @donecek=count(*)from Categories
where len(CategoryName)=@say
return @donecek
go

declare @sonuc int
exec @sonuc=spHarfSay2 9
select @sonuc
