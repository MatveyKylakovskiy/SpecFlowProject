@CloseBrowser

Feature: Login

@mytag
Scenario Outline: Success login
	Given Open Page https://www.saucedemo.com
	When Input hotel name
	When Click search button
	When check is hotel visible
	Then Check rating


	Examples:
	| userName      | password     |
	| standard_user | secret_sauce |
	| visual_user   | secret_sauce |