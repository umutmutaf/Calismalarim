select ProductName, CategoryName from Categories
left join Products on Categories.CategoryID= Products.CategoryID

/******************************************************************************/

select * from Orders
right join Customers on Orders.CustomerID=Customers.CustomerID
where OrderDate is null

/******************************************************************************/

select ProductName,CategoryName from Categories
right join Products on Categories.CategoryID=Products.ProductID
where products.CategoryID is null

/******************************************************************************/

select * from Suppliers
cross join Shippers

/******************************************************************************/

select * from Suppliers
where 1=1
