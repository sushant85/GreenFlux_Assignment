Feature: Valid_Login
	Feature to test user able to login into login page successfully.

@Browser:Chrome
Scenario Outline:Verify login functionality!
	Given I have navigated to login page
	Then I typed the <username> and <password>
	And click on login button

@source:Data.xlsx
Examples: 
| username | password |