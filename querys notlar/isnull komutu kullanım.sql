select p.CategoryID,isnull(p.CategoryID,9999)as yeni,p.* from Products p order by 1 desc