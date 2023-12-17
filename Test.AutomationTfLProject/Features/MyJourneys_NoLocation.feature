Feature: MyJourneys_NoLocation

Scenario: Verify that a user is unable to plan a journey if no locations are entered into the widget
	Given that Journey planner widget is open
	When a user clicks on Plan A Journey Button
	And a user leaves From Address Field empty
	And a user fills-in To field with Canary Wharf
	And a user clicks on Plan My Journey Buttonn
	Then the user must receive a warning message 'The From field is required' displayed under the text field
