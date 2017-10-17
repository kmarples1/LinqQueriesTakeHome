<Query Kind="Expression">
  <Connection>
    <ID>b9792636-0a9c-4652-b9d5-6ce21dd8be40</ID>
    <Persist>true</Persist>
    <Server>OPTIMUS-PRIME\</Server>
    <Database>WorkSchedule</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// 5. From the shifts scheduled for NAIT's placement contracts, 
// show the number of employees needed for each day (ordered by day-of-week). 
// Display the name of the day of week (Sunday, as the first day of the week, is number zero)
// and the number of employees needed.

from data in Shifts
orderby data.DayOfWeek
select new
{

	EmployeesNeeded = data.NumberOfEmployees,
	
	Days = from data in DayOfWeek
	select new
	{
	Sunday = 0,
	Monday = 1,
	Tuesday = 2,
	Wednesday = 3,
	Thursday = 4,
	Friday = 5,
	Saturday = 6,
	}

}