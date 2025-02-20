-- Création de la table Personne
CREATE TABLE Personne (
                          id INT PRIMARY KEY IDENTITY(1,1),     -- Identifiant unique
                          first_name NVARCHAR(50) NOT NULL,     -- Prénom
                          last_name NVARCHAR(50) NOT NULL,      -- Nom
                          age INT NOT NULL,                     -- Âge
                          phone_number NVARCHAR(20),            -- Numéro de téléphone
                          address NVARCHAR(100)                 -- Adresse
);

-- Création de la table Chien
CREATE TABLE Chien (
                       id INT PRIMARY KEY IDENTITY(1,1),     -- Identifiant unique
                       name NVARCHAR(50) NOT NULL,           -- Nom du chien
                       breed NVARCHAR(50),                   -- Race
                       age INT,                              -- Âge
                       size DECIMAL(5,2),                    -- Taille (en cm)
                       weight DECIMAL(5,2),                  -- Poids (en kg)
                       id_maitre INT NULL,                   -- Identifiant du maître (clé étrangère)
                       CONSTRAINT FK_Personne_Chien FOREIGN KEY (id_maitre) REFERENCES Personne(id)
);

-- Insertion de données dans la table Personne
INSERT INTO Personne (first_name, last_name, age, phone_number, address)
VALUES
    ('Tintin', 'Dupont', 30, '1234567890', '123 Rue du Temple'),
    ('Asterix', 'Gaulois', 40, '9876543210', '456 Village Gaulois'),
    ('Sherlock', 'Holmes', 45, '5554443333', '221B Baker Street'),
    ('Hercule', 'Poirot', 50, '4443332222', '11 Rue du Luxembourg'),
    ('Gandalf', 'Le Gris', 1000, '1112223333', 'Hobbiton'),
    ('Luke', 'Skywalker', 28, '9988776655', 'Tatooine'),
    ('Harry', 'Potter', 35, '5556667777', '4 Privet Drive'),
    ('Daenerys', 'Targaryen', 32, '8887776666', 'Meereen'),
    ('Frodo', 'Baggins', 33, '1237894560', 'Bag End'),
    ('Waldo', 'Rosenbaum', 50, '7778889999', 'Nowhere Street');

-- Insertion de données dans la table Chien
INSERT INTO Chien (name, breed, age, size, weight, id_maitre)
VALUES
    ('Milou', 'Fox Terrier', 5, 30.0, 8.0, 1), -- Lié à Tintin Dupont
    ('Idefix', 'Dogmatix', 4, 25.0, 6.0, 2), -- Lié à Asterix Gaulois
    ('Watson', 'Bulldog', 6, 60.0, 30.0, 3), -- Lié à Sherlock Holmes
    ('Hercules', 'Pitbull', 3, 60.0, 28.0, 4), -- Lié à Hercule Poirot
    ('Gandalf', 'Great Dane', 8, 80.0, 50.0, 5), -- Lié à Gandalf Le Gris
    ('Chewie', 'Malamute', 7, 70.0, 40.0, 6), -- Lié à Luke Skywalker
    ('Buck', 'Saint Bernard', 6, 70.0, 50.0, 7), -- Lié à Harry Potter
    ('Drogo', 'Dobermann', 5, 55.0, 35.0, 8), -- Lié à Daenerys Targaryen
    ('Baggins', 'Shiba Inu', 4, 30.0, 10.0, 9), -- Lié à Frodo Baggins
    ('Waldo', 'Chihuahua', 3, 20.0, 2.5, 10), -- Lié à Waldo Rosenbaum
    ('Rex', 'Chihuahua', 3, 20.0, 3.0, NULL), -- Pas de maître
    ('Pepette', 'Rottweiler', 6, 60.0, 40.0, NULL), -- Pas de maître
    ('Princesse', 'Dobermann', 4, 50.0, 30.0, NULL), -- Pas de maître
    ('Rex', 'Dalmatian', 2, 45.0, 25.0, NULL), -- Pas de maître
    ('Trixie', 'Poodle', 5, 30.0, 12.0, NULL), -- Pas de maître
    ('Nina', 'Boxer', 4, 50.0, 35.0, NULL), -- Pas de maître
    ('Pikachu', 'Corgi', 2, 25.0, 10.0, NULL), -- Pas de maître
    ('Rolo', 'Dachshund', 3, 28.0, 8.5, NULL), -- Pas de maître
    ('Fifi', 'Maltese', 4, 25.0, 6.0, NULL), -- Pas de maître
    ('Charlie', 'Beagle', 6, 40.0, 15.0, NULL), -- Pas de maître
    ('Max', 'Labrador', 5, 55.0, 30.0, NULL), -- Pas de maître
    ('Biscuit', 'Shih Tzu', 2, 25.0, 6.0, NULL), -- Pas de maître
    ('Daisy', 'Pug', 3, 35.0, 10.0, NULL), -- Pas de maître
    ('Oscar', 'Terrier', 4, 28.0, 8.0, NULL), -- Pas de maître
    ('Nala', 'Pitbull', 4, 50.0, 30.0, NULL); -- Pas de maître
    
