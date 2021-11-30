--Part 1
/*
	SELECT column_name, data_type
	FROM information_schema.columns 
	WHERE table_schema = 'techjobs' AND table_name = 'jobs';
	-----
	Jobs Table Columns:
	Id:			int
	EmployerId:	int
	Name:		longtext
*/
--Part 2
/*
	SELECT Name FROM techjobs.employers
	WHERE Location = "St. Louis City"
*/
--Part 3
/*
	SELECT Name, Description FROM techjobs.skills
	INNER JOIN techjobs.jobskills
	WHERE skills.Id = jobskills.SkillId
	ORDER BY Name ASC;
*/