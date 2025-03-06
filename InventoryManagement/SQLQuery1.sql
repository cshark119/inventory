CREATE TABLE users
(
    id int PRIMARY KEY IDENTITY(1,1),
    username VARCHAR(MAX) NULL,
    password VARCHAR(MAX) NULL,
    role VARCHAR(MAX) NULL,
    status VARCHAR(MAX) NULL,
    date DATE NULL
)

SELECT * FROM users

INSERT INTO users(username, password, role, status, date) VALUES('admin', 'admin123', 'Admin', 'Active', '2025-02-03')

CREATE TABLE categories
(
 id INT PRIMARY KEY IDENTITY (1,1),
 category VARCHAR(MAX) NULL,
 date DATE NULL
)

CREATE TABLE categories (
    id INT IDENTITY(1,1) PRIMARY KEY,
    category NVARCHAR(255) NOT NULL UNIQUE,
    date DATETIME DEFAULT GETDATE()
);