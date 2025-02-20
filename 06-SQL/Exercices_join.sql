-- Sélectionnez les noms et prénoms des clients ainsi que les détails de leurs achats (si disponibles)
SELECT c.last_name, c.first_name, p.product, p.amount
from Clients c
INNER JOIN Purchases P 
ON c.id = P.client_id;

--Sélectionnez tous les clients et les détails de leurs achats s'ils ont effectué des achats, sinon affichez les colonnes des achats avec des valeurs NULL
SELECT c.*, p.* FROM Clients c
LEFT JOIN dbo.Purchases P 
ON c.id = P.client_id;

--Sélectionnez tous les achats et les détails des clients correspondants, même s'il n'y a pas de correspondance
SELECT p.*, c.* FROM Purchases P
RIGHT JOIN dbo.Clients C 
on C.id = P.client_id;
                                 
--Sélectionnez tous les clients et tous les achats, en affichant les détails des clients même s'ils n'ont pas effectué d'achats, et vice versa
SELECT p.*, c.* FROM Purchases P
FULL JOIN dbo.Clients C
ON C.id = P.client_id;