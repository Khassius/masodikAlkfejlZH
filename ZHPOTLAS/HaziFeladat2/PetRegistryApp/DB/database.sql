CREATE TABLE Pets (
ID INTEGER NOT NULL PRIMARY KEY,
Name TEXT NOT NULL,
Gender TEXT NOT NULL,
Age INTEGER NOT NULL CHECK (Age>0),
Weight DECIMAL NOT NULL CHECK (Weight>0),
Category TEXT NOT NULL,
FOREIGN KEY (Category) REFERENCES Categories(CategoryName)
);

CREATE TABLE Categories (
CategoryName TEXT NOT NULL PRIMARY KEY


);

