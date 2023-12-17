Feature: ChangeTimeLink

Scenario: Verify change time link displays "Arriving" option
	Given that a user is on the journey planner page
	When a user a user views the change time link
	Then the user must see the Arriving option

Scenario: Plan a journey based on arrival time
    Given a user is on the Journey Planner page
    And a user fills-in Fromfield with Paddington
    And a user fills-in Tofield with London Bridge
    When a user selects the Arriving option from the change time link
    And a user clicks on the plan journey button
    Then the user must see the planned journey based on arrival time
