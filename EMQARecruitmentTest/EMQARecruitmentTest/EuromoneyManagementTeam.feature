Feature: Euromoney Home Page - Management Team
	In order to promote our management team
	As a user
	I want view a list of the management team


Scenario: Navigating to the Management Team Page
   Given I am on the Euromoney Homepage from and I click on the Navigation Menu Bar
   When I access the Navigation Menu bar
   And I click on the link "Who we are"
   And I click on the link "Management Team"
   Then I am navigated to the Management Team Homepage

Scenario: Verifying the details of the Management Team
   Given I am on the Management Team Homepage
   Then I view a list of the Management Team and their details 



