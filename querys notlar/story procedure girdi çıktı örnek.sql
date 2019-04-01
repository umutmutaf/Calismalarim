alter proc spHarfSay
@say int,@adet int out
as
select @adet=count(*)from Categories
where len(CategoryName)=@say
go

declare @sonuc int
exec spHarfSay 9,@sonuc out
select @sonuc as [girilen harf sayýsýna sahip eleman]