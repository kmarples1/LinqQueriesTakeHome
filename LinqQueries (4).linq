<Query Kind="Expression">
  <Connection>
    <ID>b9792636-0a9c-4652-b9d5-6ce21dd8be40</ID>
    <Persist>true</Persist>
    <Server>OPTIMUS-PRIME\</Server>
    <Database>WorkSchedule</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// 4. List all employees with multiple skills; ignore employees with only one skill. 
// Show the name of the employee and the list of their skillsets; 
// for each skill, show the name of the skill, the level of competance and the years of experience. 
// Use the following text for the levels: 0 = Novice, 1 = Proficient, 2 = Expert.

from person in Employees
where person.EmployeeSkills.Count != 1 && person.EmployeeSkills.Count >= 2
select new
{
	Name = person.FirstName + " " + person.LastName,

	
	Description = from data in Skills select data.Description,
	Level = from data in EmployeeSkills select new
	{
	person.Level.Novice == 0 && person.Level.Proficient == 1 && person.Level.Expert == 2
	}
	YearsExperience = from data in EmployeeSkills select data.YearsOfExperience
	
}
