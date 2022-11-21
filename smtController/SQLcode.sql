
--schema
CREATE TABLE Stocks (
CompanyName NVARCHAR(50) PRIMARY KEY,
Ticker NVARCHAR(10),
TotalStocks INT,
MarketCap BIGINT,
PastPrice MONEY,
CurrentPrice MONEY 
);

--seed data
INSERT INTO Stocks VALUES('Apple', 'AAPL', 20000, 1000000000, 148.41, 150);

INSERT INTO Stocks VALUES('Orange', 'ORNG', 10000, 100000000, 48.41, 50);

INSERT INTO Stocks VALUES('Banana', 'BNAN', 5000, 10000000, 28.41, 30.10);

INSERT INTO Stocks VALUES('Rainbow Road', 'RRRD', 1000, 500000, 15.11, 16.10);

--triggers