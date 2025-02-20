-- Niveau 1 : CREATE
-- Créez la table Chat avec les spécifications ci-dessus.
CREATE TABLE Chat (
    id INT PRIMARY KEY IDENTITY(1, 1),
    name NVARCHAR(50),
    age INT,
    color NVARCHAR(50),
    id_maitre INT NOT NULL,
    CONSTRAINT fk_chat_id_maitre FOREIGN KEY (id_maitre) REFERENCES Personne(id)
);

-- Créez la table RelationChatChien pour gérer les relations entre chats et chiens.
CREATE TABLE RelationChatChien (
    id_chat INT,
    id_chien INT,
    relation_type NVARCHAR(50),
    CONSTRAINT fk_relationChatChien_id_chat FOREIGN KEY (id_chat) REFERENCES Chat(id),
    CONSTRAINT fk_relationChatChien_id_chien FOREIGN KEY (id_chien) REFERENCES Chien(id),
    CONSTRAINT check_relation_type CHECK (relation_type IN ('loves', 'hates', 'neutral'))
);

-- Niveau 2 : INSERT et relations
-- Ajoutez deux chats nommés "Garfield" (âge : 5 ans, couleur : orange, maître : Gandalf) et "Salem" (âge : 7 ans, couleur : noir, maître : Frodo Baggins).
INSERT INTO Chat (name, age, color, id_maitre)
VALUES ('Garfield', 5, 'orange', (SELECT id FROM Personne WHERE first_name = 'Gandalf')),
       ('Salem', 7, 'noir', (SELECT id FROM Personne WHERE first_name = 'Frodo' AND last_name = 'Baggins'));

-- Ajoutez des relations dans RelationChatChien :
-- "Garfield" aime "Milou".
-- "Salem" déteste "Idefix".
-- "Garfield" est neutre avec "Hercules".
INSERT INTO RelationChatChien (id_chat, id_chien, relation_type)
VALUES ((SELECT id FROM Chat WHERE name = 'Garfield'), (SELECT  id FROM Chien WHERE name = 'Milou'), 'loves'),
       ((SELECT id FROM Chat WHERE name = 'Salem'), (SELECT  id FROM Chien WHERE name = 'Idefix'), 'hates'),
       ((SELECT id FROM Chat WHERE name = 'Garfield'), (SELECT  id FROM Chien WHERE name = 'Hercules'), 'neutral');

-- Niveau 3 : ALTER
-- Ajoutez une colonne gender (type NVARCHAR(10)) à la table Personne pour indiquer le genre du maître (valeurs possibles : Male, Female, Other).
ALTER TABLE Personne
ADD gender NVARCHAR(10)
CONSTRAINT check_gender CHECK (gender IN ('Male', 'Female', 'Other'));

-- Modifiez la colonne size dans la table Chien pour qu'elle soit de type DECIMAL(6,2).
ALTER TABLE Chien
ALTER COLUMN size DECIMAL(6,2);

-- Niveau 4 : DROP
-- Supprimez la table RelationChatChien.
DROP TABLE RelationChatChien;

-- Supprimez la colonne weight de la table Chien.
ALTER TABLE Chien
DROP COLUMN weight;

-- Questions bonus (DDL + DML)
-- Listez tous les chats et leurs maîtres respectifs.
SELECT c.*, p.*
FROM Chat c
INNER JOIN dbo.Personne P 
ON P.id = c.id_maitre;

-- Affichez toutes les relations entre les chats et les chiens, y compris leurs types de relations.
SELECT c.name, d.name, r.relation_type
FROM RelationChatChien r
INNER JOIN Chat C 
ON C.id = r.id_chat
INNER JOIN Chien d 
ON r.id_chien = d.id;

-- Modifiez la relation entre "Garfield" et "Hercules" pour qu'elle devienne loves.
UPDATE RelationChatChien
SET relation_type = 'loves'
WHERE id_chat = (SELECT id FROM Chat WHERE name = 'Garfield')
AND id_chien = (SELECT id FROM Chien WHERE name = 'Hercules');