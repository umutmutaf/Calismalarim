alter proc spUpdate
@CategoryID int,@categoryName nvarchar(50),@description ntext
as
if(@categoryName is null)
	begin
		raiserror(15600,-1,-1,'Kategori adý boþ geçilemez olamaz')
	end
if(len(@categoryName)>15)
	begin
		raiserror(15600,-1,-1,'Kategori adý 15 harften büyük olamaz')
	end
if(@CategoryID>IDENT_CURRENT('Categories'))
	begin
		raiserror(15600,-1,-1,'bu ID de kategori yok')
	end
if(@CategoryID<0)
	begin
		raiserror(15600,-1,-1,'ID 0 dan küçük olamaz')
	end

update Categories
set CategoryName=@categoryName,[Description]=@description
where CategoryID=@CategoryID

exec spUpdate -12,null,'hophop'