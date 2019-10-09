Feature: TM
	In order to manage time and material 
	As an admin
	I would like to create, edit, read and delete time & material records

@automate @web 
Scenario: Create a Time record with valid inputs
	Given I have logged in to Turn Up portal
	And I have Navigated to Time and Material page
	Then I should be able to create a time record successfully
