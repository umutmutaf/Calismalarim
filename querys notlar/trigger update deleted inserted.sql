create trigger trg_CustomersBackupInsert
on Customers
after update
as
begin
 insert into CustomersBackup(CustomerID,CompanyName,ContactName)
 select CustomerID,CompanyName,'Eski Kay�t' from deleted

 insert into CustomersBackup(CustomerID,CompanyName,ContactName)
  select CustomerID,CompanyName,'Eski Kay�t' from inserted
  end

