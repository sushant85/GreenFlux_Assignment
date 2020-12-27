Feature: Dynamic_Control
	Feature to test user able to access dynamic controls page and able to click on Button successfully.


@Browser:Chrome
Scenario Outline:Verify user able click on Add/Remove Button and Read Messages!.
	Given I have navigated to Dynamic controls page
	When I select checkbox and click on Remove button
	Then I should see it's gone message
	When I click on Add button
	Then I should see it's back message
	And check textbox enable or disable

