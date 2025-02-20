-- Cr�ation de la table Personne
CREATE TABLE Personne (
                          id INT PRIMARY KEY IDENTITY(1,1),     -- Identifiant unique
                          first_name NVARCHAR(50) NOT NULL,     -- Pr�nom
                          last_name NVARCHAR(50) NOT NULL,      -- Nom
                          age INT NOT NULL,                     -- �ge
                          phone_number NVARCHAR(20),            -- Num�ro de t�l�phone
                          address NVARCHAR(100)                 -- Adresse
);

-- Cr�ation de la table Chien
CREATE TABLE Chien (
                       id INT PRIMARY KEY IDENTITY(1,1),     -- Identifiant unique
                       name NVARCHAR(50) NOT NULL,           -- Nom du chien
                       breed NVARCHAR(50),                   -- Race
                       age INT,                              -- �ge
                       size DECIMAL(5,2),                    -- Taille (en cm)
                       weight DECIMAL(5,2),                  -- Poids (en kg)
                       id_maitre INT NULL,                   -- Identifiant du ma�tre (cl� �trang�re)
                       CONSTRAINT FK_Personne_Chien FOREIGN KEY (id_maitre) REFERENCES Personne(id)
);

-- Insertion de donn�es dans la table Personne
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

-- Insertion de donn�es dans la table Chien
INSERT INTO Chien (name, breed, age, size, weight, id_maitre)
VALUES
    ('Milou', 'Fox Terrier', 5, 30.0, 8.0, 1), -- Li� � Tintin Dupont
    ('Idefix', 'Dogmatix', 4, 25.0, 6.0, 2), -- Li� � Asterix Gaulois
    ('Watson', 'Bulldog', 6, 60.0, 30.0, 3), -- Li� � Sherlock Holmes
    ('Hercules', 'Pitbull', 3, 60.0, 28.0, 4), -- Li� � Hercule Poirot
    ('Gandalf', 'Great Dane', 8, 80.0, 50.0, 5), -- Li� � Gandalf Le Gris
    ('Chewie', 'Malamute', 7, 70.0, 40.0, 6), -- Li� � Luke Skywalker
    ('Buck', 'Saint Bernard', 6, 70.0, 50.0, 7), -- Li� � Harry Potter
    ('Drogo', 'Dobermann', 5, 55.0, 35.0, 8), -- Li� � Daenerys Targaryen
    ('Baggins', 'Shiba Inu', 4, 30.0, 10.0, 9), -- Li� � Frodo Baggins
    ('Waldo', 'Chihuahua', 3, 20.0, 2.5, 10), -- Li� � Waldo Rosenbaum
    ('Rex', 'Chihuahua', 3, 20.0, 3.0, NULL), -- Pas de ma�tre
    ('Pepette', 'Rottweiler', 6, 60.0, 40.0, NULL), -- Pas de ma�tre
    ('Princesse', 'Dobermann', 4, 50.0, 30.0, NULL), -- Pas de ma�tre
    ('Rex', 'Dalmatian', 2, 45.0, 25.0, NULL), -- Pas de ma�tre
    ('Trixie', 'Poodle', 5, 30.0, 12.0, NULL), -- Pas de ma�tre
    ('Nina', 'Boxer', 4, 50.0, 35.0, NULL), -- Pas de ma�tre
    ('Pikachu', 'Corgi', 2, 25.0, 10.0, NULL), -- Pas de ma�tre
    ('Rolo', 'Dachshund', 3, 28.0, 8.5, NULL), -- Pas de ma�tre
    ('Fifi', 'Maltese', 4, 25.0, 6.0, NULL), -- Pas de ma�tre
    ('Charlie', 'Beagle', 6, 40.0, 15.0, NULL), -- Pas de ma�tre
    ('Max', 'Labrador', 5, 55.0, 30.0, NULL), -- Pas de ma�tre
    ('Biscuit', 'Shih Tzu', 2, 25.0, 6.0, NULL), -- Pas de ma�tre
    ('Daisy', 'Pug', 3, 35.0, 10.0, NULL), -- Pas de ma�tre
    ('Oscar', 'Terrier', 4, 28.0, 8.0, NULL), -- Pas de ma�tre
    ('Nala', 'Pitbull', 4, 50.0, 30.0, NULL); -- Pas de ma�tre
    
-- Niveau 1
-- 1.S�lectionnez tous les chiens avec leur nom, leur race et leur poids.
SELECT name, breed, weight
FROM Chien;
    
-- 2.Listez tous les propri�taires (pr�nom et nom).
SELECT first_name, last_name
FROM Personne;
    
