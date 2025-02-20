--Affichez toutes les colonnes de la table "Users" pour tous les utilisateurs.
SELECT * FROM Users;

--S�lectionnez les noms et pr�noms des utilisateurs n�s � New York ou � Paris.
SELECT last_name, first_name FROM Users
WHERE birth_location
IN ('New York', 'Paris');

--Affichez les utilisateurs dont le travail est "Developer" ou "Designer".
SELECT last_name, first_name FROM Users
WHERE birth_location
IN ('New York', 'Paris');

--S�lectionnez les utilisateurs dont l'�ge est sup�rieur � 30 ans.
SELECT * FROM Users
WHERE age > 30;

--Affichez les utilisateurs dont le salaire est compris entre 2500 et 3000.
SELECT * FROM Users
WHERE salary BETWEEN 2500 AND 3000;

--S�lectionnez les utilisateurs dont le travail n'est ni "Developer" ni "Designer".
SELECT * FROM Users
WHERE job NOT IN ('Developer', 'Designer');

--Affichez les utilisateurs tri�s par ordre alphab�tique du nom de famille, puis du pr�nom.
SELECT * FROM Users
ORDER BY last_name, age;

--S�lectionnez les utilisateurs n�s avant l'ann�e 1990.
SELECT * FROM Users
WHERE YEAR(birth_date) < 1990;

--Affichez les utilisateurs dont le lieu de naissance est "London" ou "Berlin" et dont le travail est "Designer".
SELECT * FROM Users
WHERE birth_location IN ('London', 'Berlin')
AND job = 'Designer';

--S�lectionnez les 10 utilisateurs avec les salaires les plus �lev�s.
SELECT TOP 10 * FROM Users
ORDER BY salary DESC;
    
--Affichez les noms, pr�noms et �ges des utilisateurs n�s entre 1980 et 1990.
SELECT first_name, last_name, age FROM Users
WHERE YEAR(birth_date) BETWEEN 1980 AND 1990;
    
--S�lectionnez les utilisateurs par ordre d�croissant d'�ge.
SELECT * FROM Users
ORDER BY age DESC;
    
--S�lectionnez les utilisateurs dont le travail est "Doctor" et dont le salaire est sup�rieur � 3000.
SELECT * FROM Users
WHERE job = 'Doctor'
AND salary > 3000;
    
--Affichez les utilisateurs tri�s par lieu de naissance, puis par salaire.
SELECT * FROM Users
ORDER BY birth_location, salary;

--S�lectionnez les utilisateurs n�s � Paris et dont le travail est "Lawyer".
SELECT * FROM Users
WHERE birth_location = 'Paris'
AND job = 'Lawyer';
    
--Affichez le salaire le plus bas de tout les utilisateurs en utilisant un alias.
SELECT MIN(salary) as salaire_max FROM Users;

--S�lectionnez les utilisateurs n�s apr�s l'ann�e 1985 et dont le travail est "Engineer".
SELECT * FROM Users
WHERE YEAR(birth_date) > 1985
AND job = 'Engineer';

--Affichez les utilisateurs dont le pr�nom est "John" et le nom de famille est "Doe".
SELECT * FROM Users
WHERE first_name = 'John'
AND last_name = 'Doe';

--S�lectionnez les 6 utilisateurs dont le salaire est le plus bas en omettant les trois premiers r�sultats.
SELECT * FROM Users
ORDER BY salary
OFFSET 3 ROWS 
FETCH NEXT 6 ROWS ONLY;

--Affichez les utilisateurs par ordre croissant d'�ge, limit�s aux 5 premiers.
SELECT TOP 5 * FROM Users
ORDER BY age;