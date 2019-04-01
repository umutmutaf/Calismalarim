create proc sp_DisplayCategoriesWithParam1
@CategoryName nvarchar(15)
as
	select c.CategoryID,c.CategoryName
	from Categories c
	where c.CategoryName=@CategoryName
	order by c.CategoryName
go

exec sp_DisplayCategoriesWithParam1 'Beverages'

/***********************************************************/

create proc sp_DisplayParam1
@CategoryName nvarchar(15), @CategoryID int
as
	select c.CategoryID,c.CategoryName
	from Categories c
	where c.CategoryName like @CategoryName + '%'
	and c.CategoryID>@CategoryID
	order by c.CategoryName
go

exec sp_DisplayParam1 'C',2
