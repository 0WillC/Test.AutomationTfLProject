Feature: MyJourneys

Scenario: Verify that a user can plan a journey on tfl journey planner widget
	Given that the tfl application is loaded
	When a user clicks on Myjourneys tab
	And a user clicks on plan a journey link
    And a user fills-in From field with Dartford Rail Station
	And a user fills-in To field with Sidcup Rail Station
	And a user clicks on Plan journey button
	Then results headline Journey results page must be displayed
