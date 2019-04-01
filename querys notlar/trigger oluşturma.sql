insert into Categories(CategoryName) values ('food 3 ')

select SCOPE_IDENTITY()

/******************************************/--trigger oluþturma
create trigger trg_Categories on Categories
after insert
as
begin
insert into Products(ProductName,Discontinued,CategoryID)
values('New product',0,IDENT_CURRENT('Categories'))
end
/*********************************************/

select * from Categories order by 1 desc

select * from Products order by 1 desc

insert into Categories(CategoryName) values('Food 55')