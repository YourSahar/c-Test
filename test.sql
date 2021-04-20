CREATE TABLE Products (id INT PRIMARY KEY, "name" TEXT);
INSERT INTO Products VALUES 
(1, 'Test1'),
(2, 'Test2'),
(3, 'Test3'),
(4, 'Test4'),
(5, 'Test5');

CREATE TABLE Categories (id INT PRIMARY KEY, "name" TEXT);
INSERT INTO Categories VALUES
(1, '1tesT'),
(2, '2tesT'),
(3, '3tesT'),
(4, '4tesT'),
(5, '5tesT');

CREATE TABLE CombinePC (ProdID INT FOREIGN KEY REFERENCES Products(id), CatID INT FOREIGN KEY REFERENCES Categories(id), PRIMARY KEY (ProdID, CatID));

INSERT INTO CombinePC VALUES 
(1, 3),
(2, 1),
(3, 2),
(5, 4);

SELECT P."Name", C."Name" FROM Products P
LEFT JOIN ProductCategories PC
	ON P.Id = PC.ProductId
LEFT JOIN Categories C
	ON PC.CategoryId = C.Id