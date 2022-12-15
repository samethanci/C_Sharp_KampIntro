-- Select
Select * from Customers
Select Phone from Customers
Select ContactName, CompanyName, City from Customers
Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers


-- Where
Select * from Customers where City = 'London'

select * from Products
select * from Products where CategoryID = 1
select * from Products where CategoryID = 3 or CategoryID = 2
select * from Products where CategoryID = 2 and UnitPrice >= 22


-- order by sıralama
Select * from Products order by ProductName
Select * from Products order by CategoryID
Select * from Products order by CategoryID desc
Select * from Products order by UnitsInStock desc
Select * from Products order by CategoryID, ProductName
Select * from Products where CategoryID = 5 order by UnitPrice desc


Select count(*) from Products
Select count(*) from Products where CategoryID = 5
Select count(*) Adet from Products where CategoryID = 2

-- Group by

Select CategoryID from Products group by CategoryID
Select CategoryID, COUNT(*) Urun from Products group by CategoryID 
Select CategoryID, COUNT(*) Urun from Products group by CategoryID having Count(*)<10
Select CategoryID, Count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10


Select * from Products
select * from Categories

select * from Products inner join Categories on Products.CategoryID = Categories.CategoryID
Select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName, Categories.CategoryID from Products inner join Categories on Products.CategoryID = Categories.CategoryID
Select p.ProductID, p.ProductName, p.UnitPrice, c.CategoryName, c.CategoryID 
from Products p inner join Categories c on p.CategoryID = c.CategoryID

Select * from Products p left join [Order Details] od on p.ProductID = od.ProductID

Select * from Customers c inner join Orders o on c.CustomerID = o.CustomerID
Select * from Customers c left join Orders o on c.CustomerID = o.CustomerID
Select * from Customers c left join Orders o on c.CustomerID = o.CustomerID where o.CustomerID is null
Select * from Customers c inner join Orders o on c.CustomerID = o.CustomerID inner join [Order Details] od on Products.ProductID = od.ProductID
select * from [Order Details]









