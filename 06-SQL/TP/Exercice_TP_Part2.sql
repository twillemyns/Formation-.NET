-- Niveau 1 : INSERT
-- Ajoutez un nouveau ma�tre nomm� "Arya Stark", �g� de 18 ans, habitant � "Winterfell", avec un num�ro de t�l�phone "1231231234".
INSERT INTO Personne (first_name, last_name, age, phone_number, address)
VALUES ('Arya', 'Stark', 18, '1231231234', 'Winterfell');

-- Ins�rez un nouveau chien nomm� "Nymeria" (race : Loup g�ant, �ge : 3 ans, taille : 120 cm, poids : 60 kg) appartenant � Arya Stark.
INSERT INTO Chien (name, breed, age, size, weight, id_maitre)
VALUES ('Nymeria', 'Loup g�ant', 3, 120, 60, 1002);

-- Niveau 2 : UPDATE
-- Modifiez le poids du chien "Milou" pour le mettre � 9 kg.
UPDATE Chien
SET weight = 9
WHERE name = 'Milou';

-- Changez l'adresse de "Daenerys Targaryen" pour "Dragonstone".
UPDATE Personne
SET address = 'Dragonstone'
WHERE first_name = 'Daenerys'
AND last_name = 'Targaryen';

-- Mettez � jour tous les chiens sans ma�tre pour les associer � "Sherlock Holmes".
UPDATE Chien
SET id_maitre = (SELECT id
                 FROM Personne 
                 WHERE first_name = 'Sherlock'
                 AND last_name = 'Holmes')
WHERE id_maitre IS NULL;

-- Niveau 3 : DELETE
-- Supprimez tous les chiens pesant moins de 5 kg.
DELETE FROM Chien
WHERE weight < 5;

-- Supprimez le ma�tre "Waldo Rosenbaum" et tous les chiens qui lui appartiennent.
DELETE FROM Personne
WHERE first_name = 'Waldo'
AND last_name = 'Rosenbaum';

-- Niveau 4 : TRUNCATE
-- Attention : Effectuez un TRUNCATE sur la table Chien pour supprimer toutes les donn�es de mani�re rapide, puis r�ins�rez les donn�es initiales. V�rifiez la structure de la table avant et apr�s.
TRUNCATE TABLE Chien;

TRUNCATE TABLE Personne;

INSERT INTO Chien (name, breed, age, size, weight, id_maitre)
VALUES
    ('Milou', 'Fox Terrier', 5, 30.0, 8.0, 1003), -- Li� � Tintin Dupont
    ('Idefix', 'Dogmatix', 4, 25.0, 6.0, 1004), -- Li� � Asterix Gaulois
    ('Watson', 'Bulldog', 6, 60.0, 30.0, 1005), -- Li� � Sherlock Holmes
    ('Hercules', 'Pitbull', 3, 60.0, 28.0, 1006), -- Li� � Hercule Poirot
    ('Gandalf', 'Great Dane', 8, 80.0, 50.0, 1007), -- Li� � Gandalf Le Gris
    ('Chewie', 'Malamute', 7, 70.0, 40.0, 1008), -- Li� � Luke Skywalker
    ('Buck', 'Saint Bernard', 6, 70.0, 50.0, 1009), -- Li� � Harry Potter
    ('Drogo', 'Dobermann', 5, 55.0, 35.0, 1010), -- Li� � Daenerys Targaryen
    ('Baggins', 'Shiba Inu', 4, 30.0, 10.0, 1011), -- Li� � Frodo Baggins
    ('Waldo', 'Chihuahua', 3, 20.0, 2.5, 1012), -- Li� � Waldo Rosenbaum
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
