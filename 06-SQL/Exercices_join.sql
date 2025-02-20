-- S�lectionnez les noms et pr�noms des clients ainsi que les d�tails de leurs achats (si disponibles)
SELECT c.last_name, c.first_name, p.product, p.amount
from Clients c
INNER JOIN Purchases P 
ON c.id = P.client_id;

--S�lectionnez tous les clients et les d�tails de leurs achats s'ils ont effectu� des achats, sinon affichez les colonnes des achats avec des valeurs NULL
SELECT c.*, p.* FROM Clients c
LEFT JOIN dbo.Purchases P 
ON c.id = P.client_id;

--S�lectionnez tous les achats et les d�tails des clients correspondants, m�me s'il n'y a pas de correspondance
SELECT p.*, c.* FROM Purchases P
RIGHT JOIN dbo.Clients C 
on C.id = P.client_id;
                                 
--S�lectionnez tous les clients et tous les achats, en affichant les d�tails des clients m�me s'ils n'ont pas effectu� d'achats, et vice versa
SELECT p.*, c.* FROM Purchases P
FULL JOIN dbo.Clients C
ON C.id = P.client_id;