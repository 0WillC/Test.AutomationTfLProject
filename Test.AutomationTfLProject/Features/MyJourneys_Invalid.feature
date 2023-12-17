Feature: MyJourneys_Invalid

pre-requisite: TfL application is loaded and user is on Plan a journey page
Scenario: Verify-01-that a user cannot plan a journey when From location address is invalid
	Given that journey planner widget is open
	When a user clicks on Plan A Journey Button
	And a user fills-in From Address Field with Charlton#?
	And a user fills-in To Address Field with London Bridge Station
	And a user clicks on Plan My Journey Button
	Then the user must receive a Field validation error 'Journey planner could not find any results to your search. Please try again'

