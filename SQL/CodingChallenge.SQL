--1. Return the names of all salespeople that have an order with George
SELECT DISTINCT s.NAME
FROM   salesperson s
       INNER JOIN orders o
               ON s.id = o.salespersonid
       INNER JOIN customer c
               ON c.id = o.customerid
WHERE  c.NAME = 'George'

--2. Return the names of all salespeople that do not have any order with George
SELECT NAME
FROM   salesperson
WHERE  id NOT IN (SELECT DISTINCT s.id
                  FROM   salesperson s
                         INNER JOIN orders o
                                 ON s.id = o.salespersonid
                         INNER JOIN customer c
                                 ON c.id = o.customerid
                  WHERE  c.NAME = 'George')

--3. Return the names of salespeople that have 2 or more orders.
SELECT s.NAME,
       Count(o.id)
FROM   salesperson s
       INNER JOIN orders o
               ON s.id = o.salespersonid
GROUP  BY s.NAME
HAVING Count(o.id) > 1

--4. Return the name of the salesperson with the 3rd highest salary.
SELECT TOP 1 NAME,
             salary
FROM   (SELECT TOP 3 *
        FROM   (SELECT *,
                       Row_number()
                         OVER (
                           partition BY salary
                           ORDER BY id) AS RowNumber
                FROM   salesperson) AS distinctSalary
        WHERE  distinctSalary.rownumber = 1
        ORDER  BY salary DESC) AS top3Salary
ORDER  BY salary

--5. Create a new roll­up table BigOrders(where columns are Customer.ID,TotalOrderValue), and insert into that table customers whose total Amount across all orders is greater than 1000
SELECT customerid,
       Sum(costofunit * numberofunits) AS TotalOrderValue
INTO   bigorders
FROM   orders
GROUP  BY customerid
HAVING Sum(costofunit * numberofunits) > 1000
--SELECT * FROM bigorders

--6. Return the total Amount of orders for each month, ordered by year, then month (both in descending order)
--NOTE: CONVERT is not needed if Orderdate datatype is datetime
SELECT Year(CONVERT(DATETIME, orderdate, 105))  AS Year,
       Month(CONVERT(DATETIME, orderdate, 105)) AS Month,
       Sum(numberofunits)                       AS TotalOrders
FROM   orders
GROUP  BY Year(CONVERT(DATETIME, orderdate, 105)),
          Month(CONVERT(DATETIME, orderdate, 105))
ORDER  BY year DESC,
          month DESC 