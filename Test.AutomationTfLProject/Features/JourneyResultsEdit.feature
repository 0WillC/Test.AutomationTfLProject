Feature: JourneyResultsEdit

pre-requisite: An existing London Bridge to Paddington planned Journey   
Scenario: Verify that a user can amend a journey by using edit journey button
	Given that a user is on the Journey Results page
	When a user click on 'Edit Journey' link
    And a user changes InputTo field value from 'paddington' to 'North Greenwich'
    And a user clicks on 'update journey' button
	Then the user must see the result as edited on the journey results page
