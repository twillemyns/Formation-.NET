--Affichez le nombre d'utilisateurs par lieu de naissance, mais ne montrez que les lieux avec plus d'un' utilisateur.
SELECT birth_location, count(*) as nbUtilisateurs FROM Users
GROUP BY birth_location
HAVING count(*) >= 1;
    
-- S�lectionnez la profession et la moyenne des salaires pour chaque profession, mais ne montrez que celles avec une moyenne de salaire sup�rieure � 2500.
SELECT job, AVG(salary) AS avg_salary
FROM Users GROUP BY job
HAVING AVG(salary) > 2500;
    
-- Affichez la somme des salaires pour chaque lieu de naissance, mais ne montrez que les lieux dont la somme des salaires est sup�rieure � 5000.
SELECT birth_location, SUM(salary) FROM Users
GROUP BY birth_location
HAVING SUM(salary) > 5000;
    
-- S�lectionnez la date de naissance et le nombre d'utilisateurs n�s � chaque date, mais ne montrez que les dates o� il y a plus d'un utilisateur n�.
SELECT birth_date, COUNT(*) FROM Users
GROUP BY birth_date
HAVING COUNT(*) > 1;
    
-- Affichez la profession, le lieu de naissance, et le salaire maximum pour chaque profession et lieu, mais ne montrez que les r�sultats o� le salaire maximum est sup�rieur � 3000.
SELECT job, birth_location, MAX(salary) FROM Users
GROUP BY job, birth_location
HAVING MAX(salary) > 3000;