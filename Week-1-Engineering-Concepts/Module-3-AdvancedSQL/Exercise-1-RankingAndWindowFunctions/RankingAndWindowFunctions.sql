CREATE DATABASE OnlineRetailStore;
GO

USE OnlineRetailStore;
GO

CREATE TABLE Products
(
    ProductId INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);

INSERT INTO Products VALUES
(101,'Laptop','Electronics',75000),
(102,'Mouse','Electronics',1200),
(103,'Keyboard','Electronics',2500),
(104,'Monitor','Electronics',15000),
(105,'Mobile','Electronics',35000),
(106,'Headphones','Electronics',2500),

(201,'Shirt','Clothing',1500),
(202,'Jeans','Clothing',2500),
(203,'Jacket','Clothing',4500),
(204,'T-Shirt','Clothing',1500),
(205,'Blazer','Clothing',4500),

(301,'Novel','Books',500),
(302,'Dictionary','Books',900),
(303,'Comics','Books',500),
(304,'Magazine','Books',300),
(305,'Encyclopedia','Books',2000);

SELECT
    ProductId,
    ProductName,
    Category,
    Price,

    ROW_NUMBER() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS RowNumber

FROM Products;

SELECT
    ProductId,
    ProductName,
    Category,
    Price,

    RANK() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS ProductRank

FROM Products;

SELECT
    ProductId,
    ProductName,
    Category,
    Price,

    DENSE_RANK() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS DenseRank

FROM Products;

SELECT *
FROM
(
    SELECT
        ProductId,
        ProductName,
        Category,
        Price,

        ROW_NUMBER() OVER
        (
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS RowNumber

    FROM Products
) AS RankedProducts

WHERE RowNumber <= 3;

