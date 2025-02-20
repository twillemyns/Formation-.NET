--SELECT * FROM Users WHERE job != 'Developer';

--SELECT * FROM Users WHERE first_name = 'John';

--SELECT * FROM Users WHERE salary >= 3000;

--SELECT * FROM Users WHERE age < 30 OR age >= 35;

--SELECT * FROM Users WHERE job = 'Teacher' AND salary > 2600;

--SELECT * FROM Users
--WHERE birth_location = 'New-York'
--AND (salary > 3000
--OR salary <= 3500)
--AND NOT (job = 'Doctor'
--OR job = 'Lawyer');

--SELECT * FROM Users WHERE job IN ('Engineer');

--SELECT first_name, last_name FROM Users
--WHERE birth_location IN ('London', 'Paris', 'Berlin');

--SELECT * FROM Users
--WHERE age BETWEEN 25 AND 35;

--SELECT * FROM Users
--WHERE job = 'Developer'
--AND salary > 2500;

--SELECT TOP 5 * FROM Users
--ORDER BY age DESC;

--SELECT * FROM Users
--ORDER BY first_name
--OFFSET 5 ROWS
--FETCH NEXT 5 ROWS ONLY;

--SELECT TOP 3 * FROM Users
--ORDER BY salary DESC;

--SELECT MIN(salary) as min_salary FROM Users;

--SELECT MAX(age) as max_age FROM Users WHERE job = 'Engineer';

--SELECT AVG(salary) as avg_salary FROM Users WHERE job = 'Teacher';

--SELECT SUM(salary) as sum_salary FROM Users;