alter function fn_Product_Details
(
@CustomerID nvarchar(10)
)
returns table
as
return
(
select p.ProductName,p.UnitPrice,p.UnitsInStock from Customers c
inner join Orders o on c.CustomerID=o.CustomerID
inner join [Order Details] od on od.OrderID=o.OrderID
inner join Products p on p.ProductID=od.ProductID
where c.CustomerID=@CustomerID
)

--select *from [fn_Product_Details]('ALFKI')