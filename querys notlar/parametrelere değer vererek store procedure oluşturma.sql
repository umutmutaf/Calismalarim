create proc sp_DisplayParam2
(@CategoryName nvarchar(15)='C', @CategoryID int=2)
as
	select c.CategoryID,c.CategoryName
	from Categories c
	where c.CategoryName like @CategoryName + '%'
	and c.CategoryID>@CategoryID
	order by c.CategoryName
go

exec sp_DisplayParam2 