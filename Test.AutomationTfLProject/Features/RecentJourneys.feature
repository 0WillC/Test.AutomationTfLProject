Feature: RecentJourneys

pre-requisite: Multiple journeys pre-planned
Scenario: Verify recetns tab displays recently planned journeys when cookies are enabled
	Given a user is on the widget page
	And all cookies are enabled
	When a user clicks on Recents tab on the widget
	Then the user must see a list of recently planned journeys
