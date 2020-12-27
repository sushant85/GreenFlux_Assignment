Feature: DataTable
	Feature to test user able to access Data Tables web page and able to fetch record from Example 1 or 
	Example 2 Table successfully.

@Browser:Chrome
Scenario Outline:Verify user able to fetch LastName "Smith" and Due "$50" data from Table !
	Given I have navigated to Data Table web page
	Then I want to fetch lastname and Due from Table
