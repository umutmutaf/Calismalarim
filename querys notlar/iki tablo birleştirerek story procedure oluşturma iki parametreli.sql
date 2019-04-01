
create proc sp_ProCat
@CategoryName nvarchar(15)='C', @ProductName nvarchar(15)='D'
as
select p.ProductName,c.CategoryName  from Products p
inner join Categories c on c.CategoryID=p.CategoryID
where c.CategoryName like '%' + @CategoryName +'%'
and p.ProductName like '%' + @ProductName + '%'
order by ProductName
go

exec  sp_ProCat C,C
