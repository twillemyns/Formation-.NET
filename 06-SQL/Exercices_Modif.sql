CREATE TABLE Students (
                          student_id INT PRIMARY KEY,
                          first_name VARCHAR(50) NOT NULL,
                          last_name VARCHAR(50) NOT NULL,
                          age INT,
                          grade VARCHAR(10)
);

INSERT INTO Students (student_id, first_name, last_name, age, grade) VALUES
                    (1, 'Maria', 'Rodriguez', 21, 'B'),
                    (2, 'Ahmed', 'Khan', 19, 'A'),
                    (3, 'Emily', 'Baker', 22, 'C');

UPDATE Students
SET grade = 'A'
WHERE first_name = 'Maria';

UPDATE Students
SET age = age + 1;

DELETE FROM Students
WHERE first_name = 'Emily';

TRUNCATE TABLE Students;