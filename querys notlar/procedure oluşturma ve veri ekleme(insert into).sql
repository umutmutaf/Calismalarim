create proc spInsert
@categoryName nvarchar(15),@description ntext
as
insert into Categories(c.CategoryName,c.[Description]) values(@categoryName,@description)
insert into Products(ProductName,CategoryID) values(@categoryName,IDENT_CURRENT('Categories'))
return @@identity
go
declare @sonuc int
exec @sonuc=spInsert 'mutaf','acýklama yok'

select* from Products
where ProductID=@sonuc