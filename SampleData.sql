USE PurchaseSampleDb;

DROP TABLE Customers;
DROP TABLE Products;

CREATE TABLE Customers(CustomerId INT PRIMARY KEY IDENTITY, CustomerName VARCHAR(50), Visits INT);
CREATE TABLE Products(ProductId INT PRIMARY KEY IDENTITY, ProductName VARCHAR(50), Availability INT,  Price DECIMAL, MaxDiscountPercentage DECIMAL);

INSERT INTO Customers VALUES('Customer1', 10);
INSERT INTO Customers VALUES('Customer2', 5);
INSERT INTO Customers VALUES('Customer3', 7);

INSERT INTO Products VALUES('Product1', 250, 10, 3);
INSERT INTO Products VALUES('Product2', 300, 2, 10);
INSERT INTO Products VALUES('Product3', 450, 5, 12);

SELECT * FROM Products;