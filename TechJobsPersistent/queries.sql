--Part 1
/* SELECT * FROM jobs;
Id Integer, Name VARCHAR, EmployerId Integer
--Part 2
/*SELECT Location FROM tech_jobs.employers
WHERE Location = "St Louis"; */
--Part 3
SELECT Name, Description
FROM skills
INNER JOIN jobs ON skills.Id = jobs.Id
WHERE Id != null
ORDER BY Name ASC
