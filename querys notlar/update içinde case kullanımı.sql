select * into products_new from Products
select * from products_new

update products_new set UnitPrice =case
	when CategoryID=1 then UnitPrice*1.2
	when CategoryID=2 then UnitPrice*1.1
	else UnitPrice*1.15
end

select 
p.ProductName,p.CategoryID,p.UnitPrice,n.UnitPrice, 
convert(varchar,n.UnitPrice/p.UnitPrice*100-100) + '%'
 from products_new n,Products p
 where n.ProductID=p.ProductID
 and p.UnitPrice>0

