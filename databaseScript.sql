CREATE DATABASE sigorta_db;
USE sigorta_db;
SELECT * FROM sigortalar;
SHOW databases;
SHOW tables;
CREATE TABLE sigortalar (
    id INT AUTO_INCREMENT PRIMARY KEY,
    sirketAdi VARCHAR(100),
    aracMarka VARCHAR(100),
    modelYil SMALLINT,
    model VARCHAR(100),
    aracPaketi VARCHAR(100),
    yakitTipi VARCHAR(10),
    fiyat DECIMAL(10, 2)  -- Fiyatı ondalıklı sayı olarak tanımlıyoruz
);

INSERT INTO sigortalar (sirketAdi, aracMarka, model, modelYil, aracPaketi, yakitTipi, fiyat) 
VALUES ("Allianz Sigorta", "fiat", "doblo", 2024, "Doblo 1.6", "benzin", 50000.00);

INSERT INTO sigortalar (sirketAdi, aracMarka, model, modelYil, aracPaketi, yakitTipi, fiyat) 
VALUES ("HDI Sigorta", "fiat", "doblo", 2024, "Doblo 1.6", "benzin", 40000.00);

drop table sigortalar;