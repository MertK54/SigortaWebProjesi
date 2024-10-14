CREATE DATABASE sigorta_db;
USE sigorta_db;
CREATE TABLE sigortalar (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100),
    email VARCHAR(100),
    age TINYINT
);
SELECT * FROM sigortalar;
SHOW databases;
SHOW tables;
INSERT INTO sigortalar (name,age,email) VALUES ("mert",24,"asd@gmail.com");