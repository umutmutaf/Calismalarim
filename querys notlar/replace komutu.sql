select categoryname, replace (categoryname,'Con','###') from [dbo].[Categories]

select categoryname,charindex('a',[CategoryName],0) from [dbo].[Categories]

select categoryname, 
lower(left([CategoryName],1)+substring([CategoryName],2,len([CategoryName]))) 
from Categories

select CategoryName,
replace(CategoryName,left(CategoryName,1),lower(left(CategoryName,1))) 
from Categories

select CategoryName,lower(left(CategoryName,1))+right(CategoryName,len(CategoryName)-1) from Categories

select CategoryName,lower(reverse(CategoryName)) from Categories