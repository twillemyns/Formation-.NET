-- Cr�ation de la table Clients
--CREATE TABLE Clients (
--    id INT PRIMARY KEY IDENTITY(1,1),
--    first_name NVARCHAR(100),
--    last_name NVARCHAR(100),
--    city NVARCHAR(100),
--    age INT,
--    --CONSTRAINT PK_Clients_Id PRIMARY KEY (id)
--);

-- Cr�ation de la table Abonnements
--CREATE TABLE Abonnements (
--    client_id INT, -- FOREIGN KEY (client_id) REFERENCES Clients(id),
--    abonnement_type NVARCHAR(100),
--    CONSTRAINT FK_Client_Abonnement FOREIGN KEY (client_id)
--    REFERENCES Clients(id)
--);


-- Insertion des donn�es dans la table Clients
--INSERT INTO Clients (first_name, last_name, city, age)
--VALUES 
--    ('John', 'Doe', 'New York', 34),
--    ('Alice', 'Smith', 'London', 28),
--    ('Michael', 'Johnson', 'Berlin', 40),
--    ('Emily', 'Brown', 'Paris', 25),
--    ('David', 'Lee', 'Tokyo', 31),
--    ('Sophia', 'Taylor', 'Sydney', 29),
--    ('Daniel', 'Anderson', 'Toronto', 45),
--    ('Olivia', 'Jackson', 'Rome', 38),
--    ('James', 'Moore', 'Moscow', 50),
--    ('Emma', 'Davis', 'New York', 22);

-- Insertion des donn�es dans la table Abonnements
--INSERT INTO Abonnements (client_id, abonnement_type)
--VALUES 
--    (1, 'Premium'),
--    (2, 'Standard'),
--    (3, 'Premium'),
--    (4, 'Basic'),
--    (5, 'Premium'),
--    (5, 'Standard'), -- Un client avec plusieurs abonnements
--    (6, 'Basic'),
--    (7, 'Standard'), -- le n�8 n'a pas d'abonnement
--    (9, 'Premium'),
--    (10, 'Basic');


-- SELECT [Clients].first_name, Clients.last_name, Abonnements.abonnement_type
-- FROM Clients
-- INNER JOIN Abonnements
-- ON Clients.id = Abonnements.client_id;
-- 
-- 
-- SELECT Clients.first_name, Clients.last_name, COUNT(Abonnements.abonnement_type) AS nb_abo
-- FROM Clients
-- INNER JOIN Abonnements
-- ON Clients.id = Abonnements.client_id
-- GROUP BY Clients.first_name, Clients.last_name;
-- 
-- 
-- 
-- SELECT Clients.first_name, Clients.last_name, COUNT(Abonnements.abonnement_type) AS nb_abo
-- FROM Clients LEFT JOIN Abonnements
-- ON Clients.id = Abonnements.client_id
-- GROUP BY Clients.first_name, Clients.last_name;
-- 
-- -- Produit Cart�sien
-- SELECT Clients.first_name, Clients.last_name,Clients.id,Abonnements.client_id, Abonnements.abonnement_type
-- FROM Clients, Abonnements;
-- 
-- -- Jointure par Produit Cart�sien => A NE JAMAIS FAIRE 
-- SELECT Clients.first_name, Clients.last_name,Abonnements.client_id, Abonnements.abonnement_type
-- FROM Clients, Abonnements
-- WHERE Clients.id = Abonnements.client_id;
-- 
-- 
-- SELECT c.first_name, c.last_name, a.abonnement_type
-- FROM Clients AS c
-- INNER JOIN Abonnements AS a
-- ON c.id = a.client_id;
-- 
-- 
-- 
-- 
-- 
-- SELECT Clients.first_name, Clients.last_name, Abonnements.abonnement_type
-- FROM Clients LEFT JOIN Abonnements
-- ON Clients.id = Abonnements.client_id; 
-- -- Olivia est incluse � gauche, m�me si elle n'a pas d'abonnement
-- 
-- 
-- SELECT *
-- FROM Clients
-- LEFT JOIN Abonnements ON Clients.id = Abonnements.client_id;
-- 
-- SELECT *
-- FROM Clients
-- RIGHT JOIN Abonnements ON Clients.id = Abonnements.client_id;
-- 
-- 
-- -- Tout les clients qui n'ont pas d'abonnements
-- SELECT *
-- FROM Clients
-- WHERE Clients.id NOT IN (SELECT Abonnements.client_id FROM Abonnements);



-- Tables et donn�es pour l'execice sur les jointures

-- Cr�ation de la table Purchases
CREATE TABLE Purchases (
    client_id INT,                    -- Cl� �trang�re vers la table Clients
    product NVARCHAR(100),            -- Nom du produit achet�
    amount DECIMAL(10, 2),            -- Montant de l'achat
    CONSTRAINT FK_Client_Purchases FOREIGN KEY (client_id) REFERENCES Clients(id) -- Contrainte de cl� �trang�re
);

-- Insertion des donn�es dans la table Purchases
INSERT INTO Purchases (client_id, product, amount)
VALUES 
    (1, 'Laptop', 1200.50),           -- Achat par le client 1
    (1, 'Keyboard', 45.99),           -- Achat par le client 1
    (2, 'Smartphone', 800.00),        -- Achat par le client 2
    (2, 'Earbuds', 29.99),            -- Achat par le client 2
    (3, 'Tablet', 300.00),            -- Achat par le client 3
    (3, 'Cover', 20.00),              -- Achat par le client 3
    (4, 'TV', 500.00),                -- Achat par le client 4
    (4, 'HDMI Cables', 10.00),        -- Achat par le client 4
    (1, 'Mouse', 25.50),              -- Achat suppl�mentaire pour le client 1
    (5, 'Gaming Console', 450.00);    -- Achat par le client 5

