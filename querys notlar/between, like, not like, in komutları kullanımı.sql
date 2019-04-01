select * from ProductsYeni

delete ProductsYeni where Discontinued='true'

delete ProductsYeni where UnitPrice>20 and UnitsInStock<10

select * from Customers where ContactTitle like '%Agent'  and City like 'B%'

select * from Employees where BirthDate between '1950-01-01' and '1956-01-01'

select * from Employees where EmployeeID between 5 and 8

delete ProductsYeni where UnitPrice between 10 and 55
and QuantityPerUnit like '%pkgs.'

select ProductID, ProductName,UnitPrice from Products where UnitPrice in (20,30,40)