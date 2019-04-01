create proc spToplam
@bir int,@iki int,@toplam int output
as
select @toplam=@bir+@iki
go

declare @sonuc int
exec spToplam 5,5,@sonuc output
select @sonuc