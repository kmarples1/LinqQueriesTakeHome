<Query Kind="Expression">
  <Connection>
    <ID>b9792636-0a9c-4652-b9d5-6ce21dd8be40</ID>
    <Persist>true</Persist>
    <Server>OPTIMUS-PRIME\</Server>
    <Database>WorkSchedule</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// 6. List all the employees with the most years of experience.

//from row in EmployeeSkills
//where !row.YearsOfExperience.HasValue
//group row by row.YearsOfExperience into YOE
//orderby row.YearsOfExperience = YOE
//select new
//{
//	Name = row.Employee.FirstName + " " + row.Employee.FirstName,
//	YOE = row.YearsOfExperience.Max()
//}


//
//var teamBestScores =
//    from player in players
//    group player by player.Team into playerGroup
//    select new
//    {
//        Team = playerGroup.Key,
//        BestScore = playerGroup.Max(x => x.Score),
//    };

from person in EmployeeSkills
group person by person.YearsOfExperience into Years
select new
{
	Name = Employee.FirstName + " " + Employee.LastName,
	Experience = Years.Key,
	YOE = Years.Max(x => x.YearsOfExperience)
}
