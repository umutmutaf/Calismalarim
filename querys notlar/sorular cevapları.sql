/*1*/select e.FirstName,e.LastName,o.CustomerID,p.ProductName,od.Quantity from Employees e
inner join Orders o on o.EmployeeID=e.EmployeeID
inner join [Order Details] od on od.OrderID=o.OrderID
inner join Products p on p.ProductID=od.ProductID
where Title like 'Sales Representative'

/*2*/select s.CompanyName,p.ProductName,od.Quantity,od.UnitPrice from Suppliers s
inner join Products p on p.SupplierID=s.SupplierID
inner join [Order Details] od on od.ProductID=p.ProductID

/*3*/select max(od.Quantity)
from Customers c
inner join Orders o on o.CustomerID=c.CustomerID
inner join [Order Details] od on od.OrderID=o.OrderID

/*a*/select FirstName,LastName,Title from Employees
where Title='Vice President, Sales'

/*b*/ select FirstName,LastName,Country from Employees
where City!='London'

/*c*/ select count(Title),Title from Employees
group by Title

/*d*/ select FirstName,LastName,[Address]  from Employees
where [Address]='908 W. Capital Way' or [Address]='722 Moss Bay Blvd.'

/*6*/ select FirstName,LastName,BirthDate  from Employees
where BirthDate=datepart(month,getdate()) and BirthDate= datepart(day,getdate())

/*7*/select OrderID, datediff(day,RequiredDate,ShippedDate) from Orders
where ShippedDate>RequiredDate

/*8*/ select e.FirstName,e.LastName,cus.CompanyName,o.OrderDate,o.ShippedDate from Orders o
inner join Employees e on e.EmployeeID=o.EmployeeID
inner join Customers cus on cus.CustomerID=o.CustomerID
where (ShippedDate-OrderDate)<=10 





