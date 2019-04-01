create trigger trg_urun_SoftDelete on urun
instead of delete
as
begin

declare @silinenID int
select @silinenID=urunID from deleted

update urun
set gecerlimi = 0,guncellemetarihi=getdate(),guncelleyenKisi='mutaf'
where urunID=@silinenID
end

/************************/

select * from urun
where gecerlimi=1

delete from urun 
where urunID=1