-- Niveau 1
-- 1.Sélectionnez tous les chiens avec leur nom, leur race et leur poids.
SELECT name, breed, weight
FROM Chien;
    
-- 2.Listez tous les propriétaires (prénom et nom).
SELECT first_name, last_name
FROM Personne;
    
-- 3.Récupérez les chiens qui n'ont pas de maître.
SELECT * FROM Chien
WHERE id_maitre IS NULL;
    
-- 4.Sélectionnez tous les chiens de race "Labrador".
SELECT * FROM Chien
WHERE breed = 'Labrador';

-- Niveau 2
-- 5. Affichez le nom des chiens avec le prénom et le nom de leur maître.
SELECT c.name,p.first_name, p.last_name
FROM Chien c
INNER JOIN Personne p 
ON p.id = c.id_maitre;
    
-- 6. Récupérez les maîtres qui possèdent un chien pesant plus de 20 kg.
SELECT p.*
FROM Personne p
INNER JOIN Chien C 
ON p.id = C.id_maitre
WHERE C.weight > 20;

-- Niveau 3
-- 7. Affichez tous les propriétaires et les chiens qu'ils possèdent, y compris les propriétaires sans chien.
SELECT p.*, c.*
FROM Personne P
LEFT JOIN Chien C 
ON P.id = C.id_maitre;

-- 8. Listez tous les chiens, avec leurs maîtres s'ils en ont, sinon affichez "No Owner".
SELECT c.id,
       c.name,
       c.breed,
       c.age,
       c.size,
       c.weight,
       COALESCE(p.first_name, 'No Owner'),
       COALESCE(p.last_name, 'No Owner')
FROM Chien c
LEFT JOIN Personne p
ON c.id_maitre = p.id;

-- Niveau 4
-- 9. Récupérez tous les chiens et tous les maîtres, même ceux sans correspondance.
SELECT p.*, c.*
FROM Personne P
FULL JOIN Chien C
ON P.id = C.id_maitre;

-- Niveau 5
-- 10. Affichez les chiens dont le poids est supérieur à 10 kg mais inférieur à 30 kg.
SELECT *
FROM Chien
WHERE weight BETWEEN 10 AND 30;
    
-- 11. Récupérez les chiens de maîtres habitant dans la ville "123 Main St".
SELECT c.*
FROM Chien c
INNER JOIN Personne P 
ON P.id = c.id_maitre
WHERE p.address = '123 Main St';

-- Niveau 6
-- 12. Affichez le nombre de chiens pour chaque maître.
SELECT p.first_name, p.last_name, COUNT(*) AS nbChiens FROM Chien c
INNER JOIN Personne P 
on P.id = c.id_maitre
GROUP BY p.first_name, p.last_name;
    
-- 13. Calculez le poids total des chiens appartenant à chaque maître.
SELECT p.first_name, p.last_name, SUM(c.weight) AS poidsChiens
FROM Chien c
INNER JOIN Personne P
on P.id = c.id_maitre
GROUP BY p.first_name, p.last_name;

-- Niveau 7
-- 14. Récupérez les maîtres qui possèdent le chien le plus lourd.
SELECT p.*
FROM Personne p
INNER JOIN Chien C 
ON p.id = C.id_maitre
WHERE C.weight = (SELECT MAX(weight) FROM Chien);
    
-- 15. Affichez les chiens qui ont un maître dont l'âge est supérieur à 40 ans.
SELECT c.*
FROM Chien c
INNER JOIN Personne P 
ON P.id = c.id_maitre
WHERE p.age > 40;

-- Niveau 8
-- 16. Listez les maîtres n'ayant pas de chien.
SELECT p.* FROM Personne p
LEFT JOIN Chien C 
ON p.id = C.id_maitre
WHERE c.id_maitre IS NULL;
    
-- 17. Affichez la race la plus courante parmi les chiens.
SELECT TOP 1 breed, COUNT(*) AS nbRaces
FROM Chien
GROUP BY breed
ORDER BY nbRaces DESC;
    
-- 18. Listez tous les maîtres qui possèdent au moins deux chiens.
SELECT p.first_name, p.last_name, count(*) AS nbChiens
FROM Personne p
INNER JOIN Chien C 
ON p.id = C.id_maitre
GROUP BY p.first_name, p.last_name
HAVING count(*) >= 2;

-- Niveau 9
-- 19. Récupérez une liste combinée de chiens sans maîtres et de maîtres sans chiens.
SELECT * FROM Chien c
FULL JOIN Personne P ON P.id = c.id_maitre
WHERE c.id_maitre IS NULL
OR p.id IS NULL;
    
-- 20. Affichez le maître et ses chien associés avec somme de leur tailles respectives (taille du maître et des chiens).
SELECT p.first_name, p.last_name, SUM(c.age) + p.age AS sommeSizeAge
FROM Personne P
INNER JOIN Chien C
ON P.id = C.id_maitre
GROUP BY p.first_name, p.last_name, p.age;