create procedure sp_DisplayCategories
--with encryption
--with recompile
as
	select c.CategoryID,c.CategoryName from Categories c order by c.CategoryName
go

exec sp_DisplayCategories
select @@rowcount

sp_helptext sp_DisplayCategories

drop proc sp_DisplayCategories