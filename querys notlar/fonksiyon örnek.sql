alter function fn_Products_of_Employee
(
@EmployeeID int,
@Year int,
@Month int
)
returns table
as

return
(
select e.FirstName,e.LastName,p.ProductName,od.UnitPrice,p.UnitsInStock from Orders o 
inner join Employees e on e.EmployeeID=o.EmployeeID
inner join [Order Details] od on od.OrderID=o.OrderID
inner join Products p on p.ProductID=od.ProductID
where e.EmployeeID=@EmployeeID and year(o.OrderDate)=@Year or month(o.OrderDate)=@Month
)


select * from fn_Products_of_Employee(1,null,8)
