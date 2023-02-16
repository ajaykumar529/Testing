--all the customers whose name begins with "Joe"
select * from Customer
where Name like 'Joe%'
--all the product names ordered by customer "Joe" after '11/1/2016'

select * from Product prd
inner join OrderProduct ordprd 
on prd.ProductId=ordprd.ProductId
inner join Order ord
on ord.OrderId=ordprd.OrderId
inner join Customer cus
on Ord.CustomerId=cus.CustomerId
and cus.Name like 'Joe%'

where ord.CreatedAt>'11/01/2016'

--the total amount spend by Customer Joe
select sum(isnull(Price,0)) TotalAmount from Product prd
inner join OrderProduct ordprd 
on prd.ProductId=ordprd.ProductId
inner join Order ord
on ord.OrderId=ordprd.OrderId
inner join Customer cus
on Ord.CustomerId=cus.CustomerId
and cus.Name ='Joe%' 


--all the customer names and count of their orders for orders containing more than one product

select cus.name,count(ord.OrderId) from Product prd
inner join OrderProduct ordprd 
on prd.ProductId=ordprd.ProductId
inner join Order ord
on ord.OrderId=ordprd.OrderId
inner join Customer cus
on Ord.CustomerId=cus.CustomerId
and cus.Name ='Joe%'
group by cus.Name
having count(ordprd.ProductId)>1