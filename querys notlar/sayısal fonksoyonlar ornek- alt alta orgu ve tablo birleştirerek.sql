select 
sum((OD.UnitPrice*OD.Quantity)*(1-OD.Discount))/sum(OD.Quantity),
avg((OD.UnitPrice*OD.Quantity)*(1-OD.Discount)),
min((OD.UnitPrice*OD.Quantity)*(1-OD.Discount)),
max((OD.UnitPrice*OD.Quantity)*(1-OD.Discount))

from Employees emp
inner join orders o on o.EmployeeID=emp.EmployeeID
inner join [Order Details] od on od.OrderID=o.OrderID
where Title!='Sales Representative'


select 
sum((OD.UnitPrice*OD.Quantity)*(1-OD.Discount)),
avg((OD.UnitPrice*OD.Quantity)*(1-OD.Discount)),
min((OD.UnitPrice*OD.Quantity)*(1-OD.Discount)),
max((OD.UnitPrice*OD.Quantity)*(1-OD.Discount))
from
[Order Details] od
where od.OrderID in
(
select o.OrderID
from Orders o
where o.EmployeeID in
(
select EmployeeID
from Employees
where Title!='Sales Representative'
)
)
