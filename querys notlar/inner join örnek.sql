select ContactName,OrderDate from Orders
inner join Customers on Orders.CustomerID=Customers.CustomerID
where OrderDate>'1998-01-01'
order by OrderDate


select CategoryName,UnitsInStock from Categories 
inner join Products on Categories.CategoryID=Products.CategoryID
where UnitsInStock>0 and CategoryName='Beverages'

select FirstName,OrderDate  from Employees 
inner join Orders on Employees.EmployeeID=Orders.EmployeeID
where FirstName='Andrew'

