create view vw_ornek
as
SELECT  top 1
	Products.ProductID,
	Products.ProductName,Categories.CategoryName,
	sum(dbo.[Order Details].Quantity) as adet, count(*) as satýsadedi
FROM  dbo.Orders 
	INNER JOIN dbo.[Order Details] ON dbo.Orders.OrderID = dbo.[Order Details].OrderID 
	INNER JOIN dbo.Products ON dbo.[Order Details].ProductID = dbo.Products.ProductID 
	INNER JOIN dbo.Categories ON dbo.Products.CategoryID = dbo.Categories.CategoryID
group by 
	Products.ProductName,
	Categories.CategoryName,
	Products.ProductID
order by  
	sum(dbo.[Order Details].Quantity) desc

	select * from vw_ornek