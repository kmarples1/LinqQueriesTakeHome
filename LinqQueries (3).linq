<Query Kind="Expression">
  <Connection>
    <ID>b9792636-0a9c-4652-b9d5-6ce21dd8be40</ID>
    <Persist>true</Persist>
    <Server>OPTIMUS-PRIME\</Server>
    <Database>WorkSchedule</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// 3. Show all skills requiring a ticket and which employees have those skills. 
// Include all the data as seen in the following image. 
// Order the employees by years of experience (highest to lowest). 
// Use the following text for the levels: 0 = Novice, 1 = Proficient, 2 = Expert. 
// (Hint: Use nested ternary operators to handle the levels as text.)

//from data in EmployeeSkills
//where data.Skill.RequiresTicket == true
//orderby data.YearsOfExperience.HasValue ascending
//select new
//{
//	Description = data.Skill.Description,
//	Name = data.Employee.FirstName + " " + data.Employee.LastName,
//	Level = data.Level,
//	YearsExperience = data.YearsOfExperience
//}

from data in EmployeeSkills
where data.Skill.RequiresTicket == true
group data by data.Skill.Description into Employees
orderby data.YearsOfExperience.HasValue ascending
select new
{
	Description = Employees.Key,
	Name = from person in Employee	
	select new
	{
	person.Employee.FirstName + " " + person.Employee.LastName
	}
}



//from row in Skills
//where row.RequiresTicket = true
//orderby row.YearsOfExperience.EmployeeSkills ascending
//select new
//{
//	Novice = 0,
//	Proficient = 1,
//	Expert = 2,
//	Name = row.FirstName.EmployeeSkills.Employees + " " + row.LastName.EmployeeSkills.Employees,
//	Level = 0 : Novice : 1 : 
////	Level = row.Level.EmployeeSkills,
//	YearsExperience = row.YearsOfExperience,
//}