-- 3.R�cup�rez les chiens qui n'ont pas de ma�tre.
SELECT * FROM Chien
WHERE id_maitre IS NULL;
    
-- 4.S�lectionnez tous les chiens de race "Labrador".
SELECT * FROM Chien
WHERE breed = 'Labrador';

-- Niveau 2
-- 5. Affichez le nom des chiens avec le pr�nom et le nom de leur ma�tre.
SELECT c.name,p.first_name, p.last_name
FROM Chien c
INNER JOIN Personne p 
ON p.id = c.id_maitre;
    
-- 6. R�cup�rez les ma�tres qui poss�dent un chien pesant plus de 20 kg.
SELECT p.*
FROM Personne p
INNER JOIN Chien C 
ON p.id = C.id_maitre
WHERE C.weight > 20;

-- Niveau 3
-- 7. Affichez tous les propri�taires et les chiens qu'ils poss�dent, y compris les propri�taires sans chien.
SELECT p.*, c.*
FROM Personne P
LEFT JOIN Chien C 
ON P.id = C.id_maitre;

-- 8. Listez tous les chiens, avec leurs ma�tres s'ils en ont, sinon affichez "No Owner".
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
-- 9. R�cup�rez tous les chiens et tous les ma�tres, m�me ceux sans correspondance.
SELECT p.*, c.*
FROM Personne P
FULL JOIN Chien C
ON P.id = C.id_maitre;

-- Niveau 5
-- 10. Affichez les chiens dont le poids est sup�rieur � 10 kg mais inf�rieur � 30 kg.
SELECT *
FROM Chien
WHERE weight BETWEEN 10 AND 30;
    
-- 11. R�cup�rez les chiens de ma�tres habitant dans la ville "123 Main St".
SELECT c.*
FROM Chien c
INNER JOIN Personne P 
ON P.id = c.id_maitre
WHERE p.address = '123 Main St';

-- Niveau 6
-- 12. Affichez le nombre de chiens pour chaque ma�tre.
SELECT p.first_name, p.last_name, COUNT(*) AS nbChiens FROM Chien c
INNER JOIN Personne P 
on P.id = c.id_maitre
GROUP BY p.first_name, p.last_name;
    
-- 13. Calculez le poids total des chiens appartenant � chaque ma�tre.
SELECT p.first_name, p.last_name, SUM(c.weight) AS poidsChiens
FROM Chien c
INNER JOIN Personne P
on P.id = c.id_maitre
GROUP BY p.first_name, p.last_name;

-- Niveau 7
-- 14. R�cup�rez les ma�tres qui poss�dent le chien le plus lourd.
SELECT p.*
FROM Personne p
INNER JOIN Chien C 
ON p.id = C.id_maitre
WHERE C.weight = (SELECT MAX(weight) FROM Chien);
    
-- 15. Affichez les chiens qui ont un ma�tre dont l'�ge est sup�rieur � 40 ans.
SELECT c.*
FROM Chien c
INNER JOIN Personne P 
ON P.id = c.id_maitre
WHERE p.age > 40;

-- Niveau 8
-- 16. Listez les ma�tres n'ayant pas de chien.
SELECT p.* FROM Personne p
LEFT JOIN Chien C 
ON p.id = C.id_maitre
WHERE c.id_maitre IS NULL;
    
-- 17. Affichez la race la plus courante parmi les chiens.
SELECT TOP 1 breed, COUNT(*) AS nbRaces
FROM Chien
GROUP BY breed
ORDER BY nbRaces DESC;
    
-- 18. Listez tous les ma�tres qui poss�dent au moins deux chiens.
SELECT p.first_name, p.last_name, count(*) AS nbChiens
FROM Personne p
INNER JOIN Chien C 
ON p.id = C.id_maitre
GROUP BY p.first_name, p.last_name
HAVING count(*) >= 2;

-- Niveau 9
-- 19. R�cup�rez une liste combin�e de chiens sans ma�tres et de ma�tres sans chiens.
SELECT * FROM Chien c
FULL JOIN Personne P ON P.id = c.id_maitre
WHERE c.id_maitre IS NULL
OR p.id IS NULL;
    
-- 20. Affichez le ma�tre et ses chien associ�s avec somme de leur tailles respectives (taille du ma�tre et des chiens).
SELECT p.first_name, p.last_name, SUM(c.age) + p.age AS sommeSizeAge
FROM Personne P
INNER JOIN Chien C
ON P.id = C.id_maitre
GROUP BY p.first_name, p.last_name, p.age;