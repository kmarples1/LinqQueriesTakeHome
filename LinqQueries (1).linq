<Query Kind="Expression">
  <Connection>
    <ID>b9792636-0a9c-4652-b9d5-6ce21dd8be40</ID>
    <Persist>true</Persist>
    <Server>OPTIMUS-PRIME\</Server>
    <Database>WorkSchedule</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// 1. List all skills, alphabetically, showing only the description of the skill.

from data in Skills
orderby data.Description ascending
select data.Description 