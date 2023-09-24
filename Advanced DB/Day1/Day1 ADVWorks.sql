use AdventureWorks2012

----------------------------------------- Query 1 -------------------------------------------

select s.SalesOrderID , s.ShipDate
from Sales.SalesOrderHeader s
where s.OrderDate > '7/28/2002' and s.OrderDate < '7/29/2014'

----------------------------------------- Query 2 -------------------------------------------

select p.ProductID ,p.Name
from Production.Product p
where p.StandardCost <110

----------------------------------------- Query 3 -------------------------------------------

select p.ProductID ,p.Name
from Production.Product p
where p.Weight is null

----------------------------------------- Query 4 -------------------------------------------

select p.*
from Production.Product p
where p.Color in ('silver','red','black')

----------------------------------------- Query 5 -------------------------------------------

select p.*
from Production.Product p
where p.Name like 'B%'

----------------------------------------- Query 6 -------------------------------------------

UPDATE Production.ProductDescription
SET Description = 'Chromoly steel_High of defects'
WHERE ProductDescriptionID = 3

select p.*
from Production.ProductDescription p
where p.Description like '%[_]%'

----------------------------------------- Query 7 -------------------------------------------

select sum(s.TotalDue)
from Sales.SalesOrderHeader s
where s.OrderDate > '7/1/2001' and s.OrderDate < '	7/31/2014'
group by s.OrderDate

----------------------------------------- Query 8 -------------------------------------------

select distinct e.HireDate
from [HumanResources].[Employee] e

----------------------------------------- Query 9 -------------------------------------------

select avg(ListPrice)
from (select distinct ListPrice
	  from [Production].[Product]) as newTable

----------------------------------------- Query 10 -------------------------------------------

select CONCAT('The ',p.Name,'is only!',p.ListPrice)
from [Production].[Product] p
where ListPrice >= 100 and ListPrice <=120
order by ListPrice

----------------------------------------- Query 11 -------------------------------------------

select rowguid ,Name, SalesPersonID, Demographics into [store_Archive]
from Sales.Store
where 1=2

----------------------------------------- Query 12 -------------------------------------------
SELECT FORMAT (getdate(), 'dd/MM/yyyy ') as date
union
SELECT FORMAT (getdate(), 'dd/MM/yyyy, hh:mm:ss ') as date
union
SELECT FORMAT (getdate(), 'dddd, MMMM, yyyy') as date
union
SELECT FORMAT (getdate(), 'MMM dd yyyy') as date
union
SELECT FORMAT (getdate(), 'yyyy-MM-dd hh:mm:ss tt') as date
union
SELECT FORMAT (getdate(), 'hh:mm:ss tt') as date