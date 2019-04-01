select ProductName,CategoryName from Products  /* tablolarý birbine baðlama -'inner join'- */
inner join Categories
on Categories.CategoryID = Products.CategoryID

select ProductName,CompanyName from Products
inner join Suppliers 
on Suppliers.SupplierID=Products.SupplierID
order by CompanyName