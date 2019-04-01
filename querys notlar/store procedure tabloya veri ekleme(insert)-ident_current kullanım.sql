alter procedure spEklemek
@productname nvarchar(40),@unitprice money,@unitinstock smallint
as
/* IDENT_CURRENT kullanmadan son ID leri bulma */

--declare @SupplierID int, @CategoryID int
--select @CategoryID=max(CategoryID) from Categories
--select @SupplierID=max(SupplierID) from Suppliers

--insert into Products(ProductName,CategoryID,SupplierID,UnitPrice,UnitsInStock)
--values(@productname,@CategoryID,@SupplierID,@unitprice,@unitinstock)

insert into Products(ProductName,CategoryID,SupplierID,UnitPrice,UnitsInStock)
values(@productname,IDENT_CURRENT('Categories'),IDENT_CURRENT('Suppliers'),@unitprice,@unitinstock)

exec spEklemek  'umutmutaf23',100,20

select top 5 ProductID,ProductName,CategoryID,SupplierID,UnitPrice,UnitsInStock from Products
order by 1 desc