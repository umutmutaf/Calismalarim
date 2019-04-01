select datepart(month,e.BirthDate)as [Doğduğu ay],e.FirstName,e.LastName
from Employees e 
where datepart(month,e.BirthDate)=1

/******************************************************************************/

select
FirstName,LastName,BirthDate
from Employees emp
where datepart(mm,emp.BirthDate)
=
(
select 
datepart(mm,e.BirthDate) as month
from Employees e
where
FirstName='Laura' and LastName='Callahan'
)

/****************************************************************************/

select avg(datepart(year,getdate())-datepart(year,emp.BirthDate))
from Employees emp 

/****************************************************************************/

select 
e.FirstName,e.LastName,e.BirthDate,		
datepart(yy,getdate())-datepart(yy,e.BirthDate) as yaş,
case
when datepart(yy,getdate())-datepart(yy,e.BirthDate)>=60 
then 'emekli' 
when datepart(yy,getdate())-datepart(yy,e.BirthDate)<60 
then convert(nvarchar,(60-(datepart(yy,getdate())-datepart(yy,e.BirthDate)))*12)+' '+'ay var'
end				
from Employees e

/*******************************************************************************/

select
getdate(),
datename(month,getdate()),
datename(weekday,getdate()),
datename(week,getdate())

/*****************************************************************************/

select
datediff(year,'1991-07-29',getdate()),
datediff(month,'1991-07-29',getdate()),
datediff(day,'1991-07-29',getdate()),
datediff(minute,'1991-07-29',getdate()),
datediff(hour,'1991-07-29',getdate())

/*****************************************************************************/



