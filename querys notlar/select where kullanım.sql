select * from [dbo].[Employees]  /*eþittir*/
where [TitleOfCourtesy]='Mr.'

select * from [dbo].[Employees]  /*eþit deðildir*/
where [TitleOfCourtesy]!='Mr.'

select * from [dbo].[Employees]  /*  "<>"  eþit deðildir*/
where [TitleOfCourtesy]<>'Mr.'

select * from [dbo].[Employees]   /*ya da*/
where HireDate>'1992' 
and title='Sales Representative' 
--and BirthDate<'1950'
and Country='USA'