create view vw_GRCustomers
as
select CustomerID,CompanyName,[Address],City,Country from Customers
where Country='Germany'

with check option

select * from vw_GRCustomers

insert into vw_GRCustomers
values ('asda','bilgeadam','beþiktaþ','istanbul','Germany')