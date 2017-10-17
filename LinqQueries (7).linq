<Query Kind="Expression">
  <Connection>
    <ID>b9792636-0a9c-4652-b9d5-6ce21dd8be40</ID>
    <Persist>true</Persist>
    <Server>OPTIMUS-PRIME\</Server>
    <Database>WorkSchedule</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// 7. List the names of all employees who did not work in November. 
// Show the name in the format of "LastName, FirstName" and sort it by last name and then first name.

from data in Schedules.ToList()
where data.Day != "November"
orderby data.Employee.LastName, data.Employee.FirstName ascending
select new
{
	Name = data.Employee.FirstName  + ", " + data.Employee.LastName 
